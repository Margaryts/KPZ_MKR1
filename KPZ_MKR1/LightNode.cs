using KPZ_MKR1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }

        public abstract void Render(StringBuilder sb);
        public abstract void Accept(ILightNodeVisitor visitor);

    }
}
