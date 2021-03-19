using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Schet
    {
        public double Summa { get; set; }
        public string Value { get; set; }

        public Schet()
        {
            Summa = 0;
            Value = null;
        }

        public Schet(double summa, string value)
        {
            Summa = summa;
            Value = value;
        }

        public void Input()
        {
            Console.Write("Введите сумму: ");
            Summa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите валюту: ");
            Value = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Сумма: {0}; Валюта: {1}.", Summa, Value);
        }

        public static Schet operator +(Schet schet1, Schet schet2)
        {
            return new Schet { Summa = schet1.Summa + schet2.Summa, Value = schet1.Value };
        }

        public static Schet operator -(Schet schet1, double x)
        {
            return new Schet { Summa = schet1.Summa - x, Value = schet1.Value };
        }

        public static Schet operator +(Schet schet1, double x)
        {
            return new Schet { Summa = schet1.Summa + x, Value = schet1.Value };
        }

        public static bool operator >(Schet schet1, Schet schet2)
        {
            if (schet1.Summa > schet2.Summa)
                return true;
            else
                return false;
        }

        public static bool operator <(Schet schet1, Schet schet2)
        {
            if (schet1.Summa < schet2.Summa)
                return true;
            else
                return false;
        }

        public static bool operator ==(Schet schet1, Schet schet2)
        {
            if (schet1.Summa == schet2.Summa)
                return true;
            else
                return false;
        }

        public static bool operator !=(Schet schet1, Schet schet2)
        {
            if (schet1.Summa != schet2.Summa)
                return true;
            else
                return false;
        }

        public static Schet operator ++(Schet schet1)
        {
            return new Schet { Value = schet1.Value, Summa = schet1.Summa + (schet1.Summa / 100 * 5) };
        }
    
    }
}
