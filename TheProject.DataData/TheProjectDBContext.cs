using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.Models;

namespace TheProject.DataData
{
    public class TheProjectDBContext : IdentityDbContext<IdentityUser>
    {
        public IDbSet<Booking> Bookings { get; set; }
        public IDbSet<Restaurant> Restaurants { get; set; }
        public IDbSet<RestaurantAdmin> RestaurantAdmins { get; set; }



        public TheProjectDBContext()
            : base("DefaultConnection")
        {

        }
    }
}
