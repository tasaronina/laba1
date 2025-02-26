using System;
//Дано трехзначное число. Не прибегая к использованию строк вывести наибольшую из его цифр
namespace FirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if (!Logica.IsThreeDigitNumber(number))
            {
                Console.WriteLine("Ошибка: Введите корректное трехзначное число.");
                return;
            }


            int largestDigit = Logica.FindLargestDigit(number);


            if (Logica.AllDigitsEqual(number))
            {
                Console.WriteLine("Все цифры одинаковы.");
            }
            else
            {
                Console.Write("Наибольшая цифра: " + largestDigit);
            }
        }
    }

    public class Logica
    {

        public static int FindLargestDigit(int number)
        {
            int a = number / 100; // первая цифра
            int b = (number / 10) % 10; // вторая цифра
            int c = number % 10; // третья цифра

            int largestDigit = a;

            // cравниваем 
            if (b > largestDigit)
            {
                largestDigit = b;
            }
            if (c > largestDigit)
            {
                largestDigit = c;
            }

            return largestDigit;
        }


        public static bool IsThreeDigitNumber(int number)
        {
            if (number >= 100 && number <= 999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AllDigitsEqual(int number)
        {
            int a = number / 100; // первая цифра
            int b = (number / 10) % 10; // вторая цифра
            int c = number % 10; // третья цифра

            return a == b && b == c;
        }
    }
}
//обязательно добавить проверку чтобы если например было число 222 то выводило больлшего числа нет
