using CHACO.AbstractContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHACO.ConcreateProduct.Email.ContentImplementation
{
    public class EmailContent : IContent
    {
        public override IDictionary<string, object> Contents
        {
            get;
            set;
        }
        public string To { get; set; }
        public string From { get; set; }
    }
}
