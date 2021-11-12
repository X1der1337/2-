//Слепцов Антон

//1.Написать метод, возвращающий минимальное из трёх чисел.
//2. Написать метод подсчета количества цифр числа.
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
//С помощью цикла do while ограничить ввод пароля тремя попытками

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lesson
{
    class Program
    {
        static void task1()
        {
            Console.WriteLine("Первая задача:");
            int a, b, c, min;
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            c = int.Parse(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            Console.WriteLine($"Минимальное число - {min}");
            Console.WriteLine("=============================");
        }

        static void task2()
        {
            Console.WriteLine("Вторая задача:");
            int a, b;
            b = 0;
            Console.WriteLine("Введите число");
            a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                a = a / 10;
                b++;
            }
            Console.WriteLine($"У этого числа {b} цифр(-ы)");
            Console.WriteLine("=============================");
        }

        static void task3()
        {
            Console.WriteLine("Третья задача:");
            int a = 1, b = 0;
            Console.WriteLine("Начинайте вводить числа");
            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if ((a % 2 == 1) && (a > 0))  b += a;        
            }
            Console.WriteLine($"Сумма введенных нечетных положительных чисел равна =  {b}");
            Console.WriteLine("=============================");
        }

        static void task4()
        {
            Console.WriteLine("Четвертая задача:");
            string a, b, c, d;
            c = "root";
            d = "GeekBrains";
            int e = 0;
            do
            {
                Console.WriteLine("Введите логин:");
                a = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                b = Console.ReadLine();
                if ((a == c) && (b==d)){
                    Console.WriteLine("Вы успешно вошли в аккаунт!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль");
                    Console.WriteLine();
                    e++;
                }

            } while (e < 3);
            if (e==3) Console.WriteLine("Превышен лимит попыток входа");
            Console.WriteLine("=============================");
        }

        static void Main(string[] args)
        {
            bool n = true;
            while (n)
            {
                Console.WriteLine("Введите номер задачи которую хотите посмотреть");
                int m = int.Parse(Console.ReadLine());

                switch (m)
                {
                    case 1: Console.WriteLine("============================="); task1(); break;
                    case 2: Console.WriteLine("============================="); task2(); break;
                    case 3: Console.WriteLine("============================="); task3(); break;
                    case 4: Console.WriteLine("============================="); task4(); break;
                    case 0: n = false; break;
                    default: Console.WriteLine("Вы ввели неверное число"); break;
                }
            }
        }
    }
}
