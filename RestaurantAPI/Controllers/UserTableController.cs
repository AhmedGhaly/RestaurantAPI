﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Dto;
using RestaurantAPI.Dto.UserTable;
using RestaurantAPI.Models;
using RestaurantAPI.Repository;

namespace RestaurantAPI.Controllers
{
    public class UserTableController : BaseApiClass
    {
        private readonly ITableUserRepository tableUserRepository;
        private readonly IUserRepository userRepository;

        public UserTableController(ITableUserRepository tableUserRepository,
            IUserRepository userRepository)
        {
            this.tableUserRepository = tableUserRepository;
            this.userRepository = userRepository;
        }

        [HttpGet("searchByrestaurant/{restaurantId}")]
        public ActionResult searchByRestauarntId(int restaurantId)
        {
            List<UserTable> restaurantTalbleUser = tableUserRepository.GetAllByRestaurantId(restaurantId);

            // map list of usertable to usertabledto
            List<UserTableDto> userTableDto = new(); 
            foreach (var item in restaurantTalbleUser)
            {
                userTableDto.Add(new UserTableDto()
                {
                    dateTime = item.dateTime,
                    name = item.name,
                    phone = item.phone,
                    reservationNumber = item.id,
                    tableNumber = item.table_id,
                }) ; 
            }

            return Ok(userTableDto);
        }

        [HttpGet("searchByUserId")]
        [Authorize]
        public ActionResult searchByUserId()
        {
            List<UserTable> userReservation = tableUserRepository.GetAllByUserId(userRepository.getUserByApplicationUserId(GetUserIdFromClaims()).id);

            // map list of usertable to usertabledto
            List<UserReservationDto> userTableDto = new();
            foreach (var item in userReservation)
            {
                userTableDto.Add(new UserReservationDto()
                {
                    
                    reservationNumber = item.id,
                    tableNumber = item.table_id,
                    dateTime = item.dateTime,
                    tableType = item.Table.TableType,
                    restaurantName = item.resturant.Name,
                });
            }

            return Ok(userTableDto);
        }

        [HttpDelete]
        public ActionResult deleteUserTable(int id)
        {
            if (id < 0)
            {
                return BadRequest("Invalid UserTable id.");
            }

            var res = tableUserRepository.GetById(id);
            if (res is  null)
                return NotFound("UserTable Not Found!");

            tableUserRepository.Delete(id);
            int Raws = tableUserRepository.SaveChanges();
            if (Raws > 0)
            {
                return NoContent();
            }

            return NotFound("UserTable updated failed.");
        }


    }
}
