﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public enum AvailableState
    {
        Available,
        Occupied,
        Reserved
    }

    public enum TableType
    {
        Family,
        Solo,
    }
    public class Table
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int NumberOfPeople { get; set; }

        [Required]
        public int RestaurantId { get; set; }

        [Required]
        public AvailableState AvailableState { get; set; }

        [Required]
        public TableType TableType { get; set; }


        
        [Required]
        [ForeignKey("Resturant")]
        public int ResturantId { get; set; }
        public virtual Resturant? Resturant { get; set; }

        public virtual User? user { get; set; }
    }
    }

