--Inclusao de Atualizar_Estoque--

Use CasaDeApoioNossoLar
Go
create procedure insere_Atualizar_Estoque
@ID_Atualizar_Estoque int output,
@Alimentos varchar(100),
@Quantidade_Alimentos decimal(10,3),
@Remedios varchar(100),
@Quantidade_Remedios decimal(10,3),
@ID_Alimento int,
@ID_Remedio int

as

insert into Atualizar_Estoque (Alimentos, Quantidade_Alimentos, Remedios, Quantidade_Remedios, ID_Alimento, ID_Remedio)
values (@Alimentos, @Quantidade_Alimentos, @Remedios, @Quantidade_Remedios, @ID_Alimento, @ID_Remedio)

set @ID_Atualizar_Estoque = (select @@identity)

--Inclusão de Atualizar_Estoque Versão Alimentos--

Use CasaDeApoioNossoLar
Go
create procedure insere_Atualizar_Estoque_Alimento
@ID_Atualizar_Estoque int output,
@Alimentos varchar(100),
@Quantidade_Alimentos decimal(10,3),
@ID_Alimento int

as

insert into Atualizar_Estoque (Alimentos, Quantidade_Alimentos, Remedios, Quantidade_Remedios, ID_Alimento, ID_Remedio)
values (@Alimentos, @Quantidade_Alimentos, null, null, @ID_Alimento, null)

set @ID_Atualizar_Estoque = (select @@identity)

--Inclusão de Atualizar_Estoque Versão Remédios--

Use CasaDeApoioNossoLar
Go
create procedure insere_Atualizar_Estoque_Remedio
@ID_Atualizar_Estoque int output,
@Remedios varchar(100),
@Quantidade_Remedios decimal(10,3),
@ID_Remedio int

as

insert into Atualizar_Estoque (Alimentos, Quantidade_Alimentos, Remedios, Quantidade_Remedios, ID_Alimento, ID_Remedio)
values (null, null, @Remedios, @Quantidade_Remedios, null, @ID_Remedio)

set @ID_Atualizar_Estoque = (select @@identity)