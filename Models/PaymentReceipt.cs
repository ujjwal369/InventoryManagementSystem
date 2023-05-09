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

    public class PaymentReceipt : BaseModel
    {
        [Required]
        [ForeignKey(nameof(Branch))]
        public int BranchId { get; set; }

        [Required]
        [DataTypeDate]
        public DateTime ValueDate { get; set; }

        [Required]
        public PaymentReceiptTypeOption PaymentReceiptType { get; set; }

        [Required]
        public PaymentTypeOption PaymentType { get; set; }

        [ForeignKey(nameof(BankAccount))]
        public int? BankAccountId { get; set; }

        [MaxLength(50)]
        public string ChequeNumber { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [ForeignKey(nameof(Voucher))]
        public int? VoucherId { get; set; }


        //Reference Entity
        public BankAccount BankAccount { get; set; }
        public SyncBranch Branch { get; set; }
        public Voucher Voucher { get; set; }

        [ChildEntity]
        public ICollection<PaymentReceiptDetail> PaymentReceiptDetail { get; set; }

    }


    public class PaymentReceiptDetail : BaseChildModel
    {
        [Required]
        [ForeignKey(nameof(PaymentReceipt))]
        public int PaymentReceiptId { get; set; }
        public PaymentReceipt PaymentReceipt { get; set; }

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

    }


}
