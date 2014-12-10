--TABELA COM OS DADOS DO CONDOMINIO--
create table tbCondominio
(
IDCONDOMINIO int identity(1,1) primary key,
NOME varchar(50),
ENDERECO varchar(100),
SINDICO int 
);
--TABELA COM OS DADOS DO BLOCO DE APATAMENTO--
create table tbBloco
(
idBLOCO int identity(1,1) primary key,
DESCRICAO varchar(20),
CONDOMINIO int FOREIGN KEY REFERENCES tbCondominio(idCondominio)
);
--TABELA COM OS DADOS DO MORADORES--
create table tbMorador
(
idMORADOR int identity(1,1) primary key,
NOME varchar(50),
CPF varchar(11),
RG varchar(10)
);
--TABELA COM OS DADOS DO APARTAMENTO--
create table tbApartamento
(
idApartamento int identity(1,1) primary key,
NUMERO int,
BLOCO int FOREIGN KEY REFERENCES tbBloco(idBloco),
MORADOR int FOREIGN KEY REFERENCES tbMorador(idMorador)
);

--TABELA COM OS DADOS DO FUNCIONARIO--
create table tbFuncionario
(
idFUNCIONARIO int identity(1,1) primary key,
NOME varchar(50),
CPF varchar(11),
RG varchar(10),
CARGO varchar(20),
SALARIO varchar(20),
CONDOMINIO int FOREIGN KEY REFERENCES tbCondominio(idCondominio)
);
--TABELA COM OS DADOS DO CUSTO--
CREATE TABLE tbCusto
(
idCUSTO INT IDENTITY(1,1) PRIMARY KEY,
DATALANCAMENTO date,
DESCRICAO varchar(50),
DATAVENCIMENTO date,
VALOR varchar(20),
PAGO int,
APARTAMENTO int foreign key references tbApartamento(idApartamento) on update cascade on delete cascade
);

alter table tbCondominio add constraint Sindico
foreign key (Sindico) references tbMorador(idMorador)