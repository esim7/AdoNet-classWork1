
namespace Shop.Domain
{
    public class User : Entity
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }
        public string VerificationCode { get; set; }

        //покупки, коментарии, рейтинги и тд
    }
}
