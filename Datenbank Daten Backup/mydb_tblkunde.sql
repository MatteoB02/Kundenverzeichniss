-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.33-MariaDB

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
-- Table structure for table `tblkunde`
--

DROP TABLE IF EXISTS `tblkunde`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblkunde` (
  `Kundennummer` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Vorname` varchar(45) NOT NULL,
  `Firma` varchar(45) DEFAULT NULL,
  `Ansprechpartner` varchar(45) NOT NULL,
  `Land` varchar(45) NOT NULL,
  `Strasse` varchar(45) NOT NULL,
  `Strassennummer` int(11) NOT NULL,
  `Telefon` varchar(45) NOT NULL,
  `E-Mail` varchar(45) NOT NULL,
  `Geburtstag` date NOT NULL,
  `Bemerkung` varchar(45) NOT NULL,
  `Weihnachtsgeschenk` varchar(45) NOT NULL,
  `TblAnrede_idAnrede` int(11) NOT NULL,
  `TblPLZ_PLZ` int(11) NOT NULL,
  PRIMARY KEY (`Kundennummer`,`TblAnrede_idAnrede`,`TblPLZ_PLZ`),
  KEY `fk_TblKunde_TblAnrede1_idx` (`TblAnrede_idAnrede`),
  KEY `fk_TblKunde_TblPLZ1_idx` (`TblPLZ_PLZ`),
  CONSTRAINT `fk_TblKunde_TblAnrede1` FOREIGN KEY (`TblAnrede_idAnrede`) REFERENCES `tblanrede` (`idAnrede`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TblKunde_TblPLZ1` FOREIGN KEY (`TblPLZ_PLZ`) REFERENCES `tblplz` (`PLZ`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblkunde`
--

LOCK TABLES `tblkunde` WRITE;
/*!40000 ALTER TABLE `tblkunde` DISABLE KEYS */;
INSERT INTO `tblkunde` VALUES (1,'Lauber','Thiemens',NULL,'Thiemens','Simbabwe','dönerstrasse ',3,'88888888','thiemo88@lasagna.döner','2018-12-10','Z\'beschte wos je hets gits','Nix',1,3904);
/*!40000 ALTER TABLE `tblkunde` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-12-14 15:54:10
