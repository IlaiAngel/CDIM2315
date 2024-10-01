namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input for a: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input for b: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input for c: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input for d: ");
        int number4 = Convert.ToInt32(Console.ReadLine());

        int big = FindBig(number1, number2);
        Console.WriteLine($"a = {number1}; b = {number2};");
        Console.WriteLine($"the largest number is: {big}");

        int bigFour = FindFour(number1, number2, number3, number4);
        Console.WriteLine($"a = {number1}; b = {number2}; c = {number3}; d = {number4}; ");
        Console.WriteLine($"The largest number is {bigFour}");

        createAccount();

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
    static int FindFour(int number1, int number2, int number3, int number4)
    {
        int bigFour = number1;

        if(number2 > bigFour)
        {
            bigFour = number2;
        }
        if (number3 > bigFour)
        {
            bigFour = number3;
        }
        if (number4 > bigFour)
        {
            bigFour = number4;
        }
        return bigFour;
    }

    static bool checkAge(int birth_year){
        int current_year = 2024;
        int age = current_year - birth_year;
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void createAccount(){
         Console.Write("Enter your username: ");
         string userName = Console.ReadLine();


         //check passwords 
         Console.Write("Enter your password: ");
         string passWord = Console.ReadLine();
         Console.Write("Enter your Password Again: ");
         string passAgain = Console.ReadLine();
         if(passWord == passAgain){
             Console.Write("Enter your Birthyear: ");
         string birthYearInput = Console.ReadLine();
         int birthYear = Convert.ToInt32(birthYearInput);
         if (checkAge(birthYear)){
            Console.WriteLine("Account is created successfully");
         }else{
            Console.WriteLine("Could not create an account.");
         }
         }else{
            Console.WriteLine("Wrong password");
         }





         }



        

}
