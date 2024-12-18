namespace CreateProduct.Models;

public class User
{
    public long Id { get; set; }
    
    public string Username { get; set; }
    
    public string Email { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}