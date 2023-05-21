using Microsoft.EntityFrameworkCore;
using Service.Base.Models.Base;

using Service.Base.Attributes.ModelAttributes;
using Service.Account.Enums;
using Service.Base.Enums;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InventoryManagementSystem.Models;
using Service.Authorization.Models;

namespace Service.Account.Models
{

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


    }


}
