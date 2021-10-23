using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazeAc.Data
{
    [Table("IN-ProdType")]
    public class ProductType
    {
        [Key]
        public int ProdTypeId{ get; set; }
        public string ProdType { get; set; }
        public byte ProdCategId { get; set; }
    }
}
