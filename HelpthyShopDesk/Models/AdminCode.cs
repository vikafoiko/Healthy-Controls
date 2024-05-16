using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpthyShopDesk.Models
{
    [PrimaryKey(nameof(Id))]
    public sealed class AdminCode
    {
       [Column("account_id")]
       public int Id { get; set; }
        [Column("code")]
        public int Code { get; set; }
    }
}
