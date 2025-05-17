using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public enum DisplayType { Block, Inline }
    public enum ClosingType { SelfClosing, WithClosingTag }

    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }
        public List<string> CssClasses { get; } = new List<string>();
        public List<LightNode> Children { get; } = new List<LightNode>();

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string InnerHTML =>
            string.Join("", Children.Select(child => child.OuterHTML));

        public override string OuterHTML
        {
            get
            {
                string classAttr = CssClasses.Any() ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                if (Closing == ClosingType.SelfClosing)
                {
                    return $"<{TagName}{classAttr}/>";
                }
                else
                {
                    return $"<{TagName}{classAttr}>{InnerHTML}</{TagName}>";
                }
            }
        }
    }

}
