using Casino;
using Casino.BlackJack;
using System.Data;
using System.Data.SqlClient;
namespace Casino
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Games of Cards Casino. \nLet's Start by Sharing Your Name With Us :");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int pBank = 0;
            while (!validAnswer) {
                Console.WriteLine("And How Much Money Did You Going To Play With Today?");
                validAnswer = int.TryParse(Console.ReadLine(), out pBank);
                if (!validAnswer) Console.WriteLine("Please Enter Digits Only. No Decimals..");
            }
            Console.WriteLine("Hello, {0}. Would You Like To Join A Game Of BlackJack Right Now?", playerName);
            string pAnswer = Console.ReadLine().ToLower();
            if (pAnswer == "yes" || pAnswer == "yea" || pAnswer == "y" || pAnswer == "ya") { 
                Player player = new Player(playerName, pBank);
                player.Id = Guid.NewGuid();
                Game game = new BlackJackGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0) 
                {
                    try { game.Play();}
                    
                    catch (FraudException ex)
                    { Console.WriteLine(ex.Message);
                        UpdateDBWithExceptions(ex);
                        Console.ReadLine();return; }
                    
                    catch (Exception ex)
                    { Console.WriteLine("An Error Occurred, Please Contact Your System Administrator.");
                        UpdateDBWithExceptions(ex);
                        Console.ReadLine();return; }
                    
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

            string quearyString = "INSERT INTO Exceptions (ExceptionType, ExceptionMassage, TimeStamp) VALUES (@ExceptionType, @ExceptionMassage, @TimeStamp)";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString)) {
                SqlCommand command = new SqlCommand(quearyString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMassage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMassage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}