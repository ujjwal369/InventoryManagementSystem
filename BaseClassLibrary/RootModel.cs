using System.ComponentModel.DataAnnotations;

namespace Service.Base.Models.Base
{
    public abstract class RootModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
