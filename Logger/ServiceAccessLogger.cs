using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHACO.Logger
{    
    public class ServiceAccessLogger : ILogger
    {
        public readonly Guid ServiceAccessGuid;
        public  ServiceAccessLogger() {
            ServiceAccessGuid = new Guid();
        }
        public void Log()
        {
            Console.WriteLine("Service access is logged");
            //throw new NotImplementedException();
        }
    }
}
