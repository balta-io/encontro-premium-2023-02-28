using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaltaShop.Models;

public class Product
{
    public int Id { get; set; }

    [DisplayName("Título")]
    [MinLength(3, ErrorMessage = "Mínimo 3")]
    [MaxLength(12, ErrorMessage = "Máximo 12")]
    public string Title { get; set; } = string.Empty;

    public decimal Price { get; set; }
}