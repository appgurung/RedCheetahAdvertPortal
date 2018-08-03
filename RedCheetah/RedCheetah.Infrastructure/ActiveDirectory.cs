using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using RedCheetah.Core.Interface;

namespace RedCheetah.Infrastructure
{
    public static class ActiveDirectory 
    {
        public static bool IsAuthenticated(string srvr, string usr, string pwd)
        {
            bool authenticated = false;

            try
            {
                DirectoryEntry entry = new DirectoryEntry(srvr, usr, pwd, AuthenticationTypes.Secure);
                object nativeObject = entry.NativeObject;

                DirectorySearcher ds = new DirectorySearcher(entry);
                ds.FindOne();

                authenticated = true;
            }
            catch (DirectoryServicesCOMException ex)
            {

            }

            return authenticated;
        }
    }
}





