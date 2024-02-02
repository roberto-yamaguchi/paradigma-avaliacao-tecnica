
==== SQL DA BASE (SQL SERVER) ====


/* Tabela Departamento */
CREATE TABLE [dbo].[Departamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Tabela Pessoa */
CREATE TABLE [dbo].[Pessoa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartamentoId] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Salario] [money] NOT NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departamento] ON 
GO
INSERT [dbo].[Departamento] ([Id], [Nome]) VALUES (1, N'TI')
GO
INSERT [dbo].[Departamento] ([Id], [Nome]) VALUES (2, N'Vendas')
GO
SET IDENTITY_INSERT [dbo].[Departamento] OFF
GO
SET IDENTITY_INSERT [dbo].[Pessoa] ON 
GO
INSERT [dbo].[Pessoa] ([Id], [DepartamentoId], [Nome], [Salario]) VALUES (1, 1, N'Joe', 70000.0000)
GO
INSERT [dbo].[Pessoa] ([Id], [DepartamentoId], [Nome], [Salario]) VALUES (2, 2, N'Henry', 80000.0000)
GO
INSERT [dbo].[Pessoa] ([Id], [DepartamentoId], [Nome], [Salario]) VALUES (3, 2, N'Sam', 60000.0000)
GO
INSERT [dbo].[Pessoa] ([Id], [DepartamentoId], [Nome], [Salario]) VALUES (4, 1, N'Max', 90000.0000)
GO
SET IDENTITY_INSERT [dbo].[Pessoa] OFF
GO
ALTER TABLE [dbo].[Pessoa]  WITH CHECK ADD  CONSTRAINT [FK_Pessoa_Departamento] FOREIGN KEY([DepartamentoId])
REFERENCES [dbo].[Departamento] ([Id])
GO
ALTER TABLE [dbo].[Pessoa] CHECK CONSTRAINT [FK_Pessoa_Departamento]
GO


==== CONSULTAS SQL ====

-- DEPARTAMENTO
SELECT * FROM Departamento D;

-- PESSOA
SELECT * FROM Pessoa P;

-- COLABORADOR COM MAIOR SALÁRIO POR DEPARTAMENTO
SELECT D.Nome Departamento, P.Nome Pessoa, P.Salario Salario FROM Pessoa P
JOIN Departamento D ON P.DepartamentoId = D.Id
WHERE Salario IN (SELECT MAX(Salario) FROM Pessoa GROUP BY DepartamentoId);


