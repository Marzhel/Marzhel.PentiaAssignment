using System;
using System.ComponentModel.DataAnnotations;

namespace Marzhel.PentiaAssignment.Models
{
    public class CarPurchase : BaseEntity
    {
        [Required]
        public Car Car { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal PricePaid { get; set; }

        [Required]
        public SalesPerson SalesPerson { get; set; }
    }
}
