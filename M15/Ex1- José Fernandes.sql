#3
insert into postal values(1250, "Mouraria");
#4
select * from postal;
#5
insert into pessoa(Id,Nome,Idade,Salario,Telefone, Cod_Postal) values(998, "Ana Rita", 35, 560000, 998, null);
#6
select * from pessoa;
#7
create table senior (
Id decimal(10,0) primary key not null,
Nome char(30), 
Idade int, 
Salario decimal(10,2), 
Telefone char(12),
Cod_Postal decimal(4,0)
);
Create index iNome on senior(Nome);
Create index iTelefone on senior(Telefone);

#8
INSERT INTO senior(Id,Nome,Idade,Salario,Telefone, Cod_Postal) SELECT * FROM pessoa WHERE Idade > 40;
#9
select * from senior;
#10
UPDATE Pessoa SET salario = salario * 1.1; /*Aumenta o salario das pessoas em 10%*/
#11
UPDATE Pessoa SET salario = salario * 1.2 where Nome = "Paulo Viegas" ;
#12
UPDATE Pessoa SET salario = (SELECT Salario FROM (SELECT Min(Salario) as Salario FROM Pessoa) as Salario), telefone = 123 WHERE id = 998; /* Copia o salário da pessoa que recebe menos e dá update desse valor no salario da Ana Rita*/
#13
UPDATE Pessoa SET telefone = concat('00351', telefone) WHERE telefone IS NOT NULL and cod_postal IN (SELECT codigo FROM postal WHERE localidade = 'Lisboa'); /*Adiciona o prefixo 00351 a todas as pessoas com o CodPostal de Lisboa*/
#14
DELETE FROM Senior; /*Apaga todos os resultados dentro da tabela senior*/
#15
DELETE FROM Pessoa Where id = 998; /* Apaga os dados da pessoa com o id 998*/
#16
DELETE FROM Pessoa Where Nome like '%da%';
#17
SELECT * FROM Postal WHERE codigo NOT IN ( SELECT cod_postal FROM Pessoa); /* Identifica o codigo postal em que nenhuma pessoa viva */
#18
Delete FROM Postal WHERE codigo NOT IN ( SELECT cod_postal FROM Pessoa);
#19
Delete from comissao where Valor > 3000;


