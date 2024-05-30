namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Masters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Masters()
        {
            MasterComments = new HashSet<MasterComments>();
            MasterQualityManager = new HashSet<MasterQualityManager>();
            Requests = new HashSet<Requests>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int masterID { get; set; }

        [Required]
        [StringLength(100)]
        public string masterType { get; set; }

        [Required]
        [StringLength(100)]
        public string masterName { get; set; }

        [Required]
        [StringLength(20)]
        public string masterPhone { get; set; }

        public int userID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterComments> MasterComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterQualityManager> MasterQualityManager { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
