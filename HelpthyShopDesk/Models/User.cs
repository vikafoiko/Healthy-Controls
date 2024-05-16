using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpthyShopDesk.Models
{
    [PrimaryKey(nameof(Id))]
    public sealed class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("login")]
        public string Login { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("secondname")]
        public string SecondName { get; set;}
        [Column("photo")]
        public byte[]? Photo { get; set; }
    }
}
