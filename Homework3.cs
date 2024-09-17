namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        
        Console.WriteLine("Input an integer: ");
        int num = Convert.ToInt16(Console.ReadLine());

            if (num<=1)
            {
                Console.WriteLine("N is non-prime");
            }
            else
            {
                int isPrime = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime++;
                    }
                }
                if (isPrime == 2)
                {
                    Console.WriteLine("N is prime");
                }
                else
                {
                    Console.WriteLine("N is non-prime");
                }
            }
            




        //Code for Q2
        
        Console.WriteLine("Assign an int value to N: ");
        int N = Convert.ToInt16(Console.ReadLine());
        for (int row = 0; row<N; row++){
            for(int col = 0; col <N; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine(" ");
        }
        


        //Code for Q3
        
        Console.WriteLine("Assign an int value to N: ");
        int N = Convert.ToInt16(Console.ReadLine());

        for(int row = 0; row<N; row++){
            for(int col = 0; col<N; col++)
            {
                if(row>=col)
                Console.Write('*');
            }
            Console.WriteLine(" ");
        }
        


        


    }
}
