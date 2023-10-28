﻿using RestaurantAPI.Models;

namespace RestaurantAPI.Repository
{
    public class TableUserRepository : ITableUserRepository
    {
        private readonly RestaurantContext context;

        public TableUserRepository(RestaurantContext context)
        {
            this.context = context;
        }
        public void Add(UserTable entity)
        {
            context.UserTables.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserTable> GetAll(string include = "")
        {
            throw new NotImplementedException();
        }

        public UserTable GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Update(UserTable entity)
        {
            throw new NotImplementedException();
        }
    }
}
