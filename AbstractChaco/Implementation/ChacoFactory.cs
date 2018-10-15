using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHACO.AbstractContent;
using CHACO.Enum;
using CHACO.Product;
using static CHACO.Enum.EnumMasters;
using CHACO.ConcreateProduct.Email;

namespace CHACO.AbstractChaco.Implementation
{
    public class ChacoFactory : AbstractChaco
    {
        public override IChannel getChannelInstance(ServiceType Servicetype, string Endpoint, IContent Content)
        {
            if (ServiceType.Email == Servicetype)
            {
                return EmailChannel.getEmailInstance(Endpoint, Content);
            }
            throw new NotImplementedException();
        }
    }
}
