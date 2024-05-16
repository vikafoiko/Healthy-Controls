using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpthyShopDesk.Models
{
    [PrimaryKey(nameof(Id))]
    public sealed class Transaction
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("order_id")]
        public int OrderId { get; set; }
        [Column("product_id")]
        public int ProductId {  get; set; }
        [Column("count")]
        public int Count { get; set; }
    }
}
