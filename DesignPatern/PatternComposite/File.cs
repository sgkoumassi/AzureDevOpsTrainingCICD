using System;
using System.Collections.Generic;
using System.Text;

namespace PatternComposite
{
    public class File : Component
    {
        public File(string name) : base(name) { }
       

        public override void view()
        {
            string tab = indentation();
            Console.WriteLine(tab + "File:" + name);
        }
    }
}
