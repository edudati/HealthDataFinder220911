using HealthDataFinder.Domain.Extensions.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthDataFinder.Domain.Models
{
    [Table("person")]
    public class Person : BaseEntity
    {
        [Column("first_name")]
        public string FirstName { get; private set; }

        [Column("last_name")]
        public string LastName { get; private set; }

        [Column("cpf")]
        public string Cpf { get; private set; }

        [Column("mother_name")]
        public string MotherName { get; private set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; private set; }

        [Column("gender")]
        public Gender Gender { get; private set; }

        [Column("email")]
        public string Email { get; private set; }

        [Column("phone")]
        public string Phone { get; private set; }

        public Person()
        {

        }

        public Person(string firstName, string lastNameName, string cpf, string motherName, DateTime birthDate, Gender gender, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastNameName;
            Cpf = Extensions.Mask.UnmaskOnlyNumbers(cpf);
            MotherName = motherName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            Phone = phone;
        }
    }
}
