using Microsoft.EntityFrameworkCore;
using Service.Account.Enums;
using Service.Authorization.Models;
using Service.Base.Attributes.ModelAttributes;
using Service.Base.Enums;
using Service.Base.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Account.Models
{
    [Index(nameof(RequestTimestamp), IsUnique = true)]
    public class Voucher : RootModel
    {
        [CustomAutoCodeAttribute]
        [MaxLength(50)]
        public string VoucherNumber { get; set; }

        [Required]
        [EnumDataType(typeof(VoucherTypeOption))]
        public VoucherTypeOption VoucherType { get; set; }
        [NotMapped]
        public int Priority { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public TimeOnly TransactionTime { get; set; }

        [Required]
        public DateTime ValueDate { get; set; }

        [Required]
        [ForeignKey(nameof(Branch))]
        public int BranchId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [ForeignKey(nameof(ReferencedVoucher))]
        public int? ReferencedVoucherId { get; set; }



        [Required]
        public int MenuId { get; set; }

        [Required]
        [ForeignKey(nameof(CreatedBranch))]
        public int CreatedBranchId { get; set; }

        [Required]
        public long RequestTimestamp { get; set; }


        //Reference Entity
        public Branch Branch { get; set; }
        public Branch CreatedBranch { get; set; }
        public Voucher ReferencedVoucher { get; set; }


        public ICollection<VoucherDetail> VoucherDetail { get; set; }

    }


    public class VoucherDetail 
    {
        [Required]
        [ForeignKey(nameof(Voucher))]
        public int VoucherId { get; set; }

        [Required]
        [ForeignKey(nameof(Ledger))]
        public int LedgerId { get; set; }

        [ForeignKey(nameof(Subledger))]
        public int? SubledgerId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }


        //Reference Entity
        public ChartOfAccount Ledger { get; set; }
        public Subledger Subledger { get; set; }
        public Voucher Voucher { get; set; }

    }


}
