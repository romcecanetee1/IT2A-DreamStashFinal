-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: it2adreamstash
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `beneficiaries`
--

DROP TABLE IF EXISTS `beneficiaries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `beneficiaries` (
  `BeneficiaryID` int NOT NULL AUTO_INCREMENT,
  `BeneficiaryName` varchar(50) NOT NULL,
  `BeneficiaryInfo` varchar(100) DEFAULT NULL,
  `CampaignTitle` varchar(50) NOT NULL,
  PRIMARY KEY (`BeneficiaryID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `beneficiaries`
--

LOCK TABLES `beneficiaries` WRITE;
/*!40000 ALTER TABLE `beneficiaries` DISABLE KEYS */;
INSERT INTO `beneficiaries` VALUES (2,'Senior Citizen','Senior Citzen from town of Bocaue','Generous Hearts'),(3,'Typhoon survivors','survivor of typhoon','Heart and Seoul'),(4,'Robotics team','Students from the robotics team','Robotics Funding'),(5,'Bethany Orphanage','Children from Bethany Orphanage','Generous Hearts'),(6,'Robotics Team','Students in the Robotics team ','Robotics Funding'),(7,'Arts students','Students from Art class','Arts Tutorial');
/*!40000 ALTER TABLE `beneficiaries` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campaignentries`
--

DROP TABLE IF EXISTS `campaignentries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campaignentries` (
  `DonationCampaignID` int NOT NULL AUTO_INCREMENT,
  `CampaignTitle` varchar(100) NOT NULL,
  `CampaignDescription` text,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `DonationGoal` decimal(10,2) NOT NULL DEFAULT '0.00',
  `AmountDonated` decimal(10,2) NOT NULL DEFAULT '0.00',
  `CampaignStatus` enum('Active','Archived') NOT NULL,
  `BeneficiaryName` varchar(100) NOT NULL,
  `CampaignName_FK` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`DonationCampaignID`),
  UNIQUE KEY `DonationCampaignID_UNIQUE` (`DonationCampaignID`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campaignentries`
--

LOCK TABLES `campaignentries` WRITE;
/*!40000 ALTER TABLE `campaignentries` DISABLE KEYS */;
INSERT INTO `campaignentries` VALUES (30,'Generous Hearts','A funding event that aims to help children in orphanages','2023-11-22','2023-12-14',50000.00,2500.00,'Active','2,5',NULL),(31,'Heart and Seoul','To travel in Seoul South Korea','2023-12-01','2023-12-21',25000.00,7000.00,'Active','3',NULL),(32,'Robotics Funding','Funding for the robotics team','2023-12-06','2024-01-31',150000.00,2300.00,'Active','4 and 6',NULL),(33,'Arts Tutorial','Share knowledge about arts','2023-10-03','2023-11-07',10000.00,0.00,'Archived','7',NULL);
/*!40000 ALTER TABLE `campaignentries` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donations`
--

DROP TABLE IF EXISTS `donations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donations` (
  `DonationID` int NOT NULL AUTO_INCREMENT,
  `DonationDate` date DEFAULT NULL,
  `Donor` varchar(100) NOT NULL,
  `CampaignSupported` int NOT NULL,
  `CampaignTitle` varchar(100) NOT NULL,
  `DonationAmount` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`DonationID`)
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donations`
--

LOCK TABLES `donations` WRITE;
/*!40000 ALTER TABLE `donations` DISABLE KEYS */;
INSERT INTO `donations` VALUES (56,'2023-12-07','Wemby',30,'Generous Hearts',2000.00),(57,'2023-12-07','Wemby',31,'Heart and Seoul',5000.00),(58,'2023-12-07','Romz',31,'Heart and Seoul',2000.00),(60,'2023-12-07','Wemby',32,'Robotics Funding',500.00),(61,'2023-12-07','Romz',32,'Robotics Funding',500.00),(62,'2023-12-07','Wemby',32,'Robotics Funding',1000.00),(63,'2023-12-07','Romz',30,'Generous Hearts',500.00),(64,'2023-12-07','karlooo',32,'Robotics Funding',100.00),(65,'2023-11-28','karlooo',32,'Robotics Funding',200.00);
/*!40000 ALTER TABLE `donations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `UserName` varchar(50) DEFAULT NULL,
  `Pass` varchar(50) NOT NULL,
  `Department` varchar(50) DEFAULT NULL,
  `Course` varchar(50) DEFAULT NULL,
  `YearLevel` varchar(20) DEFAULT NULL,
  `Section` char(1) DEFAULT NULL,
  `UserRole` enum('Donor','Assistant Administrator','Administrator') NOT NULL,
  `DataRegistered` date DEFAULT NULL,
  `UserName_FK` varchar(20) DEFAULT NULL,
  `AccountStatus` enum('Active','Deactivated') NOT NULL,
  `LastChange` date DEFAULT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `UserID_UNIQUE` (`UserID`),
  UNIQUE KEY `UserName_UNIQUE` (`UserName`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin','admin','admin','','','','','Administrator','2023-11-14',NULL,'Active','2023-12-08'),(19,'Assistant','Admin','admin2','admin2','','','','','Assistant Administrator','2023-12-09',NULL,'Active','2023-12-15'),(20,'Victor','Wembanyama','Wemby','12345','CCS','COMPUTER ENGINEERING','2ND YEAR','J','Assistant Administrator','2023-12-09',NULL,'Active','2023-12-09'),(21,'Romce','Canete','Romz','123123','CCS','COMPUTER SCIENCE','2ND YEAR','A','Donor','2023-12-09',NULL,'Active',NULL),(22,'Karl','Thompson','Karlooo','123123','CCS','COMPUTER SCIENCE','2ND YEAR','A','Donor','2023-12-09',NULL,'Active',NULL),(23,'Test','Test','Test','Test','CAS','','','','Donor','2023-12-16',NULL,'Active',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_campaign`
--

DROP TABLE IF EXISTS `v_campaign`;
/*!50001 DROP VIEW IF EXISTS `v_campaign`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_campaign` AS SELECT 
 1 AS `DonationCampaignID`,
 1 AS `CampaignStatus`,
 1 AS `CampaignTitle`,
 1 AS `CampaignDescription`,
 1 AS `StartDate`,
 1 AS `EndDate`,
 1 AS `DonationGoal`,
 1 AS `AmountDonated`,
 1 AS `BeneficiaryName`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v_campaign`
--

/*!50001 DROP VIEW IF EXISTS `v_campaign`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_campaign` AS select `campaignentries`.`DonationCampaignID` AS `DonationCampaignID`,`campaignentries`.`CampaignStatus` AS `CampaignStatus`,`campaignentries`.`CampaignTitle` AS `CampaignTitle`,`campaignentries`.`CampaignDescription` AS `CampaignDescription`,`campaignentries`.`StartDate` AS `StartDate`,`campaignentries`.`EndDate` AS `EndDate`,`campaignentries`.`DonationGoal` AS `DonationGoal`,`campaignentries`.`AmountDonated` AS `AmountDonated`,`beneficiaries`.`BeneficiaryName` AS `BeneficiaryName` from (`campaignentries` join `beneficiaries`) where (`campaignentries`.`CampaignTitle` = `beneficiaries`.`CampaignTitle`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-16 10:43:18
