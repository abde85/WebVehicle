using System.ComponentModel.DataAnnotations;

namespace WebVehicle.Dtos
{
    public record Location(
         [MaxLength(10)]
         string LocationId,
         [MaxLength(100)]
         string LocationName
    );
}
