using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace KPZ_MKR1
{
    public class LightTreeIterator : IEnumerable<LightNode>
    {
        private readonly LightNode _root;

        public LightTreeIterator(LightNode root)
        {
            _root = root;
        }

        public IEnumerator<LightNode> GetEnumerator()
        {
            var stack = new Stack<LightNode>();
            stack.Push(_root);

            while (stack.Any())
            {
                var node = stack.Pop();
                yield return node;

                if (node is LightElementNode el)
                {
                    foreach (var child in el.Children.Reverse<LightNode>())
                        stack.Push(child);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
