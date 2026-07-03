using System.ComponentModel.DataAnnotations;

namespace CadastroPessoasAPI.Models;

public class Pessoa
{
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}