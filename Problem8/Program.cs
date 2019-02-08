using System;


class Program
{
    static void Main()
    {
        ////8.Напишете програма, която проверява дали дадена точка О(x, y) е вътре в окръжността К((0, 0), 5).
        ////Пояснение: точката(0, 0) е център на окръжността, а радиусът й е 5.
        //Използвайте питагоровата теорема a2 +b2 = c2.За да е точката вътре в кръга, то x* x +y * y 
        // следва да е по-малко или равно на 5.
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y:");
        int y = Convert.ToInt32(Console.ReadLine());
        bool trust = (x * x + y * y <= 5) ? true : false;
        Console.WriteLine(trust);


    }
}