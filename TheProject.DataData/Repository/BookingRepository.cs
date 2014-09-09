using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.Models;

namespace TheProject.DataData.Repository
{
    public class BookingRepository : GenericRepository<Booking>
    {
        public BookingRepository(TheProjectDBContext db) : base(db) { }
    }
}
