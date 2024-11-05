namespace Homework9;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222,"Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444,"David");

        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }


        Dictionary <double, string> gradeBook = new Dictionary<double, string>();
        gradeBook.Add(4.0,"Alice");
        gradeBook.Add(3.6,"Bob");
        gradeBook.Add(2.5,"Cathy");
        gradeBook.Add(1.8,"David");



        if (!gradeBook.ContainsValue("Tom"))
        {
            gradeBook.Add(3.3,"Tom");
        }






        double totalGPA = 0.0;
        int countGPA = 0;
        double averageGPA = 0;

        foreach (var studentGPA in gradeBook)
        {
            totalGPA += studentGPA.Key;
            countGPA++;
        }

    if (countGPA > 0)
    {
        averageGPA = totalGPA/countGPA;
        Console.WriteLine($"THe average GPA is : {averageGPA}");







    }
    foreach (var entry in gradeBook)
        {
            if (entry.Key > averageGPA)
                {
                    foreach (Student stu in Student.student_list)
                    {
                        if (stu.StudentName == entry.Value)
                        {
                            stu.PrintInfo();
                        }
                    }
                }
            }





    }
}











class Student{
    public static List<Student> student_list = new List<Student>();
    private int studentID { get; set; }
    private string studentName { get; set; }
    public string StudentName => studentName;
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }
}



