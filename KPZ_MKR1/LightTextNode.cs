﻿using KPZ_MKR1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LightTextNode : LightNode
    {
        public string Text { get; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string OuterHTML => Text;
        public override string InnerHTML => Text;

        public override void Render(StringBuilder sb)
        {
            sb.Append(Text);
        }
        public override void Accept(ILightNodeVisitor visitor) => visitor.Visit(this);

    }

}
