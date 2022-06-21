using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ApbdTest2.Services;
using System.Threading.Tasks;
using System;
using ApbdTest2.Dto;

namespace ApbdTest2.Controllers
{
    [Route("api/actions")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        private readonly IDatabaseService _databaseService;
        public ActionsController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        [HttpPost("{IdAction}")]
        public async Task<IActionResult>UpdateEndTime([FromRoute] int idAction, [FromRoute] DateTime newDate,[FromBody] ActionDto actionDto)
        {
            if(!await _databaseService.IsActionDateCorrectAsync(idAction, newDate))
            {
                return BadRequest("The new date cannot be greater than today's date");
            }
            if(!await _databaseService.DoesActionHaveEndDateAsync(idAction))
            {
                return BadRequest($"The action with id {idAction} does not have an end date");
            }
            return Ok(_databaseService.UpdateTheEndDateAsync(idAction, newDate, actionDto));
        }
    }
}
