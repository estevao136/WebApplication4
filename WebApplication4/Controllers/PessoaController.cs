using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Class;

public class PessoaController
{
    private List<Pessoa> pessoas = new List<Pessoa>();

    
    public void AdicionarPessoa(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
        Console.WriteLine("Pessoa adicionada com sucesso.");
    }

   
    public void AtualizarPessoa(string cpf, Pessoa novaPessoa)
    {
        var pessoaExistente = pessoas.FirstOrDefault(p => p.Cpf == cpf);
        if (pessoaExistente != null)
        {
            pessoaExistente.Nome = novaPessoa.Nome;
            pessoaExistente.Peso = novaPessoa.Peso;
            pessoaExistente.Altura = novaPessoa.Altura;
            Console.WriteLine("Pessoa atualizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada.");
        }
    }

    
    public void RemoverPessoa(string cpf)
    {
        var pessoa = pessoas.FirstOrDefault(p => p.Cpf == cpf);
        if (pessoa != null)
        {
            pessoas.Remove(pessoa);
            Console.WriteLine("Pessoa removida com sucesso.");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada.");
        }
    }

    
    public void BuscarTodasPessoas()
    {
        if (pessoas.Count > 0)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, CPF: {pessoa.Cpf}, Peso: {pessoa.Peso}, Altura: {pessoa.Altura}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma pessoa encontrada.");
        }
    }

    
    public void BuscarPessoaPorCpf(string cpf)
    {
        var pessoa = pessoas.FirstOrDefault(p => p.Cpf == cpf);
        if (pessoa != null)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, CPF: {pessoa.Cpf}, Peso: {pessoa.Peso}, Altura: {pessoa.Altura}");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada.");
        }
    }

    
    public void BuscarPessoasPorNome(string nome)
    {
        var pessoasEncontradas = pessoas.Where(p => p.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();
        if (pessoasEncontradas.Count > 0)
        {
            foreach (var pessoa in pessoasEncontradas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, CPF: {pessoa.Cpf}, Peso: {pessoa.Peso}, Altura: {pessoa.Altura}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma pessoa encontrada com o nome fornecido.");
        }
    }
}
