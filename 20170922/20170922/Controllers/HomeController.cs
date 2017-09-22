
using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace _20170922.Controllers
{
    /// <summary>
    /// HomeController um die Übung zu machen
    /// </summary>
    public class HomeController
    {
        //Secret Key als Byte Array erstellen
        static byte[] secretKey = Encoding.ASCII.GetBytes("SecretKeyTest");

        //TOTP erstellen
        static Totp topt = new Totp(secretKey, mode: OtpHashMode.Sha512);

        //Calculate the Code
        string totpCode = topt.ComputeTotp(DateTime.UtcNow);


        public bool VerifyTotp(string totp, out long timeWindowUsed, VerificationWindow window = null);
    }
}