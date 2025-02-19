using Models;

List<Customer> customers = new List<Customer>
{
    new Customer(0, "Kalle"),
    new Customer(1, "kajsa"),
    new Customer(2, "Knatte"),
    new Customer(3, "Fnatte"),
    new Customer(4, "Tjatte")
};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
