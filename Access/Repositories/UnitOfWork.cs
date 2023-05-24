using Access.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _db;
        public ICustomer customer { get; set; }
        public IService service { get; set; }
        public IPayment Payment { get; set; }

        public UnitOfWork(MyDbContext dbContext)
        {
            _db = dbContext;
            customer = new CustomerRepository(_db);
            service = new ServiceRepository(_db);
            Payment = new PaymentRepository(_db);
        }

        public int Complate()
        {
            try
            {
              return  _db.SaveChanges() == 1 ? 1 : 0;
            }
            catch (Exception ex)
            {
                //return ex.Message;
            }
           return _db.SaveChanges();
        }
    }
}
