using Kara.Framework.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Entity
{
    public class ActionResultCustomMessage
    {
        public ActionResultCustomMessage()
        {
            MessageType = ActionResultCustomMessageTypes.None;
        }
        public ActionResultCustomMessage(string message) : this()
        {
            Message = message;
        }
        public ActionResultCustomMessage(string message, ActionResultCustomMessageTypes messageType)
            : this(message)
        {
            MessageType = messageType;
        }
        public string Message { get; set; }
        public ActionResultCustomMessageTypes MessageType { get; set; }
    }
}
