using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseOverride
{
    class xBase
    {
        public virtual void Execute()
        {
            Console.WriteLine("base executing...");
        }
    }

    class xDerived : xBase
    {
        public override void Execute()
        {
            Console.WriteLine("before executing");
            base.Execute();
            Console.WriteLine("after executing");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            xDerived test = new xDerived();
            test.Execute();
            Console.ReadKey();
        }
    }
}
