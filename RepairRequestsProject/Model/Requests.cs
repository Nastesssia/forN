namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Requests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requests()
        {
            ClientsReviews = new HashSet<ClientsReviews>();
            MasterComments = new HashSet<MasterComments>();
            MasterQualityManager = new HashSet<MasterQualityManager>();
            PartsOrders = new HashSet<PartsOrders>();
        }

        [Key]
        public int requestID { get; set; }

        [Column(TypeName = "date")]
        public DateTime startDate { get; set; }

        [Required]
        [StringLength(50)]
        public string homeTechType { get; set; }

        [Required]
        [StringLength(70)]
        public string homeTechModel { get; set; }

        [Required]
        [StringLength(200)]
        public string problemDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string requestStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? completionDate { get; set; }

        [StringLength(200)]
        public string repairParts { get; set; }

        public int? masterID { get; set; }

        public int clientID { get; set; }

        public virtual Clients Clients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientsReviews> ClientsReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterComments> MasterComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterQualityManager> MasterQualityManager { get; set; }

        public virtual Masters Masters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartsOrders> PartsOrders { get; set; }
    }
}
