using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Security;

namespace Kara.Framework.Common.Helpers
{
    public class MachineKeyHelper
    {
        const string MachineKeyPurpose = "KaraApp:Username:{0}";
        const string Anonymous = "<anonymous>";

        private string GetMachineKeyPurpose(IPrincipal user)
        {
            return String.Format(MachineKeyPurpose,
                user.Identity.IsAuthenticated ? user.Identity.Name : Anonymous);
        }

        public string Protect(string text)
        {
            if (String.IsNullOrWhiteSpace(text)) return null;
            var data = Encoding.UTF8.GetBytes(text);           
            var purpose = GetMachineKeyPurpose(Thread.CurrentPrincipal);
            var value = MachineKey.Protect(data, purpose);
            return Convert.ToBase64String(value);
        }

        public string Unprotect(string value)
        {
            if (String.IsNullOrWhiteSpace(value)) return null;
            var purpose = GetMachineKeyPurpose(Thread.CurrentPrincipal);
            var bytes = Convert.FromBase64String(value);
            var unprotectedBytes = MachineKey.Unprotect(bytes, purpose);
            return Encoding.UTF8.GetString(unprotectedBytes);
        }
    }
}
