using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab12
{
    public class Validation
    {
        public string Login { get; set; }
        public string Password { get; set; }

       

        public bool CheckLogin(string login, SecureString password)
        {
            var pwd = default(string);
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(password);
                pwd = Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
            return (this.Login == login && this.Password == pwd);
        }
    }
}
