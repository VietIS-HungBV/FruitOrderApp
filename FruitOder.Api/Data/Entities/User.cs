using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using FruitOder.Api.Constants;
using Microsoft.EntityFrameworkCore;

namespace FruitOder.Api.Data.Entities
{
    [Table(nameof(User))]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength (25)]
        [Comment("Demo PW")]
        public string Password { get; set; }

        [Required, MaxLength(20)]
        public string Mobile { get; set; }
        public short RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Address> Address { get; set; }

        public static IEnumerable<User> GetInitialUsers() =>
            new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "HungBV",
                    Email = "abc@abc.com",
                    Mobile = "123456789",
                    Password = "123456",
                    RoleId = DatabaseConstants.Roles.Admin.Id,
                }
            };
    }
}
