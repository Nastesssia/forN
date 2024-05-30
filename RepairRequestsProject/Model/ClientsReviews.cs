namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientsReviews
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reviewID { get; set; }

        public int requestID { get; set; }

        public int rating { get; set; }

        [Required]
        [StringLength(255)]
        public string comment { get; set; }

        [Column(TypeName = "date")]
        public DateTime reviewDate { get; set; }

        [Required]
        [StringLength(255)]
        public string qrCode { get; set; }

        public virtual Requests Requests { get; set; }
    }
}
