class Program
{
     public static void Main(string[] args)
    {
        Student s1 = new Student("Tom", 15,75);
       Console.WriteLine(s1.GetName());
       s1.SetFinalGrade(40);
       Console.WriteLine(s1.GetFinalGrade());
    }//get and set functions act as constraints for a program to work how you want it to work
       
}

    