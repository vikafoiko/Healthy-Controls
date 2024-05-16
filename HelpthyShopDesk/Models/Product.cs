using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpthyShopDesk.Models
{
    [PrimaryKey(nameof(Id))]
    public sealed class Product
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("cost")]
        public decimal Price { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("count")]
        public int Count { get; set; }
        [Column("photo")]
        public byte[]? Photo { get; set; }
        [Column("category_id")]
        public int Category_id { get; set; }
  
       
        [Column("company_id")]
        public int Company_id { get; set; }
    }
}
