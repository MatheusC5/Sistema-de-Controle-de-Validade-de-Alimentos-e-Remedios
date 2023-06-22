delete from Idosos
where ID_Idoso >=1

delete from Alimentos
where ID_Alimento >=1

delete from Remedios
where ID_Remedio >=1

delete from Prontuarios
where ID_Prontuario >=1

delete from Atualizar_Estoque
where ID_Atualizar_Estoque >=1

dbcc checkident (Idosos, reseed, 0)

dbcc checkident (Alimentos, reseed, 0)

dbcc checkident (Remedios, reseed, 0)

dbcc checkident (Prontuarios, reseed, 0)

dbcc checkident (Atualizar_estoque, reseed, 0)