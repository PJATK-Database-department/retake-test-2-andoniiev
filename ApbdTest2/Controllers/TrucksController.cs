using ApbdTest2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApbdTest2.Controllers
{
    [Route("api/trucks")]
    [ApiController]
    public class TrucksController : ControllerBase
    {
        private readonly IDatabaseService _databaseService;
        public TrucksController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        [HttpGet("{IdTruck}")]
        public async Task<IActionResult> GetFireTruckInfo([FromRoute] int idFireTruck)
        {
            if(!await _databaseService.DoesFireTruckExistAsync(idFireTruck))
            {
                return NotFound($"Fire truck with id{idFireTruck} is not found");
            }
            return Ok(await _databaseService.GetFireTruckAsync(idFireTruck));
        }
    }
}
