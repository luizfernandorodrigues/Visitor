using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name} Visitado por {GetType().Name}");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name} Visitado por {GetType().Name}");
        }
    }
}
