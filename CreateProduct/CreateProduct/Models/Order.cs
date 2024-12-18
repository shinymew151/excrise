namespace CreateProduct.Models;

public class Order
{
    public int Id { get; set; }
    
    public long UserId { get; set; }
    
    public DateTime OrderDate { get; set; }
    
    public virtual User User { get; set; }
    
    public virtual List<OrderDetail> Products { get; set; } = new List<OrderDetail>();
}