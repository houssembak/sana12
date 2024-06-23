-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 23 juin 2024 à 18:07
-- Version du serveur : 10.4.22-MariaDB
-- Version de PHP : 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `devnet`
--

-- --------------------------------------------------------

--
-- Structure de la table `arret`
--

CREATE TABLE `arret` (
  `id` int(11) NOT NULL,
  `Arret` varchar(250) NOT NULL,
  `Machines` varchar(250) NOT NULL,
  `temps` varchar(250) NOT NULL,
  `causes` varchar(250) NOT NULL,
  `Remède` varchar(250) NOT NULL,
  `frequence` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `arret`
--

INSERT INTO `arret` (`id`, `Arret`, `Machines`, `temps`, `causes`, `Remède`, `frequence`) VALUES
(16, '1', '1', '1', '1', '1', ''),
(23, '11', '11', '11', '11', '11', ''),
(24, '22', '22', '22', '22', '22', ''),
(25, '33', '33', '33', '33', '33', '33');

-- --------------------------------------------------------

--
-- Structure de la table `articles`
--

CREATE TABLE `articles` (
  `id` int(250) NOT NULL,
  `reference` varchar(250) NOT NULL,
  `designation` varchar(250) NOT NULL,
  `productionhoraires` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `articles`
--

INSERT INTO `articles` (`id`, `reference`, `designation`, `productionhoraires`) VALUES
(6, '1234567', 'Test', '0'),
(7, '1', '1', '0'),
(8, '123', '222', '0'),
(9, '52', '25', '0'),
(10, '14', '1414', '41'),
(11, '111', '11', '11'),
(12, '147', '147', '147'),
(13, '147', '852', '147'),
(14, 'tee', 'dfs', '147'),
(15, '963852', 'fhgdff', '10'),
(16, 'Sana', 'Test', '14');

-- --------------------------------------------------------

--
-- Structure de la table `calculplanification`
--

CREATE TABLE `calculplanification` (
  `id` int(11) NOT NULL,
  `qte_Aproduire` varchar(250) NOT NULL,
  `date_jour` date NOT NULL,
  `qte_produit` varchar(250) NOT NULL,
  `qte_Restantes` varchar(250) NOT NULL,
  `date_livraison` varchar(250) NOT NULL,
  `Rendement` varchar(250) NOT NULL,
  `code_planification` varchar(250) NOT NULL,
  `avancement` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `calculplanification`
--

INSERT INTO `calculplanification` (`id`, `qte_Aproduire`, `date_jour`, `qte_produit`, `qte_Restantes`, `date_livraison`, `Rendement`, `code_planification`, `avancement`) VALUES
(171, '10218', '2024-06-23', '1500', '10218', '06/06/2024', '77', 'Swissi', '12,80'),
(172, '8768', '2024-06-23', '1450', '8768', '06/06/2024', '74', 'Swissi', '12,80'),
(173, '7668', '2024-06-23', '1100', '7668', '06/06/2024', '56', 'Swissi', '25,17'),
(174, '2668', '2024-06-23', '5000', '2668', '06/06/2024', '256', 'Swissi', '34,56');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE `commande` (
  `id` int(11) NOT NULL,
  `OF` varchar(250) NOT NULL,
  `code article` varchar(250) NOT NULL,
  `designation` varchar(250) NOT NULL,
  `quantite fabriquer` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`id`, `OF`, `code article`, `designation`, `quantite fabriquer`) VALUES
(6, '111', '', '1', '1'),
(7, '14', '', '14', '4141'),
(8, '147', '1', '41', '4141'),
(9, '017', '147', '147', '14785'),
(10, '258', '52', 'fhjn', '1478'),
(11, '741', 'tee', 'jhjhgj', '8000'),
(12, '74125896300147', 'Sana', 'test', '11718');

-- --------------------------------------------------------

--
-- Structure de la table `fils`
--

CREATE TABLE `fils` (
  `id` int(11) NOT NULL,
  `code` varchar(250) NOT NULL,
  `composition` varchar(250) NOT NULL,
  `couleur` varchar(250) NOT NULL,
  `codefournisseur` varchar(250) NOT NULL,
  `titre` varchar(250) NOT NULL,
  `resistance` varchar(250) NOT NULL,
  `allongment` varchar(250) NOT NULL,
  `enbivage` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `fils`
--

INSERT INTO `fils` (`id`, `code`, `composition`, `couleur`, `codefournisseur`, `titre`, `resistance`, `allongment`, `enbivage`) VALUES
(4, 'test123', 'test', 'df', 'qdsf', 'sdf', 'dsfs', 'sdfqdf', 'sdqfdf');

-- --------------------------------------------------------

--
-- Structure de la table `fournisseurs`
--

CREATE TABLE `fournisseurs` (
  `id` int(11) NOT NULL,
  `code` varchar(250) NOT NULL,
  `tva` varchar(250) NOT NULL,
  `societe` varchar(250) NOT NULL,
  `Pays` varchar(250) NOT NULL,
  `email` varchar(250) NOT NULL,
  `tel` varchar(250) NOT NULL,
  `remarque` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `fournisseurs`
--

INSERT INTO `fournisseurs` (`id`, `code`, `tva`, `societe`, `Pays`, `email`, `tel`, `remarque`) VALUES
(1, '1234563664258', '15247fger', 'ggergtertg', 'tunisie', 'leoni.01@leoni.com', '+21673625874', 'test'),
(4, 'qdsf', 'dsqf', 'dsqf', 'fdsq', 'qsdf', 'sdqf', 'qsdf'),
(9, 'test', 'dsfd', 'fdsg', 'fdgdf', 'dfg', 'dfg', 'dfgdf');

-- --------------------------------------------------------

--
-- Structure de la table `login`
--

CREATE TABLE `login` (
  `id_login` int(11) NOT NULL,
  `user` varchar(250) NOT NULL,
  `password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `login`
--

INSERT INTO `login` (`id_login`, `user`, `password`) VALUES
(1, 'test', 'test1234');

-- --------------------------------------------------------

--
-- Structure de la table `parcmachine`
--

CREATE TABLE `parcmachine` (
  `id` int(11) NOT NULL,
  `code` varchar(250) NOT NULL,
  `marque` varchar(250) NOT NULL,
  `tisserand` varchar(250) NOT NULL,
  `nbreesouples` varchar(250) NOT NULL,
  `Etat` tinyint(1) NOT NULL,
  `Date_commence` varchar(250) NOT NULL,
  `date_disponibilite` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `parcmachine`
--

INSERT INTO `parcmachine` (`id`, `code`, `marque`, `tisserand`, `nbreesouples`, `Etat`, `Date_commence`, `date_disponibilite`) VALUES
(9, 'fdsg', 'fdsg', 'fdgf', 'sdfg', 0, '2024-06-03', '06/06/2024'),
(20, 'tt', 'ijh', 'fdgf', '1', 0, '2024-06-01', '06/06/2024'),
(21, 'fgfgf', 'fdgfd', '11', 'fdgdf', 1, '2024-06-12', ''),
(22, 'sds', 'qdfqdf', '11', '6', 1, '2024-06-05', '12/05/2024');

-- --------------------------------------------------------

--
-- Structure de la table `productionplanification`
--

CREATE TABLE `productionplanification` (
  `id_planification` int(11) NOT NULL,
  `code_planification` varchar(250) NOT NULL,
  `code_article` varchar(250) NOT NULL,
  `qte_produire` varchar(250) NOT NULL,
  `production_horaire` varchar(250) NOT NULL,
  `Nb_jour_estimé` varchar(250) NOT NULL,
  `Production_journalier` varchar(250) NOT NULL,
  `nombre_de_bande` varchar(250) NOT NULL,
  `machines` varchar(250) NOT NULL,
  `Date_commence` varchar(250) NOT NULL,
  `OF` int(11) NOT NULL,
  `tisserand` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `productionplanification`
--

INSERT INTO `productionplanification` (`id_planification`, `code_planification`, `code_article`, `qte_produire`, `production_horaire`, `Nb_jour_estimé`, `Production_journalier`, `nombre_de_bande`, `machines`, `Date_commence`, `OF`, `tisserand`) VALUES
(39, 'CP123456789', '1234567', '200000', '100', '15', '13950', '6', '14', '2024-05-25', 0, 11),
(64, '14', '1234567', '41414', '14', '32', '1302', '4', '4174', '2024-05-09', 0, 0),
(65, '134', '1234567', '25874', '258', '2', '23994', '4', 'fdsg', '2024-05-13', 111, 0),
(66, '25', '1', '5252', '25', '4', '1743,75', '3', 'test1234', '2024-05-16', 111, 0),
(67, '147', '111', '4141', '11', '6', '767,25', '3', 'test1234', '2024-05-15', 14, 0),
(68, '45252', '14', '4141', '41', '5', '953,25', '1', 'fdsg', '2024-05-16', 111, 0),
(69, '0111', '147', '14785', '147', '2', '10253,25', '3', 'test1234', '2024-05-19', 14, 0),
(70, '0369', '147', '1', '147', '1', '3417,75', '1', 'fdsg', '2024-05-21', 111, 0),
(71, '951', '147', '14785', '147', '5', '3417,75', '1', '123456', '2024-05-21', 14, 11),
(72, '14', '147', '14785', '147', '5', '3417,75', '1', 'fdsg', '2024-05-21', 111, 11),
(73, '52', 'tee', '4141', '147', '2', '3417,75', '1', 'fdsg', '2024-05-22', 111, 0),
(74, '1444144', 'tee', '1478', '147', '1', '3417,75', '1', 'tt', '2024-05-22', 258, 0),
(75, '525222', 'tee', '1478', '147', '1', '3417,75', '1', 'tt', '2024-05-22', 258, 0),
(76, '525', 'tee', '14785', '147', '5', '3417,75', '1', 'tt', '2024-05-22', 258, 0),
(77, '41', 'tee', '14785', '147', '5', '3417,75', '1', 'tt', '2024-05-22', 258, 0),
(78, '01478', '963852', '8000', '10', '9', '930', '4', 'tt', '2024-06-02', 741, 0),
(79, 'Swissi', 'Sana', '11718', '14', '6', '1953', '6', 'tt', '2024-06-01', 2147483647, 0),
(80, 'ytuj', 'Sana', '11718', '14', '37', '325', '1', 'fdsg', '2024-06-03', 2147483647, 0),
(81, 'dghdf', 'Sana', '11718', '14', '6', '1953', '6', 'fgfgf', '2024-06-12', 2147483647, 0),
(82, '14', 'Sana', '11718', '14', '37', '325', '1', 'sds', '2024-06-05', 2147483647, 0);

-- --------------------------------------------------------

--
-- Structure de la table `tisserands`
--

CREATE TABLE `tisserands` (
  `id` int(11) NOT NULL,
  `code` varchar(250) NOT NULL,
  `nom` varchar(250) NOT NULL,
  `prenom` varchar(250) NOT NULL,
  `sexe` varchar(250) NOT NULL,
  `etatcivile` varchar(250) NOT NULL,
  `adresse` varchar(250) NOT NULL,
  `tel` varchar(250) NOT NULL,
  `equipe` varchar(250) NOT NULL,
  `presence` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `tisserands`
--

INSERT INTO `tisserands` (`id`, `code`, `nom`, `prenom`, `sexe`, `etatcivile`, `adresse`, `tel`, `equipe`, `presence`) VALUES
(3, 'fdgf', 'fdgd', 'fdgd', 'gds', 'fdgsdf', 'fdgfsd', 'fdgsd', 'fdgsdf', 'gsd'),
(4, '11', '1', '1', '1', '1', '1', '1', '1', '1');

-- --------------------------------------------------------

--
-- Structure de la table `trs`
--

CREATE TABLE `trs` (
  `id` int(11) NOT NULL,
  `Date` varchar(250) NOT NULL,
  `Machine` varchar(250) NOT NULL,
  `Tisserand` varchar(250) NOT NULL,
  `tt` varchar(250) NOT NULL,
  `tprevu` varchar(250) NOT NULL,
  `tr` varchar(250) NOT NULL,
  `timprevu` varchar(250) NOT NULL,
  `tf` varchar(250) NOT NULL,
  `VP` varchar(250) NOT NULL,
  `VR` varchar(250) NOT NULL,
  `ECRAT` varchar(250) NOT NULL,
  `tb` varchar(250) NOT NULL,
  `Msorti` varchar(250) NOT NULL,
  `MNonconfirme` varchar(250) NOT NULL,
  `Mconforme` varchar(250) NOT NULL,
  `OF` varchar(250) NOT NULL,
  `Designation` varchar(250) NOT NULL,
  `Reference` varchar(250) NOT NULL,
  `mq` varchar(250) NOT NULL,
  `tu` varchar(250) NOT NULL,
  `do` varchar(250) NOT NULL,
  `tp` varchar(250) NOT NULL,
  `tq` varchar(250) NOT NULL,
  `TRS(%)` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `trs`
--

INSERT INTO `trs` (`id`, `Date`, `Machine`, `Tisserand`, `tt`, `tprevu`, `tr`, `timprevu`, `tf`, `VP`, `VR`, `ECRAT`, `tb`, `Msorti`, `MNonconfirme`, `Mconforme`, `OF`, `Designation`, `Reference`, `mq`, `tu`, `do`, `tp`, `tq`, `TRS(%)`) VALUES
(1, '2024-06-21', 'tt', 'fdgf', '140', '10', '130', '10', '120', '', '', '', '8,571428571428571428571428571', '120', '20', '100', '14', '41', '147', '', '7,1428571428571428571428571429', '92,30769230769230769230769231', '7,1428571428571428571428571400', '83,33333333333333333333333334', '0,0549450549450549450549450549'),
(2, '2024-06-21', 'fdsg', 'fdgf', '140', '10', '130', '10', '120', '', '', '', '0,1', '14', '1', '13', '147', '41', '52', '', '0,0928571428571428571428571429', '92,30769230769230769230769231', '0,0833333333333333333333333300', '92,85714285714285714285714290', '0,0007142857142857142857142857'),
(3, '2024-06-22', 'tt', '11', '14', '1', '13,00', '10', '3,00', '', '', '', '8,42', '101', '1', '100,00', '017', '41', '14', '', '8,33', '0,23', '2,81', '0,99', '63,983700'),
(4, '2024-06-22 20:53:28.310499', 'tt', 'fdgf', '', '', '', '', '', '', '', '', '', '', '', '', '14', '41', '1', '', '', '', '', '', ''),
(5, '2024-06-23 14:04:39.651371', 'sds', 'fdgf', '101', '1', '100,00', '10', '90,00', '81', '1', '80,00', '10,00', '101', '1', '100,00', '147', '41', '147', '0,10', '100,00', '0,90', '0,11', '10,00', '99,000000'),
(6, '2024-06-23 16:12:41.399715', 'fgfgf', 'fdgf', '102', '2', '100,00', '10', '90,00', '101', '12', '89,00', '1,00', '101', '1', '100,00', '017', '1', '1234567', '0,01', '100,00', '0,90', '0,01', '100,00', '90,00');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `arret`
--
ALTER TABLE `arret`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `articles`
--
ALTER TABLE `articles`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `calculplanification`
--
ALTER TABLE `calculplanification`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `commande`
--
ALTER TABLE `commande`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `fils`
--
ALTER TABLE `fils`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `fournisseurs`
--
ALTER TABLE `fournisseurs`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id_login`);

--
-- Index pour la table `parcmachine`
--
ALTER TABLE `parcmachine`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `productionplanification`
--
ALTER TABLE `productionplanification`
  ADD PRIMARY KEY (`id_planification`);

--
-- Index pour la table `tisserands`
--
ALTER TABLE `tisserands`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `trs`
--
ALTER TABLE `trs`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `arret`
--
ALTER TABLE `arret`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT pour la table `articles`
--
ALTER TABLE `articles`
  MODIFY `id` int(250) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT pour la table `calculplanification`
--
ALTER TABLE `calculplanification`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=175;

--
-- AUTO_INCREMENT pour la table `commande`
--
ALTER TABLE `commande`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `fils`
--
ALTER TABLE `fils`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `fournisseurs`
--
ALTER TABLE `fournisseurs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `parcmachine`
--
ALTER TABLE `parcmachine`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT pour la table `productionplanification`
--
ALTER TABLE `productionplanification`
  MODIFY `id_planification` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=83;

--
-- AUTO_INCREMENT pour la table `tisserands`
--
ALTER TABLE `tisserands`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `trs`
--
ALTER TABLE `trs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
