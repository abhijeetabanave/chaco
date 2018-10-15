using CHACO.AbstractResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHACO.ConcreateProduct.Email.ResponseImplementation
{
    public  class EmailResponseBuilder : IResponse
    {
        public EmailResponseBuilder(int statuscode) {
            StatusCode = statuscode;
        }
       
    }
}
