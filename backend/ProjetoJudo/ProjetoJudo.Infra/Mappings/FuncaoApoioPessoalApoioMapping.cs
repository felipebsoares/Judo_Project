using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class FuncaoApoioPessoalApoioMapping : IEntityTypeConfiguration<TbFuncoesApoioPessoalApoio>
{
    public void Configure(EntityTypeBuilder<TbFuncoesApoioPessoalApoio> builder)
    {
        builder.ToTable("TB_FUNCOES_APOIO_PESSOAL_APOIO");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdFuncao).HasColumnName("ID_FUNCAO");

        builder.Property(e => e.IdApoio).HasColumnName("ID_APOIO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbFuncoesApoioPessoalApoios)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbFuncoesApoioPessoalApoios)
            .HasForeignKey(d => new { d.IdCliente, d.IdApoio })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_PESSOAL_APOIO");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbFuncoesApoioPessoalApoios)
            .HasForeignKey(d => new { d.IdCliente, d.IdFuncao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_FUNCOES_APOIO");
    }
}