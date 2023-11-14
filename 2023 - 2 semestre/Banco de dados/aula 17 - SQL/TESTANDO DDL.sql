CREATE TABLE Clientes(           --TABELA CLIENTES
    Id int Not Null Primary key, --ID DA TABELA
    Nome char(100)
);

CREATE TABLE Enderecos(            --TABELA ENDERECOS
    Id int Not Null Primary Key,   --ID DA TABELA
    Logradouro varchar (100),
    Numero int,
    Bairro varchar (50),
    Cidade varchar(20),
    Estado char(2),
    Clientes_Id int Not Null,
    Constraint Clientes_tem_Enderecos
        Foreign Key (Clientes_Id) references Clientes(Id)
);

ALTER TABLE Enderecos add column Email varchar(50), --ADICIONAR ALGUMA COLUNA EM UMA TABELA
ALTER TABLE Enderecos drop column Email,            -- EXCLUI ALGUMA COLUNA 

ALTER TABLE Enderecos drop   --DROPANDO(APAGANDO) A CHAVE ESTRANGEIRA(FK)
    Constraint Clientes_tem_Enderecos,
ALTER TABLE Enderecos add    --ADICIONA UMA NOVA CONSTRAINT NA TABELA
    Constraint Nova_Constraint
        Foreign key(Clientes_Id) references Clientes(Id);

INSERT INTO Clientes(Id, Nome) --INSERE UM CLIENTE
    value(100, 'Mari'),
INSERT INTO Clientes(Id, Nome) --INSERE UM CLIENTE
    value(200, 'Lucas'), 
INSERT INTO Clientes(Id, Nome) --INSERE UM CLIENTE
    value(300, 'Joao');

INSERT INTO Enderecos(Id, Logradouro, Numero, Bairro, Cidade, Estado, Clientes_Id) --INSERE UM ENDERECO NOVO USANDO UM FK DE UM CLIENTE JA CRIADO
    Value(100, 'Das Rosa', 1980, 'Curtume', 'Torres', 'RS', 200);

INSERT INTO Enderecos(Id, Logradouro, Numero, Bairro, Cidade, Estado, Clientes_Id)  --INSERE UM ENDERECO NOVO USANDO UM FK DE UM CLIENTE JA CRIADO
    Value(200, 'Rua das tirivas', 36, 'vila sao joao', 'Torres', 'RS', 100);

Update Enderecos set Logradouro='Rua Leopoldino João Da Rosa' WHERE Id=100; --ATUALIZA ALGUM DADO DE ALGUMA COLUNA

Update Clientes set Nome='luscas' WHERE Id=200;