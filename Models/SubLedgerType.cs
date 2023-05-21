using Microsoft.EntityFrameworkCore;
using Service.Account.Enums;
using Service.Base.Models.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Account.Models
{

    [Index(nameof(Name), IsUnique = true)]
    public class SubledgerType : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public LedgerCategoryOption LedgerCategory { get; set; }


        //Reference Entity


    }


}
