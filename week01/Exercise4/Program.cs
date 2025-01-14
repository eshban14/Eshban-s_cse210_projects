using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // using do-while loop here

        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.Write("Enter a list of numbers, type (0 to quit):");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //only add the number to the list if it is not 0
            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        }

        //compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum+= number;
        }
        Console.WriteLine($"The sum is: {sum}");


        //compute the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //find the max

        int max = numbers[0];

        foreach (int number in numbers){
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        //find the lower
        int lower = numbers[0];

        foreach (int number in numbers){
            if (number < lower){
                lower = number;
            }
        }
        Console.WriteLine($"The lower is: {lower}");

        

    

    }
}