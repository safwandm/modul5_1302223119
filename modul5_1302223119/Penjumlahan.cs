using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302223119
{
    internal class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T t1, T t2, T t3)
        {

            dynamic tempt1 = t1;
            dynamic tempt2 = t2;
            dynamic tempt3 = t3;

            Console.WriteLine(tempt1 + tempt2 + tempt3);
        }
    }
}
