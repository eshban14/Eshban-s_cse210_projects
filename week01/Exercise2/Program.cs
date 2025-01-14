using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percetage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string alphabet = "";

        if (percent >= 90)
        {
            alphabet= "A";

        }
        else if (percent >= 80)
        {
            alphabet= "B";
        }
        else if (percent >= 70){
            alphabet= "C";
        }
        else if (percent >= 60){
            alphabet = "D";
        }
        else{
            alphabet = "F";
        }

        Console.WriteLine($"Your grade is: {alphabet}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations You passed!");
        }
        else{
            Console.WriteLine("Better Luck next time!");
        }

}
}