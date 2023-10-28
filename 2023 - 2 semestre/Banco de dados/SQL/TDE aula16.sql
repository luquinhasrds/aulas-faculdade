CREATE TABLE Professores(
    Id int not null primary key,
    Nome char(20),
    Especializacao char(20),
    Idade int
);

CREATE TABLE Disciplinas(
    Id_Disc int not null primary key,
    Disciplina char(15),
    Carga_Horaria int
);

CREATE TABLE Softwares(
    Id_software int not null primary key,
    Nome char(20),
    Tipo char(20)
);

CREATE TABLE Leciona(
    Id_leciona int not null primary key,
    Professor_Id int not null,
    Constraint Leciona_tem_professor
        Foreign key(Professor_Id) references Professores(Id),
    Disciplina_Id int not null,
    Constraint Leciona_tem_disciplina
        Foreign key(Disciplina_Id) references Disciplinas(Id_Disc)
);

CREATE TABLE utiliza(
    Id_utiliza int not null primary key,
    Software_Id int not null,
    Constraint utiliza_tem_software
        Foreign key(Software_Id) references Softwares(Id_software),
    Disciplina_Id int not null,
    Constraint utiliza_tem_disciplina
        foreign key(Disciplina_Id) references Disciplinas(Id_Disc)
);