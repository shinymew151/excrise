using CreateProduct.Data;
using CreateProduct.Models;
using Faker;
using Microsoft.AspNetCore.Mvc;

namespace CreateProduct.Controllers;

public class StroreSeedController : Controller
{
    // GET
    
    private excrisedbcontext _context;

    public StroreSeedController( excrisedbcontext context )
    {
        _context = context;
    }
    
    public IActionResult GenerateUserSeed()
    {

        User user = new User()
        {
            Username = Faker.Name.FullName(),
            Email = Faker.Internet.Email(),

        };
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok();
    }

    public IActionResult GenerateProductSeed()
    {
        Product product = new Product()
        {
            ProductName = Faker.Name.FullName(),
            Price = Faker.RandomNumber.Next(100, 1000),
        };
        _context.Products.Add(product);
        _context.SaveChanges();
        return Ok();
    }

    public IActionResult GenerateOrderSeed()
    {
        Order order = new Order()
        {
            OrderDate = DateTime.Now,
        };
        _context.Orders.Add(order);
        _context.SaveChanges();
        return Ok();
    }

    public IActionResult GenerateOrderDetailSeed()
    {
        OrderDetail orderDetail = new OrderDetail()
        {
            Quantity = Faker.RandomNumber.Next(1, 100),
            ProductId = Faker.RandomNumber.Next(1, 100),
            OrderId = Faker.RandomNumber.Next(1, 100),
            UnitPrice = Faker.RandomNumber.Next(1, 100),
        };
        _context.OrderDetails.Add(orderDetail);
        _context.SaveChanges();
        return Ok();
    }
}