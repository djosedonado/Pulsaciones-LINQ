/*
Script de implementación para Grupo01

Una herramienta generó este código.
Los cambios realizados en este archivo podrían generar un comportamiento incorrecto y se perderán si
se vuelve a generar el código.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Grupo01"
:setvar DefaultFilePrefix "Grupo01"
:setvar DefaultDataPath "C:\Users\LENOVO\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\LENOVO\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detectar el modo SQLCMD y deshabilitar la ejecución del script si no se admite el modo SQLCMD.
Para volver a habilitar el script después de habilitar el modo SQLCMD, ejecute lo siguiente:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'El modo SQLCMD debe estar habilitado para ejecutar correctamente este script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO

IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
GO
BEGIN TRANSACTION
GO
/*
El tipo de la columna Sexo en la tabla [dbo].[Empleado] es  NVARCHAR (1) NULL, pero se va a cambiar a  TEXT NULL. Si la columna contiene datos no compatibles con el tipo  TEXT NULL, podrían producirse pérdidas de datos y errores en la implementación.
*/
GO
PRINT N'Iniciando recompilación de la tabla [dbo].[Empleado]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Empleado] (
    [Identificaion] NVARCHAR (11) NULL,
    [Nombre]        NVARCHAR (50) NULL,
    [Edad]          INT           NULL,
    [Sexo]          TEXT          NULL,
    [h]             NCHAR (10)    NULL
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Empleado])
    BEGIN
        INSERT INTO [dbo].[tmp_ms_xx_Empleado] ([Identificaion], [Nombre], [Edad], [Sexo], [h])
        SELECT [Identificaion],
               [Nombre],
               [Edad],
               [Sexo],
               [h]
        FROM   [dbo].[Empleado];
    END

DROP TABLE [dbo].[Empleado];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Empleado]', N'Empleado';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF OBJECT_ID(N'tempdb..#tmpErrors') IS NULL
    CREATE TABLE [#tmpErrors] (
        Error INT
    );

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT N'La parte de transacción de la actualización de la base de datos se realizó correctamente.'
COMMIT TRANSACTION
END
ELSE PRINT N'Error de la parte de transacción de la actualización de la base de datos.'
GO
IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
GO
PRINT N'Actualización completada.';


GO
