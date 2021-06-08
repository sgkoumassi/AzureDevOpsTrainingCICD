using System;
using System.Collections.Generic;
using System.Linq;

namespace porteVar
{
    class Answer
    {
        public IEnumerable<string> Filter(List<string> strings)
        {
            return
          from str in strings
          where str.StartsWith("L")
          orderby str
          select str;
        }
    }
}
