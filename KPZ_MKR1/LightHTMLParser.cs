using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LightHTMLParser
    {
        public static LightElementNode ParseLinesToHTML(string[] lines)
        {
            var root = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                LightElementNode element;

                if (i == 0)
                {
                    element = new LightElementNode("h1", DisplayType.Block, ClosingType.WithClosingTag);
                }
                else if (line.StartsWith(" "))
                {
                    element = new LightElementNode("blockquote", DisplayType.Block, ClosingType.WithClosingTag);
                }
                else if (line.Length < 20)
                {
                    element = new LightElementNode("h2", DisplayType.Block, ClosingType.WithClosingTag);
                }
                else
                {
                    element = new LightElementNode("p", DisplayType.Block, ClosingType.WithClosingTag);
                }

                element.AddChild(new LightTextNode(line.Trim()));
                root.AddChild(element);
            }

            return root;
        }
    }

}
