using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace ZombieParty.Models
{
    public class Zombie
    {
        [Key]
        public int Id { get; set; }
        [Range(5, 20, ErrorMessage = "{0} requires a value between 5 and 20.")]
        public string Name { get; set; }
        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "Zombie Type")]
        [ForeignKey("ZombieType")]

        public int ZombieTypeId { get; set; }
        public ZombieType ZombieType { get; set; }
        [Range(2, 5, ErrorMessage = "{0} requires a value between 2 and 5.")]
        public int Point { get; set; }
        [Range(0, 255, ErrorMessage = "{0} requires a value moins que 255")]
        public string ShortDesc { get; set; }
    }
}
