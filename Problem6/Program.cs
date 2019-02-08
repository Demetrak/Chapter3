using System;



class Program
{
    static void Main()
    {
        //6.Напишете програма, която за подадени от потребителя дължина и височина на право­ъгълник,
        //пресмята и отпечатва на конзолата неговия периметър и лице. S = a.b 
        // P = 2 * (a + b)

        Console.Write("Enter a:");
        var area = int.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        var area1 = int.Parse(Console.ReadLine());
        var square = 2 * (area1 + area);
        Console.WriteLine("Area is:");
        Console.WriteLine(square);

    }
}

