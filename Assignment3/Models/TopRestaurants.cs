using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class TopRestaurants
    {
        public TopRestaurants()
        {
        }

        [Required]
        public int RestaurantRanking { get; set; }
        [Required]
        public String RestaurantName { get; set; }


        public String FavDish { get; set; } = "It's all tasty!";
        [Required]
        public string RestaurantAddress { get; set; }

        public string RestaurantPhone { get; set; }

        public string RestaurantWebsite { get; set; } = "Coming Soon!";

        public static TopRestaurants[] GetRestaurants()
        {
            TopRestaurants r1 = new TopRestaurants
            {
                RestaurantRanking = 1,
                RestaurantName = "Cafe Rio",
                FavDish = "Pork Barbacoa Burrito",
                RestaurantAddress = "1122 S University Ave Provo, UT 84601",
                RestaurantPhone = "(801) 882-7995",
                RestaurantWebsite = "https://www.caferio.com",

            };

            TopRestaurants r2 = new TopRestaurants
            {
                RestaurantRanking = 2,
                RestaurantName = "Firhouse Subs",
                RestaurantAddress = "64 Bulldog Ln, Provo, UT 84604",
                RestaurantPhone = "(801) 224-5800",
                RestaurantWebsite = "https://www.firehousesubs.com",

            };

            TopRestaurants r3 = new TopRestaurants
            {
                RestaurantRanking = 3,
                RestaurantName = "Don Joaquin",
                FavDish = "Tacos Al Pastor",
                RestaurantAddress = "150 W 1230 N St, Provo, UT 84604",
                RestaurantPhone = "(801) 400-2894",
            };

            TopRestaurants r4 = new TopRestaurants
            {
                RestaurantRanking = 4,
                RestaurantName = "Dirty Bird",
                FavDish = "Classic Chicken Sandwich",
                RestaurantAddress = "495 E 600 N, Provo, UT 84606",
                RestaurantPhone = "(801) 835-9810",
                RestaurantWebsite = "https://www.dirtybirdchxx.com",

            };

            TopRestaurants r5 = new TopRestaurants
            {
                RestaurantRanking = 5,
                RestaurantName = "In-N-Out",
                FavDish = "Double-Double Animal Style",
                RestaurantAddress = "350 E University Pkwy, Orem, UT 84058",
                RestaurantPhone = "(800) 786-1000",
                RestaurantWebsite = "https://www.in-n-out.com",

            };
            return new TopRestaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
