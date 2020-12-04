#1
use mysql;
select user from user;

#2
create user joanahenriques identified by 'Q!12?w34';
create user danielgomes identified by '1652gQ&#';
alter user joanahenriques password expire never;
alter user danielgomes password expire interval 180 day;

#3
select * from user;

#4
Set Password For joanahenriques ='pirata';
Set Password For danielgomes = 'caraiba';

#5
alter user joanahenriques identified by 'pirata' account lock;

#6
rename user danielgomes to danielsampaio;

#7
show grants for joanahenriques;

#8
Grant all On vendedores.pessoa To joanahenriques;
Grant all On vendedores.comissao To joanahenriques;

#9
show grants for joanahenriques;

#10
show grants for danielsampaio;

#11
Grant update (idade) On vendedores.pessoa To danielsampaio;

#12
show grants for danielsampaio;

#13
select pessoa from vendedores; -- Não pois não tem permissão para dar select, só update

#14
update pessoa set idade = idade + 1;
select * from pessoa;

#16
REVOKE ALL ON *.* FROM joanahenriques;
FLUSH PRIVILEGES;

#17
show grants for joanahenriques;

#18
GRANT ALL ON *.* TO joanahenriques with grant option;
FLUSH PRIVILEGES;

#20
Grant select On vendedores.pessoa To danielsampaio;

#21
Grant insert On vendedores.pessoa To danielsampaio;

#23
insert into comissao(Id, Id_Msg, valor) values (111, 50, 1050);
#Parte2

  
use vendedores;
#1
Set Autocommit=0;
   
#2
START TRANSACTION;
   
#3
INSERT INTO postal (Codigo, Localidade)
VALUES ('2410', 'Leiria');

-- 4
select * from postal;

#5
COMMIT;

#6 
delete from postal where codigo!='2410';

#7
rollback;

#8 
Set Autocommit=1;