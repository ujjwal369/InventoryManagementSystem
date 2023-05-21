using Microsoft.EntityFrameworkCore;
using Service.Base.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Base.Models.Sync
{
    [Index(nameof(Username), IsUnique = true)]
    public class User 
    {
        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string LocalizedName { get; set; }
    }
}
