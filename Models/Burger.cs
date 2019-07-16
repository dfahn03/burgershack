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
    public string Description { get; set; }
    [Required]
    [Range(.90, double.MaxValue)]
    public double ItemPrice { get; set; }


    public Burger(string id, string name, string description, double itemPrice)
    {
      Id = id;
      Name = name;
      Description = description;
      ItemPrice = itemPrice;
    }
  }
}