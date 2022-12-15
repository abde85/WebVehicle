using WebVehicle.DataContext.Repository;

namespace WebVehicle.DataContext.Service
{
    public class ServiceVehicle : IServiceVehicle
    {
        private readonly ApplicationDBContext _dbContext;

        public ServiceVehicle(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

        public void SaveBpkb(Bpkb data)
        {
            var bpkb = _dbContext.Bpkbs.FirstOrDefault(x => x.Agreement_Number == data.Agreement_Number);
            if (bpkb == null)
            {
                _dbContext.Bpkbs.Add(data);
            }
            else
            {
                bpkb.Bpkb_No = data.Bpkb_No;
                bpkb.Branch_Id = data.Branch_Id;
                bpkb.Bpkb_Date = data.Bpkb_Date;
                bpkb.Faktur_No = data.Faktur_No;
                bpkb.Faktur_Date = data.Faktur_Date;
                bpkb.Location_Id = data.Location_Id;
                bpkb.Police_No = data.Police_No;
                bpkb.Bpkb_Date_In = data.Bpkb_Date_In;
            }
            _dbContext.SaveChanges();
        }

        public Bpkb GetBpkbByAgreementNumber(string agreementNumber)
        {
            return _dbContext.Bpkbs.FirstOrDefault(x => x.Agreement_Number == agreementNumber);
        }

        public List<StorageLocation> GetAllStorageLocations()
        {
            return _dbContext.StorageLocations.ToList();
        }
    }
}
