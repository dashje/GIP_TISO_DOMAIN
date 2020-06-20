CREATE DATABASE  IF NOT EXISTS `wishlist` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `wishlist`;
-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: wishlist
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cadeau`
--

DROP TABLE IF EXISTS `cadeau`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cadeau` (
  `ID_Cadeau` int(11) NOT NULL AUTO_INCREMENT,
  `Naam` varchar(45) NOT NULL,
  `Omschrijving` varchar(45) NOT NULL,
  `Website` varchar(2083) NOT NULL,
  PRIMARY KEY (`ID_Cadeau`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadeau`
--

LOCK TABLES `cadeau` WRITE;
/*!40000 ALTER TABLE `cadeau` DISABLE KEYS */;
INSERT INTO `cadeau` VALUES (2,'test','dit is een test','bol.com'),(3,'schoenen','nieuwe witte schoenen','torfs.be'),(4,'Name','Description','Website'),(5,'test','test','bol.com'),(6,'bakugan','rode','toystory'),(7,'Airpods','van Apple','apple.com'),(8,'iPhone 7','nieuwe gsm','apple.com');
/*!40000 ALTER TABLE `cadeau` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gebruiker`
--

DROP TABLE IF EXISTS `gebruiker`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gebruiker` (
  `ID_Gebruiker` int(11) NOT NULL AUTO_INCREMENT,
  `Naam` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Leeftijd` int(11) NOT NULL,
  `Geslacht` varchar(45) NOT NULL,
  `Passwoord` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_Gebruiker`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gebruiker`
--

LOCK TABLES `gebruiker` WRITE;
/*!40000 ALTER TABLE `gebruiker` DISABLE KEYS */;
INSERT INTO `gebruiker` VALUES (1,'Pieter-Jan','test',17,'M','koshcol'),(2,'Robbe','test',17,'Male','koshcol'),(3,'Jos','test',30,'Male','koshcol'),(4,'Mats','test@gmail;COL',19,'Male','mats'),(5,'Brik','brikg@gmail.com',17,'Male','brik');
/*!40000 ALTER TABLE `gebruiker` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lijst`
--

DROP TABLE IF EXISTS `lijst`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lijst` (
  `idLijst` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) NOT NULL,
  `Code` varchar(45) NOT NULL,
  `zichtbaar` varchar(45) NOT NULL,
  `FK_Gebruiker` int(11) NOT NULL,
  PRIMARY KEY (`idLijst`,`FK_Gebruiker`),
  KEY `fk_Lijst_Gebruiker_idx` (`FK_Gebruiker`),
  CONSTRAINT `FK_Naar_Gebruiker` FOREIGN KEY (`FK_Gebruiker`) REFERENCES `gebruiker` (`ID_Gebruiker`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lijst`
--

LOCK TABLES `lijst` WRITE;
/*!40000 ALTER TABLE `lijst` DISABLE KEYS */;
INSERT INTO `lijst` VALUES (1,'Name','5143','Ja',1),(2,'Name','4713','Ja',1),(3,'Name','1946','Ja',1),(4,'test lijst','4367','Ja',1),(5,'test lijst2','5642','Ja',1),(6,'test lijst 3','6786','Ja',1),(7,'test lijst 4','4013','Ja',1),(8,'test list','6868','Ja',2),(10,'test lijst 5','9393','Ja',1),(11,'nice','1592','Ja',1),(12,'zuut','8753','Ja',1),(13,'test lijst 6000','594','Ja',1),(14,'test lijst 7000','3252','Ja',1),(15,'Verjaardag Moeder','7767','Ja',1);
/*!40000 ALTER TABLE `lijst` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lijst_has_cadeau`
--

DROP TABLE IF EXISTS `lijst_has_cadeau`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lijst_has_cadeau` (
  `FK_Lijst` int(11) NOT NULL,
  `FK_Cadeau` int(11) NOT NULL,
  `GekochtJaOfNee` varchar(3) NOT NULL DEFAULT '0',
  PRIMARY KEY (`FK_Lijst`,`FK_Cadeau`),
  KEY `fk_Lijst_has_Cadeau_Cadeau1_idx` (`FK_Cadeau`),
  CONSTRAINT `FK_Naar_Cadeau` FOREIGN KEY (`FK_Cadeau`) REFERENCES `cadeau` (`ID_Cadeau`),
  CONSTRAINT `FK_Naar_Lijst` FOREIGN KEY (`FK_Lijst`) REFERENCES `lijst` (`idLijst`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lijst_has_cadeau`
--

LOCK TABLES `lijst_has_cadeau` WRITE;
/*!40000 ALTER TABLE `lijst_has_cadeau` DISABLE KEYS */;
INSERT INTO `lijst_has_cadeau` VALUES (3,3,'Nee'),(5,3,'Nee'),(7,2,'Nee'),(7,4,'Nee'),(7,5,'Nee'),(8,3,'Nee'),(8,5,'Nee'),(12,4,'Nee'),(12,6,'Nee'),(14,6,'Nee');
/*!40000 ALTER TABLE `lijst_has_cadeau` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-10 22:52:55
