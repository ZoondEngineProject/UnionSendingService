using System;
using System.Net;


namespace UnionSendingService.Library.ZELab.Antivirus
{
    class Manager
    {
        private IPAddress NullableAddr;

        public bool IsValidIP(string expAddr)
        {
            if(IPAddress.TryParse(expAddr, out this.NullableAddr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
