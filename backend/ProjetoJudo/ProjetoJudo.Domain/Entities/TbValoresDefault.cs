namespace ProjetoJudo.Domain.Entities
{
    public partial class TbValoresDefault
    {
        public int IdDefault { get; set; }
        public int? IdAtleta { get; set; }
        public int? IdAgremiacao { get; set; }
        public int? IdRegiao { get; set; }
        public int? IdProfessor { get; set; }
        public int? IdArbitro { get; set; }
        public int? IdApoio { get; set; }
        public int? IdSexo { get; set; }
        public int? IdEstadoCivil { get; set; }
        public int? IdPais { get; set; }
        public int? IdEstado { get; set; }
        public int? IdCidade { get; set; }
        public string? Bairro { get; set; }
        public int? IdNacionalidade { get; set; }
        public int? IdProfissaoAtleta { get; set; }
        public int? IdProfissaoPai { get; set; }
        public int? IdProfissaoMae { get; set; }
        public int? IdEmissorIdentidade { get; set; }
        public DateTime? DataFiliacao { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? IdCompeticao { get; set; }
        public int? IdLocal { get; set; }
        public int? IdPatrocinador { get; set; }
        public int? IdFaixa { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdClasse { get; set; }
        public int? IdPontuacao { get; set; }
        public int? IdPenalidade { get; set; }
        public DateTime? DataInscricao { get; set; }
        public string? AnoBase { get; set; }
        public int? IdTipoAnuidade { get; set; }
        public int? IdTabelaAnuidade { get; set; }
        public int? IdTipoPagamentoAnuidade { get; set; }
        public DateTime? DataPagamentoAnuidade { get; set; }
        public decimal? ValorAnuidade { get; set; }
        public decimal? ValorDescontoAnuidade { get; set; }
        public string? MesBase { get; set; }
        public int? IdTabelaMensalidade { get; set; }
        public int? IdTipoPagamentoMensalidade { get; set; }
        public DateTime? DataPagamentoMensalidade { get; set; }
        public decimal? ValorMensalidade { get; set; }
        public decimal? ValorDescontoMensalidade { get; set; }
        public DateTime? DataPromocaoAtleta { get; set; }
        public int? IdTipoPromocaoAtleta { get; set; }
        public int? IdFaixaAnterior { get; set; }
        public int? IdFaixaNova { get; set; }
        public DateTime? DataPromocaoArbitro { get; set; }
        public int? IdTipoPromocaoArbitro { get; set; }
        public int? IdNivelAnterior { get; set; }
        public int? IdNivelNovo { get; set; }
        public DateTime? DataTransferencia { get; set; }
        public int? IdTipoTransferencia { get; set; }
        public int? IdAgremiacaoAnterior { get; set; }
        public int? IdAgremiacaoNova { get; set; }
        public string? Origem { get; set; }
        public DateTime? DataPagamentoRecibo { get; set; }
        public int? IdServico { get; set; }
        public int? Quantidade { get; set; }
        public int? IdFormaPagamento { get; set; }
        public DateTime? DataDesfiliacaoAtleta { get; set; }
        public int? IdTipoDesfiliacaoAtleta { get; set; }
        public DateTime? DataDesfiliacaoAgremiacao { get; set; }
        public int? IdTipoDesfiliacaoAgremiacao { get; set; }
        public int? DataEventoCurriculoAtleta { get; set; }
        public int? IdTipoCurriculoAtleta { get; set; }
        public int? DataEventoCurriculoAgremiacao { get; set; }
        public int? IdTipoCurriculoAgremiacao { get; set; }
        public int? IdTipoIsencaoAtleta { get; set; }
        public int? IdTipoIsencaoAgremiacao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco? Id { get; set; }
        public virtual TbAgremiaco? Id1 { get; set; }
        public virtual TbFormasPagamento? Id10 { get; set; }
        public virtual TbLocaisCompetico? Id11 { get; set; }
        public virtual TbPaise? Id12 { get; set; }
        public virtual TbNiveisArbitro? Id13 { get; set; }
        public virtual TbNiveisArbitro? Id14 { get; set; }
        public virtual TbPaise? Id15 { get; set; }
        public virtual TbPatrocinadore? Id16 { get; set; }
        public virtual TbPenalidade? Id17 { get; set; }
        public virtual TbPontuaco? Id18 { get; set; }
        public virtual TbProfessore? Id19 { get; set; }
        public virtual TbPessoalApoio? Id2 { get; set; }
        public virtual TbProfisso? Id20 { get; set; }
        public virtual TbProfisso? Id21 { get; set; }
        public virtual TbProfisso? Id22 { get; set; }
        public virtual TbRegio? Id23 { get; set; }
        public virtual TbTabelaServico? Id24 { get; set; }
        public virtual TbSexo? Id25 { get; set; }
        public virtual TbTabelasAnuidade? Id26 { get; set; }
        public virtual TbTabelasMensalidade? Id27 { get; set; }
        public virtual TbTiposAnuidade? Id28 { get; set; }
        public virtual TbTiposCurriculosAgremiaco? Id29 { get; set; }
        public virtual TbArbitro? Id3 { get; set; }
        public virtual TbTiposCurriculosAtleta? Id30 { get; set; }
        public virtual TbTiposDesfiliacoesAgremiaco? Id31 { get; set; }
        public virtual TbTiposDesfiliacoesAtleta? Id32 { get; set; }
        public virtual TbTiposIsencoesAgremiaco? Id33 { get; set; }
        public virtual TbTiposIsencoesAtleta? Id34 { get; set; }
        public virtual TbTiposPagamentosAnuidade? Id35 { get; set; }
        public virtual TbTiposPagamentosMensalidade? Id36 { get; set; }
        public virtual TbTiposPromocoesArbitro? Id37 { get; set; }
        public virtual TbTiposPromocoesAtleta? Id38 { get; set; }
        public virtual TbTiposTransferencia? Id39 { get; set; }
        public virtual TbAtleta? Id4 { get; set; }
        public virtual TbEstado? Id40 { get; set; }
        public virtual TbCidade? Id41 { get; set; }
        public virtual TbEmissoresIdentidade? Id5 { get; set; }
        public virtual TbEstadosCivi? Id6 { get; set; }
        public virtual TbFaixa? Id7 { get; set; }
        public virtual TbFaixa? Id8 { get; set; }
        public virtual TbFaixa? Id9 { get; set; }
        public virtual TbCategoria? IdC { get; set; }
        public virtual TbCompetico? IdCNavigation { get; set; }
        public virtual TbClass? IdCl { get; set; }
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbAgremiaco? IdNavigation { get; set; }
    }
}
