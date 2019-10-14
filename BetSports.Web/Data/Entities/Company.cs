using System.ComponentModel.DataAnnotations;

namespace BetSports.Web.Data.Entities
{
    public class Company : IEntity
    {
        [Required]
        public int IdType { get; set; }

        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(12)]
        public string PhoneOne { get; set; }

        [MaxLength(12)]
        public string PhoneTwo { get; set; }

        [MaxLength(50)]
        public string Rnc { get; set; }

        public bool Status { get; set; }
    }
}
