namespace Planty.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Planty.Business;

    [Route("api/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private readonly IPlantService _plantService;

        public PlantsController(IPlantService plantService)
        {
            _plantService = plantService;
        }
    }
}
