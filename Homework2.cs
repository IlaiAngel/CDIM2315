namespace Homework2;

class Program
{
    static void Main(string[] args)
    {

        //Code for Q1

        Console.WriteLine("Please input a letter grade:");
        string letter = Console.ReadLine();
        switch (letter)
        {
            case "A":
            Console.WriteLine("GPA point: 4");
            break;
            case "B":
            Console.WriteLine("GPA point: 3");
            break;
            case "C":
            Console.WriteLine("GPA point: 2");
            break;
            case "D":
            Console.WriteLine("GPA point: 1");
            break;
            case "F":
            Console.WriteLine("GPA point: 0");
            break;

            default:
            Console.WriteLine("Wrong Letter Grade!");
            break;

        }
        
        //Code for Q2
        Console.WriteLine("Please input the first num: ");
        int number1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num: ");
        int number2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num: ");
        int number3 = Convert.ToInt16(Console.ReadLine());

        int small = number1;
        if (number2 <small)
        {
            small = number2;
        }
        if (number3 <small)
        {
            small=number3;
        }
        Console.WriteLine($"the smallest value is {small}");
    }
}
