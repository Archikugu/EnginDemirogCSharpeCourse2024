
//Customer customer = new Customer();

Customer customer2 = new Customer { ID = 1, FirstName = "Gökhan", LastName = "Gök", City = "Ankara" };
Customer customer3 = new Customer(2, "Osman", "Biçer", "Ankara");

Console.WriteLine(customer3.FirstName);

class Customer
{
    //Default Constructor
    public Customer()
    {
        Console.WriteLine("Yapıcı Blok Çalıştı");
    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}