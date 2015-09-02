using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class TestClass2
    {
        public TestClass2()
        {
            
        }


        public void TestFireEvent(object sender, EventArgs args)
        {
            Console.WriteLine("TestClass2 event class fired");
        }
    }
}
