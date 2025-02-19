using Models;

List<Booking> bookings = new List<Booking>
{
    new Booking() {Id = 0, Customer = new Customer(0, "Kalle")},
    new Booking() {Id = 1, Customer = new Customer(1, "Kajsa")},
    new Booking() {Id = 2, Customer = new Customer(2, "Knatte")}
};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
