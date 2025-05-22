using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace KPZ_MKR1
{
    public interface IRenderState
    {
        void Render(LightElementNode element, StringBuilder sb);
    }
}
