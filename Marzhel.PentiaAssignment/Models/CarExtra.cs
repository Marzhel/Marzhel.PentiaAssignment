using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marzhel.PentiaAssignment.Models
{
    public class CarExtra : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        #region Navigarion Properties

        public virtual ICollection<Car> Cars { get; set; }

        #endregion Navigarion Properties
    }
}
