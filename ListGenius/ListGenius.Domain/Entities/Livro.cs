// Ignore Spelling: capa titulo lancamento livro editora autor categoria

using ListGenius.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ListGenius.Domain.Entities;

public sealed class Livro
{
    public int LivroId { get; set; }

    [Required(ErrorMessage = "Informe o título do livro")]
    [MaxLength(150)]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "Informe o(s) autor(es)")]
    [MaxLength(200)]
    public string? Autor { get; set; }

    [Required(ErrorMessage = "Informe a data do lançamento")]
    public DateTime Lancamento { get; set; }

    [Required(ErrorMessage = "Informe o nome da imagem da capa")]
    [MaxLength(200)]
    public string? Capa { get; set; }

    [Required]
    [EnumDataType(typeof(Editora), ErrorMessage = "Selecione a editora")]
    public Editora Editora { get; set; }

    [Required]
    [EnumDataType(typeof(Categoria), ErrorMessage = "Selecione a categoria")]
    public Categoria Categoria { get; set; }

    public Livro(int livroId, string? titulo, string? autor,
        DateTime lancamento, string? capa, Editora editora, Categoria categoria)
    {
        LivroId = livroId;
        Titulo = titulo;
        Autor = autor;
        Lancamento = lancamento;
        Capa = capa;
        Editora = editora;
        Categoria = categoria;
    }
}
