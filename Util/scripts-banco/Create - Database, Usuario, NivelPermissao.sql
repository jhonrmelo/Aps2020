CREATE DATABASE aps2020;

CREATE TABLE Usuario (
     Id int  NOT NULL AUTO_INCREMENT,
     Nome varchar(255) NOT NULL,
     Login varchar(255) unique NOT NULL,
     Senha varchar(255) NOT NULL,
     Email varchar(255) unique NOT NULL,
     Telefone varchar(255) NOT NULL,
     Idade int NOT NULL,
     PRIMARY KEY (Id)
);

Create Table UsuarioXPermissoes (
	ID int primary key NOT NULL auto_increment,
    UsuarioID int not null,
    PermissaoID int not null,
    FOREIGN KEY (PermissaoID) REFERENCES NivelPermissao(Id),
	FOREIGN KEY (UsuarioID) REFERENCES Usuario(Id),
	unique(UsuarioID, PermissaoID)
);

CREATE TABLE NivelPermissao(
	Id int NOT NULL auto_increment,
    NomePermissao varchar(255) NOT NULL,
    PRIMARY KEY (Id)
)


INSERT INTO NIVELPERMISSAO VALUES (0, "Servidor"),  (0, "Cliente")
INSERT INTO USUARIO VALUES (0,"Admin", "Admin","1234", "admin@admin.com", "(19)91111-1111", 20)
INSERT INTO USUARIOXPERMISSOES VALUES (0,1,1)
INSERT INTO USUARIOXPERMISSOES VALUES (0,1,2)






