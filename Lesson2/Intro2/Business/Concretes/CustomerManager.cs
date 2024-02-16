using Intro2.Business.Abstracts;
using Intro2.DataAccess.Abstracts;
using Intro2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2.Business.Concretes
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<BaseCustomer> TGetAll()
        {
           return _customerDal.GetAll();
        }
    }
}
