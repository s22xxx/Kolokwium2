using KOl2_02.Entities;
using KOl2_02.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KOl2_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDbService _dbService;

        public ValuesController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> MyGET(int id)
        {
            var res = _dbService.DeleteMusician(id);

            return Ok(res.Result.Mess);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAlbum([FromRoute] int IdAlbum)
        {
            var result = await _dbService.getAlbum(IdAlbum);

            return Ok(result.actorDtosIList);
        }
    }
}
