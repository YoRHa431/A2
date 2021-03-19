using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Methods
    {
            Schet с1 = new Schet();
            Schet с2 = new Schet();
            public void zap()
            {
                Console.WriteLine("Данные о первом счете: ");
                с1.Input();
                с1.Print();
                Console.WriteLine();
                Console.WriteLine("Данные о втором счете: ");
                с2.Input();
                с2.Print();
                Console.WriteLine();
            }

            public void kol()
            {
                Console.WriteLine();
                Console.WriteLine("Слияние двух счетов");
                Console.WriteLine("Сумма первого и второго счетов: ");
                if (с1.Value == с2.Value)
                {
                    Schet schet3 = с1 + с2;
                    schet3.Print();
                }
                else
                {
                    Console.WriteLine("Валюты счетов не совпадают, операция слияния недоступна");
                }
            }

            public void snyatie()
            {
                Console.WriteLine();
                Console.Write("Выберите счёт для снятия денег(1, 2): ");
            M1: int a = 0;
                a = Convert.ToInt16(Console.ReadLine());
                if (a == 1 | a == 2)
                {
                    if (a == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Введите сумму денег для снятия с первого счёта: ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        с1 -= t;
                        с1.Print();
                    }
                    if (a == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Введите сумму денег для снятия со второго счёта: ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        с2 -= t;
                        с2.Print();
                    }
                }
                else
                {
                    Console.WriteLine("Такого счёта нет. Введите существующий счёт ");
                    goto M1;
                }

            }

            public void popol()
            {
                Console.WriteLine();
                Console.Write("Выберите счёт для пополнения деньгами(1, 2): ");
            M2: int b = 0;
                b = Convert.ToInt16(Console.ReadLine());
                if (b == 1 | b == 2)
                {
                    if (b == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Введите сумму для пополнения первого счёта: ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        с1 += x;
                        с1.Print();
                    }
                    if (b == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Введите сумму для пополнения второго счёта: ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        с2 += x;
                        с2.Print();
                    }
                }
                else
                {
                    Console.WriteLine("Такого счёта нет. Введите существующий счёт ");
                    goto M2;
                }
            }

            public void srav()
            {
                Console.WriteLine();
                Console.WriteLine("Сравнение счетов: ");
                if (с1 > с2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Первый счёт больше второго.");
                }
                else
                {
                    if (с1 < с2)
                        Console.WriteLine("Первый счёт меньше второго.");
                    else
                        Console.WriteLine("Первый и второй счета равны.");
                }
            }

            public void nachis()
            {
                Console.WriteLine();
                Console.Write("Выберите счёт для начисления процентов(1, 2): ");
            M3: int c = 0;
                c = Convert.ToInt16(Console.ReadLine());
                if (c == 1 | c == 2)
                {
                    if (c == 1)
                    {
                        Console.WriteLine("Начисление процентов на первый счёт(5%): ");
                        с1++;
                        с1.Print();
                    }
                    if (c == 2)
                    {
                        Console.WriteLine("Начисление процентов на второй счёт(5%): ");
                        с2++;
                        с2.Print();
                    }
                }
                else
                {
                    Console.WriteLine("Такого счёта нет. Введите существующий счёт ");
                    goto M3;
                }
            }

            public void start()
            {
                Methods method = new Methods();
                for (int z = 0; z < 99999; z++)
                {
                    Console.WriteLine("1. Создать");
                    Console.WriteLine("2. Слияние счетов");
                    Console.WriteLine("3. Снятие денег со счета");
                    Console.WriteLine("4. Пополнение счета");
                    Console.WriteLine("5. Сравнение счетов");
                    Console.WriteLine("6. Начисление процентов(5%)");
                    Console.WriteLine("7. Выйти.");
                    Console.Write("Выберите действе: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (x)
                    {
                        case 1: method.zap(); break;
                        case 2: method.kol(); break;
                        case 3: method.snyatie(); break;
                        case 4: method.popol(); break;
                        case 5: method.srav(); break;
                        case 6: method.nachis(); break;
                        case 7: Environment.Exit(0); break;
                        default: Console.WriteLine("Введите числа от 1 до 7"); break;

                    }
                }
            }
        }
    }
