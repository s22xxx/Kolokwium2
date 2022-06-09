namespace KOl2_02.Entities
{
    public class Musician_Track
    {
        public int IdMusician { get; set; }
        public int IdTrack { get; set; }

        public virtual Musician MusicianNavigator { get; set; }
        public virtual Track MusicianNavigator { get; set; }
    }
}
