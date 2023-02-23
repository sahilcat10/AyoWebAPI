using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AYOAPI.Model
{

    [Table("UnitConversionRates")]
    public class UnitConversionRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Metric Unit Name")]
        [StringLength(255)]
        [Required]
        public string MetricUnitName { get; set; }

        [Display(Name = "Imperial Unit Name")]
        [StringLength(255)]
        [Required]
        public string ImperialUnitName { get; set; }
        
        [Display(Name = "Metric To Imperial Rate")]
        [StringLength(255)]
        [Required]
        public string MetricToImperialRate { get; set; }
        
        [Display(Name = "Imperial To Metric Rate")]
        [StringLength(255)]
        [Required]
        public string ImperialToMetricRate { get; set; }

        [Display(Name = "Crated By")]
        [StringLength(255)]
        public string CratedBy { get; set; }
        
        [Display(Name = "Created At")]
        [DefaultValue(typeof(DateTime))]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Modified By")]
        [StringLength(255)]
        public string ModifiedBy { get; set; }
        
        [Display(Name = "Modified At")]
        [DefaultValue(typeof(DateTime))]
        public DateTime ModifiedAt { get; set; }

    }
}
