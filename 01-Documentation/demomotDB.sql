-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Dim 30 Juin 2019 à 19:38
-- Version du serveur :  5.7.11
-- Version de PHP :  5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `demomot`
--
CREATE DATABASE IF NOT EXISTS `demomot` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `demomot`;

-- --------------------------------------------------------

--
-- Structure de la table `t_player`
--

CREATE TABLE `t_player` (
  `idPlayer` int(11) NOT NULL,
  `plaScore` int(11) NOT NULL,
  `PlaName` varchar(20) NOT NULL,
  `PlaPassword` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_player`
--

INSERT INTO `t_player` (`idPlayer`, `plaScore`, `PlaName`, `PlaPassword`) VALUES
(1, 10, 'oui', 'oui');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `t_player`
--
ALTER TABLE `t_player`
  ADD PRIMARY KEY (`idPlayer`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `t_player`
--
ALTER TABLE `t_player`
  MODIFY `idPlayer` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
