using System.ComponentModel.DataAnnotations;

namespace KOl2_02.Entities
{
    public class Track
    {

        public int IdTrack { get; set; }

        public string TrackName { get; set; }


        public float Duration { get; set; }

        public int IdMusciAlbum { get; set; }
        public virtual ICollection<Musician_Track> Musician_Tracks { get; set; }
    }
}
