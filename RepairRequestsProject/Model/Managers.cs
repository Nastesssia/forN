namespace RepairRequestsProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Managers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Managers()
        {
            MasterQualityManager = new HashSet<MasterQualityManager>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int managerID { get; set; }

        [Required]
        [StringLength(255)]
        public string managerName { get; set; }

        [Required]
        [StringLength(50)]
        public string managerPhone { get; set; }

        public int userID { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterQualityManager> MasterQualityManager { get; set; }
    }
}
