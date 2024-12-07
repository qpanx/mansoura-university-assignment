
//Copy constructor
/*
class Person
{
    private string name; private int age;

    public Person(Person previousPerson)
    {
        name = previousPerson.name;
        age = previousPerson.age;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string getDetails() 
    {
        return name + "is" + age.ToString(); 
    }
}

class TestPerson
{
    static void Main()
    {
        Person person1 = new Person("Ahmed", 19);
        Person person2 = new Person(person1);
        Console.WriteLine(person2.getDetails());
    }
}
*/

//The this keyword 
/*
namespace keywords
{
    class student
    {
        string NAME;
        public student(): this("ABC")
        {
            Console.WriteLine("Parameterless Constructer of Student class");
        }

        public student(string Name)
        {
            Console.WriteLine("Parameterized constructor of Student class");
            NAME = Name;
        }
        public void display() 
        {
            Console.WriteLine("display() method of Student class");
            Console.WriteLine(NAME);
        }

    }
        
    public class program
    {
        public static void Main()
        {
            student stud = new student();
            stud.display();
        }
    }
}
*/

//Passing by value
/*
public class Calculator
{
    public int add(int a, int b)
    {
        int result;
        result = a + b;
        return result;
    }
}
public class testcalu
{
    public static void Main()
    {
        int result = 0;
        int x = 10;
        int y = 60;
        Calculator C = new Calculator();
        result = C.add(x, y);
        Console.WriteLine("Result: " + result); //output the result
    }
}
*/

//Passing by ref 
/*
public class Swapper
{
    public void swap(ref int a, ref int b)
    {
        int temp; temp = a; a = b; b = temp;
    }
}
public class Test
{
    public static void Main()
    {
        int x = 10; int y = 20;
        Swapper swapper = new Swapper();
        swapper.swap(ref x,ref y);
        Console.WriteLine("x={0}, y={1}", x,y);
    }
}
*/

//Destroying Objects
/*

using ConsoleApplication3;
using System; 
namespace
    ConsoleApplication3
{
    class SampleA
    {
        public SampleA() 
        {
            Console.WriteLine("An Instance Created");
        }
        ~SampleA() 
        {
            Console.WriteLine("An Instance Destroyed");
        }
    }
}
class Program
{
    public static void Test()
    {
        SampleA T = new SampleA();
    }
    static void Main(string[] args)
    {
        Test();
        GC.Collect();
        Console.ReadLine();
    }
}
*/

//C# Properties
/*
using System.Security.Cryptography;

class Circle
{
    private double radius;
        public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            if(value > 0) radius = value;
            else radius = 0;
        }
    }
}
class Testprog
{
    public static void Main()
    {
        Circle c1 = new Circle();
        c1.Radius = -10;
        Console.WriteLine("Circle radius = {0}", c1.Radius);
        c1.Radius = 10;
        Console.WriteLine("Circle radius={0}",c1.Radius);
    }
}
*/

//Overloading(Complex)
/*
using System.Numerics;

class TestProgram
{
    public static void Main()
    {
        Complex complex1 = new Complex(1, 2);
        Complex complex2 = new Complex(3, 4);
        Console.WriteLine("complex1 = {0}", complex1);
        Console.WriteLine("complex2 = {0}", complex2);
        Complex complex3 = -complex1;
        Console.WriteLine("complex1 = {0}", complex3);
        Console.WriteLine("complex1 + complex2 = {0}", complex1 + complex2);
        if(complex1 == complex2)
        {
            Console.WriteLine("complex1 equal complex2");
        }
        else
        {
            Console.WriteLine("complex1 equal complex2");
        }
    }
}
public class Complex
{
    public int real;
    public int imaginary;
    public Complex(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    public override string ToString()
    {
        if (imaginary >= 0)
        {
            return (System.String.Format("{0} + j{1}", real, imaginary));
        }
        else
        {
            return(System.String.Format("{0}-j{1}", real,-imaginary));
        }
    }
    public static Complex operator -(Complex complex)
    {
        return new Complex(-complex.real, -complex.imaginary);
    }
    public static Complex operator +(Complex complex1, Complex complex2)
    {
        return new Complex(complex1.real + complex2.real, complex1.imaginary + complex2.imaginary);
    }
    public static implicit operator Complex(int theInt)
    {
        return new Complex(theInt,0);
    }
    public static explicit operator int(Complex complex)
    {
        return complex.real;
    }

    public static bool operator==(Complex complex1, Complex complex2)
    {
        if(complex1.real == complex2.real && complex1.imaginary == complex2.imaginary)
        {
            return true;
        }
        return false;
    }
    public static bool operator!=(Complex complex1, Complex complex2)
    {
        return !(complex1 == complex2);
    }
    public override bool Equals(object obj)
    {
        if(!(obj is Complex))
        {
            return false;
        }
        return this == (Complex)obj;
    }
    public override int GetHashCode()
    {
        return (int)System.Math.Sqrt(real * real + imaginary * imaginary); 
    }
}
*/

//Array
/*
ArrayClass
    {
    static void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? "" : "");
    }
    Console.WriteLine();
}
static void Main()
{
    string[] weekDays = new string[] { "sun", "mon", "tue", "wed", "thu", "fri", "sat" };
    PrintArray(weekDays);
}
    }
*/