CREATE TABLE Fornecedor(
    Codigo int not null primary key,
    Nome varchar(50)
);

CREATE TABLE Categoria(
    Codigo int not null primary key,
    Nome varchar(20)
);

CREATE TABLE Produtos(
    Codigo int not null primary key,
    Descricao varchar(100),
    Data_Cadastro Date,
    Valor_Unitario int,
    Codigo_Categoria int not null,
    Constraint Produto_tem_categoria
        Foreign key (Codigo_Categoria) references Categoria(Codigo)
);

CREATE TABLE Pedido(
    Quantidade int not null primary key,
    Valor_Unitario int,
    Data_Pedido Date,
    Codigo_Produto int not null,
    Codigo_Fornecedor int not null,
    Constraint Pedido_tem_produto
        Foreign key (Codigo_Produto) references Produtos(Codigo),
    Constraint Pedido_tem_fornecedor
        Foreign key (Codigo_Fornecedor) references Fornecedor(Codigo)
);

/* Inserts na tabela FORNECEDOR */
INSERT INTO Fornecedor (Codigo, Nome)
values (10, 'Jonatan')

INSERT INTO Fornecedor (Codigo, Nome)
values (20, 'Valmir')

INSERT INTO Fornecedor (Codigo, Nome)
values (30, 'Germano')
/* Inserts na tabela FORNECEDOR */


/* Inserts na tabela CATEGORIA */
INSERT INTO Categoria (Codigo, Nome)
values (10, 'Eletronicos')

INSERT INTO Categoria (Codigo, Nome)
values (20, 'Lanches')

INSERT INTO Categoria (Codigo, Nome)
values (30, 'Peças')
/* Inserts na tabela CATEGORIA */


/* Inserts na tabela Produtos */
INSERT INTO Produtos(Codigo, Descricao, Data_Cadastro, Valor_Unitario, Codigo_Categoria)
values (10, 'Broca diamantada 15mm', '06/11/2020', 35, 30)

INSERT INTO Produtos(Codigo, Descricao, Data_Cadastro, Valor_Unitario, Codigo_Categoria)
values (20, 'Pacote de batata frita 2kg ', '15/01/2022', 20, 20)

INSERT INTO Produtos(Codigo, Descricao, Data_Cadastro, Valor_Unitario, Codigo_Categoria)
values (30, 'Televisao AMOLED 87 polegadas', '12/11/2023', 10500, 10)
/* Inserts na tabela Produtos */


/* Inserts na tabela Pedido */
INSERT INTO Pedido (Quantidade, Valor_Unitario, Data_Pedido, Codigo_Produto, Codigo_Fornecedor)
values (2, 21000, '10/12/2023', 30, 30)

INSERT INTO Pedido (Quantidade, Valor_Unitario, Data_Pedido, Codigo_Produto, Codigo_Fornecedor)
values (20, 400, '02/10/2022', 20, 10)

INSERT INTO Pedido (Quantidade, Valor_Unitario, Data_Pedido, Codigo_Produto, Codigo_Fornecedor)
values (5, 175, '20/05/2023', 10, 20)
/* Inserts na tabela Pedido */

/* Comando para listar todos produtos cadastrados */
SELECT * FROM Produtos
/* Comando para listar todos produtos cadastrados */

/* Comando para consultar os pedidos feitos no mês de outubro */
SELECT Data_Pedido FROM Pedido
WHERE month(Data_Pedido)=10;
/* Comando para consultar os pedidos feitos no mês de outubro */

/* Comando para consultar os produtos que tem "palavra" no nome */
SELECT Descricao FROM Produtos
WHERE CONTAINS (Descricao, 'Palavra')
/* Comando para consultar os produtos que tem "palavra" no nome */
