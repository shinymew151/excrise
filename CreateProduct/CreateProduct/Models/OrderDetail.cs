using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CreateProduct.Models;

public class OrderDetail
{   
    public int Id { get; set; }
    
    public int OrderId { get; set; }
    
    public int ProductId { get; set; }
    
    public int Quantity { get; set; }
    
    public int  UnitPrice { get; set; }
    
    [ForeignKey("OrderId")]
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; } = null!;
}