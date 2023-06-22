using System;
using Foundation;
using Security;

namespace XamNativeTest
{
    public class Keychain
    {
        public static void Purge()
        {
            foreach (var recordKind in new[]{
                SecKind.GenericPassword,
                SecKind.Certificate,
                SecKind.Identity,
                SecKind.InternetPassword,
                SecKind.Key,
            })
            {
                SecRecord query = new SecRecord(recordKind);
                SecKeyChain.Remove(query);
            }
        }
    }
}

