using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class FabriqueDeFormeAbstraite
    {
       public  abstract IForme getForme(string typeForme);
    }
}
