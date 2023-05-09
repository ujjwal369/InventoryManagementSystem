
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Service.Base.Models.Base
{
    public abstract class BaseModel : RootModel
    {
        [Required]
        public RecordStatusOption Status { get; set; }

        [Required]
        [ForeignKey(nameof(EntryUser))]
        public int EntryUserId { get; set; }

        [Required]
        public DateTime EntryDate { get; set; }

        [Required]
        [ForeignKey(nameof(ChangeUser))]
        public int ChangeUserId { get; set; }

        [Required]
        public DateTime ChangeDate { get; set; }

        [Required]
        [Timestamp]
        public byte[] RowVersion { get; set; }


        ////Internal field only, used for to block concurrent duplicate request
        //[Required]
        //[ReadOnly(true)]
        //[NotMapped]
        //public long RequestTimestamp { get; set; }


        //Reference Entity
        public SyncUser EntryUser { get; set; }
        public SyncUser ChangeUser { get; set; }
    }
}
