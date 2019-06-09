using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UniLoginBack.Models
{
    public partial class UNIDB001Context : DbContext
    {
        public UNIDB001Context()
        {
        }

        public UNIDB001Context(DbContextOptions<UNIDB001Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Duntb001Familia> Duntb001Familia { get; set; }
        public virtual DbSet<Duntb004Pessoa> Duntb004Pessoa { get; set; }
        public virtual DbSet<Igetb005Folha> Igetb005Folha { get; set; }
        public virtual DbSet<Isotb001Nis> Isotb001Nis { get; set; }
        public virtual DbSet<Raitb013DadosRais> Raitb013DadosRais { get; set; }
        public virtual DbSet<Unitb001Usuario> Unitb001Usuario { get; set; }
        public virtual DbSet<Unitb002LogUsuario> Unitb002LogUsuario { get; set; }
        public virtual DbSet<Unitb003Client> Unitb003Client { get; set; }
        public virtual DbSet<Unitb004Base> Unitb004Base { get; set; }
        public virtual DbSet<Unitb005UsuarioBase> Unitb005UsuarioBase { get; set; }
        public virtual DbSet<Unitb006Produto> Unitb006Produto { get; set; }
        public virtual DbSet<Unitb007UsuarioProduto> Unitb007UsuarioProduto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=sqlivan.ckdjthhtryqg.us-east-1.rds.amazonaws.com;Initial Catalog=UNIDB001;user=ivan;password=Souza2014");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Duntb001Familia>(entity =>
            {
                entity.HasKey(e => e.CoFamilia);

                entity.ToTable("duntb001_familia");

                entity.Property(e => e.CoFamilia)
                    .HasColumnName("co_familia")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoAlteracaoV7).HasColumnName("co_alteracao_v7");

                entity.Property(e => e.CoCadastroValido).HasColumnName("co_cadastro_valido");

                entity.Property(e => e.CoCondicaoCadastro).HasColumnName("co_condicao_cadastro");

                entity.Property(e => e.CoCpfEntrevistador)
                    .HasColumnName("co_cpf_entrevistador")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CoEstadoCadastro).HasColumnName("co_estado_cadastro");

                entity.Property(e => e.CoPrefeitura).HasColumnName("co_prefeitura");

                entity.Property(e => e.CoTipoLogradouro).HasColumnName("co_tipo_logradouro");

                entity.Property(e => e.DeComplemento)
                    .HasColumnName("de_complemento")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.DeComplementoAdicional)
                    .HasColumnName("de_complemento_adicional")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("date");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnName("dt_atualizacao")
                    .HasColumnType("date");

                entity.Property(e => e.DtCadastramento)
                    .HasColumnName("dt_cadastramento")
                    .HasColumnType("date");

                entity.Property(e => e.DtLimiteAtualizacao)
                    .HasColumnName("dt_limite_atualizacao")
                    .HasColumnType("date");

                entity.Property(e => e.EdEmail)
                    .HasColumnName("ed_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IcIndigena).HasColumnName("ic_indigena");

                entity.Property(e => e.IcQuilombola).HasColumnName("ic_quilombola");

                entity.Property(e => e.IcTrabalhoInfantil).HasColumnName("ic_trabalho_infantil");

                entity.Property(e => e.NoLocalidade)
                    .HasColumnName("no_localidade")
                    .HasMaxLength(76)
                    .IsUnicode(false);

                entity.Property(e => e.NoLogradouro)
                    .HasColumnName("no_logradouro")
                    .HasMaxLength(76)
                    .IsUnicode(false);

                entity.Property(e => e.NoTituloLogradouro)
                    .HasColumnName("no_titulo_logradouro")
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.NuCep)
                    .HasColumnName("nu_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NuDdd1)
                    .HasColumnName("nu_ddd_1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NuDdd2)
                    .HasColumnName("nu_ddd_2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NuLogradouro)
                    .HasColumnName("nu_logradouro")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NuTelefone1)
                    .HasColumnName("nu_telefone_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NuTelefone2)
                    .HasColumnName("nu_telefone_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtFamilias).HasColumnName("qt_familias");

                entity.Property(e => e.QtPessoas).HasColumnName("qt_pessoas");

                entity.Property(e => e.VrRendaMedia)
                    .HasColumnName("vr_renda_media")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Duntb004Pessoa>(entity =>
            {
                entity.HasKey(e => e.CoPessoa);

                entity.ToTable("duntb004_pessoa");

                entity.Property(e => e.CoPessoa)
                    .HasColumnName("co_pessoa")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoCertidaoRegistrada).HasColumnName("co_certidao_registrada");

                entity.Property(e => e.CoEstadoCadastro).HasColumnName("co_estado_cadastro");

                entity.Property(e => e.CoFamilia).HasColumnName("co_familia");

                entity.Property(e => e.CoIbgeNascimento)
                    .HasColumnName("co_ibge_nascimento")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CoNis)
                    .HasColumnName("co_nis")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CoNisOriginal)
                    .HasColumnName("co_nis_original")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CoPaisOrigem).HasColumnName("co_pais_origem");

                entity.Property(e => e.CoParentesco).HasColumnName("co_parentesco");

                entity.Property(e => e.CoRaca).HasColumnName("co_raca");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnName("dt_atualizacao")
                    .HasColumnType("date");

                entity.Property(e => e.DtCadastramento)
                    .HasColumnName("dt_cadastramento")
                    .HasColumnType("date");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.IcSexo).HasColumnName("ic_sexo");

                entity.Property(e => e.IcTrabalhoInfantil).HasColumnName("ic_trabalho_infantil");

                entity.Property(e => e.NoMae)
                    .HasColumnName("no_mae")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.NoPai)
                    .HasColumnName("no_pai")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.NoPessoa)
                    .IsRequired()
                    .HasColumnName("no_pessoa")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.NuOrdem).HasColumnName("nu_ordem");

                entity.HasOne(d => d.CoFamiliaNavigation)
                    .WithMany(p => p.Duntb004Pessoa)
                    .HasForeignKey(d => d.CoFamilia)
                    .HasConstraintName("FK_duntb004_pessoa_duntb001_familia");

                entity.HasOne(d => d.CoPessoaNavigation)
                    .WithOne(p => p.Duntb004Pessoa)
                    .HasForeignKey<Duntb004Pessoa>(d => d.CoPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_duntb004_pessoa_isotb001_nis1");
            });

            modelBuilder.Entity<Igetb005Folha>(entity =>
            {
                entity.HasKey(e => new { e.CoPessoa, e.DtFolha, e.DtCompetencia, e.CoProduto });

                entity.ToTable("igetb005_folha");

                entity.HasIndex(e => new { e.CoPessoa, e.CoProduto, e.DtFolha, e.DtCompetencia })
                    .HasName("IX_igetb005_folha")
                    .IsUnique();

                entity.Property(e => e.CoPessoa).HasColumnName("co_pessoa");

                entity.Property(e => e.DtFolha)
                    .HasColumnName("dt_folha")
                    .HasColumnType("date");

                entity.Property(e => e.DtCompetencia)
                    .HasColumnName("dt_competencia")
                    .HasColumnType("date");

                entity.Property(e => e.CoProduto)
                    .HasColumnName("co_produto")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CoArquivo).HasColumnName("co_arquivo");

                entity.Property(e => e.CoAutenticacao)
                    .HasColumnName("co_autenticacao")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CoIbge)
                    .IsRequired()
                    .HasColumnName("co_ibge")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CoIbgeMunicipioCadastramento)
                    .HasColumnName("co_ibge_municipio_cadastramento")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CoIbgeMunicipioPagamento)
                    .HasColumnName("co_ibge_municipio_pagamento")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CoSituacao).HasColumnName("co_situacao");

                entity.Property(e => e.CoTipoPagamento)
                    .HasColumnName("co_tipo_pagamento")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IcInseridoPago).HasColumnName("ic_inserido_pago");

                entity.Property(e => e.NoBeneficiario)
                    .HasColumnName("no_beneficiario")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoResponsavelTitular)
                    .HasColumnName("no_responsavel_titular")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VrDisponibilizado)
                    .HasColumnName("vr_disponibilizado")
                    .HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.CoPessoaNavigation)
                    .WithMany(p => p.Igetb005Folha)
                    .HasForeignKey(d => d.CoPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_igetb005_folha_duntb004_pessoa");
            });

            modelBuilder.Entity<Isotb001Nis>(entity =>
            {
                entity.HasKey(e => e.CoPessoa);

                entity.ToTable("isotb001_nis");

                entity.HasIndex(e => e.CoNis)
                    .HasName("IX_isotb001_nis");

                entity.Property(e => e.CoPessoa)
                    .HasColumnName("co_pessoa")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoCpf)
                    .HasColumnName("co_cpf")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CoCtps)
                    .HasColumnName("co_ctps")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CoNis)
                    .IsRequired()
                    .HasColumnName("co_nis")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CoSerieCtps)
                    .HasColumnName("co_serie_ctps")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoTipoVinculo).HasColumnName("co_tipo_vinculo");

                entity.Property(e => e.CoUfCtps)
                    .HasColumnName("co_uf_ctps")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DtAdmissao)
                    .HasColumnName("dt_admissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtEmissaoCtps)
                    .HasColumnName("dt_emissao_ctps")
                    .HasColumnType("date");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.NoBeneficiario)
                    .HasColumnName("no_beneficiario")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.NuCnpjCei)
                    .HasColumnName("nu_cnpj_cei")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.CoPessoaNavigation)
                    .WithOne(p => p.Isotb001Nis)
                    .HasForeignKey<Isotb001Nis>(d => d.CoPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_isotb001_nis_unitb001_usuario");
            });

            modelBuilder.Entity<Raitb013DadosRais>(entity =>
            {
                entity.HasKey(e => e.CoPessoa)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("raitb013_dados_rais");

                entity.Property(e => e.CoPessoa)
                    .HasColumnName("co_pessoa")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoArquivoRais).HasColumnName("co_arquivo_rais");

                entity.Property(e => e.CoCausaDesligamento).HasColumnName("co_causa_desligamento");

                entity.Property(e => e.CoCboRais)
                    .IsRequired()
                    .HasColumnName("co_cbo_rais")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CoCeiVinculado)
                    .HasColumnName("co_cei_vinculado")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CoCpf)
                    .IsRequired()
                    .HasColumnName("co_cpf")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CoInscricaoEmpresa)
                    .IsRequired()
                    .HasColumnName("co_inscricao_empresa")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CoNis)
                    .IsRequired()
                    .HasColumnName("co_nis")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CoNisInf)
                    .HasColumnName("co_nis_inf")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CoTipoAdmissao).HasColumnName("co_tipo_admissao");

                entity.Property(e => e.CoTipoInscricao).HasColumnName("co_tipo_inscricao");

                entity.Property(e => e.CoTipoNaturezaJuridica)
                    .HasColumnName("co_tipo_natureza_juridica")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoTipoSituacaoNis).HasColumnName("co_tipo_situacao_nis");

                entity.Property(e => e.CoTipoVinculoRais).HasColumnName("co_tipo_vinculo_rais");

                entity.Property(e => e.CoUtilizacaoApoio).HasColumnName("co_utilizacao_apoio");

                entity.Property(e => e.DtAdmissaoRais)
                    .HasColumnName("dt_admissao_rais")
                    .HasColumnType("date");

                entity.Property(e => e.DtDesligamentoRais)
                    .HasColumnName("dt_desligamento_rais")
                    .HasColumnType("date");

                entity.Property(e => e.DtNacimentoCidadao)
                    .HasColumnName("dt_nacimento_cidadao")
                    .HasColumnType("date");

                entity.Property(e => e.NoCidadao)
                    .IsRequired()
                    .HasColumnName("no_cidadao")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NuCtps)
                    .IsRequired()
                    .HasColumnName("nu_ctps")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NuSerieCtps)
                    .IsRequired()
                    .HasColumnName("nu_serie_ctps")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VrRemuneracaoAbr).HasColumnName("vr_remuneracao_abr");

                entity.Property(e => e.VrRemuneracaoAgo).HasColumnName("vr_remuneracao_ago");

                entity.Property(e => e.VrRemuneracaoDez).HasColumnName("vr_remuneracao_dez");

                entity.Property(e => e.VrRemuneracaoFev).HasColumnName("vr_remuneracao_fev");

                entity.Property(e => e.VrRemuneracaoJan).HasColumnName("vr_remuneracao_jan");

                entity.Property(e => e.VrRemuneracaoJul).HasColumnName("vr_remuneracao_jul");

                entity.Property(e => e.VrRemuneracaoJun).HasColumnName("vr_remuneracao_jun");

                entity.Property(e => e.VrRemuneracaoMai).HasColumnName("vr_remuneracao_mai");

                entity.Property(e => e.VrRemuneracaoMar).HasColumnName("vr_remuneracao_mar");

                entity.Property(e => e.VrRemuneracaoNov).HasColumnName("vr_remuneracao_nov");

                entity.Property(e => e.VrRemuneracaoOut).HasColumnName("vr_remuneracao_out");

                entity.Property(e => e.VrRemuneracaoSet).HasColumnName("vr_remuneracao_set");

                entity.Property(e => e.VrSalarioContratado).HasColumnName("vr_salario_contratado");

                entity.HasOne(d => d.CoPessoaNavigation)
                    .WithOne(p => p.Raitb013DadosRais)
                    .HasForeignKey<Raitb013DadosRais>(d => d.CoPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_raitb013_dados_rais_isotb001_nis");
            });

            modelBuilder.Entity<Unitb001Usuario>(entity =>
            {
                entity.HasKey(e => e.CoPessoa);

                entity.ToTable("unitb001_usuario");

                entity.Property(e => e.CoPessoa).HasColumnName("co_pessoa");

                entity.Property(e => e.CoCpf)
                    .IsRequired()
                    .HasColumnName("co_cpf")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EdEmail)
                    .IsRequired()
                    .HasColumnName("ed_email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImUsuario)
                    .HasColumnName("im_usuario")
                    .HasColumnType("text");

                entity.Property(e => e.NoUsuario)
                    .IsRequired()
                    .HasColumnName("no_usuario")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NuTelefone)
                    .HasColumnName("nu_telefone")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TxSenha)
                    .IsRequired()
                    .HasColumnName("tx_senha")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unitb002LogUsuario>(entity =>
            {
                entity.HasKey(e => e.CoLog);

                entity.ToTable("unitb002_log_usuario");

                entity.Property(e => e.CoLog).HasColumnName("co_log");

                entity.Property(e => e.CoClient).HasColumnName("co_client");

                entity.Property(e => e.CoPessoa).HasColumnName("co_pessoa");

                entity.Property(e => e.DhAcesso)
                    .HasColumnName("dh_acesso")
                    .HasColumnType("datetime");

                entity.Property(e => e.IcSucesso).HasColumnName("ic_sucesso");

                entity.Property(e => e.TxPerguntas)
                    .IsRequired()
                    .HasColumnName("tx_perguntas")
                    .HasColumnType("text");

                entity.Property(e => e.TxRespostas)
                    .HasColumnName("tx_respostas")
                    .HasColumnType("text");

                entity.HasOne(d => d.CoClientNavigation)
                    .WithMany(p => p.Unitb002LogUsuario)
                    .HasForeignKey(d => d.CoClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_unitb002_log_usuario_unitb003_client");

                entity.HasOne(d => d.CoPessoaNavigation)
                    .WithMany(p => p.Unitb002LogUsuario)
                    .HasForeignKey(d => d.CoPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_unitb002_log_usuario_unitb001_usuario1");
            });

            modelBuilder.Entity<Unitb003Client>(entity =>
            {
                entity.HasKey(e => e.CoClient);

                entity.ToTable("unitb003_client");

                entity.Property(e => e.CoClient)
                    .HasColumnName("co_client")
                    .ValueGeneratedNever();

                entity.Property(e => e.EdRedirectUrl)
                    .IsRequired()
                    .HasColumnName("ed_redirect_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoClient)
                    .IsRequired()
                    .HasColumnName("no_client")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unitb004Base>(entity =>
            {
                entity.HasKey(e => e.CoBase);

                entity.ToTable("unitb004_base");

                entity.Property(e => e.CoBase).HasColumnName("co_base");

                entity.Property(e => e.NoBase)
                    .IsRequired()
                    .HasColumnName("no_base")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unitb005UsuarioBase>(entity =>
            {
                entity.HasKey(e => new { e.CoPessoa, e.CoBase });

                entity.ToTable("unitb005_usuario_base");

                entity.Property(e => e.CoPessoa).HasColumnName("co_pessoa");

                entity.Property(e => e.CoBase).HasColumnName("co_base");

                entity.HasOne(d => d.CoBaseNavigation)
                    .WithMany(p => p.Unitb005UsuarioBase)
                    .HasForeignKey(d => d.CoBase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_unitb005_usuario_base_unitb004_base");

                entity.HasOne(d => d.CoPessoaNavigation)
                    .WithMany(p => p.Unitb005UsuarioBase)
                    .HasForeignKey(d => d.CoPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_unitb005_usuario_base_unitb001_usuario");
            });

            modelBuilder.Entity<Unitb006Produto>(entity =>
            {
                entity.HasKey(e => e.CoProduto);

                entity.ToTable("unitb006_produto");

                entity.Property(e => e.CoProduto).HasColumnName("co_produto");

                entity.Property(e => e.NoProduto)
                    .IsRequired()
                    .HasColumnName("no_produto")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unitb007UsuarioProduto>(entity =>
            {
                entity.HasKey(e => new { e.CoProduto, e.CoPessoa });

                entity.ToTable("unitb007_usuario_produto");

                entity.Property(e => e.CoProduto).HasColumnName("co_produto");

                entity.Property(e => e.CoPessoa).HasColumnName("co_pessoa");

                entity.Property(e => e.DhCriacao)
                    .HasColumnName("dh_criacao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IcAtendido).HasColumnName("ic_atendido");

                entity.HasOne(d => d.CoPessoaNavigation)
                    .WithMany(p => p.Unitb007UsuarioProduto)
                    .HasForeignKey(d => d.CoPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_unitb007_usuario_produto_unitb001_usuario");

                entity.HasOne(d => d.CoProdutoNavigation)
                    .WithMany(p => p.Unitb007UsuarioProduto)
                    .HasForeignKey(d => d.CoProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_unitb007_usuario_produto_unitb006_produto");
            });
        }
    }
}
