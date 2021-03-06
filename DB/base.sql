USE [UNIDB001]
GO
/****** Object:  Table [dbo].[duntb001_familia]    Script Date: 09/06/2019 11:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[duntb001_familia](
	[co_familia] [bigint] NOT NULL,
	[co_prefeitura] [bigint] NOT NULL,
	[dt_cadastramento] [date] NOT NULL,
	[dt_alteracao] [date] NOT NULL,
	[co_estado_cadastro] [tinyint] NOT NULL,
	[co_cadastro_valido] [tinyint] NOT NULL,
	[co_condicao_cadastro] [tinyint] NOT NULL,
	[vr_renda_media] [decimal](10, 2) NULL,
	[ic_trabalho_infantil] [bit] NULL,
	[no_localidade] [varchar](76) NULL,
	[co_tipo_logradouro] [smallint] NULL,
	[no_titulo_logradouro] [varchar](38) NULL,
	[no_logradouro] [varchar](76) NULL,
	[nu_logradouro] [varchar](16) NULL,
	[de_complemento] [varchar](22) NULL,
	[de_complemento_adicional] [varchar](75) NULL,
	[nu_cep] [char](8) NULL,
	[co_cpf_entrevistador] [char](11) NULL,
	[dt_limite_atualizacao] [date] NULL,
	[co_alteracao_v7] [tinyint] NOT NULL,
	[dt_atualizacao] [date] NOT NULL,
	[ic_indigena] [bit] NULL,
	[ic_quilombola] [bit] NULL,
	[qt_pessoas] [tinyint] NULL,
	[qt_familias] [tinyint] NULL,
	[nu_ddd_1] [char](2) NULL,
	[nu_telefone_1] [varchar](10) NULL,
	[nu_ddd_2] [char](2) NULL,
	[nu_telefone_2] [varchar](10) NULL,
	[ed_email] [varchar](50) NULL,
 CONSTRAINT [PK_duntb001_familia] PRIMARY KEY CLUSTERED 
(
	[co_familia] ASC
)WITH (PAD_INDEX = ON, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 98) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[duntb004_pessoa]    Script Date: 09/06/2019 11:51:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[duntb004_pessoa](
	[co_pessoa] [bigint] NOT NULL,
	[co_familia] [bigint] NOT NULL,
	[dt_cadastramento] [date] NULL,
	[dt_atualizacao] [date] NULL,
	[co_estado_cadastro] [tinyint] NOT NULL,
	[ic_trabalho_infantil] [bit] NULL,
	[nu_ordem] [tinyint] NOT NULL,
	[no_pessoa] [varchar](70) NOT NULL,
	[co_nis] [char](11) NULL,
	[ic_sexo] [bit] NULL,
	[dt_nascimento] [date] NULL,
	[co_parentesco] [tinyint] NULL,
	[co_raca] [tinyint] NULL,
	[co_ibge_nascimento] [char](7) NULL,
	[co_nis_original] [char](11) NULL,
	[no_mae] [varchar](70) NULL,
	[no_pai] [varchar](70) NULL,
	[co_certidao_registrada] [tinyint] NULL,
	[co_pais_origem] [smallint] NULL,
 CONSTRAINT [PK_duntb004_pessoa] PRIMARY KEY CLUSTERED 
(
	[co_pessoa] ASC
)WITH (PAD_INDEX = ON, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 98) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[isotb001_nis]    Script Date: 09/06/2019 11:51:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[isotb001_nis](
	[co_nis] [char](11) NOT NULL,
	[no_beneficiario] [varchar](70) NULL,
	[dt_nascimento] [date] NULL,
	[co_cpf] [char](11) NULL,
	[co_ctps] [varchar](7) NULL,
	[co_serie_ctps] [varchar](5) NULL,
	[co_uf_ctps] [char](2) NULL,
	[dt_emissao_ctps] [date] NULL,
	[co_tipo_vinculo] [int] NULL,
	[nu_cnpj_cei] [varchar](16) NULL,
	[dt_admissao] [date] NULL,
	[co_pessoa] [bigint] NOT NULL,
 CONSTRAINT [PK_isotb001_nis] PRIMARY KEY CLUSTERED 
(
	[co_pessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[raitb013_dados_rais]    Script Date: 09/06/2019 11:51:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[raitb013_dados_rais](
	[co_pessoa] [bigint] NOT NULL,
	[co_tipo_vinculo_rais] [tinyint] NULL,
	[co_cbo_rais] [char](6) NOT NULL,
	[dt_admissao_rais] [date] NOT NULL,
	[co_tipo_admissao] [tinyint] NULL,
	[dt_desligamento_rais] [date] NULL,
	[co_causa_desligamento] [tinyint] NULL,
	[co_tipo_situacao_nis] [tinyint] NULL,
	[co_utilizacao_apoio] [tinyint] NULL,
	[vr_salario_contratado] [decimal](18, 2) NOT NULL,
	[co_arquivo_rais] [int] NULL,
	[co_nis_inf] [char](11) NULL,
	[co_nis] [char](11) NOT NULL,
	[no_cidadao] [varchar](150) NOT NULL,
	[dt_nacimento_cidadao] [date] NOT NULL,
	[nu_ctps] [char](8) NOT NULL,
	[nu_serie_ctps] [char](5) NOT NULL,
	[co_cpf] [char](11) NOT NULL,
	[co_tipo_inscricao] [tinyint] NOT NULL,
	[co_inscricao_empresa] [char](15) NOT NULL,
	[co_cei_vinculado] [char](13) NULL,
	[co_tipo_natureza_juridica] [char](5) NULL,
	[vr_remuneracao_jan] [decimal](18, 2) NULL,
	[vr_remuneracao_fev] [decimal](18, 2) NULL,
	[vr_remuneracao_mar] [decimal](18, 2) NULL,
	[vr_remuneracao_abr] [decimal](18, 2) NULL,
	[vr_remuneracao_mai] [decimal](18, 2) NULL,
	[vr_remuneracao_jun] [decimal](18, 2) NULL,
	[vr_remuneracao_jul] [decimal](18, 2) NULL,
	[vr_remuneracao_ago] [decimal](18, 2) NULL,
	[vr_remuneracao_set] [decimal](18, 2) NULL,
	[vr_remuneracao_out] [decimal](18, 2) NULL,
	[vr_remuneracao_nov] [decimal](18, 2) NULL,
	[vr_remuneracao_dez] [decimal](18, 2) NULL,
 CONSTRAINT [PK_raitb013_dados_rais] PRIMARY KEY NONCLUSTERED 
(
	[co_pessoa] ASC
)WITH (PAD_INDEX = ON, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 98) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unitb001_usuario]    Script Date: 09/06/2019 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unitb001_usuario](
	[co_pessoa] [bigint] IDENTITY(1,1) NOT NULL,
	[no_usuario] [varchar](200) NOT NULL,
	[co_cpf] [char](11) NOT NULL,
	[tx_senha] [varchar](200) NOT NULL,
	[ed_email] [varchar](200) NOT NULL,
	[im_usuario] [text] NULL,
	[nu_telefone] [varchar](200) NULL,
 CONSTRAINT [PK_unitb001_usuario] PRIMARY KEY CLUSTERED 
(
	[co_pessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unitb002_log_usuario]    Script Date: 09/06/2019 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unitb002_log_usuario](
	[co_log] [bigint] IDENTITY(1,1) NOT NULL,
	[dh_acesso] [datetime] NOT NULL,
	[co_pessoa] [bigint] NOT NULL,
	[co_client] [int] NOT NULL,
	[ic_sucesso] [bit] NOT NULL,
	[tx_perguntas] [text] NOT NULL,
	[tx_respostas] [text] NULL,
 CONSTRAINT [PK_unitb002_log_usuario] PRIMARY KEY CLUSTERED 
(
	[co_log] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unitb003_client]    Script Date: 09/06/2019 11:51:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unitb003_client](
	[co_client] [int] NOT NULL,
	[no_client] [varchar](200) NOT NULL,
	[ed_redirect_url] [varchar](200) NOT NULL,
 CONSTRAINT [PK_unitb003_client] PRIMARY KEY CLUSTERED 
(
	[co_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unitb004_base]    Script Date: 09/06/2019 11:51:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unitb004_base](
	[co_base] [int] IDENTITY(1,1) NOT NULL,
	[no_base] [varchar](200) NOT NULL,
 CONSTRAINT [PK_unitb004_base] PRIMARY KEY CLUSTERED 
(
	[co_base] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unitb005_usuario_base]    Script Date: 09/06/2019 11:51:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unitb005_usuario_base](
	[co_pessoa] [bigint] NOT NULL,
	[co_base] [int] NOT NULL,
 CONSTRAINT [PK_unitb005_usuario_base] PRIMARY KEY CLUSTERED 
(
	[co_pessoa] ASC,
	[co_base] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unitb006_produto]    Script Date: 09/06/2019 11:51:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unitb006_produto](
	[co_produto] [int] IDENTITY(1,1) NOT NULL,
	[no_produto] [varchar](200) NOT NULL,
 CONSTRAINT [PK_unitb006_produto] PRIMARY KEY CLUSTERED 
(
	[co_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unitb007_usuario_produto]    Script Date: 09/06/2019 11:51:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unitb007_usuario_produto](
	[co_produto] [int] NOT NULL,
	[co_pessoa] [bigint] NOT NULL,
	[dh_criacao] [datetime] NOT NULL,
	[ic_atendido] [bit] NULL,
 CONSTRAINT [PK_unitb007_usuario_produto] PRIMARY KEY CLUSTERED 
(
	[co_produto] ASC,
	[co_pessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[unitb007_usuario_produto] ADD  CONSTRAINT [DF_unitb007_usuario_produto_dh_criacao]  DEFAULT (getdate()) FOR [dh_criacao]
GO
ALTER TABLE [dbo].[duntb004_pessoa]  WITH CHECK ADD  CONSTRAINT [FK_duntb004_pessoa_duntb001_familia] FOREIGN KEY([co_familia])
REFERENCES [dbo].[duntb001_familia] ([co_familia])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[duntb004_pessoa] CHECK CONSTRAINT [FK_duntb004_pessoa_duntb001_familia]
GO
ALTER TABLE [dbo].[duntb004_pessoa]  WITH CHECK ADD  CONSTRAINT [FK_duntb004_pessoa_isotb001_nis1] FOREIGN KEY([co_pessoa])
REFERENCES [dbo].[isotb001_nis] ([co_pessoa])
GO
ALTER TABLE [dbo].[duntb004_pessoa] CHECK CONSTRAINT [FK_duntb004_pessoa_isotb001_nis1]
GO
ALTER TABLE [dbo].[isotb001_nis]  WITH CHECK ADD  CONSTRAINT [FK_isotb001_nis_unitb001_usuario] FOREIGN KEY([co_pessoa])
REFERENCES [dbo].[unitb001_usuario] ([co_pessoa])
GO
ALTER TABLE [dbo].[isotb001_nis] CHECK CONSTRAINT [FK_isotb001_nis_unitb001_usuario]
GO
ALTER TABLE [dbo].[raitb013_dados_rais]  WITH CHECK ADD  CONSTRAINT [FK_raitb013_dados_rais_isotb001_nis] FOREIGN KEY([co_pessoa])
REFERENCES [dbo].[isotb001_nis] ([co_pessoa])
GO
ALTER TABLE [dbo].[raitb013_dados_rais] CHECK CONSTRAINT [FK_raitb013_dados_rais_isotb001_nis]
GO
ALTER TABLE [dbo].[unitb002_log_usuario]  WITH CHECK ADD  CONSTRAINT [FK_unitb002_log_usuario_unitb001_usuario1] FOREIGN KEY([co_pessoa])
REFERENCES [dbo].[unitb001_usuario] ([co_pessoa])
GO
ALTER TABLE [dbo].[unitb002_log_usuario] CHECK CONSTRAINT [FK_unitb002_log_usuario_unitb001_usuario1]
GO
ALTER TABLE [dbo].[unitb002_log_usuario]  WITH CHECK ADD  CONSTRAINT [FK_unitb002_log_usuario_unitb003_client] FOREIGN KEY([co_client])
REFERENCES [dbo].[unitb003_client] ([co_client])
GO
ALTER TABLE [dbo].[unitb002_log_usuario] CHECK CONSTRAINT [FK_unitb002_log_usuario_unitb003_client]
GO
ALTER TABLE [dbo].[unitb005_usuario_base]  WITH CHECK ADD  CONSTRAINT [FK_unitb005_usuario_base_unitb001_usuario] FOREIGN KEY([co_pessoa])
REFERENCES [dbo].[unitb001_usuario] ([co_pessoa])
GO
ALTER TABLE [dbo].[unitb005_usuario_base] CHECK CONSTRAINT [FK_unitb005_usuario_base_unitb001_usuario]
GO
ALTER TABLE [dbo].[unitb005_usuario_base]  WITH CHECK ADD  CONSTRAINT [FK_unitb005_usuario_base_unitb004_base] FOREIGN KEY([co_base])
REFERENCES [dbo].[unitb004_base] ([co_base])
GO
ALTER TABLE [dbo].[unitb005_usuario_base] CHECK CONSTRAINT [FK_unitb005_usuario_base_unitb004_base]
GO
ALTER TABLE [dbo].[unitb007_usuario_produto]  WITH CHECK ADD  CONSTRAINT [FK_unitb007_usuario_produto_unitb001_usuario] FOREIGN KEY([co_pessoa])
REFERENCES [dbo].[unitb001_usuario] ([co_pessoa])
GO
ALTER TABLE [dbo].[unitb007_usuario_produto] CHECK CONSTRAINT [FK_unitb007_usuario_produto_unitb001_usuario]
GO
ALTER TABLE [dbo].[unitb007_usuario_produto]  WITH CHECK ADD  CONSTRAINT [FK_unitb007_usuario_produto_unitb006_produto] FOREIGN KEY([co_produto])
REFERENCES [dbo].[unitb006_produto] ([co_produto])
GO
ALTER TABLE [dbo].[unitb007_usuario_produto] CHECK CONSTRAINT [FK_unitb007_usuario_produto_unitb006_produto]
GO
ALTER TABLE [dbo].[duntb001_familia]  WITH CHECK ADD  CONSTRAINT [CK_duntb001_familia] CHECK  ((len(ltrim(rtrim([nu_cep])))=(8) OR [nu_cep] IS NULL))
GO
ALTER TABLE [dbo].[duntb001_familia] CHECK CONSTRAINT [CK_duntb001_familia]
GO
