--Inclusão dos Idosos--

Use CasaDeApoioNossoLar
Go
create procedure insere_Idosos
@ID_Idoso int output,
@Nome varchar(100),
@Data_Nascimento date,
@Endereco_Responsavel varchar(300),
@Telefone_Responsavel varchar(20),
@Celular_Responsavel varchar(20),
@Telefone_Emergencia varchar(20)

as

insert into Idosos (Nome, Data_Nascimento, Endereco_Responsavel, Telefone_Responsavel, Celular_Responsavel, Telefone_Emergencia)
values (@Nome, @Data_Nascimento, @Endereco_Responsavel, @Telefone_Responsavel, @Celular_Responsavel, @Telefone_Emergencia)

set @ID_Idoso = (select @@identity)

--Alterar Idosos--

Use CasaDeApoioNossoLar
Go
create procedure alterar_Idosos
@ID_Idoso int,
@Nome varchar(100),
@Data_Nascimento date,
@Endereco_Responsavel varchar(300),
@Telefone_Responsavel varchar(20),
@Celular_Responsavel varchar(20),
@Telefone_Emergencia varchar(20)

as

update Idosos set Nome = @Nome, Data_Nascimento = @Data_Nascimento, Endereco_Responsavel = @Endereco_Responsavel, Telefone_Responsavel = @Telefone_Responsavel, Celular_Responsavel = @Celular_Responsavel, Telefone_Emergencia = @Telefone_Emergencia
where ID_Idoso = @ID_Idoso

update Prontuarios set Idosos = @Nome where ID_Idoso = @ID_Idoso

--Excluir Idosos--

Use CasaDeApoioNossoLar
Go
create procedure excluir_Idosos
@ID_Idoso int

as

alter table Prontuarios nocheck constraint all
delete from Idosos where ID_Idoso = @ID_Idoso
alter table Prontuarios check constraint all

--Pesquisar Idosos--

Use CasaDeApoioNossoLar
Go
create procedure pesquisar_Idosos
@pesquisar varchar(100) = null

as

begin
	if @pesquisar is null
		select * from Idosos
	else
		select * from Idosos
			where Nome like '%' + @pesquisar + '%'		
end