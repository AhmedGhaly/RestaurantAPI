﻿using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;

namespace RestaurantAPI.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly RestaurantContext context;

        public MenuRepository(RestaurantContext context)
        {
            this.context = context;
        }

        public void Add(Menu entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll(string include = "")
        {
            throw new NotImplementedException();
        }

        public Menu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetByRestaurantId(int restuarantId)
        {
            return context.Menus.Where(t => t.restaurantId == restuarantId).Include(r => r.Recipes).ToList();
        }

        public List<Recipe> getMostRatedRecipe(int restaurantId)
        {
            var menus = context.Menus.Where(r => r.restaurantId == restaurantId).Include(r => r.Recipes);
            List<Recipe> mostRated = new List<Recipe>();
            foreach (var item in menus)
                mostRated.Add(item.Recipes.OrderByDescending(r => r.rate).FirstOrDefault());

            return mostRated;

        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}