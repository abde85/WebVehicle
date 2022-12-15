using WebVehicle.DataContext.Repository;

namespace WebVehicle.DataContext.Service
{
    public interface IServiceVehicle
    {
        void SaveBpkb(Bpkb data);
        Bpkb GetBpkbByAgreementNumber(string agreementNumber);
        List<StorageLocation> GetAllStorageLocations();
    }
}
