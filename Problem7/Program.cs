using System;


class Program
{
    static void Main()
    {
        //7.Силата на гравитационното поле на Луната е приблизително 17 % от това на Земята.Напишете програма, 
        //която да изчислява тежестта на човек на Луната, по дадената тежест на Земята.
        Console.Write("Enter weight man:");
        int weight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The weight of man is {0}", weight * 0.17);


    }
}

