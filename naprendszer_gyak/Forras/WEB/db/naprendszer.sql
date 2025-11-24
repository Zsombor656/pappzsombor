-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Apr 02, 2025 at 08:26 AM
-- Server version: 8.0.40
-- PHP Version: 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `naprendszer`
--
CREATE DATABASE IF NOT EXISTS `naprendszer` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `naprendszer`;

-- --------------------------------------------------------

--
-- Table structure for table `bolygok`
--

DROP TABLE IF EXISTS `bolygok`;
CREATE TABLE `bolygok` (
  `bolygo_id` int NOT NULL,
  `neve` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `tipus_id` int NOT NULL,
  `tomeg` float DEFAULT NULL,
  `egyenlitori_sugar` float DEFAULT NULL,
  `holdak_szama` int DEFAULT NULL,
  `nap_tavolsag` float DEFAULT NULL,
  `fold_tavolsag` float DEFAULT NULL,
  `leiras` text COLLATE utf8mb4_general_ci NOT NULL,
  `url` text COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bolygok`
--

INSERT INTO `bolygok` (`bolygo_id`, `neve`, `tipus_id`, `tomeg`, `egyenlitori_sugar`, `holdak_szama`, `nap_tavolsag`, `fold_tavolsag`, `leiras`, `url`) VALUES
(1, 'Merkúr', 1, 0.055, 0.383, 0, 0.39, 0.61, 'A Merkúr a Naprendszernek a Naphoz legközelebb lévő bolygója.', 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/600px-Mercury_in_true_color.jpg'),
(2, 'Vénusz', 1, 0.815, 0.949, 0, 0.72, 0.28, 'A Vénusz a Naptól számított második bolygó, a földhöz hasonló méretű.', 'https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Venus-real_color.jpg/600px-Venus-real_color.jpg'),
(3, 'Föld', 1, 1, 1, 1, 1, 0, 'A Föld a harmadik bolygó a Naptól, és az egyetlen ismert hely, ahol élet van.', 'https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/The_Blue_Marble_%28remastered%29.jpg/600px-The_Blue_Marble_%28remastered%29.jpg'),
(4, 'Mars', 1, 0.107, 0.533, 2, 1.52, 0.52, 'A Mars a Naprendszer negyedik bolygója, a vörös bolygó néven ismert.', 'https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/OSIRIS_Mars_true_color.jpg/600px-OSIRIS_Mars_true_color.jpg'),
(5, 'Jupiter', 2, 317.899, 11.209, 79, 5.2, 4.2, 'A Jupiter a Naptól számított ötödik bolygó, egy gázóriás.', 'https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/Jupiter.jpg/600px-Jupiter.jpg'),
(6, 'Szaturnusz', 2, 95.16, 9.449, 82, 9.58, 8.58, 'A Szaturnusz a hatodik bolygó a Naptól, jellegzetes gyűrűivel.', 'https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/600px-Saturn_during_Equinox.jpg'),
(7, 'Uránusz', 3, 14.536, 4.007, 27, 19.2, 18.2, 'Az Uránusz a hetedik bolygó, a Naptól számított harmadik gázóriás.', 'https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/Uranus2.jpg/600px-Uranus2.jpg'),
(8, 'Neptunusz', 3, 17.147, 3.883, 14, 30.05, 29.05, 'A Neptunusz a nyolcadik bolygó, ismert erős szelei és hideg légköre miatt.', 'https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Neptune_Full.jpg/600px-Neptune_Full.jpg');

-- --------------------------------------------------------

--
-- Stand-in structure for view `bolygokl`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `bolygokl`;
CREATE TABLE `bolygokl` (
`tipus_neve` varchar(255)
,`neve` varchar(255)
,`tomeg` float
,`egyenlitori_sugar` float
,`holdak_szama` int
,`nap_tavolsag` float
,`fold_tavolsag` float
,`leiras` text
,`url` text
);

-- --------------------------------------------------------

--
-- Table structure for table `bolygo_tipusok`
--

DROP TABLE IF EXISTS `bolygo_tipusok`;
CREATE TABLE `bolygo_tipusok` (
  `tipus_id` int NOT NULL,
  `tipus_neve` varchar(255) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bolygo_tipusok`
--

INSERT INTO `bolygo_tipusok` (`tipus_id`, `tipus_neve`) VALUES
(1, 'Föld-típusú'),
(2, 'Gázóriás'),
(3, 'Jégóriás'),
(4, 'Hibrid');

-- --------------------------------------------------------

--
-- Structure for view `bolygokl`
--
DROP TABLE IF EXISTS `bolygokl`;

DROP VIEW IF EXISTS `bolygokl`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bolygokl`  AS SELECT `bolygo_tipusok`.`tipus_neve` AS `tipus_neve`, `bolygok`.`neve` AS `neve`, `bolygok`.`tomeg` AS `tomeg`, `bolygok`.`egyenlitori_sugar` AS `egyenlitori_sugar`, `bolygok`.`holdak_szama` AS `holdak_szama`, `bolygok`.`nap_tavolsag` AS `nap_tavolsag`, `bolygok`.`fold_tavolsag` AS `fold_tavolsag`, `bolygok`.`leiras` AS `leiras`, `bolygok`.`url` AS `url` FROM (`bolygo_tipusok` join `bolygok`) WHERE (`bolygok`.`tipus_id` = `bolygo_tipusok`.`tipus_id`) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bolygok`
--
ALTER TABLE `bolygok`
  ADD PRIMARY KEY (`bolygo_id`),
  ADD KEY `tipus_id` (`tipus_id`);

--
-- Indexes for table `bolygo_tipusok`
--
ALTER TABLE `bolygo_tipusok`
  ADD PRIMARY KEY (`tipus_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bolygok`
--
ALTER TABLE `bolygok`
  MODIFY `bolygo_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `bolygo_tipusok`
--
ALTER TABLE `bolygo_tipusok`
  MODIFY `tipus_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bolygok`
--
ALTER TABLE `bolygok`
  ADD CONSTRAINT `bolygok_ibfk_1` FOREIGN KEY (`tipus_id`) REFERENCES `bolygo_tipusok` (`tipus_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
