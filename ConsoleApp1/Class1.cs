using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SingleTon
    {
        private SingleTon() { }
        public static SingleTon instance;
        public static SingleTon Instance
        {
            get {
                if (instance == null)
                    instance = new SingleTon();
                return instance;
            }
        }

    }
}
