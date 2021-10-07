CREATE DATABASE VENTASPruebasSofwareTesteo

CREATE TABLE [dbo].[Clientes](
	[idcli] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[razoncli] [varchar](250) NOT NULL,
	[tipodoc] [numeric](18, 0) NOT NULL,
	[numdoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idcli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[direcciones](
	[iddir] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[idcli] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
	[distrito] [varchar](50) NOT NULL,
	[provincia] [varchar](50) NOT NULL,
	[departamento] [varchar](50) NOT NULL,
 CONSTRAINT [FK_cliente] PRIMARY KEY CLUSTERED 
(
	[iddir] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 