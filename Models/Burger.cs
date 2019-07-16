using System.ComponentModel.DataAnnotations;

namespace burgershack.Models
{
  public class Burger
  {
    public string Id { get; set; }
    [Required]
    [MaxLength(12)]
    [MinLength(3)]
    public string Name { get; set; }
    [Required]
    [Range(.1, double.MaxValue)]
    public double ItemPrice { get; set; }


    public Burger(string name, double itemPrice, string id)
    {
      Name = name;
      ItemPrice = itemPrice;
      Id = id;
    }
  }
}