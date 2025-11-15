using System.ComponentModel.DataAnnotations;

namespace EduConnect.Models;

public class Professor
{
    [Key]
    public required string Codigo { get; set; }
    public required string Nome { get; set; }
    public required string Email { get; set; }
    public required string Telefone { get; set; }
    public required string Status { get; set; }
    public DateTime Nasc { get; set; }
    public required List<string> Turmas { get; set; } 
}
