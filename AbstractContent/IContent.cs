using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHACO.AbstractContent
{
    public abstract class IContent
    {
        public abstract IDictionary<string,object> Contents {get; set;}
    }
}
