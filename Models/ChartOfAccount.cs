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
    [Index(nameof(Name), IsUnique = true)]
    [Index(nameof(Code), IsUnique = true)]
    public class ChartOfAccount : BaseModel
    {
        [ForeignKey(nameof(Parent))]
        public int? ParentId { get; set; }

        [Required]
        public bool IsGroup { get; set; }

        [Required]
        [CustomAutoCodeAttribute]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string LocalizedName { get; set; }

        [Required]
        public LedgerTypeOption LedgerType { get; set; }

        [Required]
        public LedgerCategoryOption LedgerCategory { get; set; }

        [ForeignKey(nameof(SubledgerType))]
        public int? SubledgerTypeId { get; set; }
        public SubledgerType SubledgerType { get; set; }
        [Required]
        public int PlaceOrder { get; set; }
        [NotMapped]
        public DepositLedgerOption? DepositLedgerId { get; set; }
        [NotMapped]
        public LoanLedgerOption? LoanLedgerId { get; set; }


        //Reference Entity
        public ChartOfAccount Parent { get; set; }


    }


}
