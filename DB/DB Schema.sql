USE [master]
GO

/****** Object:  Database [Recon]    Script Date: 02/07/2013 11:42:14 ******/
CREATE DATABASE [Recon] ON  PRIMARY 
( NAME = N'RECON', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Recon.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RECON_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Recon_1.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Recon] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Recon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Recon] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Recon] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Recon] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Recon] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Recon] SET ARITHABORT OFF 
GO

ALTER DATABASE [Recon] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Recon] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Recon] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Recon] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Recon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Recon] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Recon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Recon] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Recon] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Recon] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Recon] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Recon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Recon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Recon] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Recon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Recon] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Recon] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Recon] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Recon] SET  READ_WRITE 
GO

ALTER DATABASE [Recon] SET RECOVERY FULL 
GO

ALTER DATABASE [Recon] SET  MULTI_USER 
GO

ALTER DATABASE [Recon] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Recon] SET DB_CHAINING OFF 
GO

