// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";

int term = 12;
double amount = 100000;


//veriables --> camelCase
bool isAuthenticated = true; 
Console.WriteLine(message1);


//condition
if (isAuthenticated==true)
{
    Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = {"Kredi 1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6", }; //db den gelecek
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";


    //start     //condition       //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new(new DapperCourseDal());

List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);

}

Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "2345656";
customer1.FirstName = "Beyza";
customer1.LastName = "Aydoğan";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "23455776";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "234568";
customer3.TaxNumber = "12345678909";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "234569";
customer4.TaxNumber = "12345678977";


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };


//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}








































