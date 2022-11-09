//*************************************************************/
//*  Практическая работа №5                                   */
//*  Выполнил: Кирилов С.А., группа 2-ИСП                     */
//*  Задание: составить программу работы алгоритма ветвления  */
//*************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; // объявление переменных

            Console.WriteLine("Практическая работа №5");
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите три числа:\n");
            Console.Write("a="); //ввод исходных данных
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0) // если a>0 и b>0 и c>0, 
            { Console.WriteLine("Высказывание - все числа положительные - истинно"); } // то выводится "Истина"
            else if (a<0||b<0||c<0) // если a<0 или b<0 или c<0,
            { Console.WriteLine("Высказывание - все числа положительные - ложно"); } // то выводится "Ложь"
            Console.ReadKey();

        }
    }
}
