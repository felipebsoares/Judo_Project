using Microsoft.EntityFrameworkCore;

namespace ProjetoJudo.Infra.Context
{
    public partial class JudoDesContext : DbContext
    {
        public JudoDesContext()
        {
        }

        public JudoDesContext(DbContextOptions<JudoDesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAgremiaco> TbAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbAgremiacoesProfessore> TbAgremiacoesProfessores { get; set; } = null!;
        public virtual DbSet<TbAnuidade> TbAnuidades { get; set; } = null!;
        public virtual DbSet<TbAnuidadesConfederacao> TbAnuidadesConfederacaos { get; set; } = null!;
        public virtual DbSet<TbArbitro> TbArbitros { get; set; } = null!;
        public virtual DbSet<TbAtleta> TbAtletas { get; set; } = null!;
        public virtual DbSet<TbCategoria> TbCategorias { get; set; } = null!;
        public virtual DbSet<TbCidade> TbCidades { get; set; } = null!;
        public virtual DbSet<TbClass> TbClasses { get; set; } = null!;
        public virtual DbSet<TbCliente> TbClientes { get; set; } = null!;
        public virtual DbSet<TbCobranca> TbCobrancas { get; set; } = null!;
        public virtual DbSet<TbCompetico> TbCompeticoes { get; set; } = null!;
        public virtual DbSet<TbCompeticoesArbitro> TbCompeticoesArbitros { get; set; } = null!;
        public virtual DbSet<TbCompeticoesArea> TbCompeticoesAreas { get; set; } = null!;
        public virtual DbSet<TbCompeticoesCategoria> TbCompeticoesCategorias { get; set; } = null!;
        public virtual DbSet<TbCompeticoesChafe> TbCompeticoesChaves { get; set; } = null!;
        public virtual DbSet<TbCompeticoesClass> TbCompeticoesClasses { get; set; } = null!;
        public virtual DbSet<TbCompeticoesClassesRegra> TbCompeticoesClassesRegras { get; set; } = null!;
        public virtual DbSet<TbCompeticoesFaixa> TbCompeticoesFaixas { get; set; } = null!;
        public virtual DbSet<TbCompeticoesInscrico> TbCompeticoesInscricoes { get; set; } = null!;
        public virtual DbSet<TbCompeticoesLuta> TbCompeticoesLutas { get; set; } = null!;
        public virtual DbSet<TbCompeticoesLutasPenalidade> TbCompeticoesLutasPenalidades { get; set; } = null!;
        public virtual DbSet<TbCompeticoesLutasPontuaco> TbCompeticoesLutasPontuacoes { get; set; } = null!;
        public virtual DbSet<TbCompeticoesPatrocinadore> TbCompeticoesPatrocinadores { get; set; } = null!;
        public virtual DbSet<TbCompeticoesPenalidade> TbCompeticoesPenalidades { get; set; } = null!;
        public virtual DbSet<TbCompeticoesPessoalApoio> TbCompeticoesPessoalApoios { get; set; } = null!;
        public virtual DbSet<TbCompeticoesPontuaco> TbCompeticoesPontuacoes { get; set; } = null!;
        public virtual DbSet<TbCompeticoesResultado> TbCompeticoesResultados { get; set; } = null!;
        public virtual DbSet<TbCompeticoesTabelasPeso> TbCompeticoesTabelasPesos { get; set; } = null!;
        public virtual DbSet<TbCompeticoesTecnico> TbCompeticoesTecnicos { get; set; } = null!;
        public virtual DbSet<TbCompeticoesTipo> TbCompeticoesTipos { get; set; } = null!;
        public virtual DbSet<TbCurriculosAgremiaco> TbCurriculosAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbCurriculosAtleta> TbCurriculosAtletas { get; set; } = null!;
        public virtual DbSet<TbDesfiliacoesAgremiaco> TbDesfiliacoesAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbDesfiliacoesAtleta> TbDesfiliacoesAtletas { get; set; } = null!;
        public virtual DbSet<TbEmissoresIdentidade> TbEmissoresIdentidades { get; set; } = null!;
        public virtual DbSet<TbEstado> TbEstados { get; set; } = null!;
        public virtual DbSet<TbEstadosCivi> TbEstadosCivis { get; set; } = null!;
        public virtual DbSet<TbFaixa> TbFaixas { get; set; } = null!;
        public virtual DbSet<TbFormasPagamento> TbFormasPagamentos { get; set; } = null!;
        public virtual DbSet<TbFuncoesApoio> TbFuncoesApoios { get; set; } = null!;
        public virtual DbSet<TbFuncoesApoioPessoalApoio> TbFuncoesApoioPessoalApoios { get; set; } = null!;
        public virtual DbSet<TbFuncoesMenu> TbFuncoesMenus { get; set; } = null!;
        public virtual DbSet<TbIsencoesAgremiaco> TbIsencoesAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbIsencoesAtleta> TbIsencoesAtletas { get; set; } = null!;
        public virtual DbSet<TbLocaisCompetico> TbLocaisCompeticoes { get; set; } = null!;
        public virtual DbSet<TbMensalidade> TbMensalidades { get; set; } = null!;
        public virtual DbSet<TbNiveisArbitro> TbNiveisArbitros { get; set; } = null!;
        public virtual DbSet<TbPaise> TbPaises { get; set; } = null!;
        public virtual DbSet<TbPatrocinadore> TbPatrocinadores { get; set; } = null!;
        public virtual DbSet<TbPenalidade> TbPenalidades { get; set; } = null!;
        public virtual DbSet<TbPerfi> TbPerfis { get; set; } = null!;
        public virtual DbSet<TbPerfisUsuario> TbPerfisUsuarios { get; set; } = null!;
        public virtual DbSet<TbPermisso> TbPermissoes { get; set; } = null!;
        public virtual DbSet<TbPessoalApoio> TbPessoalApoios { get; set; } = null!;
        public virtual DbSet<TbPontuaco> TbPontuacoes { get; set; } = null!;
        public virtual DbSet<TbProfessore> TbProfessores { get; set; } = null!;
        public virtual DbSet<TbProfisso> TbProfissoes { get; set; } = null!;
        public virtual DbSet<TbPromocoesArbitro> TbPromocoesArbitros { get; set; } = null!;
        public virtual DbSet<TbPromocoesAtleta> TbPromocoesAtletas { get; set; } = null!;
        public virtual DbSet<TbRecibo> TbRecibos { get; set; } = null!;
        public virtual DbSet<TbRecibosIten> TbRecibosItens { get; set; } = null!;
        public virtual DbSet<TbRegio> TbRegioes { get; set; } = null!;
        public virtual DbSet<TbRegistroEvento> TbRegistroEventos { get; set; } = null!;
        public virtual DbSet<TbSexo> TbSexos { get; set; } = null!;
        public virtual DbSet<TbSistema> TbSistemas { get; set; } = null!;
        public virtual DbSet<TbSistemasMensagen> TbSistemasMensagens { get; set; } = null!;
        public virtual DbSet<TbSistemasTiposMensagen> TbSistemasTiposMensagens { get; set; } = null!;
        public virtual DbSet<TbTabelaPeso> TbTabelaPesos { get; set; } = null!;
        public virtual DbSet<TbTabelaServico> TbTabelaServicos { get; set; } = null!;
        public virtual DbSet<TbTabelasAnuidade> TbTabelasAnuidades { get; set; } = null!;
        public virtual DbSet<TbTabelasAnuidadesConfederacao> TbTabelasAnuidadesConfederacaos { get; set; } = null!;
        public virtual DbSet<TbTabelasMensalidade> TbTabelasMensalidades { get; set; } = null!;
        public virtual DbSet<TbTiposAnuidade> TbTiposAnuidades { get; set; } = null!;
        public virtual DbSet<TbTiposAnuidadesConfederacao> TbTiposAnuidadesConfederacaos { get; set; } = null!;
        public virtual DbSet<TbTiposCurriculosAgremiaco> TbTiposCurriculosAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbTiposCurriculosAtleta> TbTiposCurriculosAtletas { get; set; } = null!;
        public virtual DbSet<TbTiposDesfiliacoesAgremiaco> TbTiposDesfiliacoesAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbTiposDesfiliacoesAtleta> TbTiposDesfiliacoesAtletas { get; set; } = null!;
        public virtual DbSet<TbTiposIsencoesAgremiaco> TbTiposIsencoesAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbTiposIsencoesAtleta> TbTiposIsencoesAtletas { get; set; } = null!;
        public virtual DbSet<TbTiposItensRecibo> TbTiposItensRecibos { get; set; } = null!;
        public virtual DbSet<TbTiposOperaco> TbTiposOperacoes { get; set; } = null!;
        public virtual DbSet<TbTiposPagamentosAnuidade> TbTiposPagamentosAnuidades { get; set; } = null!;
        public virtual DbSet<TbTiposPagamentosAnuidadesConfederacao> TbTiposPagamentosAnuidadesConfederacaos { get; set; } = null!;
        public virtual DbSet<TbTiposPagamentosMensalidade> TbTiposPagamentosMensalidades { get; set; } = null!;
        public virtual DbSet<TbTiposPromocoesArbitro> TbTiposPromocoesArbitros { get; set; } = null!;
        public virtual DbSet<TbTiposPromocoesAtleta> TbTiposPromocoesAtletas { get; set; } = null!;
        public virtual DbSet<TbTiposTransferencia> TbTiposTransferencias { get; set; } = null!;
        public virtual DbSet<TbTransferencia> TbTransferencias { get; set; } = null!;
        public virtual DbSet<TbUsuario> TbUsuarios { get; set; } = null!;
        public virtual DbSet<TbValoresDefault> TbValoresDefaults { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=JUDO_DES;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao })
                    .HasName("PK_AGREMIACOES")
                    .IsClustered(false);

                entity.ToTable("TB_AGREMIACOES");

