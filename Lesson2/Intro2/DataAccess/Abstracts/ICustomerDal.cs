using Intro2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2.DataAccess.Abstracts
{
    public interface ICustomerDal
    {
        List<BaseCustomer> GetAll();
        void Add(BaseCustomer customer);
    }
}
