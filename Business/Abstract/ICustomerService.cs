using Core.Utilities.Resualts;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResualt<List<Customer>> GetAll();
        IDataResualt<Customer> GetByCustomerId(int customerId);
        IResualt Add(Customer customer);
        IResualt Update(Customer customer);
        IResualt Delete(Customer customer);
    }
}
