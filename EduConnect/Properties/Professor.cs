namespace EduConnect.Properties;

public class Professor(string codigo, string nome, string email, string telefone, string status, DateTime nasc, Array turmas)
{
    public string Codigo { get; set; } = codigo;
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    public string Telefone { get; set; } = telefone;
    public string Status { get; set; } = status;
    public DateTime Nasc { get; set; } = nasc;
    public Array Turmas { get; set; } = turmas;
}
