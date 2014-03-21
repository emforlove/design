using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    class Composite : Component
    {
        private List<Component> child = new List<Component>();

        public Composite(string name)
            : base(name)
        { }

        public override void Add(Component c)
        {
            child.Add(c);
        }

        public override void Remove(Component c)
        {
            child.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component c in child)
            {
                c.Display(depth + 2);
            }
        }
    }
}
