-- Comentario curto

/* insere 
-
-
comentario longo
-
-
*/



/* 
Clientes(Id int primary key, Nome char(100));
Enderecos (Id int primary key, Endereco varchar(100), Numero int, Bairro varchar(50), Cidade varchar(20),
Estado char(2), Clientes_Id int reference Clientes(Id));
*/

CREATE TABLE Clientes(
    Id int not null primary key,
    Nome char(100)
);

CREATE TABLE Enderecos(
    Id int not null primary key,
    Endereco varcahr(100),
    Numero int,
    Bairro varchar(50),
    Cidade varchar(20),
    Estado char(2),
    Clientes_Id int not null,
    Constraint Clientes_tem_Enderecos
        Foreign key(Clientes_Id) references Clientes(Id)
);