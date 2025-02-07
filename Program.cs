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

var iphone = new Product(1, "Iphone 14", 9000, "Phone");
var shoes = new Product(2, "Jordan 4s", 3000, "Clothing");
var airfryer = new Product(3, "Ninja Airfyer", 2400, "Kitchen Gear");

products.Add(iphone);
products.Add(shoes);
products.Add(airfryer);

app.MapPost("/products/addproduct", (Product product) =>
{
    products.Add(product);
});


app.Run();

class Product
{
    public int id {get; set;}

    public string Name { get; set; }
    public double Price { get; set; }

    public string Category { get; set; }

    public Product(int Id, string name, int price, string category)
    {
        this.id = Id;
        this.Name = name;
        this.Price = price;
        this.Category = category;
    }
}
