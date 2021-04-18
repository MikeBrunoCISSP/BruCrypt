using System;
using System.Security.Cryptography;

namespace DpapiCrypto
{
    public class DpapiContext
    {
        public string Name { get; private set; }
        public DataProtectionScope Scope { get; private set; }

        public override string ToString()
        {
            return Name;
        }

        public static readonly DpapiContext User = new DpapiContext()
        {
            Name = Constants.User,
            Scope = DataProtectionScope.CurrentUser
        };

        public static readonly DpapiContext System = new DpapiContext()
        {
            Name = Constants.System,
            Scope = DataProtectionScope.LocalMachine
        };
    }
}
