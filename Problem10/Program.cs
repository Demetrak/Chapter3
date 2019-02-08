using System;



class Program
{
    static void Main()
    {
        // 10.Напишете програма, която приема за вход четирицифрено число във формат abcd(например числото 2011) 
        // и след това извършва следните действия върху него:
        //-Пресмята сбора от цифрите на числото(за нашия пример 2 + 0 + 1 + 1 = 4).
        //- Разпечатва на конзолата цифрите в обратен ред: dcba(за нашия пример резултатът е 1102).
        //- Поставя последната цифра, на първо място: dabc(за нашия пример резултатът е 1201).
        //- Разменя мястото на втората и третата цифра: acbd(за нашия пример резултатът е 2101).

        var number = int.Parse(Console.ReadLine());
        int a = (number / 1000);
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10 ;
        Console.WriteLine("Sum of numbers = {0}", a + b + c + d );
        Console.WriteLine("The back turn:{0},{1},{2},{3} d, c, b, a");
        Console.WriteLine("Last digit on first place: {3},{0},{1},{2} d, a, b, c");
        Console.WriteLine("Secong digit on third place:{2},{1},{0},{1} a, c, b, d");


        
    }
}

