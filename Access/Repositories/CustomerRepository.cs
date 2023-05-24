using Access.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class CustomerRepository : GenericRepository<CustomerTbl>, ICustomer
    {
        public CustomerRepository(MyDbContext db) : base(db)
        {
        }
    }
}
