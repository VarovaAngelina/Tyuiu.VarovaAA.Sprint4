using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VarovaAA.Sprint4.Task6.V25.Lib;
namespace Tyuiu.VarovaAA.Sprint4.Task6.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Варова А. А. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Варова Ангелина Александровна | ИИПб-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных ['Теннис', 'Футбол', 'Крикет', 'Баскетбол', *");
            Console.WriteLine("* 'Бейсбол', 'Регби', 'Хоккей'] используя класс Array подсчитайте         *");
            Console.WriteLine("* количество элементов, длина которых больше 6.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var words = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

            Console.WriteLine(" Исходный массив: ");
            for (int i = 0; i <= words.Length - 1; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int nums = ds.Calculate(words);

            Console.WriteLine(nums);

            Console.ReadKey();
        }
    }
}
