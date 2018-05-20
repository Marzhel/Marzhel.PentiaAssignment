using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marzhel.PentiaAssignment.Models
{
    public class Car : BaseEntity
    {
        [Required]
        public string Color { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public decimal RecommendedPrice { get; set; }

        #region Navigarion Properties

        public CarPurchase CarPurchase { get; set; }
        public virtual ICollection<CarExtra> Extras { get; set; }

        #endregion Navigarion Properties
    }
}
