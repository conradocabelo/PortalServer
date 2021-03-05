using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model.Constants
{
    public static class Protocols
    {
        public const string OpenIdConnect = "oidc";
    }

    public static class TokenDefault
    {
        public const int AcessTokenLifetime = 3600;
        public const int AuthorizationCodeLifetime = 3600;
        public const int TokenLifetime = 300;
    }
}
