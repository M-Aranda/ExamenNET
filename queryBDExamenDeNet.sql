CREATE DATABASE examenNET;
GO

USE examenNET;
GO

CREATE TABLE Tipo_profesional(
id_tipo_profesional INT IDENTITY(1,1),
descripcion_tipo_profesional VARCHAR(150),
PRIMARY KEY(id_tipo_profesional)
);
GO

INSERT INTO Tipo_profesional VALUES ('Químico');
INSERT INTO Tipo_profesional VALUES ('Médico');
INSERT INTO Tipo_profesional VALUES ('Enfermero');
GO


CREATE TABLE Comuna(
id_comuna INT IDENTITY(1,1),
nombre_comuna VARCHAR (150),
PRIMARY KEY(id_comuna)
);
GO

CREATE TABLE Sexo(
id_sexo INT IDENTITY(1,1),
nombre_sexo VARCHAR (100),
PRIMARY KEY(id_sexo)
);
GO

INSERT INTO Sexo VALUES ('Hombre');
INSERT INTO Sexo VALUES ('Mujer');
GO


CREATE TABLE Tipo_usuario(
id_tipo_usuario INT IDENTITY(1,1),
nombre_tipo_usuario VARCHAR (150),
PRIMARY KEY(id_tipo_usuario)
);
GO

/* Se agrega el tipo de usuario */

INSERT INTO Tipo_usuario VALUES ('Denunciante');
INSERT INTO Tipo_usuario VALUES ('Profesional');
GO

CREATE TABLE Estado_Denuncia(
id_estado INT IDENTITY (1,1),
nombre_estado VARCHAR (100),
PRIMARY KEY(id_estado)
);
GO

INSERT INTO Estado_Denuncia VALUES ('Ingresado');
INSERT INTO Estado_Denuncia VALUES ('Recepción por experto');
INSERT INTO Estado_Denuncia VALUES ('Recabar mayor información');
INSERT INTO Estado_Denuncia VALUES ('Cerrado
');
GO


CREATE TABLE Usuario(
correo_usuario VARCHAR (100),
id_sexo INT,
id_tipo_usuario INT,
nombres VARCHAR (100),
ap_paterno VARCHAR (100),
ap_materno VARCHAR (100),
clave VARCHAR(32),
fecha_nacimiento DATE,
FOREIGN KEY (id_sexo) REFERENCES Sexo (id_sexo),
FOREIGN KEY (id_tipo_usuario) REFERENCES Tipo_usuario (id_tipo_usuario),
PRIMARY KEY(correo_usuario) 
);
GO


CREATE TABLE UsuarioExperto(
id_usuario_experto INT,
id_tipo_profesional INT,
correo_usuario VARCHAR (100),
FOREIGN KEY (id_tipo_profesional) REFERENCES Tipo_profesional (id_tipo_profesional),
FOREIGN KEY (correo_usuario) REFERENCES Usuario (correo_usuario),
PRIMARY KEY(id_usuario_experto)
);
GO



CREATE TABLE Denuncia(
id_denuncia INT IDENTITY (1,1),
correo_usuario VARCHAR (100),
id_comuna INT,
id_estado INT,
fecha_ingreso DATETIME,
descripcion_caso VARCHAR (500),
fecha_cierre DATETIME,
FOREIGN KEY (id_comuna) REFERENCES Comuna (id_comuna),
FOREIGN KEY (id_estado) REFERENCES Estado_denuncia (id_estado),
PRIMARY KEY (id_denuncia)
);
GO

CREATE TABLE Detalle_Denuncia(
correlativo_interno INT IDENTITY (1,1),
id_denuncia INT,
correo_profesional VARCHAR (100),
id_tipo_profesional INT,
fecha_transaccion DATETIME,
observacion_profesional VARCHAR (300),
FOREIGN KEY (id_denuncia) REFERENCES Denuncia (id_denuncia),
/*
UsuarioExperto debiese tener una clave primaria, no este despelote desnormalizado

FOREIGN KEY (correo_profesional) REFERENCES UsuarioExperto (correo_usuario),
FOREIGN KEY (id_tipo_profesional) REFERENCES UsuarioExperto (id_tipo_profesional),
*/

PRIMARY KEY(correlativo_interno)

);
GO



/*
SELECT * FROM Usuario;
GO
SELECT * FROM Sexo;
GO
USE MASTER
GO
DROP DATABASE examenNET
GO

*/