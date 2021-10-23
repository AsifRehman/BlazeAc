using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazeAc.Data
{
    [Table("IN-ProdCateg")]
    public class ProductCateg
    {
        [Key]
        public byte ProdCategId { get; set; }
        public string ProdCateg { get; set; }
    }
}
