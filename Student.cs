class Student
{
  
    private int age;
    private string name;
    private double finalGrade;//you only want the information from the constructor
      //using properties
      //auto imnplemented Property
     public string LastName {get; private set;}

    public Student(string name,string lastName, int age, double finalGrade)
    {
        this.name = name;
        this.LastName = lastName;
        this.age = age;
        this.finalGrade = finalGrade;
       
       
    }

    public Student(string name,string lastName, int age) :this(name, lastName, age,0)
    {
        //this is duplicating code and we can instead use a constructor initailizer
        //allows us to call another constructor from a constructor
        //this.name = name; 
        //this.age = age;
        //using the this keyword
    }

    
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {name}, I am {age} years old, and my final grade is {finalGrade}.");
    }
    public string Name
    {//properties area variable type thing to run code  
        get
        {
            if(age >=18)
            {
                return name;
            }
            else
            {
                return "This student is too young";
            }
        }

        set
        {
            if(value != "")
            {
                name = value;
            }

        }
    }
    
    
    public int Age
    {
        get
        {
             if (age >= 18)
            {
            return age;
            }
            else 
            {
            return -1;
            }
        }
        set
        {
             if(value != 0)
            {
            age = value;
            }
        }
    }

   
   public double FinalGrade
   {

        get
        {
            return finalGrade;
        }

        set
        {
            if(value < 65)
        {
            value = 65;
        }
        else if (value > 100)
        {
            value = 100;
        }
        finalGrade = value;
        }
   }
   
    
    
}