                entity.HasIndex(e => new { e.IdCliente, e.Cnpj }, "UK_AGREMIACOES_CNPJ")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_AGREMIACOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAgremiacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.AlvaraLocacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALVARA_LOCACAO")
                    .IsFixedLength();

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.ContratoSocial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONTRATO_SOCIAL")
                    .IsFixedLength();

                entity.Property(e => e.DataAta)
                    .HasColumnType("date")
                    .HasColumnName("DATA_ATA");

                entity.Property(e => e.DataCnpj)
                    .HasColumnType("date")
                    .HasColumnName("DATA_CNPJ");

                entity.Property(e => e.DataFiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FILIACAO");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                entity.Property(e => e.DocumentacaoAtualizada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTACAO_ATUALIZADA")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.Estatuto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUTO")
                    .IsFixedLength();

                entity.Property(e => e.Fantasia)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FANTASIA");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.IdRegiao).HasColumnName("ID_REGIAO");

                entity.Property(e => e.InscricaoEstadual)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO_ESTADUAL");

                entity.Property(e => e.InscricaoMunicipal)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO_MUNICIPAL");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Representante)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("REPRESENTANTE");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSAVEL");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_PAISES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdRegiao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_REGIOES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_ESTADOS");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_CIDADES");
            });

            modelBuilder.Entity<TbAgremiacoesProfessore>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.IdProfessor })
                    .HasName("PK_AGREMIACOES_PROFESSORES")
                    .IsClustered(false);

                entity.ToTable("TB_AGREMIACOES_PROFESSORES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.IdProfessor).HasColumnName("ID_PROFESSOR");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INICIO");

                entity.Property(e => e.IdTipoProfessor).HasColumnName("ID_TIPO_PROFESSOR");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAgremiacoesProfessores)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_PROFESSORES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbAgremiacoesProfessores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_PROFESSORES_AGREMIACOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbAgremiacoesProfessores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfessor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_PROFESSORES_PROFESSORES");
            });

            modelBuilder.Entity<TbAnuidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.AnoBase })
                    .HasName("PK_ANUIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_ANUIDADES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.AnoBase)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ANO_BASE")
                    .IsFixedLength();

                entity.Property(e => e.DataPagamento).HasColumnName("DATA_PAGAMENTO");

                entity.Property(e => e.IdTabelaAnuidades).HasColumnName("ID_TABELA_ANUIDADES");

                entity.Property(e => e.IdTipoAnuidade).HasColumnName("ID_TIPO_ANUIDADE");

                entity.Property(e => e.IdTipoPagamento).HasColumnName("ID_TIPO_PAGAMENTO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorDesconto)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO");

                entity.Property(e => e.ValorPago)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_PAGO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAnuidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbAnuidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbAnuidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaAnuidades })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_TABELAS_ANUIDADES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbAnuidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoAnuidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_TIPOS_ANUIDADES");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbAnuidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_TIPOS_PAGAMENTOS_ANUIDADES");
            });

            modelBuilder.Entity<TbAnuidadesConfederacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.AnoBase })
                    .HasName("PK_ANUIDADES_CONFEDERACAO")
                    .IsClustered(false);

                entity.ToTable("TB_ANUIDADES_CONFEDERACAO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.AnoBase)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ANO_BASE")
                    .IsFixedLength();

                entity.Property(e => e.DataPagamento).HasColumnName("DATA_PAGAMENTO");

                entity.Property(e => e.IdTabelaAnuidades).HasColumnName("ID_TABELA_ANUIDADES");

                entity.Property(e => e.IdTipoAnuidade).HasColumnName("ID_TIPO_ANUIDADE");

                entity.Property(e => e.IdTipoPagamento).HasColumnName("ID_TIPO_PAGAMENTO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorDesconto)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO");

                entity.Property(e => e.ValorPago)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_PAGO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaAnuidades })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TABELAS_ANUIDADES_CONFEDERACAO");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoAnuidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TIPOS_ANUIDADES_CONFEDERACAO");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbAnuidadesConfederacaos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO");
            });

            modelBuilder.Entity<TbArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdArbitro })
                    .HasName("PK_ARBITROS")
                    .IsClustered(false);

                entity.ToTable("TB_ARBITROS");

                entity.HasIndex(e => new { e.IdCliente, e.Apelido }, "UK_ARBITROS_APELIDOS")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Cpf }, "UK_ARBITROS_CPF")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdArbitro)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_ARBITRO");

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.Apelido)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APELIDO");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataIdentidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_IDENTIDADE");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdEmissor).HasColumnName("ID_EMISSOR");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

                entity.Property(e => e.IdNacionalidade).HasColumnName("ID_NACIONALIDADE");

                entity.Property(e => e.IdNivel).HasColumnName("ID_NIVEL");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.Identidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDENTIDADE");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEmissor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_EMISSORES_IDENTIDADES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEstadoCivil })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_ESTADOS_CIVIS");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbArbitroId2s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNacionalidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_PAISES1");

                entity.HasOne(d => d.Id3)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivel })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_NIVEIS_ARBITROS");

                entity.HasOne(d => d.Id4)
                    .WithMany(p => p.TbArbitroId4s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_PAISES");

                entity.HasOne(d => d.Id5)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_SEXOS");

                entity.HasOne(d => d.Id6)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_ESTADOS");

                entity.HasOne(d => d.Id7)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_CIDADES");
            });

            modelBuilder.Entity<TbAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta })
                    .HasName("PK_ATLETAS")
                    .IsClustered(false);

                entity.ToTable("TB_ATLETAS");

                entity.HasIndex(e => new { e.IdCliente, e.Cpf }, "UK_ATLETAS_CPF")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.RegistroConfederacao }, "UK_ATLETAS_REGISTRO_CONFEDERACAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.RegistroFederacao }, "UK_ATLETAS_REGISTRO_FEDERACAO")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAtleta)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_ATLETA");

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataFiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FILIACAO");

                entity.Property(e => e.DataIdentidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_IDENTIDADE");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdEmissor).HasColumnName("ID_EMISSOR");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

                entity.Property(e => e.IdFaixa).HasColumnName("ID_FAIXA");

                entity.Property(e => e.IdNacionalidade).HasColumnName("ID_NACIONALIDADE");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.IdProfissaoAtleta).HasColumnName("ID_PROFISSAO_ATLETA");

                entity.Property(e => e.IdProfissaoMae).HasColumnName("ID_PROFISSAO_MAE");

                entity.Property(e => e.IdProfissaoPai).HasColumnName("ID_PROFISSAO_PAI");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.Identidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDENTIDADE");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.NomeMae)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME_MAE");

                entity.Property(e => e.NomePai)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME_PAI");

                entity.Property(e => e.RegistroConfederacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REGISTRO_CONFEDERACAO");

                entity.Property(e => e.RegistroFederacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REGISTRO_FEDERACAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_AGREMIACOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEmissor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_EMISSORES_IDENTIDADES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEstadoCivil })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_ESTADOS_CIVIS");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_FAIXAS");

                entity.HasOne(d => d.Id3)
                    .WithMany(p => p.TbAtletaId3s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNacionalidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_PAISES1");

                entity.HasOne(d => d.Id4)
                    .WithMany(p => p.TbAtletaId4s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_PAISES");

                entity.HasOne(d => d.Id5)
                    .WithMany(p => p.TbAtletaId5s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_PROFISSOES1");

                entity.HasOne(d => d.Id6)
                    .WithMany(p => p.TbAtletaId6s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoMae })
                    .HasConstraintName("FK_ATLETAS_PROFISSOES3");

                entity.HasOne(d => d.Id7)
                    .WithMany(p => p.TbAtletaId7s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoPai })
                    .HasConstraintName("FK_ATLETAS_PROFISSOES2");

                entity.HasOne(d => d.Id8)
                    .WithMany(p => p.TbAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_SEXOS");

                entity.HasOne(d => d.Id9)
                    .WithMany(p => p.TbAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_ESTADOS");

                entity.HasOne(d => d.Id10)
                    .WithMany(p => p.TbAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATLETAS_CIDADES");
            });

            modelBuilder.Entity<TbCategoria>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCategoria })
                    .HasName("PK_CATEGORIAS")
                    .IsClustered(false);

                entity.ToTable("TB_CATEGORIAS");

                entity.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_CATEGORIAS_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_CATEGORIAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCategoria)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCategoria)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORIAS_CLIENTES");
            });

            modelBuilder.Entity<TbCidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPais, e.IdEstado, e.IdCidade })
                    .HasName("PK_CIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_CIDADES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdCidade)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CIDADE");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CIDADES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CIDADES_PAIS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CIDADES_ESTADOS");
            });

            modelBuilder.Entity<TbClass>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdClasse })
                    .HasName("PK_CLASSES")
                    .IsClustered(false);

                entity.ToTable("TB_CLASSES");

                entity.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_CLASSES_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla, e.IdSexo }, "UK_CLASSES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdClasse)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CLASSE");

                entity.Property(e => e.Descricao1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO1");

                entity.Property(e => e.Descricao2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO2");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.IdadeFinal).HasColumnName("IDADE_FINAL");

                entity.Property(e => e.IdadeInicial).HasColumnName("IDADE_INICIAL");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbClasses)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbClasses)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSES_SEXOS");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_CLIENTES")
                    .IsClustered(false);

                entity.ToTable("TB_CLIENTES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdSistema).HasColumnName("ID_SISTEMA");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.PastaArquivos)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASTA_ARQUIVOS");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.TbClientes)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTES_SISTEMAS");
            });

            modelBuilder.Entity<TbCobranca>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCobranca })
                    .HasName("PK_COBRANCAS")
                    .IsClustered(false);

                entity.ToTable("TB_COBRANCAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCobranca)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_COBRANCA");

                entity.Property(e => e.DataCobranca)
                    .HasColumnType("date")
                    .HasColumnName("DATA_COBRANCA");

                entity.Property(e => e.DataVencimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_VENCIMENTO");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.MesBase)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MES_BASE")
                    .IsFixedLength();

                entity.Property(e => e.Oficio)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OFICIO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorCobranca)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_COBRANCA");

                entity.Property(e => e.ValorDesconto)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCobrancas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COBRANCAS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCobrancas)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COBRANCAS_AGREMIACOES");
            });

            modelBuilder.Entity<TbCompetico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao })
                    .HasName("PK_COMPETICOES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_COMPETICOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.DataFinal)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FINAL");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INICIO");

                entity.Property(e => e.Descricao1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO1");

                entity.Property(e => e.Descricao2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO2");

                entity.Property(e => e.IdLocal).HasColumnName("ID_LOCAL");

                entity.Property(e => e.IdTipoCompeticao).HasColumnName("ID_TIPO_COMPETICAO");

                entity.Property(e => e.IdadeMaxima).HasColumnName("IDADE_MAXIMA");

                entity.Property(e => e.IdadeMinima).HasColumnName("IDADE_MINIMA");

                entity.Property(e => e.PesoRanking).HasColumnName("PESO_RANKING");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdLocal })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LOCAIS_COMPETICOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_COMPETICOES_TIPO");
            });

            modelBuilder.Entity<TbCompeticoesArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdArbitro })
                    .HasName("PK_COMPETICOES_ARBITROS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_ARBITROS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdArbitro).HasColumnName("ID_ARBITRO");

                entity.Property(e => e.Presente)
                    .IsRequired()
                    .HasColumnName("PRESENTE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesArbitros)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_ARBITROS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdArbitro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_ARBITROS_ARBITROS");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_ARBITROS_COMPETICOES");
            });

            modelBuilder.Entity<TbCompeticoesArea>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdArea })
                    .HasName("PK_COMPETICOES_AREAS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_AREAS");

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla }, "UK_COMPETICOES_AREAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdArea)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_AREA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesAreas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_AREAS_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesAreas)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_AREAS_COMPETICOES");
            });

            modelBuilder.Entity<TbCompeticoesCategoria>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdCategoria })
                    .HasName("PK_COMPETICOES_CATEGORIAS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_CATEGORIAS");

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicao }, "UK_COMPETICOES_CATEGORIAS_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdCategoria)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesCategoria)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CATEGORIAS_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesCategoria)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CATEGORIAS_COMPETICOES");
            });

            modelBuilder.Entity<TbCompeticoesChafe>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdChave })
                    .HasName("PK_COMPETICOES_CHAVES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_CHAVES");

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicaoChave }, "UK_COMPETICOES_CHAVES_ORDENS_EXIBICAO_CHAVES")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdChave)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CHAVE");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdClasse).HasColumnName("ID_CLASSE");

                entity.Property(e => e.IdFaixaFinal).HasColumnName("ID_FAIXA_FINAL");

                entity.Property(e => e.IdFaixaInicial).HasColumnName("ID_FAIXA_INICIAL");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.OrdemExibicaoChave).HasColumnName("ORDEM_EXIBICAO_CHAVE");

                entity.Property(e => e.PesoRanking).HasColumnName("PESO_RANKING");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_SEXOS");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdCategoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_CATEGORIAS");

                entity.HasOne(d => d.IdC1)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdClasse })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_CLASSES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesChafeIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdFaixaFinal })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_FAIXAS2");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesChafeId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdFaixaInicial })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_FAIXAS1");
            });

            modelBuilder.Entity<TbCompeticoesClass>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdClasse })
                    .HasName("PK_COMPETICOES_CLASSES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_CLASSES");

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicao }, "UK_COMPETICOES_CLASSES_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla, e.IdSexo }, "UK_COMPETICOES_CLASSES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdClasse)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CLASSE");

                entity.Property(e => e.Descricao1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO1");

                entity.Property(e => e.Descricao2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO2");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.IdadeFinal).HasColumnName("IDADE_FINAL");

                entity.Property(e => e.IdadeInicial).HasColumnName("IDADE_INICIAL");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesClasses)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLASSES_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesClasses)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLASSES_COMPETICOES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesClasses)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLASSES_SEXOS");
            });

            modelBuilder.Entity<TbCompeticoesClassesRegra>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdClasseReal, e.IdClasseInscricao })
                    .HasName("PK_COMPETICOES_CLASSES_REGRAS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_CLASSES_REGRAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdClasseReal).HasColumnName("ID_CLASSE_REAL");

                entity.Property(e => e.IdClasseInscricao).HasColumnName("ID_CLASSE_INSCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesClassesRegras)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesClassesRegras)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesClassesRegraIdCNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdClasseInscricao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES_CLASSES2");

                entity.HasOne(d => d.IdC1)
                    .WithMany(p => p.TbCompeticoesClassesRegraIdC1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdClasseReal })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES_CLASSES1");
            });

            modelBuilder.Entity<TbCompeticoesFaixa>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdFaixa })
                    .HasName("PK_COMPETICOES_FAIXAS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_FAIXAS");

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicao }, "UK_COMPETICOES_FAIXAS_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla }, "UK_COMPETICOES_FAIXAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdFaixa)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_FAIXA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesFaixas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_FAIXAS_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesFaixas)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_FAIXAS_COMPETICOES");
            });

            modelBuilder.Entity<TbCompeticoesInscrico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdInscricao })
                    .HasName("PK_COMPETICOES_INSCRICOES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_INSCRICOES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdInscricao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_INSCRICAO");

                entity.Property(e => e.DataInscricao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INSCRICAO");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.IdChave).HasColumnName("ID_CHAVE");

                entity.Property(e => e.IdFaixa).HasColumnName("ID_FAIXA");

                entity.Property(e => e.Peso).HasColumnName("PESO");

                entity.Property(e => e.Presente)
                    .IsRequired()
                    .HasColumnName("PRESENTE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_AGREMIACOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_ATLETAS");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdChave })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES_CHAVES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdFaixa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES_FAIXAS");
            });

            modelBuilder.Entity<TbCompeticoesLuta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta })
                    .HasName("PK_COMPETICOES_LUTAS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_LUTAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdLuta)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_LUTA");

                entity.Property(e => e.DataFinal)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FINAL");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INICIO");

                entity.Property(e => e.IdAtleta1).HasColumnName("ID_ATLETA1");

                entity.Property(e => e.IdAtleta2).HasColumnName("ID_ATLETA2");

                entity.Property(e => e.IdAtletaVencedor).HasColumnName("ID_ATLETA_VENCEDOR");

                entity.Property(e => e.IdChave).HasColumnName("ID_CHAVE");

                entity.Property(e => e.OrdemAtleta1Chave).HasColumnName("ORDEM_ATLETA1_CHAVE");

                entity.Property(e => e.OrdemAtleta2Chave).HasColumnName("ORDEM_ATLETA2_CHAVE");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesLuta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesLutaIds)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta1 })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS1");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesLutaIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta2 })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS2");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesLutaId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtletaVencedor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS3");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesLuta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_COMPETICOES");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesLuta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdChave })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_COMPETICOES_CHAVES");
            });

            modelBuilder.Entity<TbCompeticoesLutasPenalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta, e.Tempo })
                    .HasName("PK_COMPETICOES_LUTAS_PENALIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_LUTAS_PENALIDADES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdLuta).HasColumnName("ID_LUTA");

                entity.Property(e => e.Tempo).HasColumnName("TEMPO");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.IdPenalidade).HasColumnName("ID_PENALIDADE");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_ATLETAS");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_COMPETICOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdLuta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_LUTAS");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdPenalidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_COMPETICOES_PENALIDADES");
            });

            modelBuilder.Entity<TbCompeticoesLutasPontuaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta, e.Tempo })
                    .HasName("PK_COMPETICOES_LUTAS_PONTUACOES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_LUTAS_PONTUACOES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdLuta).HasColumnName("ID_LUTA");

                entity.Property(e => e.Tempo).HasColumnName("TEMPO");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.IdPontuacao).HasColumnName("ID_PONTUACAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_ATLETAS");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_COMPETICOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdLuta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_LUTAS");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdPontuacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_COMPETICOES_PONTUACOES");
            });

            modelBuilder.Entity<TbCompeticoesPatrocinadore>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPatrocinador })
                    .HasName("PK_COMPETICOES_PATROCINADORES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_PATROCINADORES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdPatrocinador).HasColumnName("ID_PATROCINADOR");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesPatrocinadores)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PATROCINADORES_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesPatrocinadores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PATROCINADORES_COMPETICOES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesPatrocinadores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPatrocinador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PATROCINADORES_PATROCINADORES");
            });

            modelBuilder.Entity<TbCompeticoesPenalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPenalidade })
                    .HasName("PK_COMPETICOES_PENALIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_PENALIDADES");

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicao }, "UK_COMPETICOES_PENALIDADES_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla }, "UK_COMPETICOES_PENALIDADES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdPenalidade)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PENALIDADE");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesPenalidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PENALIDADES_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PENALIDADES_COMPETICOES");
            });

            modelBuilder.Entity<TbCompeticoesPessoalApoio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdApoio, e.IdFuncao })
                    .HasName("PK_COMPETICOES_PESSOAL_APOIO")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_PESSOAL_APOIO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdApoio).HasColumnName("ID_APOIO");

                entity.Property(e => e.IdFuncao).HasColumnName("ID_FUNCAO");

                entity.Property(e => e.Presente)
                    .IsRequired()
                    .HasColumnName("PRESENTE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesPessoalApoios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIOS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdApoio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_PESSOAL_APOIO");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_COMPETICOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFuncao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_FUNCOES_APOIO");
            });

            modelBuilder.Entity<TbCompeticoesPontuaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPontuacao })
                    .HasName("PK_COMPETICOES_PONTUACOES")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_PONTUACOES");

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicao }, "UK_COMPETICOES_PONTUACOES_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla }, "UK_COMPETICOES_PONTUACOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdPontuacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PONTUACAO");

                entity.Property(e => e.DscPontuacao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DSC_PONTUACAO");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesPontuacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PONTUACOES_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_PONTUACOES_COMPETICOES");
            });

            modelBuilder.Entity<TbCompeticoesResultado>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdChave, e.IdAtleta })
                    .HasName("PK_COMPETICOES_RESULTADOS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_RESULTADOS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdChave).HasColumnName("ID_CHAVE");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.Colocacao).HasColumnName("COLOCACAO");

                entity.Property(e => e.DataResultado)
                    .HasColumnType("date")
                    .HasColumnName("DATA_RESULTADO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesResultados)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_RESULTADOS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesResultados)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_RESULTADOS_ATLETAS");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesResultados)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_RESULTADOS_COMPETICOES");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesResultados)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdChave })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_RESULTADOS_CHAVES");
            });

            modelBuilder.Entity<TbCompeticoesTabelasPeso>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdClasse, e.IdCategoria })
                    .HasName("PK_COMPETICOES_TABELAS_PESOS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_TABELAS_PESOS");

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicaoCategoria }, "UK_COMPETICOES_TABELAS_PESOS_ORDENS_EXIBICAO_CATEGORIAS")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicaoClasse }, "UK_COMPETICOES_TABELAS_PESOS_ORDENS_EXIBICAO_CLASSES")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdClasse).HasColumnName("ID_CLASSE");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.OrdemExibicaoCategoria).HasColumnName("ORDEM_EXIBICAO_CATEGORIA");

                entity.Property(e => e.OrdemExibicaoClasse).HasColumnName("ORDEM_EXIBICAO_CLASSE");

                entity.Property(e => e.PesoFinal).HasColumnName("PESO_FINAL");

                entity.Property(e => e.PesoInicial).HasColumnName("PESO_INICIAL");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_SEXOS");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdCategoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES_CATEGORIAS");

                entity.HasOne(d => d.IdC1)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdClasse })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES_CLASSES");
            });

            modelBuilder.Entity<TbCompeticoesTecnico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdAgremiacao, e.IdProfessor })
                    .HasName("PK_COMPETICOES_TECNICOS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_TECNICOS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.IdProfessor).HasColumnName("ID_PROFESSOR");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesTecnicos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TECNICOS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesTecnicos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TECNICOS_AGREMIACOES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesTecnicos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TECNICOS_COMPETICOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesTecnicos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfessor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TECNICOS_PROFESSORES");
            });

            modelBuilder.Entity<TbCompeticoesTipo>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoCompeticao })
                    .HasName("PK_COMPETICOES_TIPOS")
                    .IsClustered(false);

                entity.ToTable("TB_COMPETICOES_TIPOS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_COMPETICOES_TIPOS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoCompeticao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_COMPETICAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesTipos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TIPOS_CLIENTES");
            });

            modelBuilder.Entity<TbCurriculosAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.DataEvento })
                    .HasName("PK_CURRICULOS_AGREMIACOES")
                    .IsClustered(false);

                entity.ToTable("TB_CURRICULOS_AGREMIACOES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.DataEvento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_EVENTO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdTipoCurriculoAgremiacao).HasColumnName("ID_TIPO_CURRICULO_AGREMIACAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCurriculosAgremiacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURRICULOS_AGREMIACOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCurriculosAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURRICULOS_AGREMIACOES_AGREMIACOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCurriculosAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoCurriculoAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURRICULOS_AGREMIACOES_TIPOS_CURRICULOS_AGREMIACOES");
            });

            modelBuilder.Entity<TbCurriculosAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataEvento })
                    .HasName("PK_CURRICULOS_ATLETAS")
                    .IsClustered(false);

                entity.ToTable("TB_CURRICULOS_ATLETAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.DataEvento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_EVENTO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdTipoCurriculoAtleta).HasColumnName("ID_TIPO_CURRICULO_ATLETA");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCurriculosAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURRICULOS_ATLETAS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbCurriculosAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURRICULOS_ATLETAS_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCurriculosAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoCurriculoAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURRICULOS_ATLETAS_TIPOS_CURRICULOS_ATLETAS");
            });

            modelBuilder.Entity<TbDesfiliacoesAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.DataDesfiliacao })
                    .HasName("PK_DESFILIACOES_AGREMIACOES")
                    .IsClustered(false);

                entity.ToTable("TB_DESFILIACOES_AGREMIACOES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.DataDesfiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_DESFILIACAO");

                entity.Property(e => e.DataRefiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_REFILIACAO");

                entity.Property(e => e.IdTipoDesfiliacaoAgremiacao).HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbDesfiliacoesAgremiacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbDesfiliacoesAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_AGREMIACOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbDesfiliacoesAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoDesfiliacaoAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_TIPOS_DESFILIACOES_AGREMIACOES");
            });

            modelBuilder.Entity<TbDesfiliacoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataDesfiliacao })
                    .HasName("PK_DESFILIACOES_ATLETAS")
                    .IsClustered(false);

                entity.ToTable("TB_DESFILIACOES_ATLETAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.DataDesfiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_DESFILIACAO");

                entity.Property(e => e.DataRefiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_REFILIACAO");

                entity.Property(e => e.IdTipoDesfiliacaoAtleta).HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbDesfiliacoesAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DESFILIACOES_ATLETAS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbDesfiliacoesAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DESFILIACOES_ATLETAS_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbDesfiliacoesAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoDesfiliacaoAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DESFILIACOES_ATLETAS_TIPOS_DESFILIACOES_ATLETAS");
            });

            modelBuilder.Entity<TbEmissoresIdentidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdEmissor })
                    .HasName("PK_EMISSORES_IDENTIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_EMISSORES_IDENTIDADES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_EMISSORES_IDENTIDADES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEmissor)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_EMISSOR");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbEmissoresIdentidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMISSORES_IDENTIDADES_CLIENTES");
            });

            modelBuilder.Entity<TbEstado>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPais, e.IdEstado })
                    .HasName("PK_ESTADOS")
                    .IsClustered(false);

                entity.ToTable("TB_ESTADOS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.IdEstado)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_ESTADO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbEstados)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESTADOS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbEstados)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESTADOS_PAISES");
            });

            modelBuilder.Entity<TbEstadosCivi>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdEstadoCivil })
                    .HasName("PK_ESTADO_CIVIL")
                    .IsClustered(false);

                entity.ToTable("TB_ESTADOS_CIVIS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");
            });

            modelBuilder.Entity<TbFaixa>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFaixa })
                    .HasName("PK_FAIXAS")
                    .IsClustered(false);

                entity.ToTable("TB_FAIXAS");

                entity.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_FAIXAS_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_FAIXAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFaixa)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_FAIXA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdadeMinima).HasColumnName("IDADE_MINIMA");

                entity.Property(e => e.MesesCarencia).HasColumnName("MESES_CARENCIA");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbFaixas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAIXAS_CLIENTES");
            });

            modelBuilder.Entity<TbFormasPagamento>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFormaPagamento })
                    .HasName("PK_FORMAS_PAGAMENTOS")
                    .IsClustered(false);

                entity.ToTable("TB_FORMAS_PAGAMENTOS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_FORMAS_PAGAMENTOS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFormaPagamento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_FORMA_PAGAMENTO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbFormasPagamentos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORMAS_PAGAMENTOS_CLIENTES");
            });

            modelBuilder.Entity<TbFuncoesApoio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFuncao })
                    .HasName("PK_FUNCOES_APOIO")
                    .IsClustered(false);

                entity.ToTable("TB_FUNCOES_APOIO");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_FUNCOES_APOIO_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFuncao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_FUNCAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbFuncoesApoios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FUNCOES_APOIO_CLIENTES");
            });

            modelBuilder.Entity<TbFuncoesApoioPessoalApoio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFuncao, e.IdApoio })
                    .IsClustered(false);

                entity.ToTable("TB_FUNCOES_APOIO_PESSOAL_APOIO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFuncao).HasColumnName("ID_FUNCAO");

                entity.Property(e => e.IdApoio).HasColumnName("ID_APOIO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbFuncoesApoioPessoalApoios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbFuncoesApoioPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdApoio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_PESSOAL_APOIO");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbFuncoesApoioPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFuncao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_FUNCOES_APOIO");
            });

            modelBuilder.Entity<TbFuncoesMenu>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFuncaoMenu })
                    .HasName("PK_FUNCOES_MENU")
                    .IsClustered(false);

                entity.ToTable("TB_FUNCOES_MENU");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_FUNCOES_MENU_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFuncaoMenu)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_FUNCAO_MENU");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Anotacoes).HasColumnName("ANOTACOES");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Foto).HasColumnName("FOTO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbFuncoesMenus)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FUNCOES_MENU_CLIENTES");
            });

            modelBuilder.Entity<TbIsencoesAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.DataInicio })
                    .HasName("PK_ISENCOES_AGREMIACOES")
                    .IsClustered(false);

                entity.ToTable("TB_ISENCOES_AGREMIACOES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INICIO");

                entity.Property(e => e.DataFim)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FIM");

                entity.Property(e => e.IdTipoIsencaoAgremiacao).HasColumnName("ID_TIPO_ISENCAO_AGREMIACAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbIsencoesAgremiacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ISENCOES_AGREMIACOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbIsencoesAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ISENCOES_AGREMIACOES_AGREMIACOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbIsencoesAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoIsencaoAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ISENCOES_AGREMIACOES_TIPOS_ISENCOES_AGREMIACOES");
            });

            modelBuilder.Entity<TbIsencoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataInicio })
                    .HasName("PK_ISENCOES_ATLETAS")
                    .IsClustered(false);

                entity.ToTable("TB_ISENCOES_ATLETAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INICIO");

                entity.Property(e => e.DataFim)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FIM");

                entity.Property(e => e.IdTipoIsencaoAtleta).HasColumnName("ID_TIPO_ISENCAO_ATLETA");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbIsencoesAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ISENCOES_ATLETAS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbIsencoesAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ISENCOES_ATLETAS_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbIsencoesAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoIsencaoAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ISENCOES_ATLETAS_TIPOS_ISENCOES_ATLETAS");
            });

            modelBuilder.Entity<TbLocaisCompetico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdLocal })
                    .HasName("PK_LOCAIS_COMPETICOES")
                    .IsClustered(false);

                entity.ToTable("TB_LOCAIS_COMPETICOES");

                entity.HasIndex(e => new { e.IdCliente, e.Cnpj }, "UK_LOCAIS_COMPETICOES_CNPJ")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_LOCAIS_COMPETICOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdLocal)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_LOCAL");

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.InscricaoEstadual)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO_ESTADUAL");

                entity.Property(e => e.InscricaoMunicipal)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO_MUNICIPAL");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.QtdLugares).HasColumnName("QTD_LUGARES");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSAVEL");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbLocaisCompeticos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCAIS_COMPETICOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbLocaisCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCAIS_COMPETICOES_PAISES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbLocaisCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCAIS_COMPETICOES_ESTADOS");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbLocaisCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCAIS_COMPETICOES_CIDADES");
            });

            modelBuilder.Entity<TbMensalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.MesBase })
                    .HasName("PK_MENSALIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_MENSALIDADES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.MesBase)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MES_BASE")
                    .IsFixedLength();

                entity.Property(e => e.DataPagamento).HasColumnName("DATA_PAGAMENTO");

                entity.Property(e => e.IdTabelaMensalidades).HasColumnName("ID_TABELA_MENSALIDADES");

                entity.Property(e => e.IdTipoPagamento).HasColumnName("ID_TIPO_PAGAMENTO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorDesconto)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO");

                entity.Property(e => e.ValorPago)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_PAGO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbMensalidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENSALIDADES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbMensalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENSALIDADES_AGREMIACOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbMensalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaMensalidades })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENSALIDADES_TABELAS_MENSALIDADES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbMensalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENSALIDADES_TIPOS_PAGAMENTOS_MENSALIDADES");
            });

            modelBuilder.Entity<TbNiveisArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdNivelArbitro })
                    .HasName("PK_NIVEIS_ARBITROS")
                    .IsClustered(false);

                entity.ToTable("TB_NIVEIS_ARBITROS");

                entity.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_NIVEIS_ARBITROS_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_NIVEIS_ARBITROS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdNivelArbitro)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_NIVEL_ARBITRO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbNiveisArbitros)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NIVEIS_ARBITROS_CLIENTES");
            });

            modelBuilder.Entity<TbPaise>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPais })
                    .HasName("PK_PAISES")
                    .IsClustered(false);

                entity.ToTable("TB_PAISES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla2 }, "UK_PAISES_SIGLAS_2")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla3 }, "UK_PAISES_SIGLAS_3")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPais)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PAIS");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Nacionalidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NACIONALIDADE");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA_2");

                entity.Property(e => e.Sigla3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA_3");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPaises)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAISES_CLIENTES");
            });

            modelBuilder.Entity<TbPatrocinadore>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPatrocinador })
                    .HasName("PK_PATROCINADORES")
                    .IsClustered(false);

                entity.ToTable("TB_PATROCINADORES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PATROCINADORES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPatrocinador)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PATROCINADOR");

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.Fantasia)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FANTASIA");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.InscricaoEstadual)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO_ESTADUAL");

                entity.Property(e => e.InscricaoMunicipal)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO_MUNICIPAL");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSAVEL");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPatrocinadores)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PATROCINADORES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbPatrocinadores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PATROCINADORES_PAISES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbPatrocinadores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PATROCINADORES_ESTADOS");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbPatrocinadores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PATROCINADORES_CIDADES");
            });

            modelBuilder.Entity<TbPenalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPenalidade })
                    .HasName("PK_PENALIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_PENALIDADES");

                entity.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_PENALIDADES_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PENALIDADES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPenalidade)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PENALIDADE");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPenalidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PENALIDADES_CLIENTES");
            });

            modelBuilder.Entity<TbPerfi>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPerfil })
                    .HasName("PK_PERFIS")
                    .IsClustered(false);

                entity.ToTable("TB_PERFIS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PERFIS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPerfil)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PERFIL");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPerfis)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFIS_CLIENTES");
            });

            modelBuilder.Entity<TbPerfisUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPerfil, e.IdUsuario })
                    .HasName("PK_PERFIS_USUARIOS")
                    .IsClustered(false);

                entity.ToTable("TB_PERFIS_USUARIOS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPerfisUsuarios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFIS_USUARIOS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbPerfisUsuarios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPerfil })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFIS_USUARIOS_PERFIS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbPerfisUsuarios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdUsuario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFIS_USUARIOS_USUARIOS");
            });

            modelBuilder.Entity<TbPermisso>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPerfil, e.IdFuncaoMenu, e.IdTipoOperacao })
                    .HasName("PK_PERMISSOES")
                    .IsClustered(false);

                entity.ToTable("TB_PERMISSOES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");

                entity.Property(e => e.IdFuncaoMenu).HasColumnName("ID_FUNCAO_MENU");

                entity.Property(e => e.IdTipoOperacao).HasColumnName("ID_TIPO_OPERACAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPermissos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERMISSOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbPermissos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFuncaoMenu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERMISSOES_FUNCOES_MENU");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbPermissos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPerfil })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERMISSOES_PERFIS");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbPermissos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoOperacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERMISSOES_TIPOS_OPERACOES");
            });

            modelBuilder.Entity<TbPessoalApoio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdApoio })
                    .HasName("PK_PESSOAL_APOIO")
                    .IsClustered(false);

                entity.ToTable("TB_PESSOAL_APOIO");

                entity.HasIndex(e => new { e.IdCliente, e.Apelido }, "UK_PESSOAL_APOIO_APELIDOS")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Cpf }, "UK_PESSOAL_APOIO_CPF")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdApoio)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_APOIO");

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.Apelido)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APELIDO");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataIdentidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_IDENTIDADE");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdEmissor).HasColumnName("ID_EMISSOR");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

                entity.Property(e => e.IdNacionalidade).HasColumnName("ID_NACIONALIDADE");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.Identidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDENTIDADE");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPessoalApoios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEmissor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_EMISSORES_IDENTIDADES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEstadoCivil })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_ESTADOS_CIVIS");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbPessoalApoioId2s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNacionalidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_PAISES1");

                entity.HasOne(d => d.Id3)
                    .WithMany(p => p.TbPessoalApoioId3s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_PAISES");

                entity.HasOne(d => d.Id4)
                    .WithMany(p => p.TbPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_SEXOS");

                entity.HasOne(d => d.Id5)
                    .WithMany(p => p.TbPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_ESTADOS");

                entity.HasOne(d => d.Id6)
                    .WithMany(p => p.TbPessoalApoios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOAL_APOIO_CIDADES");
            });

            modelBuilder.Entity<TbPontuaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPontuacao })
                    .HasName("PK_PONTUACOES")
                    .IsClustered(false);

                entity.ToTable("TB_PONTUACOES");

                entity.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_PONTUACOES_ORDENS_EXIBICAO")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PONTUACOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdPontuacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PONTUACAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPontuacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PONTUACOES_CLIENTES");
            });

            modelBuilder.Entity<TbProfessore>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdProfessor })
                    .HasName("PK_PROFESSORES")
                    .IsClustered(false);

                entity.ToTable("TB_PROFESSORES");

                entity.HasIndex(e => new { e.IdCliente, e.Apelido }, "UK_PROFESSORES_APELIDOS")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.Cpf }, "UK_PROFESSORES_CPF")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdProfessor)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PROFESSOR");

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.Apelido)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APELIDO");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataIdentidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_IDENTIDADE");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdEmissor).HasColumnName("ID_EMISSOR");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

                entity.Property(e => e.IdNacionalidade).HasColumnName("ID_NACIONALIDADE");

                entity.Property(e => e.IdNivel).HasColumnName("ID_NIVEL");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.Identidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDENTIDADE");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbProfessores)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbProfessores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbProfessores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEmissor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_EMISSORES_IDENTIDADES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbProfessores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEstadoCivil })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_ESTADOS_CIVIS");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbProfessoreId2s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNacionalidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_PAISES1");

                entity.HasOne(d => d.Id3)
                    .WithMany(p => p.TbProfessoreId3s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_PAISES");

                entity.HasOne(d => d.Id4)
                    .WithMany(p => p.TbProfessores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_SEXOS");

                entity.HasOne(d => d.Id5)
                    .WithMany(p => p.TbProfessores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_ESTADOS");

                entity.HasOne(d => d.Id6)
                    .WithMany(p => p.TbProfessores)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFESSORES_CIDADES");
            });

            modelBuilder.Entity<TbProfisso>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdProfissao })
                    .HasName("PK_PROFISSOES")
                    .IsClustered(false);

                entity.ToTable("TB_PROFISSOES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PROFISSOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdProfissao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PROFISSAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbProfissos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROFISSOES_CLIENTES");
            });

            modelBuilder.Entity<TbPromocoesArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdArbitro, e.DataPromocao })
                    .HasName("PK_PROMOCOES_ARBITROS")
                    .IsClustered(false);

                entity.ToTable("TB_PROMOCOES_ARBITROS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdArbitro).HasColumnName("ID_ARBITRO");

                entity.Property(e => e.DataPromocao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PROMOCAO");

                entity.Property(e => e.IdNivelArbitroAnterior).HasColumnName("ID_NIVEL_ARBITRO_ANTERIOR");

                entity.Property(e => e.IdNivelArbitroNovo).HasColumnName("ID_NIVEL_ARBITRO_NOVO");

                entity.Property(e => e.IdTipoPromocaoArbitro).HasColumnName("ID_TIPO_PROMOCAO_ARBITRO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPromocoesArbitros)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbPromocoesArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdArbitro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbPromocoesArbitroIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivelArbitroAnterior })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_NIVEIS_ARBITROS1");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbPromocoesArbitroId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivelArbitroNovo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_NIVEIS_ARBITROS2");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbPromocoesArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPromocaoArbitro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_TIPOS_PROMOCOES_ARBITROS");
            });

            modelBuilder.Entity<TbPromocoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataPromocao })
                    .HasName("PK_PROMOCOES_ATLETAS")
                    .IsClustered(false);

                entity.ToTable("TB_PROMOCOES_ATLETAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.DataPromocao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PROMOCAO");

                entity.Property(e => e.IdFaixaAnterior).HasColumnName("ID_FAIXA_ANTERIOR");

                entity.Property(e => e.IdFaixaNova).HasColumnName("ID_FAIXA_NOVA");

                entity.Property(e => e.IdTipoPromocaoAtleta).HasColumnName("ID_TIPO_PROMOCAO_ATLETA");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPromocoesAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbPromocoesAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_ATLETAS");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbPromocoesAtletaIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixaAnterior })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_FAIXAS1");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbPromocoesAtletaId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixaNova })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_FAIXAS2");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbPromocoesAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPromocaoAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_TIPOS_PROMOCOES_ATLETAS");
            });

            modelBuilder.Entity<TbRecibo>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.NumeroRecibo })
                    .HasName("PK_RECIBOS")
                    .IsClustered(false);

                entity.ToTable("TB_RECIBOS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.NumeroRecibo).HasColumnName("NUMERO_RECIBO");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PAGAMENTO");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Origem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEM")
                    .HasDefaultValueSql("('G')")
                    .IsFixedLength();

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorBonificacao)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_BONIFICACAO");

                entity.Property(e => e.ValorCartaoCredito)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_CARTAO_CREDITO");

                entity.Property(e => e.ValorCartaoDebito)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_CARTAO_DEBITO");

                entity.Property(e => e.ValorCheque)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_CHEQUE");

                entity.Property(e => e.ValorDebitoAutomatico)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DEBITO_AUTOMATICO");

                entity.Property(e => e.ValorDinheiro)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DINHEIRO");

                entity.Property(e => e.ValorPix)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_PIX");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbRecibos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbRecibos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .HasConstraintName("FK_RECIBOS_AGREMIACOES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbRecibos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .HasConstraintName("FK_RECIBOS_ATLETAS");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbRecibos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdUsuario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_USUARIOS");
            });

            modelBuilder.Entity<TbRecibosIten>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdRecibo, e.IdItemRecibo })
                    .HasName("PK_RECIBOS_ITENS")
                    .IsClustered(false);

                entity.ToTable("TB_RECIBOS_ITENS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdRecibo).HasColumnName("ID_RECIBO");

                entity.Property(e => e.IdItemRecibo).HasColumnName("ID_ITEM_RECIBO");

                entity.Property(e => e.IdFormaPagamento).HasColumnName("ID_FORMA_PAGAMENTO");

                entity.Property(e => e.IdServico).HasColumnName("ID_SERVICO");

                entity.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorDesconto)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_UNITARIO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbRecibosItens)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_ITENS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbRecibosItens)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFormaPagamento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_ITENS_FORMAS_PAGAMENTO");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbRecibosItens)
                    .HasForeignKey(d => new { d.IdCliente, d.IdRecibo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_ITENS_RECIBOS");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbRecibosItens)
                    .HasForeignKey(d => new { d.IdCliente, d.IdServico })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_ITENS_SERVICOS");
            });

            modelBuilder.Entity<TbRegio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdRegiao })
                    .HasName("PK_REGIOES")
                    .IsClustered(false);

                entity.ToTable("TB_REGIOES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_REGIOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdRegiao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_REGIAO");

                entity.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSAVEL");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbRegios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGIOES_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbRegios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGIOES_PAISES");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbRegios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGIOES_ESTADOS");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbRegios)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGIOES_CIDADES");
            });

            modelBuilder.Entity<TbRegistroEvento>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdEvento })
                    .HasName("PK_REGISTRO_EVENTOS")
                    .IsClustered(false);

                entity.ToTable("TB_REGISTRO_EVENTOS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEvento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_EVENTO");

                entity.Property(e => e.DataHoraEvento)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_HORA_EVENTO");

                entity.Property(e => e.Descricao)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdComputador)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ID_COMPUTADOR");

                entity.Property(e => e.IdFuncaoMenu).HasColumnName("ID_FUNCAO_MENU");

                entity.Property(e => e.IdTipoOperacao).HasColumnName("ID_TIPO_OPERACAO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbRegistroEventos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGISTRO_EVENTOS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbRegistroEventos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFuncaoMenu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGISTRO_EVENTOS_FUNCOES_MENU");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbRegistroEventos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoOperacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGISTRO_EVENTOS_TIPOS_OPERACOES");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbRegistroEventos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdUsuario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGISTRO_EVENTOS_USUARIOS");
            });

            modelBuilder.Entity<TbSexo>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdSexo })
                    .HasName("PK_SEXOS")
                    .IsClustered(false);

                entity.ToTable("TB_SEXOS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbSistema>(entity =>
            {
                entity.HasKey(e => e.IdSistema)
                    .HasName("PK_SISTEMA")
                    .IsClustered(false);

                entity.ToTable("TB_SISTEMAS");

                entity.Property(e => e.IdSistema)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_SISTEMA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.Property(e => e.Versao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VERSAO");
            });

            modelBuilder.Entity<TbSistemasMensagen>(entity =>
            {
                entity.HasKey(e => new { e.IdSistema, e.IdMensagem })
                    .HasName("PK_SISTEMAS_MENSAGENS")
                    .IsClustered(false);

                entity.ToTable("TB_SISTEMAS_MENSAGENS");

                entity.HasIndex(e => new { e.IdSistema, e.Sigla }, "UK_SISTEMAS_MENSAGENS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdSistema).HasColumnName("ID_SISTEMA");

                entity.Property(e => e.IdMensagem)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_MENSAGEM");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdTipoMensagem).HasColumnName("ID_TIPO_MENSAGEM");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.TbSistemasMensagens)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SISTEMAS_MENSAGENS_SISTEMAS");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbSistemasMensagens)
                    .HasForeignKey(d => new { d.IdSistema, d.IdTipoMensagem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SISTEMAS_MENSAGENS_SISTEMAS_TIPOS_MENSAGENS");
            });

            modelBuilder.Entity<TbSistemasTiposMensagen>(entity =>
            {
                entity.HasKey(e => new { e.IdSistema, e.IdTipoMensagem })
                    .HasName("PK_SISTEMAS_TIPOS_MENSAGENS")
                    .IsClustered(false);

                entity.ToTable("TB_SISTEMAS_TIPOS_MENSAGENS");

                entity.HasIndex(e => new { e.IdSistema, e.Sigla }, "UK_SISTEMAS_TIPOS_MENSAGENS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdSistema).HasColumnName("ID_SISTEMA");

                entity.Property(e => e.IdTipoMensagem)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_MENSAGEM");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.TbSistemasTiposMensagens)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SISTEMAS_TIPOS_MENSAGENS_SISTEMAS");
            });

            modelBuilder.Entity<TbTabelaPeso>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdClasse, e.IdCategoria })
                    .HasName("PK_TABELA_PESOS")
                    .IsClustered(false);

                entity.ToTable("TB_TABELA_PESOS");

                entity.HasIndex(e => new { e.IdCliente, e.OrdemExibicaoCategoria }, "UK_TABELA_PESOS_ORDENS_EXIBICAO_CATEGORIAS")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdCliente, e.OrdemExibicaoClasse }, "UK_TABELA_PESOS_ORDENS_EXIBICAO_CLASSES")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdClasse).HasColumnName("ID_CLASSE");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.OrdemExibicaoCategoria).HasColumnName("ORDEM_EXIBICAO_CATEGORIA");

                entity.Property(e => e.OrdemExibicaoClasse).HasColumnName("ORDEM_EXIBICAO_CLASSE");

                entity.Property(e => e.PesoFinal).HasColumnName("PESO_FINAL");

                entity.Property(e => e.PesoInicial).HasColumnName("PESO_INICIAL");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTabelaPesos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELA_PESOS_CLIENTES");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbTabelaPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCategoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELA_PESOS_CATEGORIAS");

                entity.HasOne(d => d.IdCl)
                    .WithMany(p => p.TbTabelaPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdClasse })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELA_PESOS_CLASSES");
            });

            modelBuilder.Entity<TbTabelaServico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdServico })
                    .HasName("PK_TABELA_SERVICOS")
                    .IsClustered(false);

                entity.ToTable("TB_TABELA_SERVICOS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TABELA_SERVICOS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdServico)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_SERVICO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.Property(e => e.Valor)
                    .HasColumnType("money")
                    .HasColumnName("VALOR");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTabelaServicos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELA_SERVICOS_CLIENTES");
            });

            modelBuilder.Entity<TbTabelasAnuidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTabela })
                    .HasName("PK_TABELAS_ANUIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_TABELAS_ANUIDADES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTabela)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TABELA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorAnuidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_ANUIDADE");

                entity.Property(e => e.ValorRegistro)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_REGISTRO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTabelasAnuidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELAS_ANUIDADES_CLIENTES");
            });

            modelBuilder.Entity<TbTabelasAnuidadesConfederacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTabela })
                    .HasName("PK_TABELAS_ANUIDADES_CONFEDERACAO")
                    .IsClustered(false);

                entity.ToTable("TB_TABELAS_ANUIDADES_CONFEDERACAO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTabela)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TABELA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorAnuidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_ANUIDADE");

                entity.Property(e => e.ValorRegistro)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_REGISTRO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTabelasAnuidadesConfederacaos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELAS_ANUIDADES_CONFEDERACAO_CLIENTES");
            });

            modelBuilder.Entity<TbTabelasMensalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTabela })
                    .HasName("PK_TABELAS_MENSALIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_TABELAS_MENSALIDADES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTabela)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TABELA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.ValorMensalidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_MENSALIDADE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTabelasMensalidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELAS_MENSALIDADES_CLIENTES");
            });

            modelBuilder.Entity<TbTiposAnuidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoAnuidade })
                    .HasName("PK_TIPOS_ANUIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_ANUIDADES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_ANUIDADES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoAnuidade)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_ANUIDADE");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposAnuidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_ANUIDADES_CLIENTES");
            });

            modelBuilder.Entity<TbTiposAnuidadesConfederacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoAnuidade })
                    .HasName("PK_TIPOS_ANUIDADES_CONFEDERACAO")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_ANUIDADES_CONFEDERACAO");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_ANUIDADES_CONFEDERACAO_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoAnuidade)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_ANUIDADE");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposAnuidadesConfederacaos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_ANUIDADES_CONFEDERACAO_CLIENTES");
            });

            modelBuilder.Entity<TbTiposCurriculosAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoCurriculoAgremiacao })
                    .HasName("PK_TIPOS_CURRICULOS_AGREMIACOES")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_CURRICULOS_AGREMIACOES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_CURRICULOS_AGREMIACOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoCurriculoAgremiacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_CURRICULO_AGREMIACAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposCurriculosAgremiacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_CURRICULOS_AGREMIACOES_CLIENTES");
            });

            modelBuilder.Entity<TbTiposCurriculosAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoCurriculoAtleta })
                    .HasName("PK_TIPOS_CURRICULOS_ATLETAS")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_CURRICULOS_ATLETAS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_CURRICULOS_ATLETAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoCurriculoAtleta)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_CURRICULO_ATLETA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposCurriculosAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_CURRICULOS_ATLETAS_CLIENTES");
            });

            modelBuilder.Entity<TbTiposDesfiliacoesAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoDesfiliacaoAgremiacao })
                    .HasName("PK_TIPOS_DESFILIACOES_AGREMIACOES")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_DESFILIACOES_AGREMIACOES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_DESFILIACOES_AGREMIACOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoDesfiliacaoAgremiacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposDesfiliacoesAgremiacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_DESFILIACOES_AGREMIACOES_CLIENTES");
            });

            modelBuilder.Entity<TbTiposDesfiliacoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoDesfiliacaoAtleta })
                    .HasName("PK_TIPOS_DESFILIACOES_ATLETAS")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_DESFILIACOES_ATLETAS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_DESFILIACOES_ATLETAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoDesfiliacaoAtleta)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposDesfiliacoesAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_DESFILIACOES_ATLETAS_CLIENTES");
            });

            modelBuilder.Entity<TbTiposIsencoesAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoIsencaoAgremiacao })
                    .HasName("PK_TIPOS_ISENCOES_AGREMIACOES")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_ISENCOES_AGREMIACOES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_ISENCOES_AGREMIACOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoIsencaoAgremiacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_ISENCAO_AGREMIACAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposIsencoesAgremiacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_ISENCOES_AGREMIACOES_CLIENTES");
            });

            modelBuilder.Entity<TbTiposIsencoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoIsencaoAtleta })
                    .HasName("PK_TIPOS_ISENCOES_ATLETAS")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_ISENCOES_ATLETAS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_ISENCOES_ATLETAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoIsencaoAtleta)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_ISENCAO_ATLETA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposIsencoesAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_ISENCOES_ATLETAS_CLIENTES");
            });

            modelBuilder.Entity<TbTiposItensRecibo>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoItem })
                    .HasName("PK_TIPOS_ITENS_RECIBOS")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_ITENS_RECIBOS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_ITENS_RECIBOS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoItem)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_ITEM");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposItensRecibos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_ITENS_RECIBOS_CLIENTES");
            });

            modelBuilder.Entity<TbTiposOperaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoOperacao })
                    .HasName("PK_TIPOS_OPERACOES")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_OPERACOES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_OPERACOES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoOperacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_OPERACAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposOperacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_OPERACOES_CLIENTES");
            });

            modelBuilder.Entity<TbTiposPagamentosAnuidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPagamento })
                    .HasName("PK_TIPOS_PAGAMENTOS_ANUIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_PAGAMENTOS_ANUIDADES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_PAGAMENTOS_ANUIDADES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoPagamento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_PAGAMENTO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposPagamentosAnuidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_PAGAMENTOS_ANUIDADES_CLIENTES");
            });

            modelBuilder.Entity<TbTiposPagamentosAnuidadesConfederacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPagamento })
                    .HasName("PK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoPagamento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_PAGAMENTO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposPagamentosAnuidadesConfederacaos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO_CLIENTES");
            });

            modelBuilder.Entity<TbTiposPagamentosMensalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPagamento })
                    .HasName("PK_TIPOS_PAGAMENTOS_MENSALIDADES")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_PAGAMENTOS_MENSALIDADES");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_PAGAMENTOS_MENSALIDADES_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoPagamento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_PAGAMENTO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposPagamentosMensalidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_PAGAMENTOS_MENSALIDADES_CLIENTES");
            });

            modelBuilder.Entity<TbTiposPromocoesArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPromocao })
                    .HasName("PK_TIPOS_PROMOCOES_ARBITROS")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_PROMOCOES_ARBITROS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_PROMOCOES_ARBITROS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoPromocao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_PROMOCAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposPromocoesArbitros)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_PROMOCOES_ARBITROS_CLIENTES");
            });

            modelBuilder.Entity<TbTiposPromocoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPromocao })
                    .HasName("PK_TIPOS_PROMOCOES")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_PROMOCOES_ATLETAS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_PROMOCOES_ATLETAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoPromocao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_PROMOCAO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposPromocoesAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_PROMOCOES_ATLETAS_CLIENTES");
            });

            modelBuilder.Entity<TbTiposTransferencia>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoTransferencia })
                    .HasName("PK_TIPOS_TRANSFERENCIAS")
                    .IsClustered(false);

                entity.ToTable("TB_TIPOS_TRANSFERENCIAS");

                entity.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_TRANSFERENCIAS_SIGLAS")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipoTransferencia)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TIPO_TRANSFERENCIA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTiposTransferencia)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOS_TRANSFERENCIAS_CLIENTES");
            });

            modelBuilder.Entity<TbTransferencia>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataTransferencia })
                    .HasName("PK_TRANSFERENCIAS")
                    .IsClustered(false);

                entity.ToTable("TB_TRANSFERENCIAS");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.DataTransferencia)
                    .HasColumnType("date")
                    .HasColumnName("DATA_TRANSFERENCIA");

                entity.Property(e => e.IdAgremiacaoAnterior).HasColumnName("ID_AGREMIACAO_ANTERIOR");

                entity.Property(e => e.IdAgremiacaoNova).HasColumnName("ID_AGREMIACAO_NOVA");

                entity.Property(e => e.IdTipoTransferencia).HasColumnName("ID_TIPO_TRANSFERENCIA");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTransferencia)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbTransferenciaIds)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacaoAnterior })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_AGREMIACOES1");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbTransferenciaIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacaoNova })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_AGREMIACOES2");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbTransferencia)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_ATLETAS");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbTransferencia)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoTransferencia })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_TIPOS_TRANSFERENCIAS");
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdUsuario })
                    .HasName("PK_USUARIOS")
                    .IsClustered(false);

                entity.ToTable("TB_USUARIOS");

                entity.HasIndex(e => new { e.IdCliente, e.LoginUsuario }, "UK_USUARIOS_LOGIN_USUARIO")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_USUARIO");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_CRIACAO");

                entity.Property(e => e.DataExpiracao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_EXPIRACAO");

                entity.Property(e => e.DataUltimoLogin)
                    .HasColumnType("date")
                    .HasColumnName("DATA_ULTIMO_LOGIN");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.LoginUsuario)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("LOGIN_USUARIO");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Selecao).HasColumnName("SELECAO");

                entity.Property(e => e.Senha)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SENHA");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SITUACAO")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength();

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbUsuarios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOS_CLIENTES");
            });

            modelBuilder.Entity<TbValoresDefault>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdDefault })
                    .HasName("PK_VALORES_DEFAULT")
                    .IsClustered(false);

                entity.ToTable("TB_VALORES_DEFAULT");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdDefault)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_DEFAULT");

                entity.Property(e => e.AnoBase)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ANO_BASE")
                    .IsFixedLength();

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.DataDesfiliacaoAgremiacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_DESFILIACAO_AGREMIACAO");

                entity.Property(e => e.DataDesfiliacaoAtleta)
                    .HasColumnType("date")
                    .HasColumnName("DATA_DESFILIACAO_ATLETA");

                entity.Property(e => e.DataEventoCurriculoAgremiacao).HasColumnName("DATA_EVENTO_CURRICULO_AGREMIACAO");

                entity.Property(e => e.DataEventoCurriculoAtleta).HasColumnName("DATA_EVENTO_CURRICULO_ATLETA");

                entity.Property(e => e.DataFiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FILIACAO");

                entity.Property(e => e.DataInscricao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INSCRICAO");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                entity.Property(e => e.DataPagamentoAnuidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PAGAMENTO_ANUIDADE");

                entity.Property(e => e.DataPagamentoMensalidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PAGAMENTO_MENSALIDADE");

                entity.Property(e => e.DataPagamentoRecibo)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PAGAMENTO_RECIBO");

                entity.Property(e => e.DataPromocaoArbitro)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PROMOCAO_ARBITRO");

                entity.Property(e => e.DataPromocaoAtleta)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PROMOCAO_ATLETA");

                entity.Property(e => e.DataTransferencia)
                    .HasColumnType("date")
                    .HasColumnName("DATA_TRANSFERENCIA");

                entity.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                entity.Property(e => e.IdAgremiacaoAnterior).HasColumnName("ID_AGREMIACAO_ANTERIOR");

                entity.Property(e => e.IdAgremiacaoNova).HasColumnName("ID_AGREMIACAO_NOVA");

                entity.Property(e => e.IdApoio).HasColumnName("ID_APOIO");

                entity.Property(e => e.IdArbitro).HasColumnName("ID_ARBITRO");

                entity.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                entity.Property(e => e.IdClasse).HasColumnName("ID_CLASSE");

                entity.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                entity.Property(e => e.IdEmissorIdentidade).HasColumnName("ID_EMISSOR_IDENTIDADE");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

                entity.Property(e => e.IdFaixa).HasColumnName("ID_FAIXA");

                entity.Property(e => e.IdFaixaAnterior).HasColumnName("ID_FAIXA_ANTERIOR");

                entity.Property(e => e.IdFaixaNova).HasColumnName("ID_FAIXA_NOVA");

                entity.Property(e => e.IdFormaPagamento).HasColumnName("ID_FORMA_PAGAMENTO");

                entity.Property(e => e.IdLocal).HasColumnName("ID_LOCAL");

                entity.Property(e => e.IdNacionalidade).HasColumnName("ID_NACIONALIDADE");

                entity.Property(e => e.IdNivelAnterior).HasColumnName("ID_NIVEL_ANTERIOR");

                entity.Property(e => e.IdNivelNovo).HasColumnName("ID_NIVEL_NOVO");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.IdPatrocinador).HasColumnName("ID_PATROCINADOR");

                entity.Property(e => e.IdPenalidade).HasColumnName("ID_PENALIDADE");

                entity.Property(e => e.IdPontuacao).HasColumnName("ID_PONTUACAO");

                entity.Property(e => e.IdProfessor).HasColumnName("ID_PROFESSOR");

                entity.Property(e => e.IdProfissaoAtleta).HasColumnName("ID_PROFISSAO_ATLETA");

                entity.Property(e => e.IdProfissaoMae).HasColumnName("ID_PROFISSAO_MAE");

                entity.Property(e => e.IdProfissaoPai).HasColumnName("ID_PROFISSAO_PAI");

                entity.Property(e => e.IdRegiao).HasColumnName("ID_REGIAO");

                entity.Property(e => e.IdServico).HasColumnName("ID_SERVICO");

                entity.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                entity.Property(e => e.IdTabelaAnuidade).HasColumnName("ID_TABELA_ANUIDADE");

                entity.Property(e => e.IdTabelaMensalidade).HasColumnName("ID_TABELA_MENSALIDADE");

                entity.Property(e => e.IdTipoAnuidade).HasColumnName("ID_TIPO_ANUIDADE");

                entity.Property(e => e.IdTipoCurriculoAgremiacao).HasColumnName("ID_TIPO_CURRICULO_AGREMIACAO");

                entity.Property(e => e.IdTipoCurriculoAtleta).HasColumnName("ID_TIPO_CURRICULO_ATLETA");

                entity.Property(e => e.IdTipoDesfiliacaoAgremiacao).HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

                entity.Property(e => e.IdTipoDesfiliacaoAtleta).HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

                entity.Property(e => e.IdTipoIsencaoAgremiacao).HasColumnName("ID_TIPO_ISENCAO_AGREMIACAO");

                entity.Property(e => e.IdTipoIsencaoAtleta).HasColumnName("ID_TIPO_ISENCAO_ATLETA");

                entity.Property(e => e.IdTipoPagamentoAnuidade).HasColumnName("ID_TIPO_PAGAMENTO_ANUIDADE");

                entity.Property(e => e.IdTipoPagamentoMensalidade).HasColumnName("ID_TIPO_PAGAMENTO_MENSALIDADE");

                entity.Property(e => e.IdTipoPromocaoArbitro).HasColumnName("ID_TIPO_PROMOCAO_ARBITRO");

                entity.Property(e => e.IdTipoPromocaoAtleta).HasColumnName("ID_TIPO_PROMOCAO_ATLETA");

                entity.Property(e => e.IdTipoTransferencia).HasColumnName("ID_TIPO_TRANSFERENCIA");

                entity.Property(e => e.MesBase)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MES_BASE")
                    .IsFixedLength();

                entity.Property(e => e.Origem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEM")
                    .IsFixedLength();

                entity.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

                entity.Property(e => e.ValorAnuidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_ANUIDADE");

                entity.Property(e => e.ValorDescontoAnuidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO_ANUIDADE");

                entity.Property(e => e.ValorDescontoMensalidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO_MENSALIDADE");

                entity.Property(e => e.ValorMensalidade)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_MENSALIDADE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VALORES_DEFAULT_CLIENTES");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TbValoresDefaultIds)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES1");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbValoresDefaultIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacaoAnterior })
                    .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES2");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TbValoresDefaultId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacaoNova })
                    .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES3");

                entity.HasOne(d => d.Id2)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdApoio })
                    .HasConstraintName("FK_VALORES_DEFAULT_PESSOAL_APOIO");

                entity.HasOne(d => d.Id3)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdArbitro })
                    .HasConstraintName("FK_VALORES_DEFAULT_ARBITROS");

                entity.HasOne(d => d.Id4)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_ATLETAS");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCategoria })
                    .HasConstraintName("FK_VALORES_DEFAULT_CATEGORIAS");

                entity.HasOne(d => d.IdCl)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdClasse })
                    .HasConstraintName("FK_VALORES_DEFAULT_CLASSES");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .HasConstraintName("FK_VALORES_DEFAULT_COMPETICOES");

                entity.HasOne(d => d.Id5)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEmissorIdentidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_EMISSORES_IDENTIDADES");

                entity.HasOne(d => d.Id6)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEstadoCivil })
                    .HasConstraintName("FK_VALORES_DEFAULT_ESTADOS_CIVIS");

                entity.HasOne(d => d.Id7)
                    .WithMany(p => p.TbValoresDefaultId7s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixa })
                    .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS1");

                entity.HasOne(d => d.Id8)
                    .WithMany(p => p.TbValoresDefaultId8s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixaAnterior })
                    .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS2");

                entity.HasOne(d => d.Id9)
                    .WithMany(p => p.TbValoresDefaultId9s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixaNova })
                    .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS3");

                entity.HasOne(d => d.Id10)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFormaPagamento })
                    .HasConstraintName("FK_VALORES_DEFAULT_FORMAS_PAGAMENTO");

                entity.HasOne(d => d.Id11)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdLocal })
                    .HasConstraintName("FK_VALORES_DEFAULT_LOCAIS_COMPETICOES");

                entity.HasOne(d => d.Id12)
                    .WithMany(p => p.TbValoresDefaultId12s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNacionalidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_PAISES2");

                entity.HasOne(d => d.Id13)
                    .WithMany(p => p.TbValoresDefaultId13s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivelAnterior })
                    .HasConstraintName("FK_VALORES_DEFAULT_NIVEIS_ARBITROS1");

                entity.HasOne(d => d.Id14)
                    .WithMany(p => p.TbValoresDefaultId14s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivelNovo })
                    .HasConstraintName("FK_VALORES_DEFAULT_NIVEIS_ARBITROS2");

                entity.HasOne(d => d.Id15)
                    .WithMany(p => p.TbValoresDefaultId15s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .HasConstraintName("FK_VALORES_DEFAULT_PAISES1");

                entity.HasOne(d => d.Id16)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPatrocinador })
                    .HasConstraintName("FK_VALORES_DEFAULT_PATROCINADORES");

                entity.HasOne(d => d.Id17)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPenalidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_PENALIDADES");

                entity.HasOne(d => d.Id18)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPontuacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_PONTUACOES");

                entity.HasOne(d => d.Id19)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfessor })
                    .HasConstraintName("FK_VALORES_DEFAULT_PROFESSORES");

                entity.HasOne(d => d.Id20)
                    .WithMany(p => p.TbValoresDefaultId20s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES1");

                entity.HasOne(d => d.Id21)
                    .WithMany(p => p.TbValoresDefaultId21s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoMae })
                    .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES3");

                entity.HasOne(d => d.Id22)
                    .WithMany(p => p.TbValoresDefaultId22s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoPai })
                    .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES2");

                entity.HasOne(d => d.Id23)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdRegiao })
                    .HasConstraintName("FK_VALORES_DEFAULT_REGIOES");

                entity.HasOne(d => d.Id24)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdServico })
                    .HasConstraintName("FK_VALORES_DEFAULT_TABELA_SERVICOS");

                entity.HasOne(d => d.Id25)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .HasConstraintName("FK_VALORES_DEFAULT_SEXOS");

                entity.HasOne(d => d.Id26)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaAnuidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TABELAS_ANUIDADES");

                entity.HasOne(d => d.Id27)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaMensalidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TABELAS_MENSALIDADES");

                entity.HasOne(d => d.Id28)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoAnuidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ANUIDADES");

                entity.HasOne(d => d.Id29)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoCurriculoAgremiacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_CURRICULOS_AGREMIACOES");

                entity.HasOne(d => d.Id30)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoCurriculoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_CURRICULOS_ATLETAS");

                entity.HasOne(d => d.Id31)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoDesfiliacaoAgremiacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_DESFILIACOES_AGREMIACOES");

                entity.HasOne(d => d.Id32)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoDesfiliacaoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_DESFILIACOES_ATLETAS");

                entity.HasOne(d => d.Id33)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoIsencaoAgremiacao })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ISENCOES_AGREMIACOES");

                entity.HasOne(d => d.Id34)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoIsencaoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ISENCOES_ATLETAS");

                entity.HasOne(d => d.Id35)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamentoAnuidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PAGAMENTOS_ANUIDADES");

                entity.HasOne(d => d.Id36)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamentoMensalidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PAGAMENTOS_MENSALIDADES");

                entity.HasOne(d => d.Id37)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPromocaoArbitro })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PROMOCOES_ARBITROS");

                entity.HasOne(d => d.Id38)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPromocaoAtleta })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PROMOCOES_ATLETAS");

                entity.HasOne(d => d.Id39)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoTransferencia })
                    .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_TRANSFERENCIAS");

                entity.HasOne(d => d.Id40)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .HasConstraintName("FK_VALORES_DEFAULT_ESTADOS");

                entity.HasOne(d => d.Id41)
                    .WithMany(p => p.TbValoresDefaults)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .HasConstraintName("FK_VALORES_DEFAULT_CIDADES");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
