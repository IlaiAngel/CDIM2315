namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer(110,28,"Alice");
        Customer Bob = new Customer(111,30,"Bob");
        
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();

        Alice.ChangeID(220);
        Bob.ChangeID(221);
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();

        Bob.CompareAge(Alice);
    }
}

class Customer{
    private int cus_id=0;

    public int cusId{
        get{ return cus_id;}
    }


    public string cus_name= string.Empty;
    public int cus_age=0;

     public Customer(int id, int age, string name){
       cus_id = id;
       cus_age= age;
       cus_name= name;
    }

    public void ChangeID(int new_id){
        cus_id = new_id;
    }

    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
        

    }

    public void CompareAge(Customer objCustomer){
        if (cus_age > objCustomer.cus_age){
            Console.WriteLine($"{cus_name} is older.");
        }else{
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }



}