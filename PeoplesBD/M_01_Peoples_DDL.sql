CREATE DATABASE M_Peoples;

USE M_Peoples;

CREATE TABLE Funcionarios
(
	IdFuncionarios INT PRIMARY KEY IDENTITY NOT NULL
	,Nome VARCHAR(255) NOT NULL UNIQUE
	,Sobrenome VARCHAR(255) NOT NULL UNIQUE
	,DataNascimento DATE
);

EXEC sp_rename 'Funcionarios.IdFuncionarios', 'IdFuncionario', 'COLUMN';