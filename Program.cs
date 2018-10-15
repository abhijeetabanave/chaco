using CHACO.AbstractChaco.Implementation;
using CHACO.AbstractContent;
using CHACO.AbstractResponse;
using CHACO.ConcreateProduct.Email;
using CHACO.ConcreateProduct.Email.ContentImplementation;
using CHACO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CHACO.Enum.EnumMasters;

namespace CHACO
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Test123";

            string two = "123Test12345";
            var fsd = two.Intersect(one);
            var fds  = Regex.Match(two, one,RegexOptions.).Value;
            #region email service 
            EmailContent emailcontent = new EmailContent();
            emailcontent.Contents = new Dictionary<string, object>() {
                { "name","abhijeet" },
                { "empid", 1234},

            };
            emailcontent.To = "abc@edelweissfin.com";
            emailcontent.From = "xyz@edelweissfin.com";
            IChannel emailchannel = new ChacoFactory().getChannelInstance(ServiceType.Email, "Email", emailcontent);
            
            IResponse emailchannelresponse = emailchannel.Send();

            Console.WriteLine("Email response : " + emailchannelresponse.StatusCode);

            #endregion

            Console.ReadLine();
        }
    }
}
