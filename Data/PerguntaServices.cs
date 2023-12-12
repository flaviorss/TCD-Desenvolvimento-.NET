using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;
namespace TCD.Data;

public class PerguntaServices
{

    #region Métodos privados
    private readonly PerguntaDbContext dbContext;
    #endregion

    #region Construtor
    public PerguntaServices(PerguntaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion

    #region Metodos Publicos 
    /// <summary>
    /// Retorna a lista de usuarios
    /// </summary>
    /// <returns></returns>
    public async Task<List<Pergunta>> RetornaPerguntaAsync()
    {
        return await dbContext.Pergunta.ToListAsync();
    }

    public async Task<List<Pergunta>> RetornaPerguntaSelecionadaAsync()
    {
        return await dbContext.Pergunta
            .Where(p => p.Selecionado == 1)
            .ToListAsync();
    }

    /// <summary>
    /// Adiciona um novo produto para DbContext e o salva
    /// </summary>
    /// <param name="perg"></param>
    /// <returns></returns>
    public async Task<Pergunta> AddPerguntaAsync(Pergunta perg)
    {
        try
        {
            perg.Selecionado = 0;
            perg.NumAvaliacoes = 0;
            perg.Avaliacao = 0.0;
            dbContext.Pergunta.Add(perg);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return perg;
    }

    /// <summary>
    /// Atualiza um produto e salva as mudanças
    /// </summary>
    /// <param name="perg"></param>
    /// <returns></returns>
    public async Task<Pergunta> UpdatePerguntaAsync(Pergunta perg)
    {
        try
        {
            var productExist = dbContext.Pergunta.FirstOrDefault(p => p.Id == perg.Id);
            if (productExist != null)
            {
                dbContext.Update(perg);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return perg;
    }

    public async Task<Pergunta> UpdateCondicaoAsync(Pergunta perg, int valor)
    {
        try
        {
            var perguntaExist = dbContext.Pergunta.FirstOrDefault(p => p.Id == perg.Id);
            if (perguntaExist != null)
            {
                perguntaExist.Selecionado = valor;
                dbContext.Update(perguntaExist);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return perg;
    }

    public async Task UpdateAvaliacaoAsync(int perguntaId, double? avaliacao)
    {
        try
        {
            var perguntaExist = dbContext.Pergunta.FirstOrDefault(p => p.Id == perguntaId);
            if (perguntaExist != null)
            {   
                
                perguntaExist.Avaliacao = avaliacao;
                //perguntaExist.Avaliacao = (perguntaExist.Avaliacao * perguntaExist.NumAvaliacoes + avaliacao) / (perguntaExist.NumAvaliacoes + 1);
                perguntaExist.NumAvaliacoes += 1;
                dbContext.Update(perguntaExist);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Remove um produto de DbContext e o salva
    /// </summary>
    /// <param name="pergunta"></param>
    /// <returns></returns>
    public async Task DeletePerguntaAsync(Pergunta pergunta)
    {
        try
        {
            dbContext.Pergunta.Remove(pergunta);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion
}