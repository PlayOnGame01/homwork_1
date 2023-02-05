using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homwork_1
{

    class Program
    {
        ///////////////Задание 1 
        //public class FizzBuzz
        //{
        //    public void Start()
        //    {
        //        FizzBuzz(100);
        //    }
        //    private void FizzBuzz(int num)
        //    {
        //        for (int i = 1; i < num; i++)
        //        {
        //            if (i % 3 == 0) //Fizz
        //            {
        //                Console.Write("Fizz");
        //            }
        //            else if (i % 5 == 0 && i % 3 == 0)
        //            {
        //                Console.Write("FizzBuzz");
        //            }
        //            else if (i % 5 == 0)
        //            {
        //                Console.WriteLine("Buzz");
        //            }
        //            else
        //            {
        //                Console.WriteLine(i.ToString());
        //            }
        //        }
        //        Console.ReadKey();
        //    }
        //}
        /////////////////////////////////////////////
        ////Задание 3
        //static void Main(string[] args)
        //    {
        //    string some_number = null;
        //    char[] char_number;
        //    some_number = Console.ReadLine();
        //    char_number = new char[some_number.Length];
        //    for (int i = 0; i < some_number.Length; i++)
        //    {
        //        char_number[i] = some_number[i];
        //        Console.Write(some_number[i]);
        //    }
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}
        /////////////////////////////////////////////
        ////Задание 4
        /////static void Main(string[] args)
        //    {
        //    string some_number = null;
        //    char[] char_number;
        //    some_number = Console.ReadLine();
        //    char_number = new char[some_number.Length];
        //    for (int i = 0; i < some_number.Length; i++)
        //    {
        //        char_number[i] = some_number[i];
        //        Console.Write(some_number[i]);
        //    }
        //    Console.WriteLine();
        //    for (int i = char_number.Length - 1; i >= 0; i--)
        //    Console.Write(char_number[i]);
        //    Console.ReadKey();
        //}
        ///////////////////////
        //////////Задание 5 
        //static void Main(string[] args)
        //{
        //    Console.Write("Введите день: ");
        //    int a = int.Parse(Console.ReadLine());
        //    if (a > 31) Console.WriteLine("Дата некоректная");
        //    else Console.Write("Введите месяц: ");
        //    int b = int.Parse(Console.ReadLine());
        //    if (b > 12) Console.WriteLine("Дата некоректная");
        //    else if ((a <= 0) || ((a >= 28) && (b == 2)) || ((a > 31) && ((b == 1) || (b == 3) || (b == 5) || (b == 7) || (b == 8) || (b == 10) || (b == 12))) || ((a > 30) && ((b == 4) || (b == 6) || (b == 9) || (b == 11)))) Console.WriteLine("Дата некоректная");
        //    if ((b == 12) || (b <= 2)) Console.Write("Время года - зима");
        //    else if ((b >= 3) && (b <= 5)) Console.Write("Время года - весна");
        //    else if ((b >= 6) && (b <= 8)) Console.Write("Время года - лето");
        //    else if ((b >= 9) && (b <= 11)) Console.Write("Время года - осень");
        //    Console.ReadKey(); 
        //}
    }
}
