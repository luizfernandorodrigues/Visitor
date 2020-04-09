using System.Collections.Generic;

namespace Visitor
{
    public class ObjectStruture
    {
        private List<Element> _elementos = new List<Element>();

        public void Anexar(Element element)
        {
            _elementos.Add(element);
        }

        public void Desanexar(Element element)
        {
            _elementos.Remove(element);
        }

        public void Aceept(Visitor visitor)
        {
            foreach (var item in _elementos)
                item.Accept(visitor);
        }
    }
}
