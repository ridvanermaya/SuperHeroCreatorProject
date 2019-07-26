using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroCreator.Models
{
    [Table("SuperHero")]
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimarySuperHeroAbility { get; set; }
        public string SecondarySuperHeroAbility { get; set; }
        public string CatchPhrase { get; set; }
    }
}