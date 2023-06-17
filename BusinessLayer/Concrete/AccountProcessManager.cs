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
    public class AccountProcessManager : IAccountProcessService
    {
        private readonly IAccountProcessDataAccess _accountProcessDataAccess;

        public AccountProcessManager(IAccountProcessDataAccess accountProcessDataAccess)
        {
            _accountProcessDataAccess = accountProcessDataAccess;
        }

        public List<AccountProcess> TGetList()
        {
            return _accountProcessDataAccess.GetList();
        }

        public AccountProcess TGetById(int Id)
        {
            return _accountProcessDataAccess.GetById(Id);
        }

        public void TAdd(AccountProcess t)
        {
            _accountProcessDataAccess.Add(t);
        }

        public void TDelete(AccountProcess t)
        {
            _accountProcessDataAccess.Delete(t);
        }

        public void TUpdate(AccountProcess t)
        {
            _accountProcessDataAccess.Update(t);
        }
    }
}
