using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.DataData.Repository;

namespace TheProject.DataData
{
    public interface IUnitOfWork
    {
        BookingRepository BookingRepository { get; }
        RestaurantRepository RestaurantRepository { get; }
        RestaurantAdminRepository RestaurantAdminRepository { get; }

        int Commit();
        Task<int> CommitAsync();
    }
}
