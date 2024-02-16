using Business.Concrete;
using Entities.Concrete;

Person person = new Person();
Console.WriteLine("Lütfen adınızı giriniz:");
person.FirstName = Console.ReadLine();

Console.WriteLine("Lütfen soyadınızı giriniz:");
person.LastName = Console.ReadLine();

Console.WriteLine("Lütfen doğum yılınızı giriniz:");
if (int.TryParse(Console.ReadLine(), out int birthYear))
{
    person.DateOfBirthYear = birthYear;
}
else
{
    Console.WriteLine("Geçersiz doğum yılı girdiniz. Lütfen bir sayı girin.");
    return;
}

Console.WriteLine("Lütfen T.C. kimlik numaranızı giriniz:");
if (long.TryParse(Console.ReadLine(), out long nationalIdentity))
{
    person.NationalIdentity = nationalIdentity;
}
else
{
    Console.WriteLine("Geçersiz T.C. kimlik numarası girdiniz. Lütfen bir sayı girin.");
    return;
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);