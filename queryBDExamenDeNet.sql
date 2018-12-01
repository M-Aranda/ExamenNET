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

INSERT INTO Tipo_profesional VALUES ('Qu�mico');
INSERT INTO Tipo_profesional VALUES ('M�dico');
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
INSERT INTO Estado_Denuncia VALUES ('Recepci�n por experto');
INSERT INTO Estado_Denuncia VALUES ('Recabar mayor informaci�n');
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
FOREIGN KEY (correo_usuario) REFERENCES Usuario (correo_usuario),
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

INSERT INTO Comuna VALUES ('Arica');
INSERT INTO Comuna VALUES ('Camarones');
INSERT INTO Comuna VALUES ('Putre');
INSERT INTO Comuna VALUES ('Iquique');
INSERT INTO Comuna VALUES ('Cami�a');
INSERT INTO Comuna VALUES ('Colchane');
INSERT INTO Comuna VALUES ('Huara');
INSERT INTO Comuna VALUES ('Pica');
INSERT INTO Comuna VALUES ('Antofagasta');
INSERT INTO Comuna VALUES ('Mejillones');
INSERT INTO Comuna VALUES ('Taltal');
INSERT INTO Comuna VALUES ('Calama');
INSERT INTO Comuna VALUES ('Ollague');
INSERT INTO Comuna VALUES ('Tocopilla');
INSERT INTO Comuna VALUES ('Cha�aral');
INSERT INTO Comuna VALUES ('Caldera');
INSERT INTO Comuna VALUES ('Copiap�');
INSERT INTO Comuna VALUES ('Freirina');
INSERT INTO Comuna VALUES ('Huasco');
INSERT INTO Comuna VALUES ('Vallenar');
INSERT INTO Comuna VALUES ('Canela');
INSERT INTO Comuna VALUES ('Illapel');
INSERT INTO Comuna VALUES ('Salamanca');
INSERT INTO Comuna VALUES ('Andacollo');
INSERT INTO Comuna VALUES ('Coquimbo');
INSERT INTO Comuna VALUES ('Paihuaco');
INSERT INTO Comuna VALUES ('Vicu�a');
INSERT INTO Comuna VALUES ('Combarbal�');
INSERT INTO Comuna VALUES ('Ovalle');
INSERT INTO Comuna VALUES ('Punitaqui');
INSERT INTO Comuna VALUES ('Rinconada');
INSERT INTO Comuna VALUES ('Papudo');
INSERT INTO Comuna VALUES ('Petorca');
INSERT INTO Comuna VALUES ('Zapallar');
INSERT INTO Comuna VALUES ('Hijuelas');
INSERT INTO Comuna VALUES ('Limache');
INSERT INTO Comuna VALUES ('Nogales');
INSERT INTO Comuna VALUES ('Olmu�');
INSERT INTO Comuna VALUES ('Quillota');
INSERT INTO Comuna VALUES ('Algarrobo');
INSERT INTO Comuna VALUES ('Cartagena');
INSERT INTO Comuna VALUES ('Catemu');
INSERT INTO Comuna VALUES ('Llaillay');
INSERT INTO Comuna VALUES ('Panquehue');
INSERT INTO Comuna VALUES ('Putaendo');
INSERT INTO Comuna VALUES ('Casablanca');
INSERT INTO Comuna VALUES ('Conc�n');
INSERT INTO Comuna VALUES ('Puchuncav�');
INSERT INTO Comuna VALUES ('Quilpu�');
INSERT INTO Comuna VALUES ('Quintero');
INSERT INTO Comuna VALUES ('Valpara�so');
INSERT INTO Comuna VALUES ('Colina');
INSERT INTO Comuna VALUES ('Lampa');
INSERT INTO Comuna VALUES ('Tiltil');
INSERT INTO Comuna VALUES ('Pirque');
INSERT INTO Comuna VALUES ('Buin');
INSERT INTO Comuna VALUES ('Paine');
INSERT INTO Comuna VALUES ('Alhu�');
INSERT INTO Comuna VALUES ('Curacav�');
INSERT INTO Comuna VALUES ('Melipilla');
INSERT INTO Comuna VALUES ('Cerrillos');
INSERT INTO Comuna VALUES ('Conchal�');
INSERT INTO Comuna VALUES ('Huechuraba');
INSERT INTO Comuna VALUES ('Independencia');
INSERT INTO Comuna VALUES ('Macul');
INSERT INTO Comuna VALUES ('Maip�');
INSERT INTO Comuna VALUES ('�u�oa');
INSERT INTO Comuna VALUES ('Pe�alol�n');
INSERT INTO Comuna VALUES ('Providencia');
INSERT INTO Comuna VALUES ('Pudahuel');
INSERT INTO Comuna VALUES ('Quilicura');
INSERT INTO Comuna VALUES ('Recoleta');
INSERT INTO Comuna VALUES ('Renca');
INSERT INTO Comuna VALUES ('Santiago');
INSERT INTO Comuna VALUES ('Vitacura');
INSERT INTO Comuna VALUES ('Pe�aflor');
INSERT INTO Comuna VALUES ('Talagante');
INSERT INTO Comuna VALUES ('Codegua');
INSERT INTO Comuna VALUES ('Co�nco');
INSERT INTO Comuna VALUES ('Coltauco');
INSERT INTO Comuna VALUES ('Do�ihue');
INSERT INTO Comuna VALUES ('Graneros');
INSERT INTO Comuna VALUES ('Machal�');
INSERT INTO Comuna VALUES ('Malloa');
INSERT INTO Comuna VALUES ('Mostazal');
INSERT INTO Comuna VALUES ('Olivar');
INSERT INTO Comuna VALUES ('Peumo');
INSERT INTO Comuna VALUES ('Pichidegua');
INSERT INTO Comuna VALUES ('Rancagua');
INSERT INTO Comuna VALUES ('Rengo');
INSERT INTO Comuna VALUES ('Requ�noa');
INSERT INTO Comuna VALUES ('Litueche');
INSERT INTO Comuna VALUES ('Marchihue');
INSERT INTO Comuna VALUES ('Navidad');
INSERT INTO Comuna VALUES ('Peredones');
INSERT INTO Comuna VALUES ('Pichilemu');
INSERT INTO Comuna VALUES ('Ch�pica');
INSERT INTO Comuna VALUES ('Chimbarongo');
INSERT INTO Comuna VALUES ('Lolol');
INSERT INTO Comuna VALUES ('Nancagua');
INSERT INTO Comuna VALUES ('Palmilla');
INSERT INTO Comuna VALUES ('Peralillo');
INSERT INTO Comuna VALUES ('Placilla');
INSERT INTO Comuna VALUES ('Pumanque');
INSERT INTO Comuna VALUES ('Cauquenes');
INSERT INTO Comuna VALUES ('Chanco');
INSERT INTO Comuna VALUES ('Pelluhue');
INSERT INTO Comuna VALUES ('Curic�');
INSERT INTO Comuna VALUES ('Huala��');
INSERT INTO Comuna VALUES ('Licant�n');
INSERT INTO Comuna VALUES ('Molina');
INSERT INTO Comuna VALUES ('Rauco');
INSERT INTO Comuna VALUES ('Romeral');
INSERT INTO Comuna VALUES ('Teno');
INSERT INTO Comuna VALUES ('Vichuqu�n');
INSERT INTO Comuna VALUES ('Colb�n');
INSERT INTO Comuna VALUES ('Linares');
INSERT INTO Comuna VALUES ('Longav�');
INSERT INTO Comuna VALUES ('Parral');
INSERT INTO Comuna VALUES ('Retiro');
INSERT INTO Comuna VALUES ('Constituci�n');
INSERT INTO Comuna VALUES ('Curepto');
INSERT INTO Comuna VALUES ('Empedrado');
INSERT INTO Comuna VALUES ('Maule');
INSERT INTO Comuna VALUES ('Pelarco');
INSERT INTO Comuna VALUES ('Pencahue');
INSERT INTO Comuna VALUES ('Talca');
INSERT INTO Comuna VALUES ('Arauco');
INSERT INTO Comuna VALUES ('Ca�ete');
INSERT INTO Comuna VALUES ('Contulmo');
INSERT INTO Comuna VALUES ('Curanilahue');
INSERT INTO Comuna VALUES ('Lebu');
INSERT INTO Comuna VALUES ('Tir�a');
INSERT INTO Comuna VALUES ('Antuco');
INSERT INTO Comuna VALUES ('Cabrero');
INSERT INTO Comuna VALUES ('Laja');
INSERT INTO Comuna VALUES ('Mulch�n');
INSERT INTO Comuna VALUES ('Nacimiento');
INSERT INTO Comuna VALUES ('Negrete');
INSERT INTO Comuna VALUES ('Quilaco');
INSERT INTO Comuna VALUES ('Quilleco');
INSERT INTO Comuna VALUES ('Tucapel');
INSERT INTO Comuna VALUES ('Yumbel');
INSERT INTO Comuna VALUES ('Chiguayante');
INSERT INTO Comuna VALUES ('Concepci�n');
INSERT INTO Comuna VALUES ('Coronel');
INSERT INTO Comuna VALUES ('Florida');
INSERT INTO Comuna VALUES ('Hualp�n');
INSERT INTO Comuna VALUES ('Hualqui');
INSERT INTO Comuna VALUES ('Lota');
INSERT INTO Comuna VALUES ('Penco');
INSERT INTO Comuna VALUES ('Talcahuano');
INSERT INTO Comuna VALUES ('Tom�');
INSERT INTO Comuna VALUES ('Bulnes');
INSERT INTO Comuna VALUES ('Chill�n');
INSERT INTO Comuna VALUES ('Cobquecura');
INSERT INTO Comuna VALUES ('Coelemu');
INSERT INTO Comuna VALUES ('Coihueco');
INSERT INTO Comuna VALUES ('Ninhue');
INSERT INTO Comuna VALUES ('�iquen');
INSERT INTO Comuna VALUES ('Pemuco');
INSERT INTO Comuna VALUES ('Pinto');
INSERT INTO Comuna VALUES ('Portezuelo');
INSERT INTO Comuna VALUES ('Quill�n');
INSERT INTO Comuna VALUES ('Quirihue');
INSERT INTO Comuna VALUES ('R�nquil');
INSERT INTO Comuna VALUES ('Treguaco');
INSERT INTO Comuna VALUES ('Yungay');
INSERT INTO Comuna VALUES ('Carahue');
INSERT INTO Comuna VALUES ('Cholchol');
INSERT INTO Comuna VALUES ('Cunco');
INSERT INTO Comuna VALUES ('Curarrehue');
INSERT INTO Comuna VALUES ('Freire');
INSERT INTO Comuna VALUES ('Galvarino');
INSERT INTO Comuna VALUES ('Gorbea');
INSERT INTO Comuna VALUES ('Lautaro');
INSERT INTO Comuna VALUES ('Loncoche');
INSERT INTO Comuna VALUES ('Melipeuco');
INSERT INTO Comuna VALUES ('Perquenco');
INSERT INTO Comuna VALUES ('Pitrufqu�n');
INSERT INTO Comuna VALUES ('Puc�n');
INSERT INTO Comuna VALUES ('Saavedra');
INSERT INTO Comuna VALUES ('Temuco');
INSERT INTO Comuna VALUES ('Tolt�n');
INSERT INTO Comuna VALUES ('Vilc�n');
INSERT INTO Comuna VALUES ('Villarrica');
INSERT INTO Comuna VALUES ('Angol');
INSERT INTO Comuna VALUES ('Collipulli');
INSERT INTO Comuna VALUES ('Curacaut�n');
INSERT INTO Comuna VALUES ('Ercilla');
INSERT INTO Comuna VALUES ('Lonquimay');
INSERT INTO Comuna VALUES ('Lumaco');
INSERT INTO Comuna VALUES ('Pur�n');
INSERT INTO Comuna VALUES ('Renaico');
INSERT INTO Comuna VALUES ('Traigu�n');
INSERT INTO Comuna VALUES ('Victoria');
INSERT INTO Comuna VALUES ('Corral');
INSERT INTO Comuna VALUES ('Lanco');
INSERT INTO Comuna VALUES ('M�fil');
INSERT INTO Comuna VALUES ('Mariquina');
INSERT INTO Comuna VALUES ('Paillaco');
INSERT INTO Comuna VALUES ('Panguipulli');
INSERT INTO Comuna VALUES ('Valdivia');
INSERT INTO Comuna VALUES ('Futrono');
INSERT INTO Comuna VALUES ('Ancud');
INSERT INTO Comuna VALUES ('Castro');
INSERT INTO Comuna VALUES ('Chonchi');
INSERT INTO Comuna VALUES ('Dalcahue');
INSERT INTO Comuna VALUES ('Puqueld�n');
INSERT INTO Comuna VALUES ('Queil�n');
INSERT INTO Comuna VALUES ('Quemchi');
INSERT INTO Comuna VALUES ('Quell�n');
INSERT INTO Comuna VALUES ('Quinchao');
INSERT INTO Comuna VALUES ('Calbuco');
INSERT INTO Comuna VALUES ('Cocham�');
INSERT INTO Comuna VALUES ('Fresia');
INSERT INTO Comuna VALUES ('Frutillar');
INSERT INTO Comuna VALUES ('Llanquihue');
INSERT INTO Comuna VALUES ('Maull�n');
INSERT INTO Comuna VALUES ('Osorno');
INSERT INTO Comuna VALUES ('Purranque');
INSERT INTO Comuna VALUES ('Puyehue');
INSERT INTO Comuna VALUES ('Chait�n');
INSERT INTO Comuna VALUES ('Futaleuf�');
INSERT INTO Comuna VALUES ('Hualaihu�');
INSERT INTO Comuna VALUES ('Palena');
INSERT INTO Comuna VALUES ('Ais�n');
INSERT INTO Comuna VALUES ('Cisnes');
INSERT INTO Comuna VALUES ('Guaitecas');
INSERT INTO Comuna VALUES ('Cochrane');
INSERT INTO Comuna VALUES ('higgins');
INSERT INTO Comuna VALUES ('Tortel');
INSERT INTO Comuna VALUES ('Coihaique');
INSERT INTO Comuna VALUES ('Ant�rtica');
INSERT INTO Comuna VALUES ('Porvenir');
INSERT INTO Comuna VALUES ('Primavera');
INSERT INTO Comuna VALUES ('Timaukel');
INSERT INTO Comuna VALUES ('Natales');
GO

/*
SELECT * FROM Usuario;
GO
SELECT * FROM Sexo;
GO
SELECT * FROM Comuna;
GO
SELECT * FROM Denuncia;
GO
USE MASTER
GO
DROP DATABASE examenNET
GO

*/