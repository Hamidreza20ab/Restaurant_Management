namespace Restaurant_Management.DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int EmployeeID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int TitleID { get; set; }

        public DateTime Birthdate { get; set; }

        public DateTime HireDate { get; set; }

        [Required]
        [StringLength(400)]
        public string Address { get; set; }

        [Required]
        [StringLength(11)]
        public string MobileNumber { get; set; }

        [StringLength(11)]
        public string HomePhone { get; set; }

        [Required]
        [StringLength(20)]
        public string LastDegree { get; set; }

        public bool EmployeeStatus { get; set; }

        public virtual Titles Titles { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
