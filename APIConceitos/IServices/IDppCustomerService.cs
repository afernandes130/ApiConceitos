using APIConceitos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConceitos.IServices
{
    public interface IDppCustomerService
    {
        DPPCustomers Save(DPPCustomers customer);
        IEnumerable<DPPCustomers> GetAll();
        DPPCustomers Get(int dppCustomerId);
        void Delete(int dppCustomerId);
    }
}
