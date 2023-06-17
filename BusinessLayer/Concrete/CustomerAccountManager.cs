using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDataAccess _customerAccountDataAccess;

        public CustomerAccountManager(ICustomerAccountDataAccess customerAccountDataAccess)
        {
            _customerAccountDataAccess = customerAccountDataAccess;
        }

        public List<CustomerAccount> TGetList()
        {
            return _customerAccountDataAccess.GetList();
        }

        public CustomerAccount TGetById(int Id)
        {
            return _customerAccountDataAccess.GetById(Id);
        }

        public void TAdd(CustomerAccount t)
        {
            _customerAccountDataAccess.Add(t);
        }

        public void TDelete(CustomerAccount t)
        {
            _customerAccountDataAccess.Delete(t);
        }

        public void TUpdate(CustomerAccount t)
        {
            _customerAccountDataAccess.Update(t);
        }
    }
}
