using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int cmd=0;
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите целое число A =");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число B =");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции: \n 1 - сложение\n 2 - вычитание\n 3 - умножение\n 4 - частное\n");
                Console.WriteLine("Ваш выбор: ");
                cmd = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода" + ex.Message);
                Console.ReadKey();
                return;
             }
            switch (cmd)
            {
                case 1:
                    {
                        Console.WriteLine("Результат равен = {0}", a + b);
                        break;
                    }
                    case 2:

                    {
                        Console.WriteLine("Результат равен = {0}", a - b);
                        break;
                    }
                        case 3:
                    {
                        Console.WriteLine("Результат равен = {0}", a*b);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            Console.WriteLine("Результат равен = {0:f2}", a / b);
                        }
                        catch(Exception ex) 
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Нет операции с указанным номером!");
                        break;
                    }




            }
            Console.ReadKey();
        }
    }
}
