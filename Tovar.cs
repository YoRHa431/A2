using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Tovar
    {
        public string naimenovanie;
        public uint kolichestvo;
        public double price;

        public Tovar()
        {
            this.naimenovanie = null;
            this.kolichestvo = 1;
            this.price = 0.0;
        }
        public Tovar(string naimenovanie, uint kolichestvo, double price)
        {
            this.naimenovanie = naimenovanie;
            this.kolichestvo = kolichestvo;
            this.price = price;
        }
        public void ElemAdd(List<Tovar> list, Tovar tovaros)
        {
            list.Add(tovaros);
        }
        public void ElemDelete(List<Tovar> list, Tovar tovaros)
        {
            list.Remove(tovaros);
        }
        public void Showlist(List<Tovar> list)
        {
            Console.WriteLine("Наименование  Количество  Стоимость");
            foreach (var item in list)
            {
                Console.WriteLine(item.naimenovanie + " " + "{0,4}шт " + "{1}руб", item.kolichestvo, item.price);
            }
        }
        public void ShowCurrent(List<Tovar> list, int current)
        {
            Console.WriteLine("  Наименование" + " " + "Количество  Стоимость");
            Console.WriteLine(list[current].naimenovanie + " " + list[current].kolichestvo + "шт" + list[current].price + "rub ");
        }
        public void ElemChange(List<Tovar> list, int current, Tovar tovaros)
        {
            list[current] = tovaros;
        }
        public void ListSort(List<Tovar> list)
        {
            int sortEnd = 0;
            while (sortEnd == 0)
            {
                sortEnd = 1;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].price > list[i + 1].price)
                    {
                        sortEnd = 0;
                        Tovar temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
        }
    }
}
