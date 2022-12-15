using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebVehicle.DataContext.Repository
{
    [Table("tr_bpkb")]
    public class Bpkb
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string Agreement_Number { get; set; }
        [Required]
        [MaxLength(100)]
        public string Bpkb_No { get; set; }
        [Required]
        [MaxLength(10)]
        public string Branch_Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Bpkb_Date { get; set; }
        [Required]
        [MaxLength(100)]
        public string Faktur_No { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Faktur_Date { get; set; }
        [Required]
        [MaxLength(10)]
        public string Location_Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Police_No { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Bpkb_Date_In { get; set; }
        [ForeignKey("Location_Id")]
        public StorageLocation StorageLocations { get; set; }
    }
}
