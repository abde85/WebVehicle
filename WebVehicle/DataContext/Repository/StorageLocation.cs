using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebVehicle.DataContext.Repository
{
    [Table("ms_storage_location")]
    public class StorageLocation
    {
        [Key]
        [MaxLength(10)]
        public string LocationId { get; set; }
        [Required]
        [MaxLength(100)]
        public string LocationName { get; set; }
        public ICollection<Bpkb> Bpkbs { get; set; }
    }
}
