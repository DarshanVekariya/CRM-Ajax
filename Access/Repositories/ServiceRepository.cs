using Access.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class ServiceRepository : GenericRepository<Service>, IService
    {
        public ServiceRepository(MyDbContext db) : base(db)
        {
        }
    }
}
