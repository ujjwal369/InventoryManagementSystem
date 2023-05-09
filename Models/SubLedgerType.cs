using Microsoft.EntityFrameworkCore;
using Service.Base.Models.Base;
using Service.Base.Models.Sync;
using Service.Base.Attributes.ModelAttributes;
using Service.Account.Enums;
using Service.Base.Enums;
using Service.Base.Enums.Common;
using Service.Base.Enums.Common.DocumentType;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Account.Models
{
    /* CAUTION:     !! READ CAREFULLY !!
     * Please resolve any dependencies assembly
     * Please resolve enum reference
     * Please check any missing attributes, foreign key and unique constraints
    */
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
