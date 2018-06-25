-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.2.12-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for bd_greendaylandscaping
CREATE DATABASE IF NOT EXISTS `bd_greendaylandscaping` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bd_greendaylandscaping`;

-- Dumping structure for table bd_greendaylandscaping.tbl_bill
CREATE TABLE IF NOT EXISTS `tbl_bill` (
  `id_bill` int(11) NOT NULL AUTO_INCREMENT,
  `id_customer` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `details` varchar(50) NOT NULL,
  PRIMARY KEY (`id_bill`),
  KEY `id_custormer` (`id_customer`),
  KEY `id_user` (`id_user`),
  CONSTRAINT `id_custormer` FOREIGN KEY (`id_customer`) REFERENCES `tbl_customers` (`code`),
  CONSTRAINT `id_user` FOREIGN KEY (`id_user`) REFERENCES `tbl_users` (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Dumping data for table bd_greendaylandscaping.tbl_bill: ~7 rows (approximately)
DELETE FROM `tbl_bill`;
/*!40000 ALTER TABLE `tbl_bill` DISABLE KEYS */;
INSERT INTO `tbl_bill` (`id_bill`, `id_customer`, `id_user`, `fecha`, `details`) VALUES
	(1, 11, 1, '0000-00-00', 'April 2018'),
	(2, 12, 1, '0000-00-00', 'april'),
	(3, 12, 1, '0000-00-00', 'april 19 /2020'),
	(4, 12, 1, '0000-00-00', 'april 19/2018'),
	(5, 12, 1, '0000-00-00', '04/19/2018'),
	(6, 13, 1, '0000-00-00', 'SPRING CLEAN UP'),
	(7, 5, 1, '0000-00-00', 'spring clean up');
/*!40000 ALTER TABLE `tbl_bill` ENABLE KEYS */;

-- Dumping structure for table bd_greendaylandscaping.tbl_customers
CREATE TABLE IF NOT EXISTS `tbl_customers` (
  `code` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL DEFAULT '0',
  `telephone` varchar(50) NOT NULL DEFAULT '0',
  `address` varchar(50) NOT NULL DEFAULT '0',
  `postalCode` varchar(50) NOT NULL DEFAULT '0',
  `staticPrice` double DEFAULT NULL,
  PRIMARY KEY (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- Dumping data for table bd_greendaylandscaping.tbl_customers: ~13 rows (approximately)
DELETE FROM `tbl_customers`;
/*!40000 ALTER TABLE `tbl_customers` DISABLE KEYS */;
INSERT INTO `tbl_customers` (`code`, `name`, `lastName`, `telephone`, `address`, `postalCode`, `staticPrice`) VALUES
	(1, 'John', 'Stanise', '2035369407', '68 WOLFPIT RD WILTON CT', '60897', 85),
	(2, 'Joe', 'Thomas', 'NULL', '105 POND RD WILTON CT', '06897', 0),
	(3, 'Daved', 'Popoff', 'NULL', '98 MAYWOOD RD NORWALK CT', '06850', 0),
	(4, 'Daved', 'Popoff', '203 228 0646', '123 WEST AVE DARIEN CT', '06820', 50),
	(5, 'Andy', 'NULL', '203 8568133', '51 NOAH-S LN NORWALK CT', '6851', 25),
	(6, 'Daved', 'Tatkow', '9178599062', '62 WOLFPIT RD WILTON CT', '06897', 0),
	(7, 'Maria', 'Tripoti', '203 515 6311', '100 POND RD WILTON CT', '6897', 4500),
	(8, 'Peter', 'NULL', '917 560 0150', '40 FRANCE ST NORWALK', '6851', 65),
	(9, 'Tracy', 'Casteli', '203 216 1622', '240 ROWAYTON RD NORWALK', '6853', 0),
	(10, 'Tracy', 'Casteli', '203 216 1622', '67 OLD BOSTON RD WILTON CT', '6897', 50),
	(11, 'kevin', 'Tangney', '203 252 6567', '212 Wolfpit rd', '6897', 65),
	(12, 'steve ', 'tomsen ', '347 920 6710', '8 sunnyside ave ', '6820', 30),
	(13, 'SUSAN ', 'NUL', '203 343 2977', 'WILTON WOOD RD WILTON ', '6897', 55);
/*!40000 ALTER TABLE `tbl_customers` ENABLE KEYS */;

-- Dumping structure for table bd_greendaylandscaping.tbl_elementbill
CREATE TABLE IF NOT EXISTS `tbl_elementbill` (
  `id_billFac` int(11) NOT NULL AUTO_INCREMENT,
  `id_bill` int(11) NOT NULL DEFAULT 0,
  `fecha` varchar(50) NOT NULL DEFAULT '0',
  `details` varchar(50) NOT NULL DEFAULT '0',
  `servicePrice` double NOT NULL DEFAULT 0,
  `amount` double NOT NULL DEFAULT 0,
  PRIMARY KEY (`id_billFac`),
  KEY `id_bill` (`id_bill`),
  CONSTRAINT `id_bill` FOREIGN KEY (`id_bill`) REFERENCES `tbl_bill` (`id_bill`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Dumping data for table bd_greendaylandscaping.tbl_elementbill: ~6 rows (approximately)
DELETE FROM `tbl_elementbill`;
/*!40000 ALTER TABLE `tbl_elementbill` DISABLE KEYS */;
INSERT INTO `tbl_elementbill` (`id_billFac`, `id_bill`, `fecha`, `details`, `servicePrice`, `amount`) VALUES
	(1, 1, '4-17-2018', 'Spring clean up  Guys 3 Hours ', 400, 1150.99),
	(2, 1, '4-17-2018', 'Seed grass  Guys 3 Hours ', 240.74, 991.73),
	(3, 1, '4-17-2018', 'Fertilizer Guys 3 Hours ', 60.57, 811.56),
	(4, 1, '4-17-2018', 'Limestone Guys 3 Hours ', 49.68, 800.6700000000001),
	(5, 5, '19-4-2018', 'this is firt h bill Guys 1 Hours 1', 500, 500),
	(6, 5, '19-4-2018', 'i will do for same price  2.290 Guys 0 Hours 1', 500, 1000);
/*!40000 ALTER TABLE `tbl_elementbill` ENABLE KEYS */;

-- Dumping structure for table bd_greendaylandscaping.tbl_savebills
CREATE TABLE IF NOT EXISTS `tbl_savebills` (
  `id_saveBills` int(11) NOT NULL AUTO_INCREMENT,
  `id_customer` int(11) NOT NULL DEFAULT 0,
  `fecha` date DEFAULT NULL,
  `id_bill` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_saveBills`),
  KEY `id_customer` (`id_customer`),
  KEY `id_bills` (`id_bill`),
  CONSTRAINT `id_bills` FOREIGN KEY (`id_bill`) REFERENCES `tbl_bill` (`id_bill`),
  CONSTRAINT `id_customer` FOREIGN KEY (`id_customer`) REFERENCES `tbl_customers` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Dumping data for table bd_greendaylandscaping.tbl_savebills: ~7 rows (approximately)
