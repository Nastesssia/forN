namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parts()
        {
            PartsOrders = new HashSet<PartsOrders>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int partID { get; set; }

        [Required]
        [StringLength(100)]
        public string partsName { get; set; }

        [Required]
        [StringLength(255)]
        public string partsDescription { get; set; }

        public int stockQuantity { get; set; }

        public decimal price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartsOrders> PartsOrders { get; set; }
    }
}
