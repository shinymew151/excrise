namespace CreateProduct.Models;

public class Product
{   
    public long Id { get; set; }
    
    public string ProductName { get; set; }
    
    public long Price { get; set; }

    public virtual List<OrderDetail> OrderDetails { get; set; } = [];
}