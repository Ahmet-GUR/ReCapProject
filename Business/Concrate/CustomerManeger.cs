using Business.Abstract;
using Business.Constants;
using Core.Utilities.Resualts;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CustomerManeger : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManeger(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResualt Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResualt(Messages.Add);
        }

        public IResualt Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResualt(Messages.Delete);
        }

        public IDataResualt<List<Customer>> GetAll()
        {
            return new SuccessDataResualt<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResualt<Customer> GetByCustomerId(int customerId)
        {
            return new SuccessDataResualt<Customer>(_customerDal.GetById(cu => cu.CustomerId == customerId));
        }

        public IResualt Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResualt(Messages.Update);
        }
    }
}
