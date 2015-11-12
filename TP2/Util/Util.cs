using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
   public static class Util
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsComplete(string txt)
        {
            if (txt.Equals(string.Empty) || string.IsNullOrWhiteSpace(txt)) return false;
            return true;
        }
       
    }
}
