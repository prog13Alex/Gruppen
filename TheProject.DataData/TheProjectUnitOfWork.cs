using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.DataData.Repository;

namespace TheProject.DataData
{
    public class TheProjectUnitOfWork: IUnitOfWork
    {
        private TheProjectDBContext _Context;

        public BookingRepository BookingRepository { get; private set; }
        public RestaurantRepository RestaurantRepository { get; private set; }
        public RestaurantAdminRepository RestaurantAdminRepository { get; private set; }


        public TheProjectUnitOfWork(TheProjectDBContext context, RepositoryProvider rep)
        {
            _Context = context;

            BookingRepository = rep.BookingRepository;
        }

        public int Commit()
        {
            return _Context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _Context.SaveChangesAsync();
        }
    }
}
