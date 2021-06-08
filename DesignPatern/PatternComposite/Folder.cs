using System;
using System.Collections.Generic;
using System.Text;

namespace PatternComposite
{
    public class Folder : Component
    {
        private List<Component> components = new List<Component>();
        public Folder(string name) : base(name) { }
        public override void view()
        {
            string tab = indentation();
            Console.WriteLine(tab + "Folder:" + name);
            foreach (Component c in components)
            {
                c.view();
            }
        }

        public Component addComponent(Component component)
        {
            this.level = this.level + 1;
            this.parent = this;
            this.components.Add(component);
            return component;
        }
       
    }
}
