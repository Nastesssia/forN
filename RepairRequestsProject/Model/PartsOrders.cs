namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PartsOrders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderID { get; set; }

        public int requestID { get; set; }

        public int partID { get; set; }

        public int quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime orderDate { get; set; }

        public virtual Parts Parts { get; set; }

        public virtual Requests Requests { get; set; }
    }
}
