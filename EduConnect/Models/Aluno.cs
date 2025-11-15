using System.ComponentModel.DataAnnotations;

namespace EduConnect.Models;

public class Aluno
{
    [Key]
    public required string Matricula { get; set; }
    public required string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public required string Turma { get; set; }
    public required string Email { get; set; }
    public required string Telefone { get; set; }
    public required string Status { get; set; }
    public required string MediaNotas { get; set; }
}
