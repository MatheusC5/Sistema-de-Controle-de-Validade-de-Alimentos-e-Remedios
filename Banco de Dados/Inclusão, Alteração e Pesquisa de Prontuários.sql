--Inclusão dos Prontuários--

Use CasaDeApoioNossoLar
Go
create procedure insere_Prontuarios
@ID_Prontuario int output,
@Idosos varchar(100),
@Enfermidades varchar(100),
@Alimentos varchar(100),
@Remedios varchar(100),
@Data_Criacao date,
@Data_Uso date,
@Prescricao_Observacoes varchar(300),
@ID_Idoso int,
@ID_Alimento int,
@ID_Remedio int

as

insert into Prontuarios (Idosos, Enfermidades, Alimentos, Remedios, Data_Criacao, Data_Uso, Prescricao_Observacoes, ID_Idoso, ID_Alimento, ID_Remedio)
values (@Idosos, @Enfermidades, @Alimentos, @Remedios, @Data_Criacao, @Data_Uso, @Prescricao_Observacoes, @ID_Idoso, @ID_Alimento, @ID_Remedio)

set @ID_Prontuario = (select @@identity)

--Inclusão dos Prontuários sem Prescricao_Observacoes--

Use CasaDeApoioNossoLar
Go
create procedure insere_Prontuarios_Sem_Prescricao_Observacoes
@ID_Prontuario int output,
@Idosos varchar(100),
@Enfermidades varchar(100),
@Alimentos varchar(100),
@Remedios varchar(100),
@Data_Criacao date,
@Data_Uso date,
@ID_Idoso int,
@ID_Alimento int,
@ID_Remedio int

as

insert into Prontuarios (Idosos, Enfermidades, Alimentos, Remedios, Data_Criacao, Data_Uso, Prescricao_Observacoes, ID_Idoso, ID_Alimento, ID_Remedio)
values (@Idosos, @Enfermidades, @Alimentos, @Remedios, @Data_Criacao, @Data_Uso, null, @ID_Idoso, @ID_Alimento, @ID_Remedio)

set @ID_Prontuario = (select @@identity)

--Inclusão dos Prontuários Versão Alimentos--

Use CasaDeApoioNossoLar
Go
create procedure insere_Prontuarios_Alimentos
@ID_Prontuario int output,
@Idosos varchar(100),
@Alimentos varchar(100),
@Data_Criacao date,
@Data_Uso date,
@ID_Idoso int,
@ID_Alimento int

as

insert into Prontuarios (Idosos, Enfermidades, Alimentos, Remedios, Data_Criacao, Data_Uso, Prescricao_Observacoes, ID_Idoso, ID_Alimento, ID_Remedio)
values (@Idosos, null, @Alimentos, null, @Data_Criacao, @Data_Uso, null, @ID_Idoso, @ID_Alimento, null)

set @ID_Prontuario = (select @@identity)

--Alterar Prontuários--

Use CasaDeApoioNossoLar
Go
create procedure alterar_Prontuarios
@ID_Prontuario int output,
@Idosos varchar(100),
@Enfermidades varchar(100),
@Alimentos varchar(100),
@Remedios varchar(100),
@Data_Criacao date,
@Data_Uso date,
@Prescricao_Observacoes varchar(300),
@ID_Idoso int,
@ID_Alimento int,
@ID_Remedio int

as

update Prontuarios set Idosos = @Idosos, Enfermidades = @Enfermidades, Alimentos = @Alimentos, Remedios = @Remedios, Data_Criacao = @Data_Criacao, Data_Uso = @Data_Uso, Prescricao_Observacoes = @Prescricao_Observacoes, ID_Idoso = @ID_Idoso, ID_Alimento = @ID_Alimento, ID_Remedio = @ID_Remedio
where ID_Prontuario = @ID_Prontuario

update Idosos set Nome = @Idosos where @ID_Idoso = ID_Idoso and @Idosos = Nome

update Alimentos set Nome = @Alimentos where @ID_Alimento = ID_Alimento and @Alimentos = Nome

update Remedios set Nome = @Remedios where @ID_Remedio = ID_Remedio and @Remedios = Nome

--Alterar Prontuários Sem Prescricao_Observacoes--

Use CasaDeApoioNossoLar
Go
create procedure alterar_Prontuarios_Sem_Prescricao_Observacoes
@ID_Prontuario int output,
@Idosos varchar(100),
@Enfermidades varchar(100),
@Alimentos varchar(100),
@Remedios varchar(100),
@Data_Criacao date,
@Data_Uso date,
@ID_Idoso int,
@ID_Alimento int,
@ID_Remedio int

as

update Prontuarios set Idosos = @Idosos, Enfermidades = @Enfermidades, Alimentos = @Alimentos, Remedios = @Remedios, Data_Criacao = @Data_Criacao, Data_Uso = @Data_Uso, Prescricao_Observacoes = null, ID_Idoso = @ID_Idoso, ID_Alimento = @ID_Alimento, ID_Remedio = @ID_Remedio
where ID_Prontuario = @ID_Prontuario

update Idosos set Nome = @Idosos where @ID_Idoso = ID_Idoso and @Idosos = Nome

update Alimentos set Nome = @Alimentos where @ID_Alimento = ID_Alimento and @Alimentos = Nome

update Remedios set Nome = @Remedios where @ID_Remedio = ID_Remedio and @Remedios = Nome

--Alterar Prontuários Versão Alimentos--

Use CasaDeApoioNossoLar
Go
create procedure alterar_Prontuarios_Alimentos
@ID_Prontuario int output,
@Idosos varchar(100),
@Alimentos varchar(100),
@Data_Criacao date,
@Data_Uso date,
@ID_Idoso int,
@ID_Alimento int

as

update Prontuarios set Idosos = @Idosos, Enfermidades = null, Alimentos = @Alimentos, Remedios = null, Data_Criacao = @Data_Criacao, Data_Uso = @Data_Uso, Prescricao_Observacoes = null, ID_Idoso = @ID_Idoso, ID_Alimento = @ID_Alimento, ID_Remedio = null
where ID_Prontuario = @ID_Prontuario

update Idosos set Nome = @Idosos where @ID_Idoso = ID_Idoso and @Idosos = Nome

update Alimentos set Nome = @Alimentos where @ID_Alimento = ID_Alimento and @Alimentos = Nome

--Pesquisar Idosos nos Prontuários--

Use CasaDeApoioNossoLar
Go
create procedure pesquisar_Prontuario_Idosos
@pesquisar varchar(100) = null

as

begin
	if @pesquisar is null
		select * from Prontuarios
	else
		select * from Prontuarios
			where Idosos like '%' + @pesquisar + '%'	
end