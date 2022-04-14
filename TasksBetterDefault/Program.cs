using System;
using Math = System.Math;
namespace TasksBetterDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadacha1 

            Console.WriteLine("Задача 1");

            //Пусть t время которое шел челоаек . x - длинна интервала.u - скорость трамвая,тогда:
            //t = 40 * (x / (u - 3)) = 60 * (x / (u + 3))
            //40 / (u - 3) = 60 / (u + 3)
            //2 / (u - 3) = 3 / (u + 3)
            //2 * (u + 3) = 3 * (u - 3)
            //2u + 6 = 3u - 9
            //u = 15 км / ч.
            //Ответ: 15 км / ч

            //Кол-во поездов
            Console.WriteLine("Кол-во трамваев по пути:");
            int p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во трамваев навстречу:");
            int p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите скорость чела: ");
            int v = int.Parse(Console.ReadLine());
            //p1 * (x / (u - v)) == p2 * (x / (u + v));

            //функция нахождения кратного числа
            int nahod(int b, int c)
            {
                int a = 1;
                while (true)
                {
                    if (a % b == 0 && a % c == 0)
                    {
                        return a;
                    }
                    else
                    {
                        a += 1;
                    }
                }
            }

            //находим кратное число значениям трамваев
            int kratnoe = nahod(p1, p2);
            int y = kratnoe/p1;
            int x = kratnoe/p2;

            //Средняя скорость трамваев
            int u;
            for (u = 1; u <= 100; u++)
            {
                if(x*(u+v) == y * (u - v))
                {
                    Console.WriteLine("Ответ: " + u + "км/ч");
                    break;
                }
            }
            Console.WriteLine("Задача 2");
            int[] a = { 123, 142, 125, 154, 133, 119, 148 };
            int[] b = { 134, 142,163,127,142,155,120};

            Console.WriteLine(korrel(a, b));
        }
        static double korrel(int[] a, int[] b)
        {
            //Считаем средние для двух выборок: X, Y (сложить все элементы выборки и разделить на их количество).
            double X = 0, Y = 0;
            double[] c = { };
            for(int i = 0; i < a.Length; i++)
            {
                X += a[i];
                Y += b[i];
            }
            X = X / a.Length;
            Y = Y / b.Length;

            //Считаем почти дисперсию Sx и Sy: суммируем квадраты отклонений(x[i] - X) ^ 2, (y[i] - Y) ^ 2
            double Sx = 0, Sy = 0;
            for(int i = 0; i < a.Length; i++)
            {
                Sx += (a[i] - X) * (a[i] - X);
                Sy += (b[i] - Y) * (b[i] - Y);
            }

            
            //Считаем почти коварацию CovXY: суммируем произведения отклонения X и отклонения Y(x[i] - X) * (y[i] - Y)
            for(int i = 0; i < a.Length; i++)
            {
                double CovXY = 0;
                CovXY += (a[i] - X) * (b[i] - Y);
                Console.WriteLine(CovXY);
            }
            return 0;

        }
    }
}
