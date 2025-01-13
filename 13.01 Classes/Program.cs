using _13._01_Classes.Utils;
using _13._01_Classes.Utils.Util10;
using _13._01_Classes.Utils.Util20;
using _13._01_Classes.Utils.Utils30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Введите номер уравнения (1 - 30): ");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        {
                            Console.Clear();

                            Console.Write("Введите значение переменной t: ");
                            double t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной l: ");
                            double l = Convert.ToDouble(Console.ReadLine());

                            Task1 task1 = new Task1(t, l);


                            task1.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            Console.Clear();

                            Console.Write("Введите значение переменной p: ");
                            double p = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task2 task2 = new Task2(p, y);


                            task2.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        {
                            Console.Clear();

                            Console.Write("Введите значение переменной n: ");
                            double n = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task3 task3 = new Task3(n, y);


                            task3.Display();

                            Console.ReadKey();

                        }
                        break;
                    case "4":
                        {
                            Console.Write("Введите значение переменной a: ");
                            double a = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной t: ");
                            double t = Convert.ToDouble(Console.ReadLine());

                            Task4 task4 = new Task4(a, t);


                            task4.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        {
                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task5 task5 = new Task5(x);


                            task5.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "6":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task6 task6 = new Task6(y, x);


                            task6.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "7":
                        {
                            Console.Write("Введите значение переменной m: ");
                            double m = Convert.ToDouble(Console.ReadLine());

                            Task7 task7 = new Task7(m);


                            task7.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "8":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task8 task8 = new Task8(y);


                            task8.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "9":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task9 task9 = new Task9(y, x);


                            task9.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "10":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной k: ");
                            double k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task10 task10 = new Task10(y, k, x);


                            task10.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "11":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task11 task11 = new Task11(y, x);


                            task11.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "12":
                        {
                            Console.Write("Введите значение переменной t: ");
                            double t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task12 task12 = new Task12(t, x);


                            task12.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "13":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task13 task13 = new Task13(y);


                            task13.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "14":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task14 task14 = new Task14(y, x);


                            task14.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "15":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task15 task15 = new Task15(y);


                            task15.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "16":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task16 task16 = new Task16(y);


                            task16.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "17":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task17 task17 = new Task17(y);


                            task17.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "18":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task18 task18 = new Task18(y);


                            task18.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "19":
                        {
                            Console.Write("Введите значение переменной n: ");
                            double n = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной g: ");
                            double g = Convert.ToDouble(Console.ReadLine());

                            Task19 task19 = new Task19(n, y, g);


                            task19.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "20":
                        {
                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной k: ");
                            double k = Convert.ToDouble(Console.ReadLine());

                            Task20 task20 = new Task20(x, y, k);


                            task20.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "21":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной h: ");
                            double h = Convert.ToDouble(Console.ReadLine());

                            Task21 task21 = new Task21(y, h);


                            task21.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "22":
                        {
                            Console.Write("Введите значение переменной u: ");
                            double u = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task22 task22 = new Task22(u, y, x);


                            task22.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "23":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task23 task23 = new Task23(y);


                            task23.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "24":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task24 task24 = new Task24(y);


                            task24.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "25":
                        {
                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Task25 task25 = new Task25(y);


                            task25.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "26":
                        {
                            Console.Write("Введите значение переменной p: ");
                            double p = Convert.ToDouble(Console.ReadLine());

                            Task26 task26 = new Task26(p);


                            task26.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "27":
                        {
                            Console.Write("Введите значение переменной v: ");
                            double v = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной y: ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task27 task27 = new Task27(v, y, x);


                            task27.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "28":
                        {
                            Console.Write("Введите значение переменной v: ");
                            double v = Convert.ToDouble(Console.ReadLine());

                            Task28 task28 = new Task28(v);


                            task28.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "29":
                        {
                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task29 task29 = new Task29(x);


                            task29.Display();

                            Console.ReadKey();
                        }
                        break;
                    case "30":
                        {
                            Console.Write("Введите значение переменной x: ");
                            double x = Convert.ToDouble(Console.ReadLine());

                            Task30 task30 = new Task30(x);


                            task30.Display();

                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;

                }
                
            }
        }
    }
}













































































































































































































































































































/*
Савелов "Sovush" Сергей
Головин "GoFrom" Егор
*/