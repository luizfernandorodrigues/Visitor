using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStruture o = new ObjectStruture();
            o.Anexar(new ConcreteElementA());
            o.Anexar(new ConcreteElementB());

            ConcretVisitor1 v1 = new ConcretVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            o.Aceept(v1);
            o.Aceept(v2);

            Console.ReadKey();
        }
    }
}
