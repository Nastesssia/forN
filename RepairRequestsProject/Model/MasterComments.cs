namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MasterComments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int сommentID { get; set; }

        [Required]
        [StringLength(255)]
        public string message { get; set; }

        public int masterID { get; set; }

        public int requestID { get; set; }

        public virtual Masters Masters { get; set; }

        public virtual Requests Requests { get; set; }
    }
}
