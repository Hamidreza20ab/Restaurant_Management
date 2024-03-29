namespace Restaurant_Management.DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservations
    {
        [Key]
        public int ReservationID { get; set; }

        public int CustomerID { get; set; }

        public int TableID { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual Tables Tables { get; set; }
    }
}
