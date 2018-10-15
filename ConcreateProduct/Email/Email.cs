using CHACO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHACO.AbstractContent;
using CHACO.AbstractResponse;
using CHACO.ConcreateProduct.Email.ResponseImplementation;
using CHACO.ConcreateProduct.Email.ContentImplementation;

namespace CHACO.ConcreateProduct.Email
{
    public sealed class Email : IChannel
    {
        private EmailContent emailContent { get; set; }

        private Email() { }

        public Email(IContent Content) {
            Console.WriteLine("Email Contructor is initialized");
            emailContent = (EmailContent)Content;
            SetContent(emailContent);
        }

       
        public override bool AuthorizeChannel()
        {
            Console.WriteLine("I'm Authorizing Email User");
            return true;
        }

        public override IResponse Send()
        {
           
            if (IsAuthorized && emailContent != null) {
                Console.WriteLine("Send method executed and email send");
                return new EmailResponseBuilder(200);
            }            
            return new EmailResponseBuilder(401);
        }

        public override void SetContent(IContent Content)
        {
            emailContent = (EmailContent)Content;           
            if (IsAuthorized)
            {
                Console.WriteLine("Content is assigning");
                foreach (KeyValuePair<string, object> emailcontent in Content.Contents)
                {
                    Console.WriteLine(emailcontent.Key + " :  " + emailcontent.Value);
                }
            }
            else { throw new UnauthorizedAccessException(); }
         
        }

       
    }
}
