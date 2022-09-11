using System.ComponentModel.DataAnnotations.Schema;

namespace HealthDataFinder.Domain.Models
{
    [Table("user")]
    public sealed class User : BaseEntity
    {
        [Column("email")]
        public string Email { get; private set; }

        [Column("user_name")]
        public string UserName { get; private set; }

        [Column("person_id")]
        public long PersonId { get; set; }
        public Person Person { get; set; }

        [Column("address_id")]
        public long AddressId { get; set; }
        public Address Address { get; set; }

        public User()
        {

        }

        public User(string userName, string email, long personId, long addressId)
        {
            UserName = userName;
            Email = email;
            PersonId = personId;
            AddressId = addressId;
        }
    }
}
