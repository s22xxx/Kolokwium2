using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOl2_02.Entities
{
    public class Album
    {

        public int IdAlbum { get; set; }


        public string AlbumName { get; set; }


        public DateTime PublishDate { get; set; }

        public int IdMusicLabel { get; set; }

    }
}
