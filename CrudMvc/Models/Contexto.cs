using CrudMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOracleMvc.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
