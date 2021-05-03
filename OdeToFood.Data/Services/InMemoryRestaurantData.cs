using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>() 
            { 
                new Restaurant {Id = 1, Name = "Denny's", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Wendy's", Cuisine = CuisineType.French},
                new Restaurant {Id = 3, Name = "Syafii's", Cuisine = CuisineType.Indian},
                new Restaurant {Id = 4, Name = "Randy's", Cuisine = CuisineType.None}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
