-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : ven. 12 avr. 2024 à 12:58
-- Version du serveur : 10.11.4-MariaDB-1~deb12u1-log
-- Version de PHP : 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatout`
--

-- --------------------------------------------------------

--
-- Structure de la table `acces`
--

CREATE TABLE `acces` (
  `idAcces` int(11) NOT NULL,
  `nomAcces` varchar(69) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `acces`
--

INSERT INTO `acces` (`idAcces`, `nomAcces`) VALUES
(1, 'FULL'),
(2, 'Ressource'),
(3, 'Emprunt'),
(4, 'Emprunteur'),
(5, 'DISABLED');

-- --------------------------------------------------------

--
-- Structure de la table `auteur`
--

CREATE TABLE `auteur` (
  `idAuteur` int(11) NOT NULL,
  `nomAuteur` varchar(255) NOT NULL,
  `prenomAuteur` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `auteur`
--

INSERT INTO `auteur` (`idAuteur`, `nomAuteur`, `prenomAuteur`) VALUES
(1, 'reltih', 'floda'),
(2, 'gabriel', 'zubi'),
(21, 'Gabriel', 'Lefevre'),
(22, 'Sophie', 'Martin'),
(23, 'Thomas', 'Lemoine'),
(24, 'Marie', 'Gagnon'),
(25, 'Alexandre', 'Rivière'),
(26, 'Aurélie', 'Dubois'),
(27, 'Pierre', 'Giroux'),
(28, 'Céline', 'Bertrand'),
(29, 'Luc', 'Bouchard'),
(30, 'Caroline', 'Lavoie'),
(31, 'Julien', 'Roux'),
(32, 'Elise', 'Moreau'),
(33, 'Vincent', 'Bouchard'),
(34, 'Camille', 'Bergeron'),
(35, 'Nicolas', 'Lefèvre'),
(36, 'Émilie', 'Rivard'),
(37, 'Maxime', 'Gagnon'),
(38, 'Manon', 'Leroux'),
(39, 'François', 'Girard'),
(40, 'Nathalie', 'Rivière'),
(41, 'Mathieu', 'Dubois'),
(42, 'Isabelle', 'Gagnon'),
(43, 'Jean', 'Martin'),
(44, 'Marie-Pierre', 'Bouchard'),
(45, 'Philippe', 'Leroux'),
(46, 'Valérie', 'Rivard'),
(47, 'Martin', 'Giroux'),
(48, 'Amélie', 'Lemoine'),
(49, 'Sébastien', 'Roux'),
(50, 'Anne', 'Moreau'),
(51, 'Étienne', 'Rivard'),
(52, 'Marie-Ève', 'Lemoine'),
(53, 'Alexis', 'Dubois'),
(54, 'Stéphanie', 'Martin'),
(55, 'Olivier', 'Gagnon'),
(56, 'Valérie', 'Leroux'),
(57, 'Patrick', 'Girard'),
(58, 'Isabel', 'Rivière'),
(59, 'Guillaume', 'Bertrand'),
(60, 'Catherine', 'Lefèvre'),
(61, 'François-Xavier', 'Roux'),
(62, 'Sylvie', 'Gagnon'),
(63, 'Alex', 'Leroux'),
(64, 'Alicia', 'Giroux'),
(65, 'Vincent', 'Dubois'),
(66, 'Émilie', 'Rivard'),
(67, 'Martin', 'Bertrand'),
(68, 'Élizabeth', 'Lavoie'),
(69, 'Louis', 'Girard'),
(70, 'Anne-Marie', 'Rivière'),
(71, 'Charles', 'Bergeron'),
(72, 'Sophie', 'Bouchard'),
(73, 'Maxime', 'Giroux'),
(74, 'Jessica', 'Leroux'),
(75, 'François', 'Rivière'),
(76, 'Julie', 'Lefèvre'),
(77, 'Pierre-Luc', 'Bertrand'),
(78, 'Geneviève', 'Lemoine'),
(79, 'Jonathan', 'Giroux'),
(80, 'Mélanie', 'Leroux'),
(81, 'David', 'Rivard'),
(82, 'Caroline', 'Girard'),
(83, 'Jérôme', 'Rivière'),
(84, 'Isabelle', 'Bertrand'),
(85, 'Simon', 'Lefevre'),
(86, 'Roxanne', 'Giroux'),
(87, 'Antoine', 'Dubois'),
(88, 'Élise', 'Leroux'),
(89, 'Philippe', 'Gagnon'),
(90, 'Audrey', 'Lemoine'),
(91, 'Lucas', 'Rivard'),
(92, 'Nathalie', 'Bertrand'),
(93, 'Gabrielle', 'Lefèvre'),
(94, 'Nicolas', 'Dubois'),
(95, 'Stéphanie', 'Gagnon'),
(96, 'Raphaël', 'Roux'),
(97, 'Laurence', 'Leroux'),
(98, 'Pierre', 'Bertrand'),
(99, 'Julia', 'Girard'),
(100, 'Mathieu', 'Lefevre'),
(101, 'Valentin', 'Rivière'),
(102, 'Noémie', 'Lemoine'),
(103, 'Frédéric', 'Giroux'),
(104, 'Sarah', 'Bertrand'),
(105, 'Vincent', 'Dubois'),
(106, 'Cynthia', 'Rivard'),
(107, 'Alexandre', 'Giroux'),
(108, 'Maude', 'Leroux'),
(109, 'Samuel', 'Lefevre'),
(110, 'Isabelle', 'Rivière'),
(111, 'Éric', 'Dubois'),
(112, 'Amélie', 'Girard'),
(113, 'William', 'Leroux'),
(114, 'Mélanie', 'Rivard'),
(115, 'Xavier', 'Bertrand'),
(116, 'Éloïse', 'Lemoine'),
(117, 'Jonathan', 'Gagnon'),
(118, 'Valérie', 'Roux'),
(119, 'Nicolas', 'Bertrand'),
(120, 'Marie-Pier', 'Leroux'),
(121, 'Alexis', 'Girard'),
(122, 'Sophie', 'Dubois'),
(123, 'Antoine', 'Rivière'),
(124, 'Julie', 'Lefèvre'),
(125, 'Nicolas', 'Gagnon'),
(126, 'Mélissa', 'Bertrand'),
(127, 'Sébastien', 'Roux'),
(128, 'Catherine', 'Leroux'),
(129, 'Mathieu', 'Giroux'),
(130, 'Valérie', 'Rivard'),
(131, 'Alexandre', 'Bertrand'),
(132, 'Karine', 'Gagnon'),
(133, 'Daniel', 'Lemoine'),
(134, 'Audrey', 'Lefevre'),
(135, 'Mathieu', 'Dubois'),
(136, 'Véronique', 'Rivière'),
(137, 'William', 'Girard'),
(138, 'Émilie', 'Leroux'),
(139, 'Jonathan', 'Bertrand'),
(140, 'Catherine', 'Rivard'),
(141, 'Louis', 'Roux'),
(142, 'Valérie', 'Giroux'),
(143, 'Jean-François', 'Bertrand'),
(144, 'Geneviève', 'Lemoine'),
(145, 'David', 'Dubois'),
(146, 'Stéphanie', 'Girard'),
(147, 'Maxime', 'Lefevre'),
(148, 'Élise', 'Rivière'),
(149, 'Alexandre', 'Giroux'),
(150, 'Caroline', 'Leroux');

-- --------------------------------------------------------

--
-- Structure de la table `auteur_ressource`
--

CREATE TABLE `auteur_ressource` (
  `idRessource` int(11) NOT NULL,
  `idAuteur` int(11) NOT NULL,
  `dateEnregistrement` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `auteur_ressource`
--

INSERT INTO `auteur_ressource` (`idRessource`, `idAuteur`, `dateEnregistrement`) VALUES
(1, 1, NULL),
(2, 25, '2023-11-23 17:26:51'),
(2, 63, '2023-11-23 17:26:50'),
(2, 107, '2023-11-23 17:26:52'),
(7, 1, '2023-10-30 05:08:07'),
(47, 1, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `idcategorie` int(11) NOT NULL,
  `libellecategorie` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`idcategorie`, `libellecategorie`) VALUES
(1, 'Livre'),
(2, 'BD'),
(3, 'Manga'),
(4, 'Comics'),
(5, 'CD'),
(6, 'Vinyle'),
(7, 'DVD'),
(8, 'Blu-rayz'),
(9, 'Jeux vidéo'),
(10, 'Jeu de société'),
(11, 'Jeu de rôle'),
(12, 'Jeu de cartes'),
(13, 'Jeu de plateau'),
(14, 'Jeu de figurines'),
(15, 'Jeu de construction'),
(17, 'Jeu de stratégie'),
(18, 'Jeu de simulation'),
(45, 'hhh'),
(48, 'jj'),
(49, 'CDd'),
(51, 'e-livre');

-- --------------------------------------------------------

--
-- Structure de la table `commentaire`
--

CREATE TABLE `commentaire` (
  `idCommentaire` int(11) NOT NULL,
  `idRessource` int(11) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `contenu` varchar(255) NOT NULL,
  `note` int(11) NOT NULL,
  `dateCreation` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `commentaire`
--

INSERT INTO `commentaire` (`idCommentaire`, `idRessource`, `idUtilisateur`, `contenu`, `note`, `dateCreation`) VALUES
(5, 60, 23, 'Très bon jeu, manque peut-être quelques détails pour que je puisse mettre une meilleure note mais sinon, je recommande !', 3, '2023-11-23 14:34:46'),
(6, 94, 24, 'Très bon jeu mais manque de boss !', 4, '2023-11-24 15:07:49'),
(7, 94, 24, '<script>alert(\'13248651\')</script>', 3, '2023-11-24 15:08:37');

-- --------------------------------------------------------

--
-- Structure de la table `emprunter`
--

CREATE TABLE `emprunter` (
  `idemprunteur` int(11) NOT NULL,
  `idressource` int(11) NOT NULL,
  `idexemplaire` int(11) NOT NULL,
  `datedebutemprunt` datetime NOT NULL,
  `dureeemprunt` int(11) NOT NULL,
  `dateretour` datetime DEFAULT NULL,
  `extension` int(2) DEFAULT 0,
  `dateretourfait` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `emprunter`
--

INSERT INTO `emprunter` (`idemprunteur`, `idressource`, `idexemplaire`, `datedebutemprunt`, `dureeemprunt`, `dateretour`, `extension`, `dateretourfait`) VALUES
(23, 60, 60, '2023-11-23 21:48:35', 30, '2023-12-23 21:48:35', 1, 1),
(24, 59, 59, '2023-11-23 22:00:14', 60, '2023-01-22 22:00:14', 1, 1);

--
-- Déclencheurs `emprunter`
--
DELIMITER $$
CREATE TRIGGER `emprunt_moin_3` BEFORE INSERT ON `emprunter` FOR EACH ROW BEGIN
    DECLARE emprunteur_count INT;

  


        SET emprunteur_count = (SELECT COUNT(*) FROM emprunter WHERE idemprunteur = 23 AND dateretourfait != 1);


        IF emprunteur_count >= 3 THEN
            SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Trop d''emprunts pour le même emprunteur.';
        END IF;


END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `emprunteur`
--

CREATE TABLE `emprunteur` (
  `idemprunteur` int(11) NOT NULL,
  `nomemprunteur` varchar(128) NOT NULL,
  `prenomemprunteur` varchar(128) NOT NULL,
  `datenaissance` date NOT NULL,
  `emailemprunteur` varchar(255) DEFAULT NULL,
  `motpasseemprunteur` varchar(128) DEFAULT NULL,
  `telportable` varchar(128) DEFAULT NULL,
  `validationcompte` int(11) DEFAULT NULL,
  `validationtoken` uuid DEFAULT uuid()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `emprunteur`
--

INSERT INTO `emprunteur` (`idemprunteur`, `nomemprunteur`, `prenomemprunteur`, `datenaissance`, `emailemprunteur`, `motpasseemprunteur`, `telportable`, `validationcompte`, `validationtoken`) VALUES
(1, 'nom', 'prenom', '2023-09-12', 'email@email.email', '$2y$10$TqUVqJaZL9g8OINi1nOS9uXYjEoYarK0oRARMOlcOxHrwOygSM/GG', '0123456789', 1, 'e61cd68b-58c5-11ee-bd16-005056b5883c'),
(2, 'nom', 'prenom', '2023-09-12', 'email2@email.email', '$2y$10$TqUVqJaZL9g8OINi1nOS9uXYjEoYarK0oRARMOlcOxHrwOygSM/GG', '0123456789', 1, '1659526f-58c6-11ee-bd16-005056b5883c'),
(3, 'nom', 'prenom', '2023-09-12', 'email3@email.email', '$2y$10$TqUVqJaZL9g8OINi1nOS9uXYjEoYarK0oRARMOlcOxHrwOygSM/GG', '0123456789', 1, '4ef19e89-58c6-11ee-bd16-005056b5883c'),
(8, 'tyfgv', 'fytgi', '2023-09-28', 'yghjb@grd.g', '$2y$10$RHV/s1UNU94RkqvjsSQHCOnj3mLpf6Tdw/ZTf.W7PgwVwGSYGQgvy', '068598299', 0, '77a100aa-67bf-4ba3-b7f0-1027a4697357'),
(10, 'tyfgv', 'fytgi', '2023-09-28', 'yghjb@grd.gom', '$2y$10$iHGtWGqbl3BwAHk3kjGPAuSjzUdIBFnbV3gaAmblW/uKCnei/3CfS', '0685982993', 0, 'a047a76a-1511-4bb1-986b-8e5b9262e2aa'),
(19, 'piou', 'piou2', '2023-10-13', '19', '$2y$10$EywJfAfiv/c5zHLKG9Br9ee0cBDZSiOTRz41eQ4AQQcgpHEJb/TE6', '0685982993', 1, NULL),
(22, 'piou', 'piou2', '2023-11-10', 'pioupiou@piou.fr', '$2y$10$m90WiDWuCYeMc6VS1Lz7Temv1Jx0CSFURfDGtNlsYCXRfeRPUKC8W', '0685982993', 0, '35d0456f-b79c-463f-a35d-d04e802d3c59'),
(23, 'piou', 'piou', '2023-11-16', 'piou@piou.fr', '$2y$10$/4MKxhWG27qi1n8BUUBLxe/dYa9Ye4aPXWFfDrqnwSsE4aMbF/WPC', '0222222222', 0, '3c334af3-aeb4-486f-b4ac-d75f8fd8df68'),
(24, 'Serdot', 'Toma', '2023-11-24', 'jf.serdot@free.fr', '$2y$10$bdgk50HH1RVlqTuCeEj78uwIA5zynMisCrk3mcJWENfKZfoIvfhXi', '0666966690', 1, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `etat`
--

CREATE TABLE `etat` (
  `idetat` int(11) NOT NULL,
  `libelleetat` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `etat`
--

INSERT INTO `etat` (`idetat`, `libelleetat`) VALUES
(1, 'Neuf'),
(2, 'Bon état'),
(3, 'Mauvais état'),
(4, 'Très mauvais état'),
(5, 'Perdu');

-- --------------------------------------------------------

--
-- Structure de la table `exemplaire`
--

CREATE TABLE `exemplaire` (
  `idressource` int(11) NOT NULL,
  `idexemplaire` int(11) NOT NULL,
  `idetat` int(11) NOT NULL,
  `dateentree` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `exemplaire`
--

INSERT INTO `exemplaire` (`idressource`, `idexemplaire`, `idetat`, `dateentree`) VALUES
(1, 1697803279, 1, '2023-10-20'),
(1, 1700834022, 5, '2023-11-07'),
(1, 1700834066, 2, '2023-11-24'),
(1, 1700834071, 3, '2023-11-24'),
(1, 1700834075, 4, '2023-11-24'),
(1, 1700927092, 2, '2023-11-25'),
(2, 2, 2, '2023-01-01'),
(2, 1697802955, 1, '2023-10-20'),
(2, 1697802963, 2, '2023-10-20'),
(2, 1697802964, 2, '2023-10-20'),
(2, 1697803334, 1, '2023-10-20'),
(3, 3, 1, '2023-01-01'),
(4, 4, 1, '2023-01-01'),
(4, 50, 2, '2023-10-18'),
(5, 5, 1, '2023-01-01'),
(5, 879, 3, '2023-10-13'),
(6, 6, 1, '2023-01-01'),
(7, 7, 2, '2023-01-01'),
(8, 8, 1, '2023-01-01'),
(9, 9, 3, '2023-01-01'),
(10, 10, 1, '2023-01-01'),
(11, 11, 1, '2023-01-01'),
(12, 12, 1, '2023-01-01'),
(12, 1700759589, 1, '2023-10-31'),
(13, 13, 1, '2023-01-01'),
(14, 14, 1, '2023-01-01'),
(14, 1699627214, 1, '2023-11-10'),
(14, 1699627223, 1, '2023-11-10'),
(15, 15, 1, '2023-01-01'),
(16, 16, 1, '2023-01-01'),
(17, 17, 1, '2023-01-01'),
(18, 18, 1, '2023-01-01'),
(19, 19, 1, '2023-01-01'),
(20, 20, 1, '2023-01-01'),
(21, 21, 1, '2023-01-01'),
(22, 22, 1, '2023-01-01'),
(23, 23, 1, '2023-01-01'),
(24, 24, 1, '2023-01-01'),
(25, 25, 1, '2023-01-01'),
(26, 26, 1, '2023-01-01'),
(27, 27, 1, '2023-01-01'),
(28, 28, 1, '2023-01-01'),
(29, 29, 1, '2023-01-01'),
(30, 30, 1, '2023-01-01'),
(31, 31, 1, '2023-01-01'),
(32, 32, 1, '2023-01-01'),
(33, 33, 1, '2023-01-01'),
(34, 34, 1, '2023-01-01'),
(35, 35, 1, '2023-01-01'),
(36, 36, 1, '2023-01-01'),
(37, 37, 1, '2023-01-01'),
(38, 38, 1, '2023-01-01'),
(39, 39, 1, '2023-01-01'),
(40, 40, 1, '2023-01-01'),
(41, 41, 1, '2023-01-01'),
(42, 42, 1, '2023-01-01'),
(43, 43, 1, '2023-01-01'),
(44, 44, 1, '2023-01-01'),
(45, 45, 1, '2023-01-01'),
(46, 46, 1, '2023-01-01'),
(47, 47, 1, '2023-01-01'),
(48, 48, 1, '2023-01-01'),
(49, 49, 1, '2023-01-01'),
(50, 50, 1, '2023-01-01'),
(51, 51, 1, '2023-01-01'),
(52, 52, 1, '2023-01-01'),
(53, 53, 1, '2023-01-01'),
(54, 54, 1, '2023-01-01'),
(55, 55, 1, '2023-01-01'),
(56, 56, 1, '2023-01-01'),
(57, 57, 1, '2023-01-01'),
(58, 58, 1, '2023-01-01'),
(59, 59, 1, '2023-01-01'),
(60, 60, 1, '2023-01-01'),
(61, 61, 1, '2023-01-01'),
(70, 0, 1, '2023-10-18');

-- --------------------------------------------------------

--
-- Structure de la table `ressource`
--

CREATE TABLE `ressource` (
  `idressource` int(11) NOT NULL,
  `idcategorie` int(11) NOT NULL,
  `titre` varchar(128) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `image` varchar(255) DEFAULT NULL,
  `anneesortie` int(11) DEFAULT NULL,
  `isbn` varchar(128) DEFAULT NULL,
  `langue` char(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `ressource`
--

INSERT INTO `ressource` (`idressource`, `idcategorie`, `titre`, `description`, `image`, `anneesortie`, `isbn`, `langue`) VALUES
(1, 1, 'Gatsby le Magnifique', 'Roman de F. Scott Fitzgerald', 'gatsby-le-magnifique.jpg', 1925, '9782709628396', 'fr'),
(2, 1, '1984', 'Roman de George Orwell', '1984.jpg', 1949, '9782070368228', 'fr'),
(3, 1, 'Orgueil et Préjugés', 'Roman de Jane Austen', 'orgueil-et-prejuges.jpg', 1813, '9782253004606', 'fr'),
(4, 1, 'Le Seigneur des Anneaux', 'Trilogie de J.R.R. Tolkien', 'le-seigneur-des-anneaux.jpg', 1954, '9782070612889', 'fr'),
(5, 1, 'Crime et Châtiment', 'Roman de Fiodor Dostoïevski', 'crime-et-chatiment.jpg', 1866, '9782253009571', 'fr'),
(6, 1, 'Cent ans de solitude', 'Roman de Gabriel García Márquez', 'cent-ans-de-solitude.jpg', 1967, '9782020238113', 'fr'),
(7, 1, 'Les Misérables', 'Roman de Victor Hugo', 'les-miserables.jpg', 1862, '9782081395087', 'fr'),
(8, 1, 'Le Petit Prince', 'Roman de Antoine de Saint-Exupéry', 'le-petit-prince.jpg', 1943, '9782070612759', 'fr'),
(9, 1, 'L\'Étranger', 'Roman de Albert Camus', 'l-etranger.jpg', 1942, '9782070360024', 'fr'),
(10, 1, 'Le Comte de Monte-Cristo', 'Roman de Alexandre Dumas', 'le-comte-de-monte-cristo.jpg', 1844, '9782070413504', 'fr'),
(11, 1, 'Anna Karenine', 'Roman de Léon Tolstoï', 'anna-karenine.jpg', 1877, '9782070414808', 'fr'),
(12, 2, 'Astérix le Gaulois', 'Bande dessinée de René Goscinny et Albert Uderzo', 'asterix-le-gaulois.jpg', 1961, '9782012101396', 'fr'),
(13, 2, 'Tintin au pays des Soviets', 'Bande dessinée de Hergé', 'tintin-au-pays-des-soviets.jpg', 1929, '9782203001012', 'fr'),
(14, 2, 'Les Aventures de Lucky Luke', 'Bande dessinée de Morris et René Goscinny', 'les-aventures-de-lucky-luke.jpg', 1946, '9782884710236', 'fr'),
(15, 2, 'Blake et Mortimer', 'Bande dessinée de Edgar P. Jacobs', 'blake-et-mortimer.jpg', 1946, '9782870970249', 'fr'),
(16, 2, 'Gaston Lagaffe', 'Bande dessinée de André Franquin', 'gaston-lagaffe.jpg', 1957, '9782205025709', 'fr'),
(17, 2, 'Le Chat', 'Bande dessinée de Philippe Geluck', 'le-chat.jpg', 1983, '9782205058288', 'fr'),
(18, 2, 'Les Schtroumpfs', 'Bande dessinée de Peyo', 'les-schtroumpfs.jpg', 1958, '9782800115000', 'fr'),
(19, 2, 'Asterix et Cléopâtre', 'Bande dessinée de René Goscinny et Albert Uderzo', 'asterix-et-cleopatre.jpg', 1965, '9782012101365', 'fr'),
(20, 2, 'Blake et Mortimer - La Marque Jaune', 'Bande dessinée de Edgar P. Jacobs', 'blake-et-mortimer-la-marque-jaune.jpg', 1956, '9782870970430', 'fr'),
(21, 2, 'Tintin - Objectif Lune', 'Bande dessinée de Hergé', 'tintin-objectif-lune.jpg', 1953, '9782203001036', 'fr'),
(22, 3, 'One Piece', 'Manga de Eiichiro Oda', 'one-piece.jpg', 1997, '9782723491499', 'fr'),
(23, 3, 'Naruto', 'Manga de Masashi Kishimoto', 'naruto.jpg', 1999, '9782871294288', 'fr'),
(24, 3, 'Dragon Ball', 'Manga de Akira Toriyama', 'dragon-ball.jpg', 1984, '9782723420391', 'fr'),
(25, 3, 'Death Note', 'Manga de Tsugumi Ohba et Takeshi Obata', 'death-note.jpg', 2003, '9782723449217', 'fr'),
(26, 3, 'Bleach', 'Manga de Tite Kubo', 'bleach.jpg', 2001, '9782723442881', 'fr'),
(27, 3, 'Attack on Titan', 'Manga de Hajime Isayama', 'attack-on-titan.jpg', 2009, '9782811635537', 'fr'),
(28, 3, 'Fullmetal Alchemist', 'Manga de Hiromu Arakawa', 'fullmetal-alchemist.jpg', 2001, '9782723449217', 'fr'),
(29, 3, 'One Punch Man', 'Manga de ONE et Yusuke Murata', 'one-punch-man.jpg', 2012, '9782368526307', 'fr'),
(30, 3, 'Tokyo Ghoul', 'Manga de Sui Ishida', 'tokyo-ghoul.jpg', 2011, '9782723492656', 'fr'),
(31, 3, 'Fairy Tail', 'Manga de Hiro Mashima', 'fairy-tail.jpg', 2006, '9782811618837', 'fr'),
(32, 5, 'Thriller', 'Album de Michael Jackson', 'thriller.jpg', 1982, '5099750442225', 'en'),
(33, 5, 'Back in Black', 'Album de AC/DC', 'back-in-black.jpg', 1980, '696998020022', 'en'),
(34, 5, 'The Dark Side of the Moon', 'Album de Pink Floyd', 'the-dark-side-of-the-moon.jpg', 1973, '5099902988313', 'en'),
(35, 5, 'Abbey Road', 'Album des Beatles', 'abbey-road.jpg', 1969, '5099969945510', 'en'),
(36, 5, 'Nevermind', 'Album de Nirvana', 'nevermind.jpg', 1991, '0720642442523', 'en'),
(37, 5, 'Rumours', 'Album de Fleetwood Mac', 'rumours.jpg', 1977, '0075992746619', 'en'),
(38, 5, 'The Joshua Tree', 'Album de U2', 'the-joshua-tree.jpg', 1987, '0042282648226', 'en'),
(39, 5, 'Born to Run', 'Album de Bruce Springsteen', 'born-to-run.jpg', 1975, '5099746582423', 'en'),
(40, 5, 'The Queen Is Dead', 'Album de The Smiths', 'the-queen-is-dead.jpg', 1986, '0828768138125', 'en'),
(41, 5, 'Graceland', 'Album de Paul Simon', 'graceland.jpg', 1986, '0074648639426', 'en'),
(42, 7, 'Pulp Fiction', 'Film de Quentin Tarantino', 'pulp-fiction.jpg', 1994, '3333297468793', 'en'),
(43, 7, 'Le Parrain', 'Film de Francis Ford Coppola', 'le-parrain.jpg', 1972, '5051888148135', 'en'),
(44, 7, 'Fight Club', 'Film de David Fincher', 'fight-club.jpg', 1999, '3344428020085', 'en'),
(45, 7, 'Inception', 'Film de Christopher Nolan', 'inception.jpg', 2010, '5051889075189', 'en'),
(46, 7, 'The Shawshank Redemption', 'Film de Frank Darabont', 'the-shawshank-redemption.jpg', 1994, '7321950141003', 'en'),
(47, 7, 'The Dark Knight', 'Film de Christopher Nolan', 'the-dark-knight.jpg', 2008, '7321902182522', 'en'),
(48, 7, 'Interstellar', 'Film de Christopher Nolan', 'interstellar.jpg', 2014, '3333297204107', 'en'),
(49, 7, 'Eternal Sunshine of the Spotless Mind', 'Film de Michel Gondry', 'eternal-sunshine-of-the-spotless-mind.jpg', 2004, '3333297177073', 'en'),
(50, 7, 'The Godfather: Part II', 'Film de Francis Ford Coppola', 'the-godfather-part-ii.jpg', 1974, '7321900113694', 'en'),
(51, 7, 'The Matrix', 'Film de Lana et Lilly Wachowski', 'the-matrix.jpg', 1999, '7321900210652', 'en'),
(52, 9, 'The Legend of Zelda: Breath of the Wild', 'Jeu vidéo pour Nintendo Switch', 'zelda-breath-of-the-wild.jpg', 2017, '045496430577', 'en'),
(53, 9, 'Super Mario Odyssey', 'Jeu vidéo pour Nintendo Switch', 'super-mario-odyssey.jpg', 2017, '045496591918', 'en'),
(54, 9, 'Red Dead Redemption 2', 'Jeu vidéo pour PlayStation 4 et Xbox One', 'red-dead-redemption-2.jpg', 2018, '5026555421862', 'en'),
(55, 9, 'The Witcher 3: Wild Hunt', 'Jeu vidéo pour PlayStation 4, Xbox One et PC', 'the-witcher-3-wild-hunt.jpg', 2015, '3391891990662', 'en'),
(56, 9, 'Grand Theft Auto V', 'Jeu vidéo pour PlayStation 4, Xbox One et PC', 'grand-theft-auto-v.jpg', 2013, '5026555423125', 'en'),
(57, 9, 'Minecraft', 'Jeu vidéo pour plusieurs plateformes', 'minecraft.jpg', 2011, '885370829626', 'en'),
(58, 9, 'Super Smash Bros. Ultimate', 'Jeu vidéo pour Nintendo Switch', 'super-smash-bros-ultimate.jpg', 2018, '045496592998', 'en'),
(59, 9, 'Final Fantasy VII Remake', 'Jeu vidéo pour PlayStation 4', 'final-fantasy-vii-remake.jpg', 2020, '0662248925438', 'en'),
(60, 9, 'The Last of Us Part II', 'Jeu vidéo pour PlayStation 4', 'the-last-of-us-part-ii.jpg', 2020, '0711719833883', 'en'),
(61, 9, 'Animal Crossing: New Horizons', 'Jeu vidéo pour Nintendo Switch', 'animal-crossing-new-horizons.jpg', 2020, '045496596439', 'en'),
(70, 1, 'LÉtranger', 'Roman de Albert Camus', 'l-etranger.jpg', 1942, '9782070360024', 'fr'),
(94, 51, 'AAAAAAAAAAAAAAAAAAAAAAAAAa', 'dtryfuio', 'tof.jpg', 2023, '5456465', 'fr');

-- --------------------------------------------------------

--
-- Structure de la table `User`
--

CREATE TABLE `User` (
  `idUser` int(5) NOT NULL,
  `nomUser` varchar(200) NOT NULL,
  `prenomUser` varchar(200) NOT NULL,
  `mailUser` varchar(200) DEFAULT NULL,
  `mdpUser` varchar(200) DEFAULT NULL,
  `idAcces` int(11) NOT NULL DEFAULT 5
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `User`
--

INSERT INTO `User` (`idUser`, `nomUser`, `prenomUser`, `mailUser`, `mdpUser`, `idAcces`) VALUES
(1, 'APP', 'APP', 'APP@APP.fr', '$2a$04$IfxroVRq1R1emXxxh2TsEulMad.mwqiRY.90q8.uYzRR2JGK/hSfS', 1),
(2, 'APP', 'APP2', 'APP@APP2.fr', '$2a$04$IfxroVRq1R1emXxxh2TsEulMad.mwqiRY.90q8.uYzRR2JGK/hSfS', 2);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `acces`
--
ALTER TABLE `acces`
  ADD PRIMARY KEY (`idAcces`);

--
-- Index pour la table `auteur`
--
ALTER TABLE `auteur`
  ADD PRIMARY KEY (`idAuteur`);

--
-- Index pour la table `auteur_ressource`
--
ALTER TABLE `auteur_ressource`
  ADD PRIMARY KEY (`idRessource`,`idAuteur`),
  ADD KEY `AutRess_idRessource` (`idRessource`),
  ADD KEY `AutRess_idAuteur` (`idAuteur`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`idcategorie`);

--
-- Index pour la table `commentaire`
--
ALTER TABLE `commentaire`
  ADD PRIMARY KEY (`idCommentaire`),
  ADD KEY `FK_commentaire_ressource` (`idRessource`),
  ADD KEY `FK_commentaire_utilisateur` (`idUtilisateur`);

--
-- Index pour la table `emprunter`
--
ALTER TABLE `emprunter`
  ADD PRIMARY KEY (`idemprunteur`,`idressource`,`idexemplaire`,`datedebutemprunt`),
  ADD KEY `i_fk_emprunter_emprunteur1` (`idemprunteur`),
  ADD KEY `i_fk_emprunter_exemplaire1` (`idressource`,`idexemplaire`);

--
-- Index pour la table `emprunteur`
--
ALTER TABLE `emprunteur`
  ADD PRIMARY KEY (`idemprunteur`),
  ADD UNIQUE KEY `emailemprunteur` (`emailemprunteur`);

--
-- Index pour la table `etat`
--
ALTER TABLE `etat`
  ADD PRIMARY KEY (`idetat`);

--
-- Index pour la table `exemplaire`
--
ALTER TABLE `exemplaire`
  ADD PRIMARY KEY (`idressource`,`idexemplaire`),
  ADD KEY `i_fk_exemplaire_ressource1` (`idressource`),
  ADD KEY `i_fk_exemplaire_etat1` (`idetat`);

--
-- Index pour la table `ressource`
--
ALTER TABLE `ressource`
  ADD PRIMARY KEY (`idressource`),
  ADD KEY `i_fk_ressource_categorie1` (`idcategorie`);

--
-- Index pour la table `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`idUser`),
  ADD UNIQUE KEY `mailUser` (`mailUser`),
  ADD KEY `idAcces` (`idAcces`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `acces`
--
ALTER TABLE `acces`
  MODIFY `idAcces` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `auteur`
--
ALTER TABLE `auteur`
  MODIFY `idAuteur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=151;

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `idcategorie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT pour la table `commentaire`
--
ALTER TABLE `commentaire`
  MODIFY `idCommentaire` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `emprunteur`
--
ALTER TABLE `emprunteur`
  MODIFY `idemprunteur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT pour la table `etat`
--
ALTER TABLE `etat`
  MODIFY `idetat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `ressource`
--
ALTER TABLE `ressource`
  MODIFY `idressource` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

--
-- AUTO_INCREMENT pour la table `User`
--
ALTER TABLE `User`
  MODIFY `idUser` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `auteur_ressource`
--
ALTER TABLE `auteur_ressource`
  ADD CONSTRAINT `AutRess_idAuteur` FOREIGN KEY (`idAuteur`) REFERENCES `auteur` (`idAuteur`),
  ADD CONSTRAINT `AutRess_idRessource` FOREIGN KEY (`idRessource`) REFERENCES `ressource` (`idressource`);

--
-- Contraintes pour la table `commentaire`
--
ALTER TABLE `commentaire`
  ADD CONSTRAINT `FK_commentaire_ressource` FOREIGN KEY (`idRessource`) REFERENCES `ressource` (`idressource`),
  ADD CONSTRAINT `FK_commentaire_utilisateur` FOREIGN KEY (`idUtilisateur`) REFERENCES `emprunteur` (`idemprunteur`);

--
-- Contraintes pour la table `emprunter`
--
ALTER TABLE `emprunter`
  ADD CONSTRAINT `FK_emprunter_emprunteur` FOREIGN KEY (`idemprunteur`) REFERENCES `emprunteur` (`idemprunteur`),
  ADD CONSTRAINT `FK_emprunter_exemplaire` FOREIGN KEY (`idressource`,`idexemplaire`) REFERENCES `exemplaire` (`idressource`, `idexemplaire`);

--
-- Contraintes pour la table `exemplaire`
--
ALTER TABLE `exemplaire`
  ADD CONSTRAINT `FK_exemplaire_etat` FOREIGN KEY (`idetat`) REFERENCES `etat` (`idetat`),
  ADD CONSTRAINT `FK_exemplaire_ressource` FOREIGN KEY (`idressource`) REFERENCES `ressource` (`idressource`);

--
-- Contraintes pour la table `ressource`
--
ALTER TABLE `ressource`
  ADD CONSTRAINT `FK_ressource_categorie` FOREIGN KEY (`idcategorie`) REFERENCES `categorie` (`idcategorie`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
