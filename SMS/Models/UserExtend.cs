using Microsoft.AspNetCore.Identity;

namespace SMS.Models
{
    public class UserExtend : IdentityUser
    {
        public int UID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Status { get; set; }
        public string Religion { get; set; }
        public string Address { get; set; }

        public string YearOfStart { get; set; }
        public string Authority { get; set; }
        public string Avatar { get; set; }
    }
}
