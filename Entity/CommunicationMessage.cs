using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Entity
{
    public class CommunicationMessage
    {
        public CommunicationMessage()
        {
            Attachments = new List<Attachment>();
            To = new List<MailAddress>();
            Cc = new List<MailAddress>();
            Bcc = new List<MailAddress>();
            TotalAttempts = 3;
        }
        public string Subject { get; set; }
        public string Content { get; set; }
        public MailAddress From { get; set; }
        public List<MailAddress> To { get; set; }
        public bool IsHtml { get; set; }
        public List<MailAddress> Cc { get; set; }
        public List<MailAddress> Bcc { get; set; }
        public List<Attachment> Attachments { get; set; }
        public int TotalAttempts { get; set; }
        public bool SendAsync { get; set; }
    }
}
