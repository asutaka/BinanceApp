﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceApp.Common
{
    public static class ConstantValue
    {
        //Signin Google
        public const string clientId = "761897430379-8nf5v577simq1v4hqiaedbt92vcuhee5.apps.googleusercontent.com";
        public const string clientSecret = "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";
        public const string scopes = "https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile";
        public const string redirectURI = "urn:ietf:wg:oauth:2.0:oob";
        //Security
        public static readonly string PasswordHash = "P@$Sw0rd";
        public static readonly string SaltKey = "Phunv@AI";
        public static readonly string VIKey = "Phunv@Huy456aA@1";
    }
}
