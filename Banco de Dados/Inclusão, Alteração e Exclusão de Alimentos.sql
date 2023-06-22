--Inclusão dos Alimentos--

Use CasaDeApoioNossoLar
Go
create procedure insere_Alimentos
@ID_Alimento int output,
@Nome varchar(100),
@Marca varchar(100),
@Unidade int,
@Validade date,
@Estoque decimal(10,3),
@Peso varchar(20)

as

insert into Alimentos(Nome, Marca, Unidade, Validade, Estoque, Peso)
values (@Nome, @Marca, @Unidade, @Validade, @Estoque, @Peso)

set @ID_Alimento = (select @@identity)

--Inclusão dos Alimentos Sem Marca--

Use CasaDeApoioNossoLar
Go
create procedure insere_Alimentos_Sem_Marca
@ID_Alimento int output,
@Nome varchar(100),
@Unidade int,
@Validade date,
@Estoque decimal(10,3),
@Peso varchar(20)

as

insert into Alimentos(Nome, Marca, Unidade, Validade, Estoque, Peso)
values (@Nome, null, @Unidade, @Validade, @Estoque, @Peso)

set @ID_Alimento = (select @@identity)

--Alterar Alimentos--

Use CasaDeApoioNossoLar
Go
create procedure alterar_Alimentos
@ID_Alimento int,
@Nome varchar(100),
@Marca varchar(100),
@Unidade int,
@Validade date,
@Estoque decimal(10,3),
@Peso varchar(20)

as

update Alimentos set Nome = @Nome, Marca = @Marca, Unidade = @Unidade, Validade = @Validade, Estoque = @Estoque, Peso = @Peso
where ID_Alimento = @ID_Alimento

update Prontuarios set Alimentos = @Nome where ID_Alimento = @ID_Alimento

--Alterar Alimentos Sem Marca--

Use CasaDeApoioNossoLar
Go
create procedure alterar_Alimentos_Sem_Marca
@ID_Alimento int,
@Nome varchar(100),
@Unidade int,
@Validade date,
@Estoque decimal(10,3),
@Peso varchar(20)

as

update Alimentos set Nome = @Nome, Marca = null, Unidade = @Unidade, Validade = @Validade, Estoque = @Estoque, Peso = @Peso
where ID_Alimento = @ID_Alimento

update Prontuarios set Alimentos = @Nome where ID_Alimento = @ID_Alimento

--Excluir Alimentos--

Use CasaDeApoioNossoLar
Go
create procedure excluir_Alimentos
@ID_Alimento int

as

alter table Prontuarios nocheck constraint all
delete from Alimentos where ID_Alimento = @ID_Alimento
alter table Prontuarios check constraint all