﻿using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;

namespace RestaurantAPI.Repository.ProductRepository
{
    public class RecipetRepository : IRecipeRepository
    {
        private readonly RestaurantContext Context;
        public RecipetRepository(RestaurantContext context)
        {
            Context = context;
        }



        public List<Recipe> GetAll(string include = "")
        {
            var query = Context.Recipes.AsQueryable();
            if (!String.IsNullOrEmpty(include))
            {
                var includes = include.Split(",");
                foreach (var inc in includes)
                {
                    query = query.Include(inc.Trim());
                }
            }
            return query.ToList();
        }

        //public Recipe getByCategoryId(int categoryId)
        //{
        //    var recipe = Context.Recipes.FirstOrDefault(r => r.recipeCategoryId == categoryId);
        //    if (recipe != null)
        //        return recipe;
        //    return null;
        //}

        public Recipe GetById(int id)
        {
            var recipe = Context.Recipes.Where(r=>r.id == id).Include(r => r.recipteImages).Include(r => r.Menu).FirstOrDefault();
            if (recipe != null)
                return recipe;
            return null;
        }

        //public Recipe getByRestaurantId(int restaurantId)
        //{
        //    var recipe = Context.Recipes.FirstOrDefault(r => r.restaurantId == restaurantId);
        //    if (recipe != null)
        //        return recipe;
        //    return null;
        //}

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Update(Recipe entity)
        {
            Context.Recipes.Update(entity);
        }

        public void Add(Recipe entity)
        {
            Context.Recipes.Add(entity);
        }

        public void Delete(int id)
        {
            Recipe rec = GetById(id);
            Context.Recipes.Remove(rec);
        }

        public List<Recipe> getByMenuId(int menuId)
        {
            return Context.Recipes.Where(r => r.menuId == menuId).ToList();
        }
    }
}
