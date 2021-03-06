USE [master]
GO

/****** Object:  Database [BD_Laboratorio]    Script Date: 09/05/2014 14:51:38 ******/
CREATE DATABASE [BD_Laboratorio] ON  PRIMARY 
( NAME = N'DB_Laboratorio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DB_Laboratorio.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_Laboratorio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DB_Laboratorio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [BD_Laboratorio] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_Laboratorio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BD_Laboratorio] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET ARITHABORT OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [BD_Laboratorio] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BD_Laboratorio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BD_Laboratorio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BD_Laboratorio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BD_Laboratorio] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BD_Laboratorio] SET  READ_WRITE 
GO

ALTER DATABASE [BD_Laboratorio] SET RECOVERY FULL 
GO

ALTER DATABASE [BD_Laboratorio] SET  MULTI_USER 
GO

ALTER DATABASE [BD_Laboratorio] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BD_Laboratorio] SET DB_CHAINING OFF 
GO

