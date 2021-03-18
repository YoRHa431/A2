using Laba2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class MyApplication
    {
        public void Menu(Tovar tovar1, List<Tovar> tovarList)
        {
            int current = -1;
            int n = 0;
            int littleMenu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Добавить элемент в коллекцию.");
                Console.WriteLine("2. Удаление текущего элемента из списка");
                Console.WriteLine("3. Перемещение по списку");
                Console.WriteLine("4. Установка нового значения для текущего элемента");
                Console.WriteLine("5. Вывести элементы списка");
                Console.WriteLine("6. Показать текущий элемент списка");
                Console.WriteLine("7. Сортировка");
                Console.WriteLine("8. Выход");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Введите наименование товара");
                        string naimenovanie = Console.ReadLine();
                        Console.WriteLine("Введите количество");
                        uint kolichestvo = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Введите стоимость");
                        double price = Convert.ToDouble(Console.ReadLine());
                        tovar1.ElemAdd(tovarList, new Tovar(naimenovanie, kolichestvo, price));
                        current++;
                        break;
                    case 2:
                        tovar1.ElemDelete(tovarList, tovarList[current]);
                        current--;
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите позицию текущего элемента списка");
                            Console.WriteLine("1. Первый");
                            Console.WriteLine("2. Следующий");
                            Console.WriteLine("3. Предыдущий");
                            Console.WriteLine("4. Последний");
                            Console.WriteLine("5. Показать текущий элемент списка");
                            Console.WriteLine("6. Назад");
                            littleMenu = Convert.ToInt32(Console.ReadLine());
                            switch (littleMenu)
                            {
                                case 4:
                                    current = tovarList.Count - 1;
                                    break;
                                case 3:
                                    if (current > 0)
                                    {
                                        current--;
                                    }
                                    break;
                                case 2:
                                    if (current < tovarList.Count)
                                    {
                                        current++;
                                    }
                                    break;
                                case 1:
                                    current = 0;
                                    break;
                                case 5:
                                    Console.WriteLine();
                                    tovar1.ShowCurrent(tovarList, current);
                                    Console.ReadKey();
                                    break;
                            }
                        } while (littleMenu < 6);
                        break;
                    case 4:
                        Console.WriteLine("Введите наименование товара");
                        string newNaimenovanie = Console.ReadLine();
                        Console.WriteLine("Введите количество");
                        uint newKolichestvo = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Введите стоимость");
                        double newPrice = Convert.ToDouble(Console.ReadLine());
                        tovar1.ElemChange(tovarList, current, new Tovar(newNaimenovanie, newKolichestvo, newPrice));
                        break;
                    case 5:
                        Console.Clear();
                        tovar1.Showlist(tovarList);
                        Console.WriteLine("Для продолжения нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        tovar1.ShowCurrent(tovarList, current);
                        Console.WriteLine("Для продолжения нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Выберите сортировку");
                        Console.WriteLine("1. По возрастанию");
                        Console.WriteLine("2. По убыванию");
                        Console.WriteLine("3. Назад");
                        littleMenu = Convert.ToInt32(Console.ReadLine());
                        switch (littleMenu)
                        {
                            case 1:
                                tovar1.ListSort(tovarList);
                                break;
                            case 2:
                                tovar1.ListSort(tovarList);
                                tovarList.Reverse();
                                break;
                        }
                        break;
                }
            } while (n < 8);
        }
    }
}
