namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterQualityManager")]
    public partial class MasterQualityManager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int connectID { get; set; }

        public int masterID { get; set; }

        public int managerID { get; set; }

        public int requestID { get; set; }

        [Required]
        [StringLength(255)]
        public string appealReason { get; set; }

        [Column(TypeName = "date")]
        public DateTime appealDate { get; set; }

        public virtual Managers Managers { get; set; }

        public virtual Masters Masters { get; set; }

        public virtual Requests Requests { get; set; }
    }
}
