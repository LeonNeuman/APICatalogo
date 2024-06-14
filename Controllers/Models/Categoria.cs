using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace APICatalogo.Controllers.Models;

public class Categoria
{
    public Categoria()
    {
            Produtos = new Collection<Produto>();
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }
    public ICollection<Produto>? Produtos { get; set; }

}
