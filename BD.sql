USE [Ventas]
GO
/****** Object:  Table [dbo].[TotalVentas]    Script Date: 06/23/2015 11:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TotalVentas](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Total_ventas] [bigint] NOT NULL,
	[Estado] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TotalVentas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[MODIFICAR_VENTAS]    Script Date: 06/23/2015 11:57:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<ESDEVELOPER>
-- Create date: <22-06-2015>
-- Description:	<AGREGAR>
-- =============================================
CREATE PROCEDURE [dbo].[MODIFICAR_VENTAS]
@ID AS BIGINT,
@NOMBRE AS VARCHAR(100),
@TOTAL_VENTAS AS BIGINT,
@ESTADO AS VARCHAR(100)
AS
BEGIN

UPDATE TotalVentas SET Nombre = @NOMBRE, Total_ventas = @TOTAL_VENTAS, Estado = @ESTADO
WHERE Id = @ID;

END
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_VENTAS]    Script Date: 06/23/2015 11:57:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<ESDEVELOPER>
-- Create date: <22-06-2015>
-- Description:	<AGREGAR>
-- =============================================
CREATE PROCEDURE [dbo].[ELIMINAR_VENTAS]
@ID AS BIGINT
AS
BEGIN

DELETE FROM TotalVentas WHERE Id = @ID;

END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_VENTAS_POR_NOMBRE]    Script Date: 06/23/2015 11:57:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<ESDEVELOPER>
-- Create date: <22-06-2015>
-- Description:	<AGREGAR>
-- =============================================
CREATE PROCEDURE [dbo].[CONSULTAR_VENTAS_NOMBRE]
@NOMBRE AS VARCHAR(100)
AS
BEGIN

SELECT * FROM TotalVentas WHERE Nombre = @NOMBRE;

END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_VENTAS]    Script Date: 06/23/2015 11:57:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<ESDEVELOPER>
-- Create date: <22-06-2015>
-- Description:	<AGREGAR>
-- =============================================
CREATE PROCEDURE [dbo].[CONSULTAR_VENTAS]
AS
BEGIN

SELECT * FROM TotalVentas;

END
GO
/****** Object:  StoredProcedure [dbo].[AGREGAR_VENTAS]    Script Date: 06/23/2015 11:57:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<ESDEVELOPER>
-- Create date: <22-06-2015>
-- Description:	<AGREGAR>
-- =============================================
CREATE PROCEDURE [dbo].[AGREGAR_VENTAS]
@NOMBRE AS VARCHAR(100),
@TOTAL_VENTAS AS BIGINT,
@ESTADO AS VARCHAR(100)
AS
BEGIN

INSERT INTO TotalVentas(Nombre, Total_ventas, Estado)
VALUES
(@NOMBRE, @TOTAL_VENTAS, @ESTADO);

END
GO
