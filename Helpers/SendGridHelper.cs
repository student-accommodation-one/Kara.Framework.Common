using Exceptions;
using Kara.Framework.Common.Entity;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public class SendGridHelper
    {
        public class SendGridCredential : NetworkCredential
        {

        }
        public static ActionResultCustom<bool> SendEmail(SendGridCredential credential, CommunicationMessage message)
        {
            var result = new ActionResultCustom<bool>();
            SendGridMessage emailMessage = null;
            try
            {
                emailMessage = new SendGridMessage
                {
                    From = message.From,
                    To = message.To.ToArray(),
                    Cc = message.Cc.ToArray(),
                    Bcc = message.Bcc.ToArray(),
                    Subject = message.Subject,
                    Text = message.Content,
                    Html = message.Content
                };

                if (message.Attachments != null)
                    foreach (var item in message.Attachments)
                        emailMessage.AddAttachment(item.ContentStream, item.Name);

                var transportWeb = new SendGrid.Web(credential);
                if (!message.SendAsync)
                    transportWeb.Deliver(emailMessage);
                else
                    transportWeb.DeliverAsync(emailMessage);

                result.IsSuccess = true;
                return result;
            }
            catch (Exception ex)
            {
                result.Messages.Add(new ActionResultCustomMessage(ex.ToString()));
               
                if (ex is InvalidApiRequestException)
                {
                    var apiEx = ex as InvalidApiRequestException;
                    foreach (var item in apiEx.Errors)
                        result.Messages.Add(new ActionResultCustomMessage(item));
                }               
            }
            result.IsSuccess = false;
            return result;
        }
    }
}
