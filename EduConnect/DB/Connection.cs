using EduConnect.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace EduConnect.DB;

internal class Connection : DbContext
{
    public DbSet<Aluno> Aluno { get; set; }
    public DbSet<Professor> Professor { get; set; }
    private readonly string ConnectString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EduConnect;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectString);
    }
}