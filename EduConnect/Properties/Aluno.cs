namespace EduConnect.Properties;

public class Aluno(string matricula, string nome, DateTime nascimento, string turma, string email, string telefone, string status, string media)
{
    public string Matricula { get; set; } = matricula;
    public string Nome { get; set; } = nome;
    public DateTime DataNascimento { get; set; } = nascimento;
    public string Turma { get; set; } = turma;
    public string Email { get; set; } = email;
    public string Telefone { get; set; } = telefone;
    public string Status { get; set; } = status;
    public string MediaNotas { get; set; } = media;
}
