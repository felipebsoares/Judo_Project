﻿using System.ComponentModel.DataAnnotations;

namespace ProjetoJudo.Application.DTOs.Atleta;

public class CreateAtletaDto
{
    public int IdAtleta { get; set; }
    public string RegistroFederacao { get; set; } = null!;
    public string? RegistroConfederacao { get; set; }
    public string Nome { get; set; } = null!;
    public DateTime DataNascimento { get; set; }
    public DateTime DataFiliacao { get; set; }
    public int IdAgremiacao { get; set; }
    public string Cep { get; set; } = null!;
    public string Endereco { get; set; } = null!;
    public string? Bairro { get; set; }
    public string? Complemento { get; set; }
    public int IdCidade { get; set; }
    public int IdEstado { get; set; }
    public int IdPais { get; set; }
    public string Telefone { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Cpf { get; set; } = null!;
    public string Identidade { get; set; } = null!;
    public DateTime DataIdentidade { get; set; }
    public int IdEmissor { get; set; }
    public int IdNacionalidade { get; set; }
    public int IdProfissaoAtleta { get; set; }
    public string? NomePai { get; set; }
    public int? IdProfissaoPai { get; set; }
    public string? NomeMae { get; set; }
    public int? IdProfissaoMae { get; set; }
    public int IdFaixa { get; set; }
    public int IdSexo { get; set; }
    public int IdEstadoCivil { get; set; }
    public string? Anotacoes { get; set; }
    public bool Selecao { get; set; }
    public int IdCliente { get; set; }
}