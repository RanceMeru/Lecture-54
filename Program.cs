class Program
{
     public static void Main(string[] args)
    {
        Student s1 = new Student("Tom", 15,75);
        s1.Name ="Bob";
       Console.WriteLine(s1.Name);
       s1.SetFinalGrade(105 );
       Console.WriteLine(s1.GetFinalGrade());
    }//get and set functions act as constraints for a program to work how you want it to work
       
}

    