namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num: ");
        int number1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num: ");
        int number2 = Convert.ToInt16(Console.ReadLine());

        int big = FindBig(number1, number2);
        Console.WriteLine($"a = {number1}; b = {number2} ");
        Console.WriteLine($"the largest number is: {big}");

        FindN();
    }

    static int FindBig(int number1, int number2)
    {
        
        int big = number1;
        if (number2 >big)
        {
            big = number2;
        }
        return big;

    }
    static void FindN()
    {
        Console.WriteLine("Assign an int value to N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Left or Right?");
        string Shape =(Console.ReadLine());


        if(Shape == "Left"){
        for(int row = 0; row<N; row++){
            for(int col = 0; col<N; col++)
            {
                if(row>=col)
                Console.Write('*');
            }
            Console.WriteLine(" ");
        }
        }
        if(Shape == "Right"){
        for(int row = 0; row<N; row++){
            for(int col = 0; col<N - row - 1; col++)
            {
                Console.Write(' ');
            }
            for (int col = 0; col <= row; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
        }
        Console.WriteLine($"N is: {N}; shape is {Shape}");







    }
}
