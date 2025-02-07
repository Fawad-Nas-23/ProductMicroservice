using Microsoft.AspNetCore.Authorization.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var products = new List<Product>();

var iphone = new Product("Iphone 14", 9000, "Phone");
var shoes = new Product("Jordan 4s", 3000, "Clothing");
var airfryer = new Product("Ninja Airfyer", 2400, "Kitchen Gear");

app.MapPut(/"products/{name}", (string name) =>

{
    
}

)


app.Run();

class Product
{

    public string Name { get; set; }
    public double Price { get; set; }

    public string Category { get; set; }

    public Product(string name, int price, string category)
    {

        this.Name = name;
        this.Price = price;
        this.Category = category;
    }
}
