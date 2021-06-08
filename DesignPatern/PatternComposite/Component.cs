using System;
using System.Collections.Generic;
using System.Text;

namespace PatternComposite
{
    public abstract class Component
    {
        protected string name;
        protected int level;

        protected Folder parent;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void view();

        public string indentation()
        {
            string str = "";
            for(int i=0;i< level; i++)
            {
                str += "\t";
            }
            return str;
        }
    }
}
