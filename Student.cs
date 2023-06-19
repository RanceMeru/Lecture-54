class Student
{
  
    private int age;
    private string name;
    private double finalGrade;//you only want the information from the constructor

    public Student(string name, int age, double finalGrade)
    {
        this.name = name;
        this.age = age;
        this.finalGrade = finalGrade;
        //public string lastName { get; set; };
    }

    public Student(string name, int age) :this(name, age,0)
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
    
    public int GetAge()
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
    public void setAge(int newAge)
    {
        if(newAge != 0)
        {
            age = newAge;
        }
    }
    public double GetFinalGrade()
    {
        return finalGrade;

    }
    public void SetFinalGrade(double newFinalGrade)
    {
        if(newFinalGrade < 65)
        {
            newFinalGrade = 65;
        }
        else if (newFinalGrade > 100)
        {
            newFinalGrade = 100;
        }
        finalGrade = newFinalGrade;
    }
}