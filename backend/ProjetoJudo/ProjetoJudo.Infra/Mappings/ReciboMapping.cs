using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class ReciboMapping : IEntityTypeConfiguration<TbRecibo>
{
    public void Configure(EntityTypeBuilder<TbRecibo> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.NumeroRecibo })
            .HasName("PK_RECIBOS")
            .IsClustered(false);
        builder.ToTable("TB_RECIBOS");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.NumeroRecibo).HasColumnName("NUMERO_RECIBO");

                builder.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                builder.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                builder.Property(e => e.DataPagamento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PAGAMENTO");

                builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                builder.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                builder.Property(e => e.Origem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEM")
                    .HasDefaultValueSql("('G')")
                    .IsFixedLength();

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.ValorBonificacao)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_BONIFICACAO");

                builder.Property(e => e.ValorCartaoCredito)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_CARTAO_CREDITO");

                builder.Property(e => e.ValorCartaoDebito)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_CARTAO_DEBITO");

                builder.Property(e => e.ValorCheque)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_CHEQUE");

                builder.Property(e => e.ValorDebitoAutomatico)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DEBITO_AUTOMATICO");

                builder.Property(e => e.ValorDinheiro)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DINHEIRO");

                builder.Property(e => e.ValorPix)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_PIX");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbRecibos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbRecibos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .HasConstraintName("FK_RECIBOS_AGREMIACOES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbRecibos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .HasConstraintName("FK_RECIBOS_ATLETAS");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbRecibos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdUsuario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_USUARIOS");
    }
}