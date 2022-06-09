using KOl2_02.Entities;

namespace KOl2_02.Services
{
    public interface IDbService
    {
        Task<GET_DTO> DeleteMusician(int id);

        Task<GET_DTO> GetAlbum(int Id);

    }
}
