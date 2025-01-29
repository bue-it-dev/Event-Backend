namespace Event.DTOs
{
    public class AuthenticateResponsDTO
    {
        public long ExpiresIn { get; set; }
        public string AccessToken { get; set; }
    }
}
