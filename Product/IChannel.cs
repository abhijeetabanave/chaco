using CHACO.AbstractContent;
using CHACO.AbstractResponse;
using CHACO.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHACO.Product
{
    public abstract class IChannel
    {
       
        public readonly Guid guid = new Guid();
        public bool IsAuthorized { get; set; }
        public IChannel() {
            new ServiceAccessLogger().Log();
            IsAuthorized = AuthorizeChannel();
        }

        public abstract IResponse Send();
        public abstract void SetContent(IContent Content);
        public abstract bool AuthorizeChannel();

        public virtual void ResponseLogger() {
            Console.WriteLine("response logged;");
        }
  
    }
}
