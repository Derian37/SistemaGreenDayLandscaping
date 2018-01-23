-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.22-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para bd_registro
CREATE DATABASE IF NOT EXISTS `bd_registro` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bd_registro`;

-- Volcando estructura para procedimiento bd_registro.consulta_detalle
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consulta_detalle`(
	IN `det` VARCHAR(50)

)
BEGIN
SELECT registro.id_registro,registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro
WHERE detalle = det;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_registro.consulta_registro
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consulta_registro`(
	IN `fechone` VARCHAR(50),
	IN `fechtwo` VARCHAR(50)


,
	IN `det` VARCHAR(50)
)
BEGIN
SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro
WHERE registro.fecha BETWEEN fechone AND fechtwo
AND registro.estado!="Eliminado"
AND registro.detalle="DEPOSITO SOMOS VOZ"
ORDER BY id_registro DESC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_registro.consulta_registroOtros
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consulta_registroOtros`(
	IN `fechone` VARCHAR(50),
	IN `fechtwo` VARCHAR(50)
)
BEGIN
SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro
WHERE registro.fecha BETWEEN fechone AND fechtwo
AND registro.estado!="Eliminado"
AND registro.detalle!="DEPOSITO SOMOS VOZ"
ORDER BY id_registro DESC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_registro.eliminar_registros
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `eliminar_registros`()
BEGIN
 DELETE FROM registro
 WHERE registro.estado = "Eliminado";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_registro.insertar_registro
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_registro`(
	IN `detalle` VARCHAR(50),
	IN `monto` FLOAT,
	IN `fecha` DATE,
	IN `estado` VARCHAR(50)






)
BEGIN
INSERT INTO registro (registro.detalle,registro.monto,registro.fecha,registro.estado)
	VALUES(detalle,monto,fecha,estado);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_registro.listar_registro
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_registro`()
BEGIN
	SELECT * FROM registro
	WHERE registro.estado != "Eliminado"
	ORDER BY id_registro DESC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_registro.listar_registro_eliminado
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_registro_eliminado`()
BEGIN
	SELECT * FROM registro
	WHERE registro.estado = "Eliminado"
	ORDER BY id_registro DESC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_registro.modifica_registro
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modifica_registro`(
	IN `id_registro` INT,
	IN `detalle` VARCHAR(50),
	IN `monto` FLOAT,
	IN `fecha` DATE,
	IN `estado` VARCHAR(50)

)
BEGIN
UPDATE registro 
SET registro.detalle=detalle,registro.monto=monto,registro.fecha=fecha, registro.estado=estado
WHERE registro.id_registro=id_registro;
END//
DELIMITER ;

-- Volcando estructura para tabla bd_registro.registro
CREATE TABLE IF NOT EXISTS `registro` (
  `id_registro` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(50) DEFAULT NULL,
  `monto` float DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_registro`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para procedimiento bd_registro.Test
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Test`(
	IN `Param1` DATE,
	IN `Param2` DATE
)
BEGIN
SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_registro.vaciar_registro
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `vaciar_registro`()
BEGIN
 DELETE FROM registro;
 ALTER TABLE registro AUTO_INCREMENT=0;
END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
