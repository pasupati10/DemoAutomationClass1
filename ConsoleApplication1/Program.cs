using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program:ParentClass
    {
        public int childvar;
        public void ChildMethods()
        {
            Console.WriteLine("This is my Child method");
        }

        public override void ParentMethod()
        {
            Console.WriteLine("This is my Child method");
        }
        static void Main(string[] args)
        {

            
            //p.ParentMethod();

            ParentClass p1 = new Program();
            p1.ParentMethod();
        }
    }
}
