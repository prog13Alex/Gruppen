using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TheProject.Models
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int NumberOfSeats { get; set; }
        public int MaxCapacity { get; set; }
        public int MaxGuestsPerBooking { get; set; }
        public int NormalSittingTime { get; set; }
        public bool IsActive { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

        public int AdminUserId { get; set; }
        [ForeignKey("AdminUserId")]
        public virtual RestaurantAdmin AdminUser { get; set; }

        public Restaurant()
        {
            Bookings = new List<Booking>();
        }
    }
}