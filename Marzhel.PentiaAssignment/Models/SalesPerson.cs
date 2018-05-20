using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marzhel.PentiaAssignment.Models
{
    public class SalesPerson : BaseEntity
    {
        public Address Address { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Salary { get; set; }

        #region Navigarion Properties

        public virtual ICollection<CarPurchase> CarPurchases { get; set; }

        #endregion Navigarion Properties
    }
}
