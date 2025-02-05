using System;
using System.Collections.Generic;

namespace Event.Models
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        //public IFormFile BirthAttachment { get; set; }
        //public IFormFile NationalAttachment { get; set; }
        //public IFormFile ReceiptPhoto { get; set; }
    }
}
