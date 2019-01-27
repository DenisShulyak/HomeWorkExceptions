using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
            /*
            1.	реализовать метод деления двух чисел. 
            Внутри метода проверять входящие параметры. 
            Если они не заданы, то генерировать исключение 
            ArgumentNullException. Если делитель равен нулю, 
            то генерировать исключение ArgumentException.
            */
        static public double DivisionNumbers(double number1, double number2 )
        {
            if (number1 == null || number2 == null)
                throw new ArgumentNullException("Числа не были заданы");
            if (number2 == 0)
                throw new ArgumentException("На нуль делить нельзя!");
            return number1 / number2;
        }
            /*
            2.	Написать программу, которая обращается 
            к элементам массива по индексу и выходит за его 
            пределы. После обработки исключения вывести в 
            финальном блоке сообщение о завершении обработки массива.
             */
        static public int AppealByIndex(int index)
        {
            int[] numbers = new int[10];
            return numbers[index];

        }


        static void Main(string[] args)
        {



            Console.WriteLine("1)");
          //  double number1 = 5, number2 = 0;
            Console.WriteLine("Введите делимое:");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель:");
            double number2 = double.Parse(Console.ReadLine());

            //1)
            try
            {
                Console.WriteLine("Полученное частное: " + DivisionNumbers(number1, number2));
            } 
            catch (ArgumentNullException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }


            //2)

            Console.WriteLine("2)");
            try
            {
                AppealByIndex(11);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Выход за пределы массива");
            }
            finally
            {
                Console.WriteLine("Обработка массива была завершена");
            }




            Console.ReadLine();
        }
    }
}
