using System.ComponentModel.DataAnnotations;

namespace burgershack.Models
{
  public class Side
  {
    public string Id { get; set; }
    [Required]
    [MaxLength(12)]
    [MinLength(3)]
    public string Name { get; set; }
    [Required]
    [Range(.1, double.MaxValue)]
    public double ItemPrice { get; set; }


    public Side(string name, double itemPrice, string id)
    {
      Name = name;
      ItemPrice = itemPrice;
      Id = id;
    }
  }
}