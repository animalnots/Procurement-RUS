using System;

namespace POEApi.Infrastructure
{
    public class LogonFailedException : Exception
    {
        public LogonFailedException(string userName) 
            : base(string.Format(Lang.ErrorAuthStrValue + " {0}", userName))
        { }

        public LogonFailedException()
            : base(Lang.ErrorSessionidStrValue)
        { }
    }
}
