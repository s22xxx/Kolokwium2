using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOl2_02.Entities
{
    public class MusicLabel
    {
        [Key]
        public int IdMusicLabel { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
