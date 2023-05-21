using Microsoft.EntityFrameworkCore;
using Service.Base.Enums;
using Service.Base.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Authorization.Models
{
    [Index(nameof(Name), IsUnique = true)]
    [Index(nameof(Code), IsUnique = true)]
    public class Branch : BaseModel
    {
        [ForeignKey(nameof(Parent))]
        public int? ParentId { get; set; }

        [Required]
        [MaxLength(3)]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string LocalizedName { get; set; }

        [Required]
        public int LocalBodyId { get; set; }

        [Required]
        public BranchCategoryOption BranchCategory { get; set; }

        [Required]
        public DateTime EstablishedDate { get; set; }

        [Required]
        [MaxLength(512)]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(30)]
        public string ContactNumber { get; set; }

        //Reference Entity
        public Branch Parent { get; set; }


    }
}
