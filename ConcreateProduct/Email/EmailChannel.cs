using CHACO.AbstractContent;
using CHACO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHACO.ConcreateProduct.Email
{
    public class EmailChannel 
    {
        public static IChannel getEmailInstance(string Endpoint, IContent Content)
        {
            return new Email(Content);
        }
    }
}
