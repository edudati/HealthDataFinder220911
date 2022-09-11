using System.ComponentModel.DataAnnotations.Schema;

namespace HealthDataFinder.Domain.Models
{
    [Table("address")]
    public class Address : BaseEntity
    {
        [Column("cep")]
        public string Cep { get; set; }

        [Column("logradouro")]
        public string Street { get; set; }

        [Column("complemento")]
        public string Complement { get; set; }

        [Column("bairro")]
        public string Neighborhood { get; set; }

        [Column("localidade")]
        public string City { get; set; }

        [Column("uf")]
        public string State { get; set; }

        public Address()
        {
        }

        public Address(string cep, string street, string complement, string neighborhood, string city, string state)
        {
            Cep = cep;
            Street = street;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }
    }
}
