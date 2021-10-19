using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;

            Console.WriteLine("Сколько у Вас денег?");
            x = Convert.ToDouble(Console.ReadLine()); // считываем с консоли

            // условие для какждой ситуации
            if (x <= 50)
            {
                Console.WriteLine("Вы взяли мало денег");
            } else if(x >= 250)
            {
                Console.WriteLine("Вы будете обедать?");
            }
            else if (x >= 220)
            {
                Console.WriteLine("Вам хватит на завтра!");
            }

            Console.ReadLine(); // задерживаем консоль 
        }


    }
}
