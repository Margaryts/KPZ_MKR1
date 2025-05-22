using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace KPZ_MKR1
{
    public interface ILightNodeVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode text);
    }
}
