--Criação das Tabelas--

Use CasaDeApoioNossoLar
Go
create table Idosos
(
	ID_Idoso INT IDENTITY NOT NULL PRIMARY KEY,
	Nome varchar(100),
	Data_Nascimento date,
	Endereco_Responsavel varchar(300),
	Telefone_Responsavel varchar(20),
	Celular_Responsavel varchar(20),
	Telefone_Emergencia varchar(20)
)

Use CasaDeApoioNossoLar
Go
create table Alimentos
(
	ID_Alimento INT IDENTITY NOT NULL PRIMARY KEY,
	Nome varchar(100),
	Marca varchar(100),
	Unidade int,
	Validade date,
	Estoque decimal(10,3),
	Peso varchar(20)
)

Use CasaDeApoioNossoLar
Go
create table Remedios
(
	ID_Remedio INT IDENTITY NOT NULL PRIMARY KEY,
	Nome varchar(100),
	Marca varchar(100),
	Unidade int,
	Validade date,
	Estoque decimal(10,3),
	Peso varchar(20)
)

Use CasaDeApoioNossoLar
Go
create table [Prontuarios]
(
	[ID_Prontuario] [INT] IDENTITY (1,1) not null,
	[Idosos] varchar(100),
	[Enfermidades] varchar (100),	
	[Alimentos] varchar(100),
	[Remedios] varchar(100),
	[Data_Criacao] date,
	[Data_Uso] date,
	[Prescricao_Observacoes] varchar(300),
	[ID_Idoso] [int],
	[ID_Alimento] [int],
	[ID_Remedio] [int]
CONSTRAINT [PK_Prontuario] PRIMARY KEY CLUSTERED
(
[ID_Prontuario]
) ON [PRIMARY],
CONSTRAINT [FK_ID_Idoso] FOREIGN KEY
(
[ID_Idoso]
) REFERENCES [Idosos] (
[ID_Idoso]
)
ON UPDATE CASCADE 
ON DELETE CASCADE,
CONSTRAINT [FK_ID_Alimento] FOREIGN KEY
(
[ID_Alimento]
) REFERENCES [Alimentos] (
[ID_Alimento]
) 
ON UPDATE CASCADE
ON DELETE CASCADE,
CONSTRAINT [FK_ID_Remedio] FOREIGN KEY
(
[ID_Remedio]
) REFERENCES [Remedios] (
[ID_Remedio]
) 
ON UPDATE CASCADE
ON DELETE CASCADE

) ON [PRIMARY]
GO

Use CasaDeApoioNossoLar
Go
create table [Atualizar_Estoque]
(
	[ID_Atualizar_Estoque] [INT] IDENTITY (1,1) not null,
    	[Alimentos] varchar(100),
	[Quantidade_Alimentos] decimal(10,3),
	[Remedios] varchar(100),
	[Quantidade_Remedios] decimal(10,3),
	[ID_Alimento] [int],
	[ID_Remedio] [int]
CONSTRAINT [PK_Atualizar_Estoque] PRIMARY KEY CLUSTERED
(
[ID_Atualizar_Estoque]
) ON [PRIMARY],
CONSTRAINT [FK_ID_Alimentos] FOREIGN KEY
(
[ID_Alimento]
) REFERENCES [Alimentos] (
[ID_Alimento]
)
ON UPDATE CASCADE 
ON DELETE CASCADE,
CONSTRAINT [Fk_ID_Remedios] FOREIGN KEY
(
[ID_Remedio]
) REFERENCES [Remedios] (
[ID_Remedio]
)
ON UPDATE CASCADE 
ON DELETE CASCADE

) ON [PRIMARY]
GO