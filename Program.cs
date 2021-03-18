using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApplication menu = new MyApplication();
            menu.Menu(new Tovar(), new List<Tovar>());
        }
    }
}
