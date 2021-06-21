-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: 192.168.30.104    Database: ControleBiblioteca
-- ------------------------------------------------------
-- Server version	5.5.5-10.2.38-MariaDB-1:10.2.38+maria~bionic

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cad_alugueis`
--

DROP TABLE IF EXISTS `cad_alugueis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cad_alugueis` (
  `idaluguel` int(11) NOT NULL AUTO_INCREMENT,
  `idlivro` int(11) DEFAULT NULL,
  `idpessoa` int(11) DEFAULT NULL,
  `datasaida` date DEFAULT NULL,
  `dataentrega` date DEFAULT NULL,
  `valor` double DEFAULT NULL,
  PRIMARY KEY (`idaluguel`),
  KEY `cad_alugueis_FK` (`idpessoa`),
  KEY `cad_alugueis_FK_1` (`idlivro`),
  CONSTRAINT `cad_alugueis_FK` FOREIGN KEY (`idpessoa`) REFERENCES `cad_pessoas` (`idpessoa`),
  CONSTRAINT `cad_alugueis_FK_1` FOREIGN KEY (`idlivro`) REFERENCES `cad_livros` (`idlivro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cad_alugueis`
--

LOCK TABLES `cad_alugueis` WRITE;
/*!40000 ALTER TABLE `cad_alugueis` DISABLE KEYS */;
/*!40000 ALTER TABLE `cad_alugueis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cad_contatos`
--

DROP TABLE IF EXISTS `cad_contatos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cad_contatos` (
  `idcontato` int(11) NOT NULL AUTO_INCREMENT,
  `telefone` varchar(15) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `idpessoa` int(11) DEFAULT NULL,
  `principal` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idcontato`),
  KEY `cad_contatos_FK` (`idpessoa`),
  CONSTRAINT `cad_contatos_FK` FOREIGN KEY (`idpessoa`) REFERENCES `cad_pessoas` (`idpessoa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cad_contatos`
--

LOCK TABLES `cad_contatos` WRITE;
/*!40000 ALTER TABLE `cad_contatos` DISABLE KEYS */;
/*!40000 ALTER TABLE `cad_contatos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cad_enderecos`
--

DROP TABLE IF EXISTS `cad_enderecos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cad_enderecos` (
  `idendereco` int(11) NOT NULL AUTO_INCREMENT,
  `logradouro` varchar(50) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `numero` varchar(20) DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `cidade` varchar(50) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `idpessoa` int(11) DEFAULT NULL,
  PRIMARY KEY (`idendereco`),
  KEY `cad_enderecos_FK` (`idpessoa`),
  CONSTRAINT `cad_enderecos_FK` FOREIGN KEY (`idpessoa`) REFERENCES `cad_pessoas` (`idpessoa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cad_enderecos`
--

LOCK TABLES `cad_enderecos` WRITE;
/*!40000 ALTER TABLE `cad_enderecos` DISABLE KEYS */;
/*!40000 ALTER TABLE `cad_enderecos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cad_livros`
--

DROP TABLE IF EXISTS `cad_livros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cad_livros` (
  `idlivro` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(50) DEFAULT NULL,
  `categoria` varchar(50) DEFAULT NULL,
  `autor` varchar(50) DEFAULT NULL,
  `dataentrada` date DEFAULT NULL,
  PRIMARY KEY (`idlivro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cad_livros`
--

LOCK TABLES `cad_livros` WRITE;
/*!40000 ALTER TABLE `cad_livros` DISABLE KEYS */;
/*!40000 ALTER TABLE `cad_livros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cad_pessoas`
--

DROP TABLE IF EXISTS `cad_pessoas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cad_pessoas` (
  `idpessoa` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `idendereco` int(11) DEFAULT NULL,
  `idcontato` int(11) DEFAULT NULL,
  `cpf` varchar(15) DEFAULT NULL,
  `datanasc` date DEFAULT NULL,
  PRIMARY KEY (`idpessoa`),
  KEY `cad_pessoas_FK` (`idendereco`),
  CONSTRAINT `cad_pessoas_FK` FOREIGN KEY (`idendereco`) REFERENCES `cad_enderecos` (`idendereco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cad_pessoas`
--

LOCK TABLES `cad_pessoas` WRITE;
/*!40000 ALTER TABLE `cad_pessoas` DISABLE KEYS */;
/*!40000 ALTER TABLE `cad_pessoas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cad_ranking`
--

DROP TABLE IF EXISTS `cad_ranking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cad_ranking` (
  `idranking` int(11) NOT NULL AUTO_INCREMENT,
  `idlivro` int(11) DEFAULT NULL,
  `data` date DEFAULT NULL,
  PRIMARY KEY (`idranking`),
  KEY `cad_ranking_FK` (`idlivro`),
  CONSTRAINT `cad_ranking_FK` FOREIGN KEY (`idlivro`) REFERENCES `cad_livros` (`idlivro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cad_ranking`
--

LOCK TABLES `cad_ranking` WRITE;
/*!40000 ALTER TABLE `cad_ranking` DISABLE KEYS */;
/*!40000 ALTER TABLE `cad_ranking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'ControleBiblioteca'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-20 21:07:44
