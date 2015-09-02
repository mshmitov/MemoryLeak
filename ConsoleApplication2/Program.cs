using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new TestClass1();
            var class2 = new TestClass2();

            class1.TestEvent += class2.TestFireEvent;
            class1.OnTestEvent();
            //class1.TestEvent -= class2.TestFireEvent;

            GC.Collect();
            Console.ReadLine();
        }
    }
}
