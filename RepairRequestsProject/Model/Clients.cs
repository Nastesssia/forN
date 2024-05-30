namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clients()
        {
            Requests = new HashSet<Requests>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int clientID { get; set; }

        [Required]
        [StringLength(100)]
        public string clientName { get; set; }

        [Required]
        [StringLength(20)]
        public string clientPhone { get; set; }

        public int userID { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
