#1
CREATE TABLE Empregado AS SELECT Id, Nome, Salario FROM Pessoa WHERE Id <=35; -- A nova tabela fica com 3 novos registos
select * from empregado;
#2
CREATE TABLE PessoaMenor AS SELECT * FROM Pessoa WHERE idade < 18;
select * from pessoamenor;
#3
ALTER TABLE pessoa ADD Fax varchar(15);
#4
select * from pessoa; 
#5
ALTER TABLE pessoa MODIFY Fax varchar(25);
#6
ALTER TABLE Pessoa MODIFY Salario Decimal(10,2) NULL; -- Altera o numero de casas decimais dos valores da coluna Salario
#7
ALTER TABLE pessoa MODIFY Salario Decimal(10,2) not null;
#8
DROP TABLE pessoamenor;
#9
CREATE VIEW Gestores AS SELECT * from Pessoa where salario > 200000; -- Cria uma view onde mostra todas as infos das pessoas que têm o salario maior que 200000
#10
CREATE VIEW People1 AS SELECT * from Pessoa where salario < 100000;
#11
CREATE VIEW People2 AS SELECT Id, Nome, Salario from Pessoa where salario < 100000;
#12
select * from people1;
#13
select * from people2;
#14
CREATE VIEW People03 (Num, Nome, Ordenado) AS SELECT Id, Nome, Salario from Pessoa where salario between 20000 and 100000; -- Cria uma View com o NumDeIdentificação, Nome e ordenado das pessoas com salario entre 20000 e 100000
#15
select * from people3;
#16
select * from people03 where ordenado > 70000;
#17
update people03 set ordenado = 20000 where num = "42";
#18
select * from people03; -- O Ordenado do id 42 foi alterado para 20000
#19
UPDATE People2 SET SALARIO=53000 WHERE ID=42;
#20
select * from people1;
#21
select * from people2;
#22
select * from people03;
#23
select * from pessoa;
#30
-- Ao alterar valores nas views, altera também nas tables, como aconteceu com o ordenado do António Dias (Id 42)
#31
 SELECT nome, cod_postal, localidade from Pessoa, Postal where cod_postal=codigo; -- Seleciona as pessoas que vivem no respetivo codigo postal, e relaciona o codigo postal com a respetiva localidade
 #32
 create view Moradas as select nome, localidade from pessoa, postal;
 #33
 CREATE VIEW vComissao(Id, Nome, salario,comissão) AS SELECT C.id, nome, salario,sum(valor) FROM Pessoa P, Comissao C WHERE P.id = C.id GROUP BY C.id, Nome, salario;
 -- Seleciona as informações das pessoas e soma todas as comissões associadas ao seu id 
#34
create view Resultado (Nome, salario,comissão) as select nome, salario, sum(valor) from Pessoa, Comissao where salario < 100000;
#35
CREATE VIEW Teste AS SELECT * FROM Pessoa WHERE salario >= 10000 WITH CHECK OPTION; -- Cria uma view onde mostra as pessoas que ganhem tanto ou mais que 10000


INSERT INTO Teste VALUES(111,'Maria Rico',33,74000,'789654',1500,null);
INSERT INTO Teste VALUES(112,'Joana Menos',34,4000,'123654',1500,null); --

select * from teste;

CREATE VIEW Teste2 AS SELECT * FROM Pessoa WHERE salario <10000 WITH CHECK OPTION; -- Cria uma view onde mostra as pessoas que ganhem menos que 10000

INSERT INTO Pessoa VALUES(200,'José Pobre',33,400,'789654',1500,null);
INSERT INTO Pessoa VALUES(201,'Luís Rico',34,74000,'123654',1500,null); 

select * from teste2;

-- Ambas as views consegiram filtrar em tempo real todas as condições
-- As CheckOptions limitam o inserir de informação nas views conforme a regra feita na query

#36
 DROP VIEW Teste;
 
#37
CREATE UNIQUE INDEX indNome ON Pessoa(Nome);
CREATE INDEX indSal ON Pessoa(Salario DESC);
CREATE UNIQUE INDEX indComissao ON Comissao(Id, Id_msg);

#38
DROP INDEX indNome ON Pessoa;
DROP INDEX indSal ON Pessoa;
DROP INDEX indComissao ON Comissao;
