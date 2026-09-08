using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Type Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} has to be filled.")]
        [Range(5, 10, ErrorMessage = "{0} requires a value between 5 and 10.")]
        public string TypeName { get; set; }
        [Range(2, 5, ErrorMessage = "{0} requires a value between 2 and 5.")]
        public int Point { get; set; }
    }
}
