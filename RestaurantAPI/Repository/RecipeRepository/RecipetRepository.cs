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
            var recipes = Context.Recipes.Include(include).ToList();
            if (recipes != null)
                return recipes;
            return null;
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
            var recipe = Context.Recipes.Where(r=>r.id == id).Include(r => r.recipteImages).Include(r => r.Menu).ThenInclude(r => r.restaurant).FirstOrDefault();
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
            throw new NotImplementedException();
        }

        public void Update(Recipe entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Recipe entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> getByMenuId(int menuId)
        {
            return Context.Recipes.Where(r => r.menuId == menuId).ToList();
        }

        public List<string> getRecipeImages(int id)
        {
            return Context.RecipeImages.Where(r => r.RecipeId == id).Select(r => r.Image).ToList();
        }


    }
}
