using Newtonsoft.Json;

namespace BinanceApp.Model.ENTITY
{
    public class ProfileModel
    {
        [JsonProperty("sub")]
        public string Sub { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("given_name")]
        public string GivenName { get; set; }
        [JsonProperty("family_name")]
        public string FamilyName { get; set; }
        [JsonProperty("picture")]
        public string Picture { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("email_verified")]
        public bool EmailVerify { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("hd")]
        public string HD { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
    }
}
