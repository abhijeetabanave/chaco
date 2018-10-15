using CHACO.AbstractContent;
using CHACO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CHACO.Enum.EnumMasters;

namespace CHACO.AbstractChaco
{
    public abstract class AbstractChaco
    {
        //public virtual IChannel getChannelInstance(IContent Content) {
        //    throw new NotImplementedException();
        //}
        
        public virtual IChannel getChannelInstance(ServiceType Servicetype,string Endpoint, IContent Content)
        {
            throw new NotImplementedException();
        }
    }
}
