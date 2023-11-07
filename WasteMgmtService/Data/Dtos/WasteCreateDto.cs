using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WasteMgmtService.Data.Dtos
{
    public class WasteCreateDto
    {
        [Required]
        public string WasteMaterial { get; set; }

        [Required]
        public int WasteWeight { get; set; }
    }
}
