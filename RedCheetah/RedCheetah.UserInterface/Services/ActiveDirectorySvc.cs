using RedCheetah.Core.Interface;
using System;

namespace RedCheetah.UserInterface.Services
{
    public class ActiveDirectorySvc : IActiveDirectory
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ActiveDirectorySvc));

        public bool IsAuthenticated(string srvr, string usr, string pwd)
        {
            var resp = false;
            try
            {              
                resp =  Infrastructure.ActiveDirectory.IsAuthenticated(srvr, usr, pwd);
                return resp;
            }
            catch(Exception ex)
            {
                _log.Error(ex.StackTrace);
            }
            _log.ErrorFormat("AD login for {0} is:: {1}", srvr, resp);
            return resp;
        }
    }
}