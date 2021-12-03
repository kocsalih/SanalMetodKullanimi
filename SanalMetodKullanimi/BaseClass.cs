using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetodKullanimi
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base Class");
        }
        public virtual void ekranaYaz(string data)
        {
            Console.WriteLine(data);
        }
    }
}
