﻿namespace Planty.API.Controllers
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
    public class ProductsController : ControllerBase
    {
        private readonly IPlantService _plantService;

        public ProductsController(IPlantService plantService)
        {
            _plantService = plantService;
        }

        [Route("")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Plant>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _plantService.GetAllAsync());
        }

        [Route("{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(Plant), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            return Ok(await _plantService.GetByIdAsync(id));
        }

        [Route("")]
        [HttpPost]
        [ProducesResponseType(typeof(PlantBase), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAsync(PlantBase model)
        {
            return Ok(await _plantService.CreateAsync(model));
        }

        [Route("{id}")]
        [HttpPut]
        [ProducesResponseType(typeof(Plant), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateAsync(Guid id, PlantBase model)
        {
            return Ok(await _plantService.UpdateAsync(id, model));
        }

        [Route("{id}")]
        [HttpDelete]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _plantService.DeleteAsync(id);
            return Ok();
        }
    }
}