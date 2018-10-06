using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class ParentClass
    {
        public int parentvara;
        public virtual void ParentMethod()
        {
            Console.WriteLine("This is my parent method");
        }
    }
}
