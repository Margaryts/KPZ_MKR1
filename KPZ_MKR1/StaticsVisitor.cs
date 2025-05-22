using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace KPZ_MKR1
{
    public class StatisticsVisitor : ILightNodeVisitor
    {
        public int ElementCount { get; private set; }
        public int TextNodeCount { get; private set; }

        public void Visit(LightElementNode element)
        {
            ElementCount++;
            foreach (var child in element.Children)
                child.Accept(this);
        }

        public void Visit(LightTextNode text)
        {
            TextNodeCount++;
        }
    }
}
