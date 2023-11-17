using Microsoft.VisualBasic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine("Good Day");
        //nameFirst();
        //numBer();
        //yourAge();
        //sqRoot();
        //dateT();
        //seQuence();
        //oddEven();
        //diviSible();
        //unKnown();
        //trapeZoid();
        //recTangle();
        //graviTation();
        //pythaGoras();
        //priNt();
        //theCheck();
        //theSequence();
        //primeNumber();
    }
    public static void nameFirst()
    {
        Console.WriteLine("Enter firstName");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter lastName");
        string lastName = Console.ReadLine();
        Console.WriteLine(firstName + " " + lastName);
    }
    public static void numBer()
    {
        int i = 1;
        int h = i + 100;
        int k = i + 1000;

        Console.WriteLine(i);
        Console.WriteLine(h);
        Console.WriteLine(k);
    }
    public static void yourAge()
    {
        Console.WriteLine("Enter Age");
        int age = int.Parse(Console.ReadLine());
        int y = age + 10;
        Console.WriteLine("I am " + y + "years old");
    }
    public static void sqRoot()
    {
        Console.WriteLine("Enter a num");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(i));
            }
    public static void dateT()
    {
        int k = DateTime.Now.Day;
        int j = DateTime.Now.Month;
        int l = DateTime.Now.Year;
        int m = DateTime.Now.Hour;
        int n = DateTime.Now.Minute;
        int o = DateTime.Now.Second;
        Console.Write(k + "/" + j + "/" + l);
        Console.WriteLine(" ");
        Console.Write(m + ":" + n + ":" + o);
    }
    public static void seQuence()
    { 
        for ( int i = 2, sum = -3; i <= 100; i = i + 2, sum =(i + 1) * -1 ) 
        {
        Console.WriteLine("i = {0}, sum ={1}", i , sum);
        }
    }
    public static void oddEven()
    {
        Console.WriteLine("Enter a number");
        int i = int.Parse(Console.ReadLine());
        int I = i % 2;

        if (I == 0)
            Console.WriteLine("The number " + i + " is even");
        else
            Console.WriteLine("The number " + i + " is odd");
    }
    public static void diviSible()
    {
        Console.WriteLine("Enter a number");
        int i = int.Parse(Console.ReadLine());
        int k = i % 5;
        int j = i  % 7;

        if (j == k)
            Console.WriteLine( i + " is divisible by 5 and 7");
        else
            Console.WriteLine(i + " is not divisible by 5 and 7");
    }
    public static void unKnown()
    {
        Console.WriteLine("Enter a number");
        int j = int.Parse(Console.ReadLine());
        int k = j / 100;
        int l = k / 10;

        if (l == 7)
            Console.WriteLine("The original number is " + j);
        else
        Console.WriteLine("The original number is not " + j);
    }
    public static void trapeZoid() 
    {
        Console.WriteLine("Enter a number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of h");
        int h = int.Parse(Console.ReadLine());

        int S = (a + b) * h/2;

        Console.WriteLine("Trapezoid surface:" + (a + b) + "*" + h/2 + "= " + S);
    }
    public static void recTangle ()
    {
        Console.WriteLine("Enter the length of the rectangle");
        int l = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the breadth");
        int b = int.Parse(Console.ReadLine());
        int p = 2 * (l * b);
        int a = 2 * l;
        Console.WriteLine(" The perimeter of rectangle A" + " = " + p);
        Console.WriteLine("The area of rectangle A" + " = " +  a );

    }
    public static void graviTation()
    {
        Console.WriteLine("Enter a number");
        int ew = Convert.ToInt32(Console.ReadLine());
        var mw = ew * 0.17;
        Console.WriteLine(mw);
    }
    public static void pythaGoras()
    {
       /* Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        bool isInside = (x * *+y * y <= 5) ? true : false;
        Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, isInside);*/
    
        int x = 0; int y = 0; int r = 5;
        int a = x * x; int b = y * y; int c = r * r;
        bool A = (x * x) + (y * y) <= (r * r);
        int l = 5; int w = 5;
        int k = 2 * l * w;
        bool B = k >= r * r;

        if (A == B)

            Console.WriteLine("Expression correct");
        else
            Console.WriteLine("Expression incorrect");
    } 
    public static void priNt()
    {
        Console.WriteLine("Enter num");
        int num = int.Parse(Console.ReadLine());
        int a = num % 10;//Module dividing by 10 to get the 4th number of the 4th digit number
        int b = (num / 10) % 10; //then module dividing by 10 to get the 3rd number of the 4th digit number
        int c = (num / 100) % 10;//then module dividing by 10 to get the 2nd number of the 4th digit number
        int d = (num / 1000) % 10;//then module dividing by 10 to get the 1st number of the 4th digit number
        int K = a + b + c + d;// to calculate
        int reverse = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            reverse = (reverse * 10) + remainder;
            num = num / 10;
        }
        Console.WriteLine(K);
        Console.WriteLine("Reversed number is {0}", reverse);
        Console.WriteLine("Last digit upfront: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", a, c, b, d);
        Console.ReadLine();
    }
   public static void theCheck()
    {
        int v = 350;
        int p = 350;
        int mask = 1 << p;
        bool isOne = (v & mask) != 0 ? true : false;
        Console.WriteLine("The bit at position {0}of number {1} is 1? {2}", p, v, isOne);
    }
    public static void theSequence()
    {
        int n = 350;
        int v = 0;
        int p = 3;
        n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
        Console.WriteLine(n);
    }
    public static void primeNumber()
    {
        int number = 72;
        bool isPrime = true;
        if (number > 2)
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) isPrime = false;
            }
        Console.WriteLine("{0} is prime?: {1}", number, isPrime);
    }
    public static void 
}