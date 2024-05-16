using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HelpthyShopDesk.Models
{
    [PrimaryKey(nameof(Id))]
    public sealed class Company
    {
        [Column("id")]
        public int Id { get; set; }
        [Column ("name")]
        public string Name { get; set; }

    }
}
