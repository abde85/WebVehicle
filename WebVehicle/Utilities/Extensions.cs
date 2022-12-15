using WebVehicle.DataContext.Repository;
using WebVehicle.Dtos;

namespace WebVehicle.Utilities
{
    public static class Extensions
    {
        public static Bpkb AsBpkb(this Vehicle vehicle)
        {
            return new Bpkb
            {
                Agreement_Number = vehicle.Agreement_Number,
                Bpkb_No = vehicle.Bpkb_No,
                Branch_Id = vehicle.Branch_Id,
                Bpkb_Date = vehicle.Bpkb_Date,
                Faktur_No = vehicle.Faktur_No,
                Faktur_Date = vehicle.Faktur_Date,
                Location_Id = vehicle.Location_Id,
                Police_No = vehicle.Police_No,
                Bpkb_Date_In = vehicle.Bpkb_Date_In
            };
        }

        public static Vehicle AsVehicle(this Bpkb bpkb)
        {
            return new Vehicle(
                bpkb.Agreement_Number,
                bpkb.Bpkb_No,
                bpkb.Branch_Id,
                bpkb.Bpkb_Date,
                bpkb.Faktur_No,
                bpkb.Faktur_Date,
                bpkb.Location_Id,
                bpkb.Police_No,
                bpkb.Bpkb_Date_In
            );
        }

        public static Location AsLocation(this StorageLocation storageLocation)
        {
            return new Location(storageLocation.LocationId, storageLocation.LocationName);
        }
    }
}
