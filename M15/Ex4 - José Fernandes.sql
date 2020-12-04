#1
create database NoviCursos;
use NoviCursos;
create table Aluno (
NumAI int auto_increment,
NomeAI char(30) not null, 
DataNascAI date, 
primary key(NumAI),
Sexo char(12)
);

create table Curso (
CodCurso int not null primary key auto_increment,
NomeCurso char(30) unique 
);

create table Disciplina (
CodDisc int primary key not null auto_increment,
NomeDisc char(30) unique not null
);

create table Aluno_Curso (
NumAI int not null,
CodCurso int,
FOREIGN KEY (CodCurso) REFERENCES Curso(CodCurso),
FOREIGN KEY (NumAI) REFERENCES Aluno(NumAI)
);

create table Curso_Disciplina (
CodDisc int not null ,
CodCurso int,
FOREIGN KEY (CodCurso) REFERENCES Curso(CodCurso),
FOREIGN KEY (CodDisc) REFERENCES Disciplina(CodDisc)
);

#2

insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Rui","1986-03-18","M");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Manuel","1991-05-01","M");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Diogo","1987-01-24 ","M");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Bernardo","1992-04-15 ","M");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Tiago","1900-01-01 ","M");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Gonçalo","1991-08-31","M");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Henrique","1989-07-26 ","M");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Olga","1900-01-01 ","F");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Marta","1993-10-16","F");
insert into Aluno(NomeAI,DataNascAI,Sexo) values ("Sandra","1994-09-08","F");

insert into Curso(NomeCurso) values ("PTGPSI");
insert into Curso(NomeCurso) values ("PTIG");
insert into Curso(NomeCurso) values ("PTM");
insert into Curso(NomeCurso) values ("PTCM");
insert into Curso(NomeCurso) values ("PTAP");
insert into Curso(NomeCurso) values ("PTAGD");
insert into Curso(NomeCurso) values ("PTG");

insert into Disciplina(NomeDisc) values ("Matemática");
insert into Disciplina(NomeDisc) values ("Inglês");
insert into Disciplina(NomeDisc) values ("Francês");
insert into Disciplina(NomeDisc) values ("Físico-química");
insert into Disciplina(NomeDisc) values ("Ed. Física");
insert into Disciplina(NomeDisc) values ("Arq. Computadores");
insert into Disciplina(NomeDisc) values ("Sistemas Operativos");
insert into Disciplina(NomeDisc) values ("Gestão");
insert into Disciplina(NomeDisc) values ("Economia");
insert into Disciplina(NomeDisc) values ("Gestão Desportiva");

insert into Aluno_Curso(NumAI,CodCurso) values (1,1);
insert into Aluno_Curso(NumAI,CodCurso) values (2,1);
insert into Aluno_Curso(NumAI,CodCurso) values (3,3);
insert into Aluno_Curso(NumAI,CodCurso) values (4,4);
insert into Aluno_Curso(NumAI,CodCurso) values (5,5);
insert into Aluno_Curso(NumAI,CodCurso) values (6,6);
insert into Aluno_Curso(NumAI,CodCurso) values (7,7);
insert into Aluno_Curso(NumAI,CodCurso) values (8,2);
insert into Aluno_Curso(NumAI,CodCurso) values (9,5);
insert into Aluno_Curso(NumAI,CodCurso) values (10,6);
select * from Aluno_Curso;


insert into Curso_Disciplina(CodDisc,CodCurso) values (1,1);
insert into Curso_Disciplina(CodDisc,CodCurso) values (1,2);
insert into Curso_Disciplina(CodDisc,CodCurso) values (1,3);
insert into Curso_Disciplina(CodDisc,CodCurso) values (2,3);
insert into Curso_Disciplina(CodDisc,CodCurso) values (3,2);
insert into Curso_Disciplina(CodDisc,CodCurso) values (6,1);
insert into Curso_Disciplina(CodDisc,CodCurso) values (7,1);
insert into Curso_Disciplina(CodDisc,CodCurso) values (4,1);
insert into Curso_Disciplina(CodDisc,CodCurso) values (5,4);
insert into Curso_Disciplina(CodDisc,CodCurso) values (8,2);
insert into Curso_Disciplina(CodDisc,CodCurso) values (9,7);
insert into Curso_Disciplina(CodDisc,CodCurso) values (10,6);


#3
show tables;

#4
CREATE TABLE Disciplina_Curso AS SELECT * FROM Curso_Disciplina WHERE CodDisc < 5;

#5
Create index IdxNomeD on Disciplina(NomeDisc);
Create index IdxNomeC on Curso(NomeCurso);

#6
update aluno set Sexo = "1" where Sexo = "M";
update aluno set Sexo = "0" where Sexo = "F";
ALTER TABLE Aluno Modify COLUMN Sexo int;

#7
Alter table Disciplina_Curso rename DisciplinaPorCurso;


#8
alter table aluno add MoradaAI varchar(30) default 'Lisboa';

#9
alter table aluno drop column sexo;


#10

alter table aluno modify DataNascAI date default "1990-01-01";

#11
drop table Disciplinaporcurso;

#12
ALTER TABLE Disciplina DROP INDEX IdxNomeD;

#13
CREATE VIEW VAlunos AS SELECT aluno.NumAI,aluno.NomeAI,aluno.DataNascAI,aluno.MoradaAI,curso.NomeCurso from aluno,curso, aluno_curso where aluno.NumAI = aluno_curso.NumAI and curso.CodCurso = aluno_curso.CodCurso;
select * from VAlunos;

#14
create view VNomeDNasc as select NumAI as IdAluno, NomeAI as NomeAluno, DataNascAI as NascAluno, MoradaAI as Morada from aluno where DataNascAI < "1990-12-31"  with check option;

#15
select * from VNomeDNasc;

#16
update VNomeDNasc set NascAluno = "1991-01-01" where NascAluno = "1900-01-01"; -- Não dá porque está com check option

#17
drop view vnomednasc;

#18
drop user "joanahenriques@localhost"; 
drop user "danielgomes@localhost"; 

#19
create user SandraLeonel@localhost identified by 'QYg&$23!' password expire interval 120 day;
create user TiagoFernandes@localhost identified by '532UGY2@' password expire never;

#20
Set Password For SandraLeonel@localhost ='mogadoura';
Set Password For TiagoFernandes@localhost = 'castroverde';

#21
alter user SandraLeonel@localhost  identified by 'mogadoura' account lock;

#22
rename user TiagoFernandes@localhost to tiagocardoso@localhost;

#23
GRANT ALL ON *.* TO tiagocardoso with grant option;
flush privileges;
#24
Grant select (NomeAI) On novicursos.aluno To sandraleonel;
flush privileges;

#25
revoke all privileges, grant option from tiagocardoso@localhost;
flush privileges;

#26
Grant select,update (Morada) On novicursos.VNomeDNasc To tiagocardoso;

#27
show grants for tiagocardoso@localhost;
show grants for sandraleonel@localhost;

#28
update vnomednasc set Morada = "Porto";