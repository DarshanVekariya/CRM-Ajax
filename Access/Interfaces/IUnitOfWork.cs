using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Interfaces
{
    public interface IUnitOfWork
    {
        public ICustomer customer { get; set; }

        public IService service { get; set; }   

        public IPayment Payment { get; set; }

        public int Complate();
    }
}
