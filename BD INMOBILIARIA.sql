USE [master]
GO
CREATE DATABASE [Inmobiliaria]
GO
USE [Inmobiliaria]
GO
/****** Object:  Table [dbo].[Banco]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Banco](
	[idBanco] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
 CONSTRAINT [PK_Banco] PRIMARY KEY CLUSTERED 
(
	[idBanco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Casa]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Casa](
	[CantPisos] [int] NULL,
	[CantBaño] [int] NULL,
	[CantHabitacion] [int] NULL,
	[FechaConstruccion] [date] NULL,
	[Piscina] [int] NULL,
	[Garage] [int] NULL,
	[Jardin] [int] NULL,
	[AreaConstruidaM2] [float] NULL,
	[Id_Inmueble3] [int] NOT NULL,
 CONSTRAINT [PK_Casa] PRIMARY KEY CLUSTERED 
(
	[Id_Inmueble3] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cita]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cita](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[dni_Cliente3] [int] NULL,
	[fecha] [date] NULL,
	[id_Inmueble8] [int] NULL,
	[estado] [varchar](10) NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciudad](
	[idCiudad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[idCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[dniCliente] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellidoP] [varchar](50) NULL,
	[apellidoM] [varchar](50) NULL,
	[edad] [int] NULL,
	[sexo] [char](1) NULL,
	[telefono] [int] NULL,
	[correo] [varchar](30) NULL,
	[habilitado] [bit] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[dniCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contrato]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contrato](
	[idContrato] [int] IDENTITY(1,1) NOT NULL,
	[id_propietario2] [int] NULL,
	[id_Inmueble5] [int] NULL,
	[porcentaje] [float] NULL,
	[fechaCont] [date] NULL,
 CONSTRAINT [PK_Contrato] PRIMARY KEY CLUSTERED 
(
	[idContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[AreaConstruidaM] [float] NULL,
	[UbicaPiso] [varchar](20) NULL,
	[CantHabitacion] [int] NULL,
	[Garage] [int] NULL,
	[CantBano] [int] NULL,
	[FecConstruccion] [int] NULL,
	[id_Inmueble1] [int] NOT NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[id_Inmueble1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inmueble]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inmueble](
	[IdInmueble] [int] IDENTITY(1,1) NOT NULL,
	[Id_Sec1] [int] NOT NULL,
	[Id_Propietario1] [int] NOT NULL,
	[Direccion] [varchar](60) NULL,
	[Estado] [varchar](10) NULL,
	[Precio] [int] NULL,
	[PrecioMinimo] [int] NULL,
	[NRegistroPublico] [int] NULL,
	[Vendido] [bit] NULL,
	[Habilitado] [bit] NULL,
	[id_SitInmueble] [int] NULL,
 CONSTRAINT [PK_Inmueble] PRIMARY KEY CLUSTERED 
(
	[IdInmueble] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Propietario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Propietario](
	[idPropietario] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NULL,
	[edad] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellidoM] [varchar](50) NULL,
	[apellidoP] [varchar](50) NULL,
	[sexo] [varchar](1) NULL,
	[telefono] [int] NULL,
	[direccion] [varchar](70) NULL,
	[correo] [varchar](30) NULL,
 CONSTRAINT [PK_Propietario] PRIMARY KEY CLUSTERED 
(
	[idPropietario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Requisitos]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Requisitos](
	[idRegRequisito] [int] IDENTITY(1,1) NOT NULL,
	[NcontratoCompVen] [varchar](6) NULL,
	[NMinutaCompVen] [varchar](6) NULL,
	[escrituraPublica] [int] NULL,
	[partidaRegistral] [int] NULL,
	[idVenta] [int] NULL,
 CONSTRAINT [PK_Requisitos] PRIMARY KEY CLUSTERED 
(
	[idRegRequisito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sector](
	[idSec] [int] IDENTITY(1,1) NOT NULL,
	[id_Ciudad1] [int] NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[idSec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sitio_Inmueble]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sitio_Inmueble](
	[id_SitInmueble] [int] IDENTITY(1,1) NOT NULL,
	[distancia] [int] NULL,
	[id_SitIn1] [int] NULL,
	[id_Inmueble44] [int] NULL,
 CONSTRAINT [PK_Sitio_Inmueble] PRIMARY KEY CLUSTERED 
(
	[id_SitInmueble] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SitioInteres]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SitioInteres](
	[idSitIn] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[direccion] [varchar](60) NULL,
	[id_SitInmueble] [int] NULL,
 CONSTRAINT [PK_SitioInteres] PRIMARY KEY CLUSTERED 
(
	[idSitIn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Terreno]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Terreno](
	[AccesoLuz] [bit] NULL,
	[AccesoAgua] [bit] NULL,
	[Alcantarillado] [bit] NULL,
	[Desague] [bit] NULL,
	[Id_Inmueble2] [int] NOT NULL,
	[ParcelaM2] [float] NULL,
 CONSTRAINT [PK_Terreno] PRIMARY KEY CLUSTERED 
(
	[Id_Inmueble2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[contrasena] [varchar](30) NULL,
	[dni] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellidoP] [varchar](50) NULL,
	[apellidoM] [varchar](50) NULL,
	[edad] [int] NULL,
	[sexo] [varchar](1) NULL,
	[cargo] [varchar](50) NULL,
	[telefono] [int] NULL,
	[correo] [varchar](30) NULL,
	[habilitar] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[id_Banco1] [int] NULL,
	[id_Cita1] [int] NULL,
	[dni_Cliente2] [int] NULL,
	[id_Inmueble6] [int] NULL,
	[fecha] [date] NULL,
	[id_Usuario1] [int] NULL,
	[precio] [int] NULL,
	[id_RegRequisito1] [int] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venta_terceros]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta_terceros](
	[IdVentaTercero] [int] IDENTITY(1,1) NOT NULL,
	[id_Banco2] [int] NULL,
	[id_Cita2] [int] NULL,
	[dni_Cliente1] [int] NULL,
	[id_Contrato1] [int] NULL,
	[id_Propietario3] [int] NULL,
	[id_Inmueble7] [int] NULL,
	[id_Usuario2] [int] NULL,
	[fecha] [date] NULL,
	[precio] [int] NULL,
	[id_RegRequisito2] [int] NULL,
 CONSTRAINT [PK_Venta_terceros] PRIMARY KEY CLUSTERED 
(
	[IdVentaTercero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Casa]  WITH CHECK ADD  CONSTRAINT [FK_Casa_Inmueble] FOREIGN KEY([Id_Inmueble3])
REFERENCES [dbo].[Inmueble] ([IdInmueble])
GO
ALTER TABLE [dbo].[Casa] CHECK CONSTRAINT [FK_Casa_Inmueble]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Cliente] FOREIGN KEY([dni_Cliente3])
REFERENCES [dbo].[Cliente] ([dniCliente])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Cliente]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Inmueble] FOREIGN KEY([id_Inmueble8])
REFERENCES [dbo].[Inmueble] ([IdInmueble])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Inmueble]
GO
ALTER TABLE [dbo].[Contrato]  WITH CHECK ADD  CONSTRAINT [FK_Contrato_Inmueble] FOREIGN KEY([id_Inmueble5])
REFERENCES [dbo].[Inmueble] ([IdInmueble])
GO
ALTER TABLE [dbo].[Contrato] CHECK CONSTRAINT [FK_Contrato_Inmueble]
GO
ALTER TABLE [dbo].[Contrato]  WITH CHECK ADD  CONSTRAINT [FK_Contrato_Propietario] FOREIGN KEY([id_propietario2])
REFERENCES [dbo].[Propietario] ([idPropietario])
GO
ALTER TABLE [dbo].[Contrato] CHECK CONSTRAINT [FK_Contrato_Propietario]
GO
ALTER TABLE [dbo].[Departamento]  WITH CHECK ADD  CONSTRAINT [FK_Departamento_Inmueble] FOREIGN KEY([id_Inmueble1])
REFERENCES [dbo].[Inmueble] ([IdInmueble])
GO
ALTER TABLE [dbo].[Departamento] CHECK CONSTRAINT [FK_Departamento_Inmueble]
GO
ALTER TABLE [dbo].[Inmueble]  WITH CHECK ADD  CONSTRAINT [FK_Inmueble_Propietario] FOREIGN KEY([Id_Propietario1])
REFERENCES [dbo].[Propietario] ([idPropietario])
GO
ALTER TABLE [dbo].[Inmueble] CHECK CONSTRAINT [FK_Inmueble_Propietario]
GO
ALTER TABLE [dbo].[Inmueble]  WITH CHECK ADD  CONSTRAINT [FK_Inmueble_Sector] FOREIGN KEY([Id_Sec1])
REFERENCES [dbo].[Sector] ([idSec])
GO
ALTER TABLE [dbo].[Inmueble] CHECK CONSTRAINT [FK_Inmueble_Sector]
GO
ALTER TABLE [dbo].[Sector]  WITH CHECK ADD  CONSTRAINT [FK_Sector_Ciudad] FOREIGN KEY([id_Ciudad1])
REFERENCES [dbo].[Ciudad] ([idCiudad])
GO
ALTER TABLE [dbo].[Sector] CHECK CONSTRAINT [FK_Sector_Ciudad]
GO
ALTER TABLE [dbo].[Sitio_Inmueble]  WITH CHECK ADD  CONSTRAINT [FK_Sitio_Inmueble_Inmueble] FOREIGN KEY([id_Inmueble44])
REFERENCES [dbo].[Inmueble] ([IdInmueble])
GO
ALTER TABLE [dbo].[Sitio_Inmueble] CHECK CONSTRAINT [FK_Sitio_Inmueble_Inmueble]
GO
ALTER TABLE [dbo].[Sitio_Inmueble]  WITH CHECK ADD  CONSTRAINT [FK_Sitio_Inmueble_SitioInteres] FOREIGN KEY([id_SitIn1])
REFERENCES [dbo].[SitioInteres] ([idSitIn])
GO
ALTER TABLE [dbo].[Sitio_Inmueble] CHECK CONSTRAINT [FK_Sitio_Inmueble_SitioInteres]
GO
ALTER TABLE [dbo].[Terreno]  WITH CHECK ADD  CONSTRAINT [FK_Terreno_Inmueble] FOREIGN KEY([Id_Inmueble2])
REFERENCES [dbo].[Inmueble] ([IdInmueble])
GO
ALTER TABLE [dbo].[Terreno] CHECK CONSTRAINT [FK_Terreno_Inmueble]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Banco] FOREIGN KEY([id_Banco1])
REFERENCES [dbo].[Banco] ([idBanco])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Banco]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cita] FOREIGN KEY([id_Cita1])
REFERENCES [dbo].[Cita] ([idCita])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cita]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([dni_Cliente2])
REFERENCES [dbo].[Cliente] ([dniCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Inmueble] FOREIGN KEY([id_Inmueble6])
REFERENCES [dbo].[Inmueble] ([IdInmueble])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Inmueble]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Requisitos] FOREIGN KEY([id_RegRequisito1])
REFERENCES [dbo].[Requisitos] ([idRegRequisito])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Requisitos]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario] FOREIGN KEY([id_Usuario1])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Usuario]
GO
ALTER TABLE [dbo].[Venta_terceros]  WITH CHECK ADD  CONSTRAINT [FK_Venta_terceros_Banco] FOREIGN KEY([id_Banco2])
REFERENCES [dbo].[Banco] ([idBanco])
GO
ALTER TABLE [dbo].[Venta_terceros] CHECK CONSTRAINT [FK_Venta_terceros_Banco]
GO
ALTER TABLE [dbo].[Venta_terceros]  WITH CHECK ADD  CONSTRAINT [FK_Venta_terceros_Cita] FOREIGN KEY([id_Cita2])
REFERENCES [dbo].[Cita] ([idCita])
GO
ALTER TABLE [dbo].[Venta_terceros] CHECK CONSTRAINT [FK_Venta_terceros_Cita]
GO
ALTER TABLE [dbo].[Venta_terceros]  WITH CHECK ADD  CONSTRAINT [FK_Venta_terceros_Cliente] FOREIGN KEY([dni_Cliente1])
REFERENCES [dbo].[Cliente] ([dniCliente])
GO
ALTER TABLE [dbo].[Venta_terceros] CHECK CONSTRAINT [FK_Venta_terceros_Cliente]
GO
ALTER TABLE [dbo].[Venta_terceros]  WITH CHECK ADD  CONSTRAINT [FK_Venta_terceros_Contrato] FOREIGN KEY([id_Contrato1])
REFERENCES [dbo].[Contrato] ([idContrato])
GO
ALTER TABLE [dbo].[Venta_terceros] CHECK CONSTRAINT [FK_Venta_terceros_Contrato]
GO
ALTER TABLE [dbo].[Venta_terceros]  WITH CHECK ADD  CONSTRAINT [FK_Venta_terceros_Inmueble] FOREIGN KEY([id_Inmueble7])
REFERENCES [dbo].[Inmueble] ([IdInmueble])
GO
ALTER TABLE [dbo].[Venta_terceros] CHECK CONSTRAINT [FK_Venta_terceros_Inmueble]
GO
ALTER TABLE [dbo].[Venta_terceros]  WITH CHECK ADD  CONSTRAINT [FK_Venta_terceros_Propietario] FOREIGN KEY([id_Propietario3])
REFERENCES [dbo].[Propietario] ([idPropietario])
GO
ALTER TABLE [dbo].[Venta_terceros] CHECK CONSTRAINT [FK_Venta_terceros_Propietario]
GO
ALTER TABLE [dbo].[Venta_terceros]  WITH CHECK ADD  CONSTRAINT [FK_Venta_terceros_Requisitos] FOREIGN KEY([id_RegRequisito2])
REFERENCES [dbo].[Requisitos] ([idRegRequisito])
GO
ALTER TABLE [dbo].[Venta_terceros] CHECK CONSTRAINT [FK_Venta_terceros_Requisitos]
GO
ALTER TABLE [dbo].[Venta_terceros]  WITH CHECK ADD  CONSTRAINT [FK_Venta_terceros_Usuario] FOREIGN KEY([id_Usuario2])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Venta_terceros] CHECK CONSTRAINT [FK_Venta_terceros_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[insertarBanco]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertarBanco](
@nombre varchar(30)
)
as
begin 
    insert into Banco(nombre) values
    (@nombre)
    end
GO
/****** Object:  StoredProcedure [dbo].[ListaBanco]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListaBanco]
as
begin
select * from Banco
end
GO
/****** Object:  StoredProcedure [dbo].[ListarCita]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarCita]
as
begin
select * from Cita
end

GO
/****** Object:  StoredProcedure [dbo].[modificarBanco]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[modificarBanco](
@idBanco int,
@nombre varchar(30)
)
as
begin
    UPDATE Banco SET
    nombre = @nombre
    where idBanco = @idBanco
    end

GO
/****** Object:  StoredProcedure [dbo].[ModificarCita]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ModificarCita](
@idCita int,
@dni_Cliente3 int,
@fecha date,
@id_Inmueble8 int,
@estado varchar(10)
)
as
begin
    UPDATE Cita SET
    dni_Cliente3 = @dni_Cliente3,
    fecha = @fecha,
    id_Inmueble8 = @id_Inmueble8,
    estado = @estado
    where idCita = @idCita
end
GO
/****** Object:  StoredProcedure [dbo].[RegistrarCita]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegistrarCita](
@dni_Cliente3 int,
@fecha date,
@id_Inmueble8 int,
@estado varchar(10)
)
as
begin 
    insert into Cita(dni_Cliente3,fecha,id_Inmueble8,estado) values
    (@dni_Cliente3,@fecha,@id_Inmueble8,@estado)
    end
GO
/****** Object:  StoredProcedure [dbo].[sp_buscarCliente]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_buscarCliente]
@dniCliente int
as
begin
select* from Cliente where dniCliente=@dniCliente
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarPropietario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_buscarPropietario]
@dni int
as
begin
select* from Propietario where dni=@dni
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_buscarSitin]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_buscarSitin]
@idSitIn int
as
begin
select * from SitioInteres where idSitIn = @idSitIn
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarUsuario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	
--buscar
create procedure [dbo].[sp_BuscarUsuario]
@idUsuario int
as
begin
select* from Usuario where idUsuario=@idUsuario
end

GO
/****** Object:  StoredProcedure [dbo].[sp_deshabilitarCliente]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deshabilitarCliente]
@dniCliente int
as
begin
update Cliente set
habilitado='0'
where dniCliente=@dniCliente
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_deshabilitarUsuario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_deshabilitarUsuario]
@idUsuario int
as
begin
update Usuario set
habilitar='0'
where idUsuario=@idUsuario
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_editarCliente]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_editarCliente]
@dniCliente int ,
@nombre varchar(50) ,
@apellidoP varchar(50) ,
@apellidoM varchar(50) ,
@edad int ,
@telefono int,
@correo varchar(30)
as
begin
update Cliente set
nombre=@nombre,
apellidoP=@apellidoP,
apellidoM=@apellidoM,
edad=@edad,
telefono=@telefono,
correo=@correo
where dniCliente=@dniCliente
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_editarPropietario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_editarPropietario]
@dni int ,
@nombre varchar(50) ,
@apellidoP varchar(50) ,
@apellidoM varchar(50) ,
@edad int,
@telefono int,
@correo varchar(30),
@direccion varchar(70)
as
begin
update Propietario set
nombre=@nombre,
apellidoP=@apellidoP,
apellidoM=@apellidoM,
edad=@edad,
telefono=@telefono,
direccion=@direccion,
correo=@correo
where dni=@dni
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_editarUsuario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_editarUsuario]
@idUsuario int ,
@contrasena varchar (30),

@nombre varchar(50) ,
@apellidoP varchar(50) ,
@apellidoM varchar(50) ,
@edad int ,

@cargo varchar (50),
@telefono int,
@correo varchar(30)

as
begin
update Usuario set
contrasena=@contrasena,

nombre=@nombre,
apellidoP=@apellidoP,
apellidoM=@apellidoM,
edad=@edad,

cargo=@cargo,
telefono=@telefono,
correo=@correo

where idUsuario=@idUsuario
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarSitin]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_eliminarSitin]
@idSitIn int
as
begin
delete from SitioInteres 
where idSitIn=@idSitIn
end

GO
/****** Object:  StoredProcedure [dbo].[sp_listarCiudad]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_listarCiudad]
as 
begin
select * from Ciudad
end

GO
/****** Object:  StoredProcedure [dbo].[sp_listarCliente]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listarCliente]
as 
begin
select * from Cliente
where habilitado=1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listarPropietario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listarPropietario]
as 
begin
select * from Propietario
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listarSector]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_listarSector]
as
begin
select * from Sector 
end

GO
/****** Object:  StoredProcedure [dbo].[sp_listarSitin]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_listarSitin]
as
begin
select * from SitioInteres
end
GO
/****** Object:  StoredProcedure [dbo].[sp_modificarCiudad]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_modificarCiudad]
@idCiudad int,@nombre varchar(30)
as
begin
update Ciudad set
nombre=@nombre
where idCiudad=@idCiudad
end

GO
/****** Object:  StoredProcedure [dbo].[sp_modificarSector]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_modificarSector]
@idSec int, @nombre varchar (50)
as
begin
update Sector set
nombre=@nombre
where idSec=@idSec
end
GO
/****** Object:  StoredProcedure [dbo].[sp_modificarSitin]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_modificarSitin]
@idSitIn int, @nombre varchar (50), @direccion varchar(60)
as
begin
update SitioInteres set
nombre=@nombre,direccion=@direccion
where idSitIn=@idSitIn
end

GO
/****** Object:  StoredProcedure [dbo].[sp_registrarCiudad]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_registrarCiudad]
@nombre varchar (30)
as
begin
insert into Ciudad (nombre) values(@nombre)
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_registrarCliente]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_registrarCliente]
@dniCliente int ,
@nombre varchar(50) ,
@apellidoP varchar(50) ,
@apellidoM varchar(50) ,
@edad int ,
@sexo char(1) ,
@telefono int ,
@correo varchar(30) ,
@habilitado bit 
as
begin
insert into Cliente (dniCliente,nombre,apellidoP,apellidoM,edad,sexo,telefono,correo,habilitado) 
values(@dniCliente,@nombre,@apellidoP,@apellidoM,@edad,@sexo,@telefono,@correo,@habilitado)
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_registrarPropietario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_registrarPropietario]
@dni int ,
@nombre varchar(50) ,
@apellidoP varchar(50) ,
@apellidoM varchar(50) ,
@edad int ,
@sexo varchar(1) ,
@telefono int ,
@correo varchar(30) ,
@direccion varchar(70) 
as
begin
insert into Propietario(dni,nombre,apellidoP,apellidoM,edad,sexo,telefono,direccion,correo) 
values(@dni,@nombre,@apellidoP,@apellidoM,@edad,@sexo,@telefono,@direccion,@correo)
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_registrarSector]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_registrarSector]
@nombre varchar (50), @idCiudad1 int
as
begin
insert into Sector(nombre,id_Ciudad1) values(@nombre,@idCiudad1) 
end

GO
/****** Object:  StoredProcedure [dbo].[sp_registrarSitin]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_registrarSitin]
@nombre varchar (50),
@direccion varchar(60)
as
begin
insert into SitioInteres(nombre,direccion) values(@nombre,@direccion)
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_validarCiudad]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_validarCiudad]
@nombre varchar (30)
as
begin
select nombre from Ciudad where nombre = @nombre
end

GO
/****** Object:  StoredProcedure [dbo].[sp_validarSitin]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_validarSitin]
@nombre varchar (50)
as
begin
select nombre from SitioInteres where nombre = @nombre
end

GO
/****** Object:  StoredProcedure [dbo].[spInsertaUsuario]    Script Date: 26/11/2020 02:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spInsertaUsuario]

@contraseña varchar (30),
@dni int,
@nombre varchar(50) ,
@apellidoP varchar(50) ,
@apellidoM varchar(50) ,
@edad int ,
@sexo char,
@cargo varchar (50),
@telefono int,
@correo varchar(30),
@habilitar bit 

as
begin
insert into  Usuario (contrasena,dni,nombre,apellidoP,apellidoM,edad,sexo,cargo,telefono,correo,habilitar) 
values(@contraseña,@dni,@nombre,@apellidoP,@apellidoM,@edad,@sexo,@cargo,@telefono,@correo,@habilitar)
end 

GO

exec sp_registrarCliente '12345678','Pedro','Alvarez','Juarez','25','M','958675528','pedr@hotmail.com',true;
exec sp_registrarCliente '52458599','Maria','Gonzalez','Hernandez','33','F','992856749','marher@hotmail.com',true;
exec sp_registrarCliente '52458599','Mario','Heredia','Rodriguez','29','M','992856589','mardf@hotmail.com',true;

exec sp_registrarPropietario '74185236','Anhalu','Alvez','Mendez','23','F','996635721','Urb.Los Jazmines N789','anhalu@hotmail.com';
exec sp_registrarPropietario '88996571','Javier','Alva','Mendoza','33','M','958642557',' Av. Larco N789','Javi@hotmail.com';
exec sp_registrarPropietario '88996985','Marco','Sarate','Herrera','24','M','944642557',' Av. America Sue N745','mariobros@hotmail.com';

exec sp_registrarCiudad 'Trujillo';
exec sp_registrarCiudad 'Cajamarca';
exec sp_registrarCiudad 'Lima';

exec sp_registrarSector 'Los Jardines','1';
exec sp_registrarSector 'San Isidro','1';
exec sp_registrarSector 'Miraflores','3';

exec spInsertaUsuario 'sdqs',96385214,'Gorge Luis','Mendez','Castro',25,'M','Agente Inmobiliario',978410632,'gorge@hotmail.com',true;
exec spInsertaUsuario 'wdfs',85245612,'Mario ','Roldan','Rojas',29,'M','Agente Inmobiliario',456852123,'mario@hotmail.com',true;
exec spInsertaUsuario 'ghjb',15975396,'Claudia Ana','Morales','Diaz',27,'F','Agente Inmobiliario',74125823,'claudia@hotmail.com',true;

exec sp_registrarSitin 'Iglesia Carmelita','Av. Los Incas 528 ';
exec sp_registrarSitin 'Plaza de Armas','Av.España 425 ';
exec sp_registrarSitin 'Escuela Bellas Artes','Jr.Bolivar 788';
----------------------------------------------------------------
exec insertarBanco 'Interbank';
exec insertarBanco  'Caja Piura';
exec insertarBanco 'Caja Trujillo';

