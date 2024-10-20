using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17.Дан пол человека: м - мужчина, ж - женщина.Вывести на экран возможные мужские и женские имена в зависимости от введенного пола. 
            /*
               Console.Write("Введите пол человека: ");
               string gender = Console.ReadLine().ToLower();

               string[] maleNames = { "Данил", "Иван", "Алексей", "Сергей", "Андрей", "Дмитрий" };
               string[] femaleNames = { "Елена", "Анна", "Мария", "Екатерина", "Ольга", "Елена" };

               if (gender == "м")
               {
                   Console.WriteLine("Мужские имена:");
                   foreach (string name in maleNames)
                   {
                       Console.WriteLine(name);
                   }
               }
               else if (gender == "ж")
               {
                   Console.WriteLine("Возможные женские имена:");
                   foreach (string name in femaleNames)
                   {
                       Console.WriteLine(name);
                   }
               }
               else
               {
                   Console.WriteLine("Некорректный ввод пола.");
               }
      */
            //17. Определить, есть ли среди цифр заданного целого трёхзначного числа одинаковые.
            /*
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int num1 = number / 100;
            int num2 = (number / 10) % 10;
            int num3 = number % 10;

            if (num1 == num2 || num1 == num3 || num3 == num2)

            {
                Console.WriteLine("Есть одинаковые цифры!");
            }
            else
            {
                Console.WriteLine("Все цифры числа различны!");
            }
       */

            Console.ReadKey();
            }
    }
}
