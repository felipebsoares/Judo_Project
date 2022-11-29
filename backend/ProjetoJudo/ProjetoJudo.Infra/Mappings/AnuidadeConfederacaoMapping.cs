using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class AnuidadeConfederacaoMapping : IEntityTypeConfiguration<TbAnuidadesConfederacao>
{
    public void Configure(EntityTypeBuilder<TbAnuidadesConfederacao> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdAtleta, e.AnoBase })
            .HasName("PK_ANUIDADES_CONFEDERACAO")
            .IsClustered(false);
        builder.ToTable("TB_ANUIDADES_CONFEDERACAO");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.AnoBase)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ANO_BASE")
                    .IsFixedLength();

                builder.Property(e => e.DataPagamento).HasColumnName("DATA_PAGAMENTO");

                builder.Property(e => e.IdTabelaAnuidades).HasColumnName("ID_TABELA_ANUIDADES");

                builder.Property(e => e.IdTipoAnuidade).HasColumnName("ID_TIPO_ANUIDADE");

                builder.Property(e => e.IdTipoPagamento).HasColumnName("ID_TIPO_PAGAMENTO");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.ValorDesconto)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO");

                builder.Property(e => e.ValorPago)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_PAGO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_ATLETAS");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaAnuidades })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TABELAS_ANUIDADES_CONFEDERACAO");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoAnuidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TIPOS_ANUIDADES_CONFEDERACAO");

                builder.HasOne(d => d.Id2)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO");
    }
}