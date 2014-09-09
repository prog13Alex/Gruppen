using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheProject.DataData.Repository;

namespace TheProject.DataData
{
    public class RepositoryProvider
    {
        public BookingRepository BookingRepository { get; private set; }
        public RestaurantRepository RestaurantRepository { get; private set; }
        public RestaurantAdminRepository RestaurantAdminRepository { get; private set; }


        public RepositoryProvider(BookingRepository _BookingRepository, 
            RestaurantRepository _RestaurantRepository, 
            RestaurantAdminRepository _RestaurantAdminRepository)
        {
            BookingRepository = _BookingRepository;
            RestaurantRepository = _RestaurantRepository;
            RestaurantAdminRepository = _RestaurantAdminRepository;
        }
    }
}
