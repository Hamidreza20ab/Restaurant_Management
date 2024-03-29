namespace Restaurant_Management.DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            Orders = new HashSet<Orders>();
            Reservations = new HashSet<Reservations>();
        }

        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(40)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(40)]
        public string CustomerLastname { get; set; }

        [StringLength(11)]
        public string MobileNumber { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}
