using Kara.Framework.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common
{
    public class ActionResultCustom<T> : IActionResultCustom
    {
        public List<T> Results = new List<T>();
        private bool _isSuccess = false;
        private List<ActionResultCustomMessage> _messages = new List<ActionResultCustomMessage>();
        private int _totalRows;
        public bool IsSuccess
        {
            get
            {
                return _isSuccess;
            }
            set
            {
                _isSuccess = value;
            }
        }

        public List<ActionResultCustomMessage> Messages
        {
            get
            {
                return _messages;
            }
            set
            {
                _messages = value;
            }
        }

        public int TotalRows
        {
            get
            {
                return _totalRows;
            }
            set
            {
                _totalRows = value;
            }
        }
    }
}
