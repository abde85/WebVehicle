using WebVehicle.DataContext.Repository;

namespace WebVehicle.DataContext.DataDummy
{
    public class InsertDataDummy : IInsertDataDummy
    {
        private readonly ApplicationDBContext _dbContext;
        public InsertDataDummy(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void InsertData()
        {
            var locations = new List<StorageLocation>();
            for (var i = 1; i <= 3; i++)
            {
                AddLocation(locations, i);
            }

            if (locations.Any())
            {
                _dbContext.StorageLocations.AddRange(locations);
                _dbContext.SaveChanges();
            }
        }

        private void AddLocation(List<StorageLocation> locations, int id)
        {
            var location = new StorageLocation
            {
                LocationId = $"00{id}",
                LocationName = $"Location {id}"
            };

            var dataLcation1 = _dbContext.StorageLocations.FirstOrDefault(x => x.LocationId == location.LocationId);
            if (dataLcation1 == null)
            {
                locations.Add(location);
            }
        }
    }
}
