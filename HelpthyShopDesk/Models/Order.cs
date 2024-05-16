using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpthyShopDesk.Models
{
    [PrimaryKey(nameof(Id))]
    public sealed class Order
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("worker_id")]
        public int WorkerId { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        
    }
}
