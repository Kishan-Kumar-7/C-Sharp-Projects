Console.Write("Please Enter Your First Name: ");
string firstName = Console.ReadLine();
string date = DateTime.Today.ToShortDateString();
String msg = $"Welcome Back {firstName}, Today is {date}.";
Console.WriteLine(msg);
string path = @"C:\Users\Kisha\Documents\Study\Github\C-Sharp-Projects\Basic_C#_Program\Scores\Scores\studentScores.txt";

string[] lines = File.ReadAllLines(path);

double tScore = 0.0;

Console.WriteLine("Student Scores: ");
foreach (string line in lines)
{
    Console.WriteLine(line);
    double score = Convert.ToDouble(line);
    tScore += score;
}

double avg = tScore / lines.Length;
Console.WriteLine($"Total of {lines.Length} students scores is {tScore}. \tAverage Score :{avg}.");
