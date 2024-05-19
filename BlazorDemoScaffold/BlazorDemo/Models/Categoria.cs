using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Models;

public class Categoria
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string? Nome { get; set; }

    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
