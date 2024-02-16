using Intro2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2.Business.Abstracts
{
    public interface ICustomerService
    {
        List<BaseCustomer> TGetAll();
    }
}
