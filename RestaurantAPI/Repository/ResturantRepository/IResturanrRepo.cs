﻿using E_Commerce.Repository;
using RestaurantAPI.Dto;
using RestaurantAPI.Models;

namespace RestaurantAPI.Repository.ResturantRepository
{
    public interface IResturanrRepo:IGenericRepository<Resturant>
    {
        public Resturant getByAddress(string address);
        public IEnumerable<ResturantDto> getByCategoryId(int category_id);
        public List<ResturantDto> getByNameAndCategoryId(string name, int categoryId);
        public void UpdateIamge(string newUrl);
    }
}
