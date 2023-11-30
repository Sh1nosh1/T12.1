using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12._1
{
    internal class Program
    {
        //Task1
        /*static void Main(string[] args)
        {
            try
            {
                Person person1 = new Person("Kirill", "Markov", 17);
                person1.GetInfo();

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }*/

        //Task2
        /*static void Main(string[] args)
        {
            try
            {
                Point points = new Point(2, 3);
                points.ToString();
                WriteLine($"{points.Distance()}:f2");

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }*/

        static void Main(string[] args)
        {
            try
            {
                Address address = new Address(3300,"PMR","Tiraspol","1 may",10,143);
                Write($"{address.ToString()}");

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
