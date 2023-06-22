--Inclusão dos Remédios--

Use CasaDeApoioNossoLar
Go
create procedure insere_Remedios
@ID_Remedio int output,
@Nome varchar(100),
@Marca varchar(100),
@Unidade int,
@Validade date,
@Estoque decimal(10,3),
@Peso varchar(20)

as

insert into Remedios(Nome, Marca, Unidade, Validade, Estoque, Peso)
values (@Nome, @Marca, @Unidade, @Validade, @Estoque, @Peso)

set @ID_Remedio = (select @@identity)

--Inclusão dos Remédios Sem Marca--

Use CasaDeApoioNossoLar
Go
create procedure insere_Remedios_Sem_Marca
@ID_Remedio int output,
@Nome varchar(100),
@Unidade int,
@Validade date,
@Estoque decimal(10,3),
@Peso varchar(20)

as

insert into Remedios(Nome, Marca, Unidade, Validade, Estoque, Peso)
values (@Nome, null, @Unidade, @Validade, @Estoque, @Peso)

set @ID_Remedio = (select @@identity)

--Alterar Remédios--

Use CasaDeApoioNossoLar
Go
create procedure alterar_Remedios
@ID_Remedio int,
@Nome varchar(100),
@Marca varchar(100),
@Unidade int,
@Validade date,
@Estoque decimal(10,3),
@Peso varchar(20)

as

update Remedios set Nome = @Nome, Marca = @Marca, Unidade = @Unidade, Validade = @Validade, Estoque = @Estoque, Peso = @Peso
where ID_Remedio = @ID_Remedio

if exists(select * from Prontuarios where Remedios != ' ')
update Prontuarios set Remedios = @Nome where ID_Remedio = @ID_Remedio and Remedios != ' '
else
update Prontuarios set Remedios = ' ' where ID_Remedio = @ID_Remedio and Remedios = ' '

--Alterar Remédios Sem Marca--

Use CasaDeApoioNossoLar
Go
create procedure alterar_Remedios_Sem_Marca
@ID_Remedio int,
@Nome varchar(100),
@Unidade int,
@Validade date,
@Estoque decimal(10,3),
@Peso varchar(20)

as

update Remedios set Nome = @Nome, Marca = null, Unidade = @Unidade, Validade = @Validade, Estoque = @Estoque, Peso = @Peso
where ID_Remedio = @ID_Remedio

if exists(select * from Prontuarios where Remedios != ' ')
update Prontuarios set Remedios = @Nome where ID_Remedio = @ID_Remedio and Remedios != ' '
else
update Prontuarios set Remedios = ' ' where ID_Remedio = @ID_Remedio and Remedios = ' '

--Excluir Remédios--

Use CasaDeApoioNossoLar
Go
create procedure excluir_Remedios
@ID_Remedio int

as

alter table Prontuarios nocheck constraint all
delete from Remedios where ID_Remedio = @ID_Remedio
alter table Prontuarios check constraint all