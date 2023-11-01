﻿using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Dto;
using RestaurantAPI.Models;
using RestaurantAPI.Repository;
using RestaurantAPI.Repository.ResturantRepository;

namespace RestaurantAPI.Controllers
{
    public class MenuController : BaseApiClass
    {
        private readonly IRecipeRepository recipeRepository;
        private readonly IMenuRepository MenuRepository;
        private readonly IResturanrRepo resturanrRepo;

        public MenuController(IRecipeRepository recipeRepository, 
            IMenuRepository menuRepository,
            IResturanrRepo resturanrRepo)
        {
            this.recipeRepository = recipeRepository;
            MenuRepository = menuRepository;
            this.resturanrRepo = resturanrRepo;
        }


        [HttpGet("{restaurantId}")]
        public ActionResult getMenuByRestaurantId(int restaurantId)
        {
            var restaurant = resturanrRepo.GetById(restaurantId);
            if(restaurant is not null)
            {
                var menus = MenuRepository.GetByRestaurantId(restaurantId);
                List<RecipeDto> recipeDtos = new List<RecipeDto>();
                List<MenuDto> menuDto = new();
                foreach (var item in menus)
                {
                    recipeDtos.AddRange(
                        item.Recipes
                        .Select(r => new RecipeDto()
                        { Description = r.Description, imageUrl = r.imageUrl, Name = r.name, Price=r.Price, menuName= item.title}).ToList());
                    menuDto.Add(new MenuDto() { 
                        id = item.id, 
                        title = item.title,
                        });
                }
                return Ok(new {menuDto,recipeDtos});
            }
            return BadRequest();
        }

        [HttpGet("getmostRatedRecipe/{restaurantId}")]
        public ActionResult getMostRatedRecipe(int restaurantId) {

            List<MostRated> recipeDtos = new();
            var recipes = MenuRepository.getMostRatedRecipe(restaurantId);
            foreach (var item in recipes)
            {
                recipeDtos.Add(new MostRated()
                {
                    id= item.id,
                    Description = item.Description,
                    imageUrl = item.imageUrl,
                    Name = item.name,
                    Price = item.Price
                });
            }

            return Ok(recipeDtos);
        }
    }
}