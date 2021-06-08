using System;

namespace PatternComposite
{
    class Program
    {
        static void Main(string[] args)
        {

            Folder root = new Folder("Root");

            Folder f1 = new Folder("Creation");
            Folder f2 = new Folder("Structure");
            Folder f3 = new Folder("Comportement");

            root.addComponent(f1);
            root.addComponent(f2);
            root.addComponent(f3);
          

            f1.addComponent(new File("Singleton"));
            f1.addComponent(new File("Factory"));

            f2.addComponent(new File("Adapter"));
            f2.addComponent(new File("Composite"));

            f3.addComponent(new File("Strategy"));
            f3.addComponent(new File("Observer"));

            Folder fts = (Folder)f1.addComponent(new Folder("Fts"));
            fts.addComponent(new File("Composite version 2"));

            root.view();

            Console.ReadKey();
        }
    }
}
