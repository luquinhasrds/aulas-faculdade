'DDL ou Data Definition Language (Linguagem de Definição de dados)'

----------------------------------------------------------------------------------------------------------
CREATE > CRIAR ESTRUTURA | TABELA DO BANDO DE DADOS } TABELA(ATRIBUTOS 'coluna', RELACIONAMENTOS 'PK, FK')
----------------------------------------------------------------------------------------------------------

-----------------------------------------------------
ALTER > ALTERAR ESTRUTURA } ALTERAR:-COLUNAS
                                    -TIPO DE COLUNAS
                                    -DROP COLUNA
                                    -NOME TABELA
-----------------------------------------------------

--------------------------------------
DROP > REMOV3 ESTRUTURA (APAGA TABELA)
-------------------------------------




------------
-- OQUE É UM DADOS? É UM VALOR QUE SE ATRIBUI A ALGO;
------------
-- OQUE É UMA TUPLA? É UM CONJUNTO DE DADOS (INSERT NO BANCO DE DADOS);
------------
-- IMFORMAÇÃO: conjunto de dados processados;
------------
-- CONHECIMENTO: informacao que faz sentido
------------
----ETAPAS DE UMA MODELAGEM----

-->MODELO CONCEITUAL
    -->DESENHAR, DIAGRAMAR (ER = {entidade [] e relacionamento <>} );

-->MODELO LÓGICO
    -->ARMARIO (atributo   |    tipo         |    chave , ...) --referenciar tabela de onde tem PK
            -- (  ID       |  int not null   |   primary key)

    --> EXEMPLO       
        (Id int not null primary key).
        (Id_Entidade int not null)
        Constraint Entidade_Tem_Id
            Foreign Key (Id_Entidade) references Entidade (Id_Entidade),

-->MODELO FISICO
DDL (CREATE TABLE | ALTER  | DROP  )
DML ( INSERT INTO | UPDATE | SELECT)

----------------------------------------------------------------------------------------------------------------------------

    objeto do mundo real
      [           ] • NUM NOTA  (PK)                     [          ] • CPF
      [   venda   ] ○ CPF  (FK)            <>            [  cliente ] ○ NOME 
      [           ] ○ CNPJ                               [          ] ○ TELEFONE

circulo preenchido '•' = atributo identificador ID (PK)
circulo sem nada '○' = colunas do banco de dados


{venda}(1,n)   <>   (1,1){cliente} =  a tabela que tem "n" recebe a chave primaria da tabela em que esta se relacionando, tornando um "FK" na tabela que a recebe.

{produto}(1,n)   <>   (1,n){venda} =  cria uma nova tarefa e cada entidade envia sua PK se tornando uma FK na nova tabela.

{venda}(1,1)   <>   (1,1){cliente} =  faz a fusao das tabelas colocando todos os dados de uma tabela e tranferindo para a outra, deixando somente uma tabela.

-----------------------------------------------------------------------------------------------------------------------------

