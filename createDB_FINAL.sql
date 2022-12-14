USE [master]
GO

/****** Object:  Database [CourseWorkDataBase]    Script Date: 17.02.2022 6:53:15 ******/
CREATE DATABASE [CourseWorkDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CourseWorkDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CourseWorkDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CourseWorkDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CourseWorkDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CourseWorkDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CourseWorkDataBase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET ARITHABORT OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CourseWorkDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CourseWorkDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CourseWorkDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CourseWorkDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET RECOVERY FULL 
GO

ALTER DATABASE [CourseWorkDataBase] SET  MULTI_USER 
GO

ALTER DATABASE [CourseWorkDataBase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CourseWorkDataBase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CourseWorkDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CourseWorkDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [CourseWorkDataBase] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CourseWorkDataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [CourseWorkDataBase] SET QUERY_STORE = OFF
GO

ALTER DATABASE [CourseWorkDataBase] SET  READ_WRITE 
GO

