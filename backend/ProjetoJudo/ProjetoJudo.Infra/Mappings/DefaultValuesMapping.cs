using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class DefaultValuesMapping : IEntityTypeConfiguration<TbValoresDefault>
{
    public void Configure(EntityTypeBuilder<TbValoresDefault> builder)
    {
        builder.ToTable("TB_VALORES_DEFAULT");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdDefault)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_DEFAULT");

                builder.Property(e => e.AnoBase)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ANO_BASE")
                    .IsFixedLength();

                builder.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                builder.Property(e => e.DataDesfiliacaoAgremiacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_DESFILIACAO_AGREMIACAO");

                builder.Property(e => e.DataDesfiliacaoAtleta)
                    .HasColumnType("date")
                    .HasColumnName("DATA_DESFILIACAO_ATLETA");

                builder.Property(e => e.DataEventoCurriculoAgremiacao).HasColumnName("DATA_EVENTO_CURRICULO_AGREMIACAO");

                builder.Property(e => e.DataEventoCurriculoAtleta).HasColumnName("DATA_EVENTO_CURRICULO_ATLETA");

                builder.Property(e => e.DataFiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FILIACAO");

                builder.Property(e => e.DataInscricao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INSCRICAO");

                builder.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                builder.Property(e => e.DataPagamentoAnuidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PAGAMENTO_ANUIDADE");

                builder.Property(e => e.DataPagamentoMensalidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PAGAMENTO_MENSALIDADE");

                builder.Property(e => e.DataPagamentoRecibo)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PAGAMENTO_RECIBO");

                builder.Property(e => e.DataPromocaoArbitro)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PROMOCAO_ARBITRO");

                builder.Property(e => e.DataPromocaoAtleta)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PROMOCAO_ATLETA");

                builder.Property(e => e.DataTransferencia)
                    .HasColumnType("date")
                    .HasColumnName("DATA_TRANSFERENCIA");

                builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                builder.Property(e => e.IdAgremiacaoAnterior).HasColumnName("ID_AGREMIACAO_ANTERIOR");

                builder.Property(e => e.IdAgremiacaoNova).HasColumnName("ID_AGREMIACAO_NOVA");

                builder.Property(e => e.IdApoio).HasColumnName("ID_APOIO");

                builder.Property(e => e.IdArbitro).HasColumnName("ID_ARBITRO");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                builder.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                builder.Property(e => e.IdClasse).HasColumnName("ID_CLASSE");

                builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.IdEmissorIdentidade).HasColumnName("ID_EMISSOR_IDENTIDADE");

                builder.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                builder.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

                builder.Property(e => e.IdFaixa).HasColumnName("ID_FAIXA");

                builder.Property(e => e.IdFaixaAnterior).HasColumnName("ID_FAIXA_ANTERIOR");

                builder.Property(e => e.IdFaixaNova).HasColumnName("ID_FAIXA_NOVA");

                builder.Property(e => e.IdFormaPagamento).HasColumnName("ID_FORMA_PAGAMENTO");

                builder.Property(e => e.IdLocal).HasColumnName("ID_LOCAL");

                builder.Property(e => e.IdNacionalidade).HasColumnName("ID_NACIONALIDADE");

                builder.Property(e => e.IdNivelAnterior).HasColumnName("ID_NIVEL_ANTERIOR");

                builder.Property(e => e.IdNivelNovo).HasColumnName("ID_NIVEL_NOVO");

                builder.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                builder.Property(e => e.IdPatrocinador).HasColumnName("ID_PATROCINADOR");

                builder.Property(e => e.IdPenalidade).HasColumnName("ID_PENALIDADE");

                builder.Property(e => e.IdPontuacao).HasColumnName("ID_PONTUACAO");

                builder.Property(e => e.IdProfessor).HasColumnName("ID_PROFESSOR");

                builder.Property(e => e.IdProfissaoAtleta).HasColumnName("ID_PROFISSAO_ATLETA");

                builder.Property(e => e.IdProfissaoMae).HasColumnName("ID_PROFISSAO_MAE");

                builder.Property(e => e.IdProfissaoPai).HasColumnName("ID_PROFISSAO_PAI");

                builder.Property(e => e.IdRegiao).HasColumnName("ID_REGIAO");

                builder.Property(e => e.IdServico).HasColumnName("ID_SERVICO");

                builder.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                builder.Property(e => e.IdTabelaAnuidade).HasColumnName("ID_TABELA_ANUIDADE");

                builder.Property(e => e.IdTabelaMensalidade).HasColumnName("ID_TABELA_MENSALIDADE");

                builder.Property(e => e.IdTipoAnuidade).HasColumnName("ID_TIPO_ANUIDADE");

                builder.Property(e => e.IdTipoCurriculoAgremiacao).HasColumnName("ID_TIPO_CURRICULO_AGREMIACAO");

                builder.Property(e => e.IdTipoCurriculoAtleta).HasColumnName("ID_TIPO_CURRICULO_ATLETA");

                builder.Property(e => e.IdTipoDesfiliacaoAgremiacao).HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

                builder.Property(e => e.IdTipoDesfiliacaoAtleta).HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

                builder.Property(e => e.IdTipoIsencaoAgremiacao).HasColumnName("ID_TIPO_ISENCAO_AGREMIACAO");

                builder.Property(e => e.IdTipoIsencaoAtleta).HasColumnName("ID_TIPO_ISENCAO_ATLETA");

                builder.Property(e => e.IdTipoPagamentoAnuidade).HasColumnName("ID_TIPO_PAGAMENTO_ANUIDADE");

                builder.Property(e => e.IdTipoPagamentoMensalidade).HasColumnName("ID_TIPO_PAGAMENTO_MENSALIDADE");

                builder.Property(e => e.IdTipoPromocaoArbitro).HasColumnName("ID_TIPO_PROMOCAO_ARBITRO");

                builder.Property(e => e.IdTipoPromocaoAtleta).HasColumnName("ID_TIPO_PROMOCAO_ATLETA");

                builder.Property(e => e.IdTipoTransferencia).HasColumnName("ID_TIPO_TRANSFERENCIA");

                builder.Property(e => e.MesBase)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MES_BASE")
                    .IsFixedLength();

                builder.Property(e => e.Origem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEM")
                    .IsFixedLength();

                builder.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

                builder.Property(e => e.ValorAnuidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_ANUIDADE");

                builder.Property(e => e.ValorDescontoAnuidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO_ANUIDADE");

                builder.Property(e => e.ValorDescontoMensalidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO_MENSALIDADE");

                builder.Property(e => e.ValorMensalidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_MENSALIDADE");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VALORES_DEFAULT_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbValoresDefaultIds)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES1");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbValoresDefaultIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacaoAnterior })
                    .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES2");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbValoresDefaultId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacaoNova })
                    .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES3");

                builder.HasOne(d => d.Id2)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdApoio })
                    .HasConstraintName("FK_VALORES_DEFAULT_PESSOAL_APOIO");

                builder.HasOne(d => d.Id3)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdArbitro })
                    .HasConstraintName("FK_VALORES_DEFAULT_ARBITROS");

                builder.HasOne(d => d.Id4)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_ATLETAS");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCategoria })
                    .HasConstraintName("FK_VALORES_DEFAULT_CATEGORIAS");

                builder.HasOne(d => d.IdCl)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdClasse })
                    .HasConstraintName("FK_VALORES_DEFAULT_CLASSES");

                builder.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .HasConstraintName("FK_VALORES_DEFAULT_COMPETICOES");

                builder.HasOne(d => d.Id5)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEmissorIdentidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_EMISSORES_IDENTIDADES");

                builder.HasOne(d => d.Id6)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEstadoCivil })
                    .HasConstraintName("FK_VALORES_DEFAULT_ESTADOS_CIVIS");

                builder.HasOne(d => d.Id7)
                    .WithMany(p => p.TbValoresDefaultId7s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixa })
                    .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS1");

                builder.HasOne(d => d.Id8)
                    .WithMany(p => p.TbValoresDefaultId8s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixaAnterior })
                    .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS2");

                builder.HasOne(d => d.Id9)
                    .WithMany(p => p.TbValoresDefaultId9s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixaNova })
                    .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS3");

                builder.HasOne(d => d.Id10)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFormaPagamento })
                    .HasConstraintName("FK_VALORES_DEFAULT_FORMAS_PAGAMENTO");

                builder.HasOne(d => d.Id11)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdLocal })
                    .HasConstraintName("FK_VALORES_DEFAULT_LOCAIS_COMPETICOES");

                builder.HasOne(d => d.Id12)
                    .WithMany(p => p.TbValoresDefaultId12s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNacionalidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_PAISES2");

                builder.HasOne(d => d.Id13)
                    .WithMany(p => p.TbValoresDefaultId13s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivelAnterior })
                    .HasConstraintName("FK_VALORES_DEFAULT_NIVEIS_ARBITROS1");

                builder.HasOne(d => d.Id14)
                    .WithMany(p => p.TbValoresDefaultId14s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivelNovo })
                    .HasConstraintName("FK_VALORES_DEFAULT_NIVEIS_ARBITROS2");

                builder.HasOne(d => d.Id15)
                    .WithMany(p => p.TbValoresDefaultId15s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .HasConstraintName("FK_VALORES_DEFAULT_PAISES1");

                builder.HasOne(d => d.Id16)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPatrocinador })
                    .HasConstraintName("FK_VALORES_DEFAULT_PATROCINADORES");

                builder.HasOne(d => d.Id17)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPenalidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_PENALIDADES");

                builder.HasOne(d => d.Id18)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPontuacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_PONTUACOES");

                builder.HasOne(d => d.Id19)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfessor })
                    .HasConstraintName("FK_VALORES_DEFAULT_PROFESSORES");

                builder.HasOne(d => d.Id20)
                    .WithMany(p => p.TbValoresDefaultId20s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES1");

                builder.HasOne(d => d.Id21)
                    .WithMany(p => p.TbValoresDefaultId21s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoMae })
                    .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES3");

                builder.HasOne(d => d.Id22)
                    .WithMany(p => p.TbValoresDefaultId22s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoPai })
                    .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES2");

                builder.HasOne(d => d.Id23)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdRegiao })
                    .HasConstraintName("FK_VALORES_DEFAULT_REGIOES");

                builder.HasOne(d => d.Id24)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdServico })
                    .HasConstraintName("FK_VALORES_DEFAULT_TABELA_SERVICOS");

                builder.HasOne(d => d.Id25)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .HasConstraintName("FK_VALORES_DEFAULT_SEXOS");

                builder.HasOne(d => d.Id26)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaAnuidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TABELAS_ANUIDADES");

                builder.HasOne(d => d.Id27)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaMensalidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TABELAS_MENSALIDADES");

                builder.HasOne(d => d.Id28)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoAnuidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ANUIDADES");

                builder.HasOne(d => d.Id29)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoCurriculoAgremiacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_CURRICULOS_AGREMIACOES");

                builder.HasOne(d => d.Id30)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoCurriculoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_CURRICULOS_ATLETAS");

                builder.HasOne(d => d.Id31)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoDesfiliacaoAgremiacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_DESFILIACOES_AGREMIACOES");

                builder.HasOne(d => d.Id32)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoDesfiliacaoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_DESFILIACOES_ATLETAS");

                builder.HasOne(d => d.Id33)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoIsencaoAgremiacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ISENCOES_AGREMIACOES");

                builder.HasOne(d => d.Id34)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoIsencaoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ISENCOES_ATLETAS");

                builder.HasOne(d => d.Id35)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamentoAnuidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PAGAMENTOS_ANUIDADES");

                builder.HasOne(d => d.Id36)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamentoMensalidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PAGAMENTOS_MENSALIDADES");

                builder.HasOne(d => d.Id37)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPromocaoArbitro })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PROMOCOES_ARBITROS");

                builder.HasOne(d => d.Id38)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPromocaoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PROMOCOES_ATLETAS");

                builder.HasOne(d => d.Id39)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoTransferencia })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_TRANSFERENCIAS");

                builder.HasOne(d => d.Id40)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .HasConstraintName("FK_VALORES_DEFAULT_ESTADOS");

                builder.HasOne(d => d.Id41)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_CIDADES");
    }
}