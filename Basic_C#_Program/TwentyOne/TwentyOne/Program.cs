
using Casino;
using Casino.BlackJack;
using Microsoft.Data.SqlClient;
using System.Numerics;
namespace Casino
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Games of Cards Casino. \nLet's Start by Sharing Your Name With Us :");
            string playerName = Console.ReadLine();
            //if (playerName.ToLower() == "admin")
            //{
            //    List<ExceptionEntity> Exceptions = ReadExceptions();
            //    foreach (var exception in Exceptions)
            //    {
            //        Console.Write(exception.Id + " | ");
            //        Console.Write(exception.ExceptionType + " | ");
            //        Console.Write(exception.ExceptionMessage + " | ");
            //        Console.Write(exception.TimeStamp + " | ");
            //        Console.WriteLine();
            //    }
            //    Console.Read();
            //    return;
            //}

            bool validAnswer = false;
            int pBank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And How Much Money Did You Going To Play With Today?");
                validAnswer = int.TryParse(Console.ReadLine(), out pBank);
                if (!validAnswer) Console.WriteLine("Please Enter Digits Only. No Decimals..");
            }
            Console.WriteLine("Hello, {0}. Would You Like To Join A Game Of BlackJack Right Now?", playerName);
            string pAnswer = Console.ReadLine().ToLower();
            if (pAnswer == "yes" || pAnswer == "yea" || pAnswer == "y" || pAnswer == "ya")
            {
                Player player = new Player(playerName, pBank);
                player.Id = Guid.NewGuid();
                Game game = new BlackJackGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    try { game.Play(); }

                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDBWithExceptions(ex);
                        Console.ReadLine(); return;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("An Error Occurred, Please Contact Your System Administrator.");
                        UpdateDBWithExceptions(ex);
                        Console.ReadLine(); return;
                    }

                }
                if (player.Balance <= 0)
                {
                    Console.WriteLine("Sorry! You Do Not Have Sufficiant Balance To Play Further..\nPlease Visit Again...");
                    game -= player;
                }
                else
                {
                    game -= player;
                    Console.WriteLine("Thank You For Playing!");
                }
            }
            Console.WriteLine("Feel Free to Look Around Casino. Bye For Now.");
        }

        [Obsolete]
        private static void UpdateDBWithExceptions(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;
                                        Initial Catalog=BlackJackGame;
                                        Integrated Security=True;
                                        Connect Timeout=30;
                                        Encrypt=False;
                                        Trust Server Certificate=False;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False";

            string quearyString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(quearyString, connection);
                    command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                    command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                    command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                    command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                    command.Parameters["@ExceptionMessage"].Value = ex.Message;
                    command.Parameters["@TimeStamp"].Value = DateTime.Now;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception exe) { Console.WriteLine(exe); }
        }

        [Obsolete]
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;
                                        Initial Catalog=BlackJackGame;
                                        Integrated Security=True;
                                        Connect Timeout=30;
                                        Encrypt=False;
                                        Trust Server Certificate=False;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False";
            string queryString = @"Select Id, ExceptionType, ExceptionMassage, TimeStamp from Exceptions";
            List<ExceptionEntity> exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(@queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    exceptions.Add(exception);
                }
                connection.Close();
            }
            return exceptions;
        }
    }
}