using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class TestClass1
    {
        public event EventHandler TestEvent;

        public virtual void OnTestEvent()
        {
            EventHandler handler = TestEvent;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
