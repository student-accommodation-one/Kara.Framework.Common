using Kara.Framework.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public class EmailHelper
    {
        public static ActionResultCustom<bool> SendEmail(CommunicationMessage message)
        {
            var result = new ActionResultCustom<bool>();

            MailMessage emailMessage = new MailMessage
            {
                Subject = message.Subject,
                From = message.From,
                Body = message.Content,
                IsBodyHtml = message.IsHtml
            };
            message.To.ForEach(t => emailMessage.To.Add(t));
            message.Cc.ForEach(t => emailMessage.CC.Add(t));
            message.Bcc.ForEach(t => emailMessage.Bcc.Add(t));
            message.Attachments.ForEach(t => emailMessage.Attachments.Add(t));

            SmtpClient c = new SmtpClient();
            SmtpStatusCode status = default(SmtpStatusCode);
            if (!message.SendAsync)
            {
                bool tryAgain = true;
                int tryCount = 1;
                while (tryAgain && tryCount <= message.TotalAttempts)
                {
                    try
                    {
                        c.Send(emailMessage);
                        tryAgain = false;
                        result.IsSuccess = true;
                        return result;
                    }
                    catch (SmtpException sm)
                    {
                        status = sm.StatusCode;
                        result.Messages.Add(new ActionResultCustomMessage(status.ToString()));
                        if (status != SmtpStatusCode.Ok)
                        {
                            tryAgain = true;
                        }
                        else
                        {
                            tryAgain = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        //TODO: Logging
                    }
                    System.Threading.Thread.Sleep(1000);
                    tryCount += 1;
                }
                if (c != null) c.Dispose();
            }
            else //fire and forget
            {
                try
                {
                    c.SendCompleted += (s, e) =>
                    {
                        c.Dispose();
                    };
                    c.SendAsync(emailMessage, null);
                    result.IsSuccess = true;
                    return result;
                }
                catch (SmtpException sm)
                {
                    status = sm.StatusCode;
                    result.Messages.Add(new ActionResultCustomMessage(status.ToString()));                   
                }
                catch (Exception ex)
                {
                    //TODO: Logging
                }
            }

            result.IsSuccess = false;
            return result;
        }

    }
}
