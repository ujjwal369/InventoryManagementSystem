using Microsoft.EntityFrameworkCore;
using Service.Account.Enums;
using Service.Base.Attributes.ModelAttributes;
using Service.Base.Enums;
using Service.Base.Models.Base;
using Service.Base.Models.Sync;
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
        public VoucherTypeOption VoucherType { get; set; }
        [NotMapped]
        public int Priority { get; set; }

        [Required]
        [DataTypeDate]
        public DateTime TransactionDate { get; set; }

        [Required]
        public TimeOnly TransactionTime { get; set; }

        [Required]
        [DataTypeDate]
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
        public ServiceModuleOption ServiceModule { get; set; }

        [Required]
        public int MenuId { get; set; }

        [Required]
        [ForeignKey(nameof(CreatedBranch))]
        public int CreatedBranchId { get; set; }

        [Required]
        public long RequestTimestamp { get; set; }


        //Reference Entity
        public SyncBranch Branch { get; set; }
        public SyncBranch CreatedBranch { get; set; }
        public Voucher ReferencedVoucher { get; set; }

        [ChildEntity]
        public ICollection<VoucherDetail> VoucherDetail { get; set; }

    }


    public class VoucherDetail : BaseChildModel
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
