-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.22-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para provpar2
CREATE DATABASE IF NOT EXISTS `provpar2` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_spanish_ci */;
USE `provpar2`;

-- Volcando estructura para tabla provpar2.partes
CREATE TABLE IF NOT EXISTS `partes` (
  `clave` varchar(10) COLLATE latin1_spanish_ci NOT NULL DEFAULT '',
  `nombre` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `tipo` varchar(10) COLLATE latin1_spanish_ci DEFAULT NULL,
  `color` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `existencia` int(11) DEFAULT NULL,
  `sminimo` int(11) DEFAULT NULL,
  `smaximo` int(11) DEFAULT NULL,
  `peso` decimal(10,2) DEFAULT NULL,
  `cc` decimal(10,2) DEFAULT NULL,
  `cv` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`clave`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla provpar2.partes: ~8 rows (aproximadamente)
/*!40000 ALTER TABLE `partes` DISABLE KEYS */;
INSERT INTO `partes` (`clave`, `nombre`, `tipo`, `color`, `existencia`, `sminimo`, `smaximo`, `peso`, `cc`, `cv`) VALUES
	('01', 'tuerca 4/8', '01', 'natural', 300, 200, 900, 1.00, 24.00, 30.00),
	('02', 'tuerca 3/8', '01', 'natural', 600, 700, 900, 2.00, 54.00, 60.00),
	('03', 'perno 1/2', '01', 'natural', 200, 100, 500, 3.00, 30.00, 35.00),
	('04', 'puerta madera', '02', 'blanco', 300, 50, 900, 5.00, 800.00, 1200.00),
	('05', 'taladro de banco', '02', 'blanco', 600, 100, 900, 10.00, 1400.00, 2200.00),
	('06', 'taladro de mano', '02', 'negro', 2, 1, 7, 7.00, 500.00, 700.00),
	('07', 'llave allen #2', '01', 'negro', 20, 10, 40, 1.00, 50.00, 80.00),
	('08', 'perno 3/8', '01', 'natural', 190, 200, 300, 1.00, 3.00, 20.00);
/*!40000 ALTER TABLE `partes` ENABLE KEYS */;

-- Volcando estructura para tabla provpar2.tipoparte
CREATE TABLE IF NOT EXISTS `tipoparte` (
  `id` varchar(10) COLLATE latin1_spanish_ci NOT NULL DEFAULT '',
  `descripcion` varchar(80) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla provpar2.tipoparte: ~7 rows (aproximadamente)
/*!40000 ALTER TABLE `tipoparte` DISABLE KEYS */;
INSERT INTO `tipoparte` (`id`, `descripcion`) VALUES
	('01', 'albañileria'),
	('02', 'MATERIAL PLOMERIA'),
	('03', 'MATERIAL CARPINTERIA'),
	('04', 'Herramientas Electricas'),
	('05', 'material aluminio'),
	('06', 'material aire acondicionado'),
	('07', 'material especial');
/*!40000 ALTER TABLE `tipoparte` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
