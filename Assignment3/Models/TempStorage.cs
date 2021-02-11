using System;
using System.Collections.Generic;

namespace Assignment3.Models
{
    public static class TempStorage
    {
        private static List<RestaurantForm> restaurants = new List<RestaurantForm>();

        public static IEnumerable<RestaurantForm> RestaurantForms => restaurants;

        public static void AddRestaurant(RestaurantForm restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
