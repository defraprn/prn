using System.ComponentModel.DataAnnotations;
namespace WasteMgmtService.Models
{
    public class Waste
    {
        [Key]
        [Required]
        public int Id { get; set; }
 
       [Required]
       public string WasteMaterial { get; set; }
        
        [Required]
        public int WasteWeight { get; set; }
    }
}
