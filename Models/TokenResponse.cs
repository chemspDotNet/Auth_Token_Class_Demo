using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Token_Based_Auth_OAuth2.Models
{
    public class TokenResponse
    {
        public TokenResponse() { }
        public int expires_in { get; set; }
        public string token_type { get; set; } = string.Empty;
        public string access_token { get; set;} = string.Empty;
    }
}