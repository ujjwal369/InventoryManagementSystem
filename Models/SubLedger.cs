using Microsoft.EntityFrameworkCore;
using Service.Base.Models.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Account.Models
{

    [Index(nameof(Name), IsUnique = true)]
    public class Subledger : BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string LocalizedName { get; set; }

        [Required]
        [ForeignKey(nameof(SubledgerType))]
        public int SubledgerTypeId { get; set; }

        public int? ReferenceId { get; set; }


        //Reference Entity
        public SubledgerType SubledgerType { get; set; }


    }


}
