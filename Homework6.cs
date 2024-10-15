namespace Homework6;

class Program
{
    static void Main(string[] args)
    {

        Professor p1 = new Professor();
        p1.name = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.PrintInfo();

        Professor p2 = new Professor();
        p2.name = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p2.PrintInfo();



        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.PrintInfo();

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.PrintInfo();


        double salaryDiffrence = p1.GetSalary() - p2.GetSalary();
        Console.WriteLine($"The Salary diffrence between {p1.name} and {p2.name} is: {salaryDiffrence}");

        double gradeTotal = s1.GetGrade() + s2.GetGrade();
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {gradeTotal}");

    

    }
}
class Professor{

    private double salary;

    public void SetSalary (double amount){
        salary = amount;
    }
    public double GetSalary(){
        return salary;
    }


    public string name {get; set;}
    public string classTeach{get; set;}
    
        public void PrintInfo(){
        Console.WriteLine($"Professor {name} teaches {classTeach}, and the  salary is: {salary}");
        
    }
}

class Student{

    private double studentGrade;

    public void SetGrade(double amount) {
       studentGrade = amount;
    }

    public double GetGrade(){
        return studentGrade;
    }


    public string studentName {get; set;}
    public string classEnroll{get; set;}
    
        public void PrintInfo(){
        Console.WriteLine($"Student {studentName} enrolls {classEnroll} and the grade is: {studentGrade}");
    }
}
