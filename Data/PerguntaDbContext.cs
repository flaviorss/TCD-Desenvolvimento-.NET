using Microsoft.EntityFrameworkCore;
namespace TCD.Data;

public class PerguntaDbContext : DbContext
{
    #region Contrutor
    public PerguntaDbContext(DbContextOptions<PerguntaDbContext> options) : base(options)
    {

    }
    #endregion

    #region Propriedades
    public DbSet<Pergunta> Pergunta { get; set; }
    #endregion

    #region Métodos sobrecarregados
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pergunta>().HasData(RetornaUsuarios());
        base.OnModelCreating(modelBuilder);
    }
    #endregion


    #region Métodos privados
    private List<Pergunta> RetornaUsuarios()
    {
        return new List<Pergunta>{
            new Pergunta { Id = 1, Texto = "Como você avaliaria a competência e o comprometimento dos professores?", Selecionado = 0, NumAvaliacoes = 0, Avaliacao = 0.0},
            new Pergunta { Id = 2, Texto = "As atividades práticas e teóricas das disciplinas do curso são equilibradas de maneira eficaz?", Selecionado = 0, NumAvaliacoes = 0, Avaliacao = 0.0},
            new Pergunta { Id = 3, Texto = "A instituição oferece recursos tecnológicos adequados para apoiar o aprendizado?", Selecionado = 0, NumAvaliacoes = 0, Avaliacao = 0.0}
        };
    }
    #endregion
}




