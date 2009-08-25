/*
SQLyog Community Edition- MySQL GUI v8.14 
MySQL - 5.1.36-community-log : Database - quangphong
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`quangphong` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */;

USE `quangphong`;

/*Table structure for table `categories` */

DROP TABLE IF EXISTS `categories`;

CREATE TABLE `categories` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Description` varchar(1024) COLLATE utf8_bin DEFAULT NULL,
  `ParentId` int(11) DEFAULT NULL,
  `ThumbnailImage` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `NormalImage` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `FullImage` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `categories` */

/*Table structure for table `products` */

DROP TABLE IF EXISTS `products`;

CREATE TABLE `products` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Description` varchar(1024) COLLATE utf8_bin DEFAULT NULL,
  `ThumbnailImage` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `NormalImage` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `FullImage1` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `FullImage2` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `FullImage3` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Content` text COLLATE utf8_bin,
  `TechImage1` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `TechImage2` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `TechImage3` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `CategoriesId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `products` */

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Password` varchar(32) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `users` */

insert  into `users`(`Id`,`UserName`,`Password`) values (1,'admin','123456');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
