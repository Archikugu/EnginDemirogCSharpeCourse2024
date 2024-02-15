// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message = "Krediler";
Console.WriteLine(message);

int term = 12;
double amount = 1000000.5;

//variables --> camelCase
bool isAuthenticated = false;

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Gökhan");
}
else
{
    Console.WriteLine("Buton-->Sisteme Giriş Yap");
}

string credit1 = "Kredi 1";
string credit2 = "Kredi 2";
string credit3 = "Kredi 3";
string credit4 = "Kredi 4";

Console.WriteLine(credit1);
Console.WriteLine(credit2);
Console.WriteLine(credit3);
Console.WriteLine(credit4);


string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

foreach (var loan in loans)
{
    Console.WriteLine(loan);
}

CourseManager courseManager = new();
courseManager.GetAll();

Console.WriteLine("Kod Bitti");