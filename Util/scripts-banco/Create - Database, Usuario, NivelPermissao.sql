CREATE DATABASE aps2020;

CREATE TABLE Usuario (
     IdUsuario int NOT NULL AUTO_INCREMENT,
     Nome varchar(255) NOT NULL,
     Usuario varchar(255) NOT NULL,
     Senha varchar(255) NOT NULL,
     Email varchar(255) NOT NULL,
     Telefone varchar(255) NOT NULL,
     Idade int NOT NULL,
     IdNivelPermissao int NOT NULL,
     FOREIGN KEY (IdNivelPermissao) REFERENCES NivelPermissao(IdNivelPermissao),
     PRIMARY KEY (IdUsuario)
);

CREATE TABLE NivelPermissao(
	IdNivelPermissao int NOT NULL auto_increment,
    NivelPermissao varchar(255) NOT NULL,
    PRIMARY KEY (IdNivelPermissao)
)

