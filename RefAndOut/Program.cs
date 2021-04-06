using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //ref
        Console.WriteLine("ref");
        int number1 = 5;
        int number2 = 10;
        var result = AddRef(ref number1, number2);
        Console.WriteLine(result);
        Console.WriteLine(number1);
        //out
        Console.WriteLine("out");
        int number3;
        int number4 = 10;
        var result1 = AddOut(out number3, number4);
        Console.WriteLine(result1);
        Console.WriteLine(number3);
        Console.ReadLine();

    }
    static int AddRef(ref int number1, int number2)
    {
        number1 = 15;
        return number1 + number2;
    }

    static int AddOut(out int number3, int number4)
    {
        number3 = 15;
        return number3 + number4;
    }
}
