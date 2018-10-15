using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHACO.AbstractResponse
{   
    public abstract class IResponse
    {
       
        public IResponse() {
           
         //   throw new NotImplementedException();
        }
        public IResponse(int statuscode) {
            this.StatusCode = statuscode;
        }

        public virtual int StatusCode { get; set; }
        public virtual string ErrorDesciption { get; set; }
        public virtual IDictionary<string, object> Contents { get; set; }
    }
}
