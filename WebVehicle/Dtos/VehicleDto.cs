using System.ComponentModel.DataAnnotations;

namespace WebVehicle.Dtos
{
    public record Vehicle(
         [MaxLength(100)]
         string Agreement_Number,
         [MaxLength(100)]
         string Bpkb_No,
         [MaxLength(10)]
         string Branch_Id,
         DateTime Bpkb_Date,
         [MaxLength(100)]
         string Faktur_No,
         DateTime Faktur_Date,
         [MaxLength(10)]
         string Location_Id,
         [MaxLength(20)]
         string Police_No,
         DateTime Bpkb_Date_In
     );
}
