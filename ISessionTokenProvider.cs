using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common
{
    public interface ISessionTokenProvider
    {
        string GenerateToken(int userId, int minuteTimeout);
        bool ValidateToken(string token);
        bool ExpireToken();
    }
}
