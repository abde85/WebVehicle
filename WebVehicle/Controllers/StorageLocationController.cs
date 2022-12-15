using Microsoft.AspNetCore.Mvc;
using WebVehicle.DataContext.Service;
using WebVehicle.Dtos;
using WebVehicle.Utilities;

namespace WebVehicle.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StorageLocationController : ControllerBase
    {
        private readonly IServiceVehicle _serviceVehicle;
        public StorageLocationController(IServiceVehicle serviceVehicle)
        {
            _serviceVehicle = serviceVehicle;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllStorageLocations()
        {
            var storageLocation = _serviceVehicle.GetAllStorageLocations()
                                  .Select(x => x.AsLocation());

            return Ok(storageLocation);
        }
    }
}
