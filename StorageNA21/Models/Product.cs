using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StorageNA21.Models
{
    public class Product
    {
        
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(30)]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Price { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }


        public string Category { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]    
        public string Shelf { get; set; }
        public int Count { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Description { get; set; }

    }
}
