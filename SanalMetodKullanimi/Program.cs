using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetodKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun u1 = new Urun();
            u1.ekranaYaz("merhaba");
            BaseClass b1 = new BaseClass();
            b1.ekranaYaz("merhababaa");

            Console.ReadKey();

        }
    }
}
