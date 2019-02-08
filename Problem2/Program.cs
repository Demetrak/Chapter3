using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.

            
            Console.WriteLine((35 % 7 ==0) ? "true" : "false");
            Console.WriteLine((35 % 5 ==0) ? "true" : "false");
            var valueOne = int.Parse(Console.ReadLine());
            var result = valueOne % 5 == 0 && valueOne % 7 == 00;
            Console.WriteLine(result);


        }
    }
}
