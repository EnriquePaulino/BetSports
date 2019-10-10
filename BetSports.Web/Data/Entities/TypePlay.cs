using System.ComponentModel.DataAnnotations;

namespace BetSports.Web.Data.Entities
{
    public class TypePlay
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        public bool Status { get; set; }
    }
}
