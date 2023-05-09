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
