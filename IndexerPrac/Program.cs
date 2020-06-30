using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPrac
{
    class Products
    {
        public int this[int i]
        {
            get { return i; }
            set { Console.WriteLine(i); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Products p = new Products();
            Console.WriteLine(p[3]);
        }
    }
}
