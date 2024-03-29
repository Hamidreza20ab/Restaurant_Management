namespace Restaurant_Management.DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Details
    {
        [Key]
        public int DetailsID { get; set; }

        public int OrderID { get; set; }

        public int FoodID { get; set; }

        public int Quantity { get; set; }

        public int UnitPrice { get; set; }

        public double Discount { get; set; }

        public virtual Foods Foods { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
