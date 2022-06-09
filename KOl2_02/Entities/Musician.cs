using System.ComponentModel.DataAnnotations;

namespace KOl2_02.Entities
{
    public class Musician
    {
        [Key]
        public int IdMusician { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string NickName { get; set; }

        public virtual ICollection<Musician_Track> Musician_Tracks { get; set; }
    }
}
