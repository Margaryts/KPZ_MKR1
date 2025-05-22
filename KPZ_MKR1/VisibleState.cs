using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace KPZ_MKR1
{
    public class VisibleState : IRenderState
    {
        public void Render(LightElementNode element, StringBuilder sb)
        {
            sb.Append($"<{element.TagName}>");
            foreach (var child in element.Children)
                child.Render(sb);
            sb.Append($"</{element.TagName}>");
        }
    }
}
