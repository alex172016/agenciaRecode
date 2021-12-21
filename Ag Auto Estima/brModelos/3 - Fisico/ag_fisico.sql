-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE Reserva (
Email VARCHAR(10),
Data_volta VARCHAR(10),
Nome VARCHAR(10),
Data_ida VARCHAR(10),
id_reserva VARCHAR(10) PRIMARY KEY,
Origem VARCHAR(10),
Destino VARCHAR(10),
Telefone VARCHAR(10),
Cpf VARCHAR(10)
)

CREATE TABLE CLiente (
Telefone VARCHAR(10),
Rua VARCHAR(10),
Nome VARCHAR(10),
Cpf VARCHAR(10),
Id VARCHAR(10) PRIMARY KEY,
data_nasc VARCHAR(10),
RG VARCHAR(10),
Email VARCHAR(10),
Estado VARCHAR(10),
Cidade VARCHAR(10),
Cep VARCHAR(10),
id_reserva VARCHAR(10),
FOREIGN KEY(id_reserva) REFERENCES Reserva (id_reserva)
)

