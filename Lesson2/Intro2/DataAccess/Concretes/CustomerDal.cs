using Intro2.DataAccess.Abstracts;
using Intro2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2.DataAccess.Concretes
{
    public class CustomerDal : ICustomerDal
    {
        List<BaseCustomer> customers;
        public CustomerDal()
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.ID = 1;
            customer1.NationalIdentity = "12345678910";
            customer1.FirstName = "Gökhan";
            customer1.LastName = "GÖK";
            customer1.CustomerNumber = "12345";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.ID = 2;
            customer2.NationalIdentity = "56789101112";
            customer2.FirstName = "Özgür";
            customer2.LastName = "Atılgan";
            customer2.CustomerNumber = "123457";

            CorporateCustomer customer3 = new CorporateCustomer();
            customer3.ID = 3;
            customer3.Name = "Kodlamaio";
            customer3.CustomerNumber = "654789";
            customer3.TaxNumber = "123456789";

            CorporateCustomer customer4 = new CorporateCustomer();
            customer4.ID = 4;
            customer4.Name = "Abc";
            customer4.CustomerNumber = "654779";
            customer4.TaxNumber = "12345678985";

            customers = new List<BaseCustomer> { customer1, customer2, customer3, customer4 };
        }
        public void Add(BaseCustomer customer)
        {
            customers.Add(customer);
        }

        public List<BaseCustomer> GetAll()
        {
            return customers;
        }
    }
}
