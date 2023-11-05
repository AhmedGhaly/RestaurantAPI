﻿using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;

namespace RestaurantAPI.Repository
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly RestaurantContext context;

        public CartItemRepository(RestaurantContext context)
        {
            this.context = context;
        }

        public void Add(CartItem entity)
        {
            context.CartItems.Add(entity);
        }

        public void Delete(int id)
        {
            CartItem cartItem = GetById(id);
            context.CartItems.Remove(cartItem);
        }

        public List<CartItem> GetAll(string include = "")
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetAllByCartId(int cartId)
        {
            return context.CartItems.Where(r => r.CartId == cartId).Include(r=>r.Cart).Include(r => r.Resturant).Include(r => r.Recipe).ToList();
        }

        public List<CartItem> GetAllByCartIdAndRestaurantId(int cartId, int restaurantId)
        {
            return context.CartItems.Where(r => r.CartId == cartId && r.ResturantId == restaurantId).Include(r => r.Cart).Include(r => r.Resturant).Include(r => r.Recipe).ToList();

        }

        public List<CartItem> GetByCartIdAndRestaurantId(int cartId, int restaurantId)
        {
            return context.CartItems.Where(r => r.CartId == cartId && r.ResturantId == restaurantId).Include(r => r.Cart).Include(r => r.Resturant).Include(r => r.Recipe).ToList();
        }

        public CartItem GetById(int id)
        {
            return context.CartItems.FirstOrDefault(c => c.Id == id);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Update(CartItem entity)
        {
            context.CartItems.Update(entity);
        }
    }
}
