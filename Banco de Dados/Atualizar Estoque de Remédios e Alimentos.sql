--Trigger para Atualizar Estoque de Alimentos e Remédios--

Use CasaDeApoioNossoLar
Go
CREATE TRIGGER [atualizar_Estoque_Alimentos_Remedios]
ON Atualizar_Estoque
FOR INSERT
AS BEGIN
Update a
SET a.Estoque = a.[Estoque] - e.Quantidade_Alimentos
FROM Alimentos AS a
INNER JOIN inserted AS e
ON a.ID_Alimento = e.[ID_Alimento]
WHERE a.ID_Alimento = e.ID_Alimento

Update r
SET r.Estoque = r.[Estoque] - e.Quantidade_Remedios
FROM Remedios AS r
INNER JOIN inserted AS e
ON r.ID_Remedio = e.[ID_Remedio]
WHERE r.ID_Remedio = e.ID_Remedio
END