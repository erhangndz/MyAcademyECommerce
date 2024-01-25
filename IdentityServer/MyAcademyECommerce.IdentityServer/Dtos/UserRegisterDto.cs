namespace MyAcademyECommerce.IdentityServer.Dtos
{
    public class UserRegisterDto
    {
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
