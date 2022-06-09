using KOl2_02.Context;
using KOl2_02.Entities;
using Microsoft.EntityFrameworkCore;

namespace KOl2_02.Services
{
    public class DbService : IDbService
    {
        private readonly MyContext _context;

        public DbService(MyContext context)
        {
            _context = context;
        }
        public async Task<GET_DTO> DeleteMusician(int id)
        {

            var jest =await  _context.Tracks.AnyAsync(e => e.IdMusician == id);
         
            if (!jest)
                return new GET_DTO(404, "brak");

            var idMusician = await _context.Musician_Tracks.Where(e => e.IdTrack == id).Select(e => e.IdMusician).ToListAsync();

            Musician musician = new Musician() { IdMusician = id };

            foreach (var item in idMusician)
            {
                Musician_Track musicianTrack = new Musician_Track() { IdMusician = id, IdTrack = item };

                _context.Tracks.Attach(musician);
                _context.Musician_Tracks.Attach(musicianTrack);
                _context.Musician_Tracks.Remove(musicianTrack);
            }

      

            _context.Tracks.Remove(musician);
            await _context.SaveChangesAsync(); 


            return  new GET_DTO(200, "Ok");

        }

        public async Task<GET_DTO> GetAlbum(int Id)
        {
            {
                var istnieje = await _context.Album.AnyAsync(e => e.IdAlbum == Id);
                if (!istnieje)
                {
                    return new GET_DTO(404, "nie isnieje");
                }

                var IdList = await _context.Album.Where(e => e.Album == Id).Select(e => e.IdAlbum).ToListAsync(); 

                var listId = await _context.Track.Where(e => e.IdAlbum == Id);

                Album album = new Album();

                foreach (var actorIds in IdList)
                {
                    List<Actor> newList = await _context.Actors.Where(m => m.IdActor == actorIds)
                      .Select(m => new Actor
                      {
                          IdActor = m.IdActor,
                          Name = m.Name,
                          Surname = m.Surname
                ,
                          Nickname = m.Nickname

                      }).ToListAsync();
                    actorList.Add(newList[0]);
                }

                //za malo czasu






                return new OutPutActorDto(finalList, 200, "Ok");
            }
        }
    }
}
