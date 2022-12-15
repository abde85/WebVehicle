using Microsoft.EntityFrameworkCore;
using WebVehicle.DataContext.Repository;

namespace WebVehicle.DataContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Bpkb> Bpkbs { get; set; }
        public virtual DbSet<StorageLocation> StorageLocations { get; set; }
    }
}