DELETE FROM `tbl_savebills`;
/*!40000 ALTER TABLE `tbl_savebills` DISABLE KEYS */;
INSERT INTO `tbl_savebills` (`id_saveBills`, `id_customer`, `fecha`, `id_bill`) VALUES
	(1, 11, '2018-04-17', 1),
	(2, 12, '0000-00-00', 2),
	(3, 12, '0000-00-00', 3),
	(4, 12, '0000-00-00', 4),
	(5, 12, '0000-00-00', 5),
	(6, 13, '0000-00-00', 6),
	(7, 5, '0000-00-00', 7);
/*!40000 ALTER TABLE `tbl_savebills` ENABLE KEYS */;

-- Dumping structure for table bd_greendaylandscaping.tbl_users
CREATE TABLE IF NOT EXISTS `tbl_users` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `passwordd` varchar(50) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table bd_greendaylandscaping.tbl_users: ~1 rows (approximately)
DELETE FROM `tbl_users`;
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT INTO `tbl_users` (`id_user`, `name`, `lastName`, `passwordd`) VALUES
	(1, 'Derian', 'Chavarría', '123');
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;

-- Dumping structure for procedure bd_greendaylandscaping.confirm_password
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `confirm_password`(
	IN `us` INT
)
BEGIN
SELECT passwordd FROM tbl_users
WHERE tbl_users.id_user = us;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.Costum_Customers
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Costum_Customers`(
	IN `code` INT
,
	IN `name` VARCHAR(50),
	IN `lastName` VARCHAR(50),
	IN `telephone` VARCHAR(50),
	IN `address` VARCHAR(50),
	IN `postalCode` VARCHAR(50)
,
	IN `staticPrice` DOUBLE
)
BEGIN
 UPDATE tbl_customers 
 SET tbl_customers.name=name,tbl_customers.lastName=lastName,tbl_customers.telephone=telephone,tbl_customers.address=address,tbl_customers.postalCode=postalCode, tbl_customers.staticPrice=staticPrice
 WHERE tbl_customers.code=code;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.get_bill
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_bill`(
	IN `id_bill` INT





)
BEGIN
SELECT DISTINCT tbl_bill.id_bill, tbl_elementbill.fecha, tbl_elementbill.details, tbl_elementbill.servicePrice,tbl_elementbill.amount FROM tbl_bill,tbl_elementbill
WHERE tbl_bill.id_bill = id_bill
AND tbl_bill.id_bill = tbl_elementbill.id_bill;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.get_billbydate
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_billbydate`(
	IN `id_customer` INT,
	IN `fecha1` VARCHAR(50),
	IN `fecha2` VARCHAR(50)







)
BEGIN
SELECT DISTINCT tbl_savebills.id_saveBills, tbl_customers.name, tbl_bill.details,tbl_savebills.fecha  FROM tbl_bill, tbl_customers,tbl_savebills
WHERE tbl_savebills.id_customer = id_customer
AND tbl_customers.code = tbl_savebills.id_customer 
AND tbl_savebills.id_bill = tbl_bill.id_bill
AND tbl_savebills.fecha  BETWEEN fecha1 and fecha2;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.get_lastbill
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_lastbill`(
	IN `id_customer` INT

)
BEGIN
SELECT tbl_bill.id_bill FROM tbl_bill
WHERE tbl_bill.id_customer = id_customer
ORDER BY tbl_bill.id_bill DESC LIMIT 1;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.get_lastcustomer
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_lastcustomer`()
BEGIN
SELECT tbl_customers.code FROM tbl_customers
ORDER BY tbl_customers.code DESC LIMIT 1;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.Insert_bills
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Insert_bills`(
	IN `id_bill` INT,
	IN `fecha` VARCHAR(50),
	IN `details` VARCHAR(50),
	IN `servicePrice` DOUBLE,
	IN `amount` DOUBLE






)
BEGIN
INSERT INTO tbl_elementbill(tbl_elementbill.id_bill,tbl_elementbill.fecha,tbl_elementbill.details,tbl_elementbill.servicePrice,tbl_elementbill.amount)
VALUES(id_bill, fecha, details, servicePrice, amount);
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.Insert_Customers
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Insert_Customers`(
	IN `name` VARCHAR(50),
	IN `lastName` VARCHAR(50),
	IN `telephone` VARCHAR(50),
	IN `address` VARCHAR(50)
,
	IN `postalCode` INT
,
	IN `staticPrice` DOUBLE
)
BEGIN
INSERT INTO tbl_customers (tbl_customers.name,tbl_customers.lastName,tbl_customers.telephone,tbl_customers.address,tbl_customers.postalCode,tbl_customers.staticPrice) 
VALUES(name,lastName,telephone,address,postalCode,staticPrice);
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.Insert_newBills
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Insert_newBills`(
	IN `id_customer` INT,
	IN `id_user` INT,
	IN `fecha` VARCHAR(50),
	IN `details` VARCHAR(50)
)
BEGIN
INSERT INTO tbl_bill(tbl_bill.id_customer,tbl_bill.id_user,tbl_bill.fecha,tbl_bill.details)
VALUES(id_customer,id_user, fecha, details);
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.Insert_saveBills
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Insert_saveBills`(
	IN `id_customer` INT,
	IN `fecha` VARCHAR(50),
	IN `id_bill` INT


)
BEGIN
INSERT INTO tbl_savebills(tbl_savebills.id_customer,tbl_savebills.fecha,tbl_savebills.id_bill)
VALUES(id_customer,fecha,id_bill);
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.list_Bills
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `list_Bills`(
	IN `id_customer` INT





,
	IN `last_id` INT
)
    COMMENT 'list_Bills'
BEGIN
SELECT DISTINCT tbl_bill.id_bill, tbl_elementbill.fecha, tbl_elementbill.details, tbl_elementbill.servicePrice, tbl_elementbill.amount,tbl_elementbill.id_billFac 
FROM tbl_bill,tbl_elementbill,tbl_savebills
WHERE tbl_bill.id_customer = id_customer
AND tbl_bill.id_bill = last_id
AND tbl_elementbill.id_bill = tbl_bill.id_bill;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.list_customerbyid
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `list_customerbyid`(
	IN `id_customer` INT

)
BEGIN
	SELECT  DISTINCT tbl_customers.name,tbl_customers.lastName, tbl_customers.address,tbl_customers.staticPrice FROM tbl_customers
	WHERE tbl_customers.code =id_customer;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.list_customers
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `list_customers`()
BEGIN
SELECT * FROM tbl_customers
ORDER BY tbl_customers.code DESC;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.list_savebillsbyid
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `list_savebillsbyid`(
	IN `id_customer` INT












)
BEGIN
	SELECT  DISTINCT tbl_bill.id_bill,tbl_customers.name,tbl_bill.details ,tbl_savebills.fecha FROM tbl_elementbill,tbl_savebills,tbl_customers,tbl_bill
	WHERE tbl_customers.code=id_customer
	AND tbl_customers.code = tbl_bill.id_customer
	AND tbl_bill.id_bill = tbl_savebills.id_bill
   ORDER BY tbl_savebills.id_saveBills DESC;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.list_users
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `list_users`()
BEGIN
SELECT id_user, name, lastName, passwordd FROM tbl_users;
END//
DELIMITER ;

-- Dumping structure for procedure bd_greendaylandscaping.modify_bill
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modify_bill`(
	IN `id_billf` INT,
	IN `id_bill` INT,
	IN `fecha` VARCHAR(50),
	IN `detalle` VARCHAR(50),
	IN `precio` DOUBLE,
	IN `monto` DOUBLE

)
BEGIN
UPDATE tbl_elementbill 
SET tbl_elementbill.fecha= fecha, tbl_elementbill.details = detalle, tbl_elementbill.servicePrice = precio, tbl_elementbill.amount= monto
WHERE tbl_elementbill.id_bill=id_bill
AND tbl_elementbill.id_billFac=id_billf;
END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
