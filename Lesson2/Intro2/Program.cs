using Intro2.Business.Concretes;
using Intro2.DataAccess.Concretes;
using Intro2.Entities;

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

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}


CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
List<BaseCustomer> customers1 = customerManager.TGetAll();
for (int i = 0; i < customers1.Count; i++)
{
    Console.WriteLine(customers1[i].ID + " / " + customers1[i].CustomerNumber);
}
