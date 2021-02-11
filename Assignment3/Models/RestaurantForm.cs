using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class RestaurantForm
    {
        public RestaurantForm()
        {
        }
        [Required]
        public string ClientName { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        [Required]
        public string FavoriteDish { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string RestaurantPhone { get; set; }
    }
}
