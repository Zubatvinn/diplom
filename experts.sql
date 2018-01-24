-- MySQL dump 10.13  Distrib 5.7.21, for Win64 (x86_64)
--
-- Host: localhost    Database: experts
-- ------------------------------------------------------
-- Server version	5.7.21-log

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
-- Table structure for table `calculations_description`
--

DROP TABLE IF EXISTS `calculations_description`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `calculations_description` (
  `calculation_number` int(11) NOT NULL,
  `calculation_name` varchar(45) DEFAULT NULL,
  `description_of_calculation` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`calculation_number`),
  CONSTRAINT `fk_calc_desc_calc_result` FOREIGN KEY (`calculation_number`) REFERENCES `calculations_result` (`calculation_number`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calculations_description`
--

LOCK TABLES `calculations_description` WRITE;
/*!40000 ALTER TABLE `calculations_description` DISABLE KEYS */;
/*!40000 ALTER TABLE `calculations_description` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `calculations_result`
--

DROP TABLE IF EXISTS `calculations_result`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `calculations_result` (
  `calculation_number` int(11) NOT NULL,
  `date_of_calculation` datetime DEFAULT NULL,
  `id_of_formula` int(11) NOT NULL,
  `result` double DEFAULT NULL,
  PRIMARY KEY (`calculation_number`,`id_of_formula`),
  KEY `fk_formula2_id_idx` (`id_of_formula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calculations_result`
--

LOCK TABLES `calculations_result` WRITE;
/*!40000 ALTER TABLE `calculations_result` DISABLE KEYS */;
INSERT INTO `calculations_result` VALUES (1,'2018-01-15 12:56:00',1,3),(1,'2018-01-15 14:10:27',8,16);
/*!40000 ALTER TABLE `calculations_result` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event`
--

DROP TABLE IF EXISTS `event`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `event` (
  `event_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` varchar(100) DEFAULT NULL,
  `template_id` int(11) DEFAULT NULL,
  `lawyer_vefirication` tinyint(4) DEFAULT NULL,
  `dm_verification` tinyint(4) DEFAULT NULL,
  `id_of_user` int(11) DEFAULT NULL,
  `issue_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`event_id`),
  KEY `template_id` (`template_id`),
  KEY `userid_fk_idx` (`id_of_user`),
  KEY `issue_id_fk_idx` (`issue_id`),
  CONSTRAINT `event_ibfk_1` FOREIGN KEY (`template_id`) REFERENCES `event_template` (`template_id`),
  CONSTRAINT `issue_id_fk` FOREIGN KEY (`issue_id`) REFERENCES `issues` (`issue_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `userid_fk` FOREIGN KEY (`id_of_user`) REFERENCES `user` (`id_of_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event`
--

LOCK TABLES `event` WRITE;
/*!40000 ALTER TABLE `event` DISABLE KEYS */;
INSERT INTO `event` VALUES (4,'Event Name','Description',1,NULL,0,NULL,NULL),(5,'Event Name','Description',2,NULL,1,NULL,NULL),(6,'Event Name','Description',2,NULL,NULL,NULL,NULL),(7,'new','Description',1,NULL,1,NULL,NULL),(8,'Event Name','Description',1,NULL,0,NULL,NULL),(9,'Event Name','Description',2,NULL,0,NULL,NULL);
/*!40000 ALTER TABLE `event` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event_resource`
--

DROP TABLE IF EXISTS `event_resource`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `event_resource` (
  `resource_id` int(11) NOT NULL,
  `event_id` int(11) NOT NULL,
  `value` int(11) DEFAULT NULL,
  `description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`resource_id`,`event_id`),
  KEY `event_id` (`event_id`),
  CONSTRAINT `event_resource_ibfk_1` FOREIGN KEY (`resource_id`) REFERENCES `resource` (`resource_id`),
  CONSTRAINT `event_resource_ibfk_2` FOREIGN KEY (`event_id`) REFERENCES `event` (`event_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event_resource`
--

LOCK TABLES `event_resource` WRITE;
/*!40000 ALTER TABLE `event_resource` DISABLE KEYS */;
INSERT INTO `event_resource` VALUES (1,7,10,'New one'),(1,8,12,'123'),(2,6,10,'Its a tree'),(2,9,10,'qwe');
/*!40000 ALTER TABLE `event_resource` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event_template`
--

DROP TABLE IF EXISTS `event_template`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `event_template` (
  `template_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`template_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event_template`
--

LOCK TABLES `event_template` WRITE;
/*!40000 ALTER TABLE `event_template` DISABLE KEYS */;
INSERT INTO `event_template` VALUES (1,'Plant',NULL),(2,'Unplant',NULL);
/*!40000 ALTER TABLE `event_template` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expert`
--

DROP TABLE IF EXISTS `expert`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `expert` (
  `id_of_expert` int(11) NOT NULL,
  `expert_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_of_expert`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expert`
--

LOCK TABLES `expert` WRITE;
/*!40000 ALTER TABLE `expert` DISABLE KEYS */;
INSERT INTO `expert` VALUES (1,'economist');
/*!40000 ALTER TABLE `expert` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formula_compound`
--

DROP TABLE IF EXISTS `formula_compound`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formula_compound` (
  `id_of_formula` int(11) NOT NULL,
  `id_of_parameter` int(11) NOT NULL,
  PRIMARY KEY (`id_of_formula`,`id_of_parameter`),
  KEY `fk_parameter_id_idx` (`id_of_parameter`),
  CONSTRAINT `fk_formula_id` FOREIGN KEY (`id_of_formula`) REFERENCES `formulas` (`id_of_formula`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_parameter_id` FOREIGN KEY (`id_of_parameter`) REFERENCES `formula_parameters` (`id_of_parameter`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formula_compound`
--

LOCK TABLES `formula_compound` WRITE;
/*!40000 ALTER TABLE `formula_compound` DISABLE KEYS */;
INSERT INTO `formula_compound` VALUES (1,1),(1,2),(1,3),(8,10),(8,12);
/*!40000 ALTER TABLE `formula_compound` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formula_parameters`
--

DROP TABLE IF EXISTS `formula_parameters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formula_parameters` (
  `id_of_parameter` int(11) NOT NULL AUTO_INCREMENT,
  `name_of_parameter` varchar(45) DEFAULT NULL,
  `measurement_of_parameter` varchar(45) DEFAULT NULL,
  `description_of_parameter` varchar(45) DEFAULT NULL,
  `id_of_expert` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_of_parameter`),
  UNIQUE KEY `id_of_parameter_UNIQUE` (`id_of_parameter`),
  KEY `fk_formula_compound_expert_id_idx` (`id_of_expert`),
  CONSTRAINT `fk_formula_compound_expert_id` FOREIGN KEY (`id_of_expert`) REFERENCES `expert` (`id_of_expert`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formula_parameters`
--

LOCK TABLES `formula_parameters` WRITE;
/*!40000 ALTER TABLE `formula_parameters` DISABLE KEYS */;
INSERT INTO `formula_parameters` VALUES (1,'U(t)','грн','Об\'єм накопичення',1),(2,'C(t)','грн','Об\'єм споживання',1),(3,'Z(t)','грн','Витрати на забеспечення безпеки населення',1),(10,'test2','test','test',1),(12,'test1','test','test',1);
/*!40000 ALTER TABLE `formula_parameters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formulas`
--

DROP TABLE IF EXISTS `formulas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formulas` (
  `id_of_formula` int(11) NOT NULL AUTO_INCREMENT,
  `name_of_formula` varchar(100) DEFAULT NULL,
  `description_of_formula` varchar(100) DEFAULT NULL,
  `id_of_expert` int(11) NOT NULL,
  PRIMARY KEY (`id_of_formula`),
  UNIQUE KEY `id_of_formula_UNIQUE` (`id_of_formula`),
  KEY `fk_formulas_expert_id_idx` (`id_of_expert`),
  CONSTRAINT `fk_formulas_expert_id` FOREIGN KEY (`id_of_expert`) REFERENCES `expert` (`id_of_expert`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formulas`
--

LOCK TABLES `formulas` WRITE;
/*!40000 ALTER TABLE `formulas` DISABLE KEYS */;
INSERT INTO `formulas` VALUES (1,'Q(t)','Розрахунок національного доходу',1),(2,'З(1-2)','Оцінка збитків при смерті у працездатному віці',1),(3,'З(1-3)','Оцінка збитків при смерті до настання працездатного віку',1),(4,'Е1','Оцінка збитків при смерті після настання працездатного віку',1),(5,'Е','Розрахунок економічної ефективності людської діяльності',1),(8,'test','test',1);
/*!40000 ALTER TABLE `formulas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `issues`
--

DROP TABLE IF EXISTS `issues`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `issues` (
  `issue_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `description` varchar(500) DEFAULT NULL,
  `creation_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `calc_series_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`issue_id`),
  KEY `calc_series_id` (`calc_series_id`),
  CONSTRAINT `issues_ibfk_1` FOREIGN KEY (`calc_series_id`) REFERENCES `calculations_description` (`calculation_number`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `issues`
--

LOCK TABLES `issues` WRITE;
/*!40000 ALTER TABLE `issues` DISABLE KEYS */;
INSERT INTO `issues` VALUES (1,'Ploho','qwe','2018-01-23 13:59:30',NULL),(2,'Ochen Ploho','ewq','2018-01-23 13:59:30',NULL),(3,'Хорошо','все будет хорошо','2018-01-23 14:16:25',NULL),(4,'asdasd','asdasd','2018-01-23 14:21:28',NULL);
/*!40000 ALTER TABLE `issues` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `new_table`
--

DROP TABLE IF EXISTS `new_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `new_table` (
  `event_id` int(11) NOT NULL,
  `document_code` varchar(100) NOT NULL,
  `description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`event_id`,`document_code`),
  CONSTRAINT `eventid_fk` FOREIGN KEY (`event_id`) REFERENCES `event` (`event_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `new_table`
--

LOCK TABLES `new_table` WRITE;
/*!40000 ALTER TABLE `new_table` DISABLE KEYS */;
/*!40000 ALTER TABLE `new_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parameters_value`
--

DROP TABLE IF EXISTS `parameters_value`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parameters_value` (
  `calculation_number` int(11) NOT NULL,
  `id_of_parameter` int(11) NOT NULL,
  `parameter_value` double DEFAULT NULL,
  PRIMARY KEY (`calculation_number`,`id_of_parameter`),
  KEY `fk_parameter_id_idx` (`id_of_parameter`),
  KEY `fk_paramater2_id_idx` (`id_of_parameter`),
  CONSTRAINT `fk_paramater2_id` FOREIGN KEY (`id_of_parameter`) REFERENCES `formula_parameters` (`id_of_parameter`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parameters_value`
--

LOCK TABLES `parameters_value` WRITE;
/*!40000 ALTER TABLE `parameters_value` DISABLE KEYS */;
INSERT INTO `parameters_value` VALUES (1,1,1),(1,2,1),(1,3,1),(1,10,4),(1,12,4);
/*!40000 ALTER TABLE `parameters_value` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `resource`
--

DROP TABLE IF EXISTS `resource`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `resource` (
  `resource_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`resource_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `resource`
--

LOCK TABLES `resource` WRITE;
/*!40000 ALTER TABLE `resource` DISABLE KEYS */;
INSERT INTO `resource` VALUES (1,'Money',NULL),(2,'Tree',NULL);
/*!40000 ALTER TABLE `resource` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `template_resource`
--

DROP TABLE IF EXISTS `template_resource`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `template_resource` (
  `resource_id` int(11) NOT NULL,
  `template_id` int(11) NOT NULL,
  PRIMARY KEY (`resource_id`,`template_id`),
  KEY `template_resource_ibfk_2_idx` (`template_id`),
  CONSTRAINT `template_resource_ibfk_1` FOREIGN KEY (`resource_id`) REFERENCES `resource` (`resource_id`),
  CONSTRAINT `template_resource_ibfk_2` FOREIGN KEY (`template_id`) REFERENCES `event_template` (`template_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `template_resource`
--

LOCK TABLES `template_resource` WRITE;
/*!40000 ALTER TABLE `template_resource` DISABLE KEYS */;
INSERT INTO `template_resource` VALUES (1,1),(2,2);
/*!40000 ALTER TABLE `template_resource` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `user_name` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `id_of_expert` int(11) DEFAULT NULL,
  `id_of_user` int(11) NOT NULL,
  PRIMARY KEY (`id_of_user`),
  KEY `fk_user_expert_id_idx` (`id_of_expert`),
  CONSTRAINT `fk_user_expert_id` FOREIGN KEY (`id_of_expert`) REFERENCES `expert` (`id_of_expert`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-24 13:35:40
