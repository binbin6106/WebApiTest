namespace WebApplication1.Helper
{
    public class TokenParameter
    {
        public const string Issuer = "公子小六";//颁发者        
        public const string Audience = "公子小六";//接收者        
        public const string Secret = "12345678123456781234567812345678";//签名秘钥        
        public const int AccessExpiration = 30;//AccessToken过期时间（分钟）
    }
}
