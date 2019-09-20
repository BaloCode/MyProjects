-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 22, 2018 at 09:01 PM
-- Server version: 5.7.21
-- PHP Version: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
CREATE TABLE IF NOT EXISTS `accounts` (
  `Usr_id` int(5) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `email` varchar(100) COLLATE utf8_bin NOT NULL,
  `password` varchar(100) COLLATE utf8_bin NOT NULL,
  `Score` int(10) NOT NULL,
  PRIMARY KEY (`Usr_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `Usr_id` int(11) NOT NULL,
  `Res_id` int(11) NOT NULL AUTO_INCREMENT,
  `Table_id` int(11) NOT NULL,
  `Date` timestamp NOT NULL,
  PRIMARY KEY (`Res_id`),
  KEY `Usr_id` (`Usr_id`),
  KEY `Table_id` (`Table_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `tables`
--

DROP TABLE IF EXISTS `tables`;
CREATE TABLE IF NOT EXISTS `tables` (
  `Table_id` int(11) NOT NULL,
  `Table_pos` int(11) NOT NULL,
  `Comments` text COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`Table_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `tables`
--

INSERT INTO `tables` (`Table_id`, `Table_pos`, `Comments`) VALUES
(1, 2, 'A perfect 2 chair table'),
(2, 4, '4 chair Table'),
(3, 6, 'A perfect 6 chairs Table');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `Table_id` FOREIGN KEY (`Table_id`) REFERENCES `tables` (`Table_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Usr_id` FOREIGN KEY (`Usr_id`) REFERENCES `accounts` (`Usr_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
