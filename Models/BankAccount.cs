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
    [Index(nameof(BankId), nameof(AccountNumber), IsUnique = true)]
    public class BankAccount : BaseModel
    {
        [Required]
        [ForeignKey(nameof(Bank))]
        public int BankId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BankBranchName { get; set; }

        [Required]
        [MaxLength(50)]
        public string AccountNumber { get; set; }

        [Required]
        [ForeignKey(nameof(Ledger))]
        public int LedgerId { get; set; }


        [Required]
        [ForeignKey(nameof(Branch))]
        public int BranchId { get; set; }


        //Reference Entity
        public Bank Bank { get; set; }
        public ChartOfAccount Ledger { get; set; }
        public SyncBranch Branch { get; set; }


    }


}
