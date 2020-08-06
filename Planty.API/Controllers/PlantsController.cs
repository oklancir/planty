namespace Planty.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Planty.Business;
    using Planty.Business.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private readonly IPlantService _plantService;

        public PlantsController(IPlantService plantService)
        {
            _plantService = plantService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Plant>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _plantService.GetAllAsync());
        }

        [HttpGet]
        [ProducesResponseType(typeof(Plant), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            return Ok(await _plantService.GetByIdAsync(id));
        }

        [HttpPost]
        [ProducesResponseType(typeof(PlantBase), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAsync(PlantBase model)
        {
            return Ok(await _plantService.CreateAsync(model));
        }

        [HttpPut]
        [ProducesResponseType(typeof(Plant), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateAsync(Guid id, PlantBase model)
        {
            return Ok(await _plantService.UpdateAsync(id, model));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _plantService.DeleteAsync(id);
            return Ok();
        }
    }
}
