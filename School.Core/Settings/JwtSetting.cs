namespace School.Core.Settings
{
    public class JwtSetting
    {
        public string Issuer { get; set; }  

        public List<string> Audiences { get; set; }

        public string SignInKey { get; set; }
    }
}
