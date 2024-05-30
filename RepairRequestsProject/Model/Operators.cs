namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operators
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int operatorID { get; set; }

        [Required]
        [StringLength(100)]
        public string operatorName { get; set; }

        [Required]
        [StringLength(20)]
        public string operatoPhone { get; set; }

        public int userID { get; set; }

        public virtual Users Users { get; set; }
    }
}
