CREATE DATABASE `schule` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

CREATE TABLE `fahrzeuge` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Kennzeichen` varchar(45) NOT NULL,
  `Hersteller` varchar(45) DEFAULT NULL,
  `Modell` varchar(45) DEFAULT NULL,
  `Kraftstoff` varchar(45) NOT NULL,
  `Verbrauch` double DEFAULT NULL,
  `AnschaffungsDatum` date NOT NULL,
  `AnschaffungsKosten` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `instandhaltungen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Datum` date NOT NULL,
  `Kilometerstand` double NOT NULL,
  `Kosten` double NOT NULL,
  `Beschreibung` varchar(1000) DEFAULT NULL,
  `Fahrzeug_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `kfzversicherungen` (
  `Nummer` varchar(45) NOT NULL,
  `Fahrzeug_id` int(11) NOT NULL,
  `Kaskozusatz` int(11) NOT NULL DEFAULT 0,
  `JahresBetrag` double DEFAULT NULL,
  `Geselschaft_id` int(11) NOT NULL,
  PRIMARY KEY (`Nummer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `reservierungen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Beginn` datetime NOT NULL,
  `Ende` datetime NOT NULL,
  `Zweck` varchar(200) DEFAULT NULL,
  `Fahrzeug_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `versicherungsgeselschaften` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `Postanschrift` varchar(100) DEFAULT NULL,
  `Telefonnummer` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

