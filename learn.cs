// Day 1: Learning C# Basics (Best of luck students)

using System;

class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine("My name is " + Name + " and I am " + Age + " years old.");
    }
}

class Program
{
    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("I am learning C#");

        int age = 20;
        float height = 5.9f;
        string name = "Bipin";
        bool isStudent = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Student: " + isStudent);

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + userName + ", you are " + userAge + " years old.");

// Day 2: Learning C# Basics (Best of luck students)
// loop and conditionals
        if (userAge >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Count: " + i);
        }

//         int j = 1;
//         while (j <= 5)
//         {
//             Console.WriteLine(j);
//             j++;
//         }

//         GreetUser("Bipin");
//         GreetUser("Friend");

//         Person p1 = new Person();
//         p1.Name = "Bipin";
//         p1.Age = 20;
//         p1.Introduce();

//         Console.Write("Enter first number: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());

//         int sum = num1 + num2;
//         Console.WriteLine("Sum: " + sum);
//     }
// }
int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        GreetUser("Bipin");
        GreetUser("Friend");

        Person p1 = new Person();
        p1.Name = "Bipin";
        p1.Age = 20;
        p1.Introduce();

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("Sum: " + sum);
    }
}
int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        GreetUser("Bipin");
        GreetUser("Friend");

        Person p1 = new Person();
        p1.Name = "Bipin";
        p1.Age = 20;
        p1.Introduce();

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("Sum: " + sum);
    }
}
