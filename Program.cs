using System;

namespace Lesson2App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            byte b = Convert.ToByte(Console.ReadLine());
            if (b<15) Console.WriteLine("Промежуток [0 - 14]");
            else if(b<36) Console.WriteLine("[15 - 35]");
            else if(b<51) Console.WriteLine("[36 - 50]");
            else if(b<101) Console.WriteLine("[50 - 100]");
            else 
            { 
                Console.WriteLine("Этот число не входит ни в один из промежутков");
            }
        }
    }
}g
