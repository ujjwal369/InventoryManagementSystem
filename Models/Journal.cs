using Microsoft.EntityFrameworkCore;
using Service.Authorization.Models;
using Service.Base.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Account.Models
{

    public class Journal : BaseModel
    {
        [Required]
        [ForeignKey(nameof(Branch))]
        public int BranchId { get; set; }

        [Required]
        public DateTime ValueDate { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [ForeignKey(nameof(Voucher))]
        public int? VoucherId { get; set; }


        //Reference Entity
        public Branch Branch { get; set; }
        public Voucher Voucher { get; set; }

        public ICollection<JournalDetail> JournalDetail { get; set; }

    }


    public class JournalDetail 
    {
        [Required]
        [ForeignKey(nameof(Journal))]
        public int JournalId { get; set; }

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
        public Journal Journal { get; set; }
        public Subledger Subledger { get; set; }

    }


}
