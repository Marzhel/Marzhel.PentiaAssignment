using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marzhel.PentiaAssignment.Models
{
    public class Customer
    {
        public Address Address { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Surname { get; set; }

        #region Navigarion Properties

        public virtual ICollection<CarPurchase> CarPurchases { get; set; }

        #endregion Navigarion Properties
    }
}
