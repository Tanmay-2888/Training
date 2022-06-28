using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class User
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }

        public string EmailId { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }

    }
}
