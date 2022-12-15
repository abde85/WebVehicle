using Microsoft.AspNetCore.Mvc;
using WebVehicle.DataContext.Service;
using WebVehicle.Dtos;
using WebVehicle.Utilities;

namespace WebVehicle.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleController : Controller
    {
        private readonly IServiceVehicle _serviceVehicle;

        public VehicleController(IServiceVehicle serviceVehicle)
        {
            _serviceVehicle = serviceVehicle;
        }

        [HttpGet("{agreementNumber}")]
        public async Task<ActionResult<Vehicle>> GetByAgreementNumberAsync(string agreementNumber)
        {
            var bpkb = _serviceVehicle.GetBpkbByAgreementNumber(agreementNumber);
            var vehicle = bpkb.AsVehicle();

            return vehicle;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Vehicle request)
        {
            var bpkb = request.AsBpkb();
            _serviceVehicle.SaveBpkb(bpkb);

            return NoContent();
        }
    }
}
