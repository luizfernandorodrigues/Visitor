using System;

namespace Visitor
{
    public class ConcretVisitor1 : Visitor
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
