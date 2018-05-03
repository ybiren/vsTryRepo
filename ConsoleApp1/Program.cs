using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = SingleTon.Instance;
            var y= SingleTon.Instance;

        }
    }
}
