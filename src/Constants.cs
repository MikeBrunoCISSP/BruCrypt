using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpapiCrypto
{
    internal static class Constants
    {
        internal const string User = nameof(User);
        internal const string System = nameof(System);
    }

    internal static class CharacterSet
    {
        internal const string Alpha = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        internal const string Numeric = @"0123456789";
        internal const string Symbol = @"~!@#$%^&*()-_+=/?,<.>;:";
    }
}
