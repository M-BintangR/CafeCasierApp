-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for cafee
DROP DATABASE IF EXISTS `cafee`;
CREATE DATABASE IF NOT EXISTS `cafee` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `cafee`;

-- Dumping structure for table cafee.detail_pesanan
DROP TABLE IF EXISTS `detail_pesanan`;
CREATE TABLE IF NOT EXISTS `detail_pesanan` (
  `id_detail_pesanan` int NOT NULL AUTO_INCREMENT,
  `pesanan_id` int DEFAULT '0',
  `menu_id` int DEFAULT '0',
  `jml_pesanan` bigint DEFAULT NULL,
  `total_harga` bigint DEFAULT NULL,
  PRIMARY KEY (`id_detail_pesanan`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table cafee.detail_pesanan: ~0 rows (approximately)
REPLACE INTO `detail_pesanan` (`id_detail_pesanan`, `pesanan_id`, `menu_id`, `jml_pesanan`, `total_harga`) VALUES
	(2, 1, 3, 10, 160000),
	(9, 3, 3, 2, 32000),
	(10, 3, 1, 2, 20000),
	(11, 4, 1, 2, 20000);

-- Dumping structure for table cafee.menu
DROP TABLE IF EXISTS `menu`;
CREATE TABLE IF NOT EXISTS `menu` (
  `id_menu` int NOT NULL AUTO_INCREMENT,
  `nama` varchar(50) DEFAULT NULL,
  `harga` varchar(150) DEFAULT NULL,
  `deskripsi` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_menu`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table cafee.menu: ~0 rows (approximately)
REPLACE INTO `menu` (`id_menu`, `nama`, `harga`, `deskripsi`) VALUES
	(1, 'kopi late', '10000', 'kopi latte (americano + susu)'),
	(3, 'Kopi Hitam', '16000', 'Kopi Hitam Pahit, Sepahit Cinta Mu Ke Dia. 😁');

-- Dumping structure for table cafee.pembayaran
DROP TABLE IF EXISTS `pembayaran`;
CREATE TABLE IF NOT EXISTS `pembayaran` (
  `id_pembayaran` int NOT NULL AUTO_INCREMENT,
  `pesanan_id` int NOT NULL DEFAULT '0',
  `total_item` int NOT NULL DEFAULT '0',
  `total_bayar` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_pembayaran`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table cafee.pembayaran: ~0 rows (approximately)

-- Dumping structure for table cafee.pesanan
DROP TABLE IF EXISTS `pesanan`;
CREATE TABLE IF NOT EXISTS `pesanan` (
  `id_pesanan` int NOT NULL AUTO_INCREMENT,
  `nama_pelanggan` varchar(50) DEFAULT NULL,
  `status` enum('PAID','UNPAID') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'UNPAID',
  `tgl_pesanan` datetime DEFAULT NULL,
  `nomor_meja` int DEFAULT NULL,
  `nomor_lantai` int DEFAULT NULL,
  PRIMARY KEY (`id_pesanan`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table cafee.pesanan: ~3 rows (approximately)
REPLACE INTO `pesanan` (`id_pesanan`, `nama_pelanggan`, `status`, `tgl_pesanan`, `nomor_meja`, `nomor_lantai`) VALUES
	(1, 'Bintang', 'PAID', '2025-01-31 00:32:22', 1, 1),
	(3, 'Aco', 'UNPAID', '2025-01-31 04:59:53', 2, 3),
	(4, 'Baco', 'UNPAID', '2025-01-31 04:59:46', 2, 2);

-- Dumping structure for table cafee.users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int NOT NULL AUTO_INCREMENT,
  `username` varchar(100) DEFAULT NULL,
  `email` varchar(60) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `role` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_user`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table cafee.users: ~0 rows (approximately)
REPLACE INTO `users` (`id_user`, `username`, `email`, `password`, `role`) VALUES
	(1, 'admin', 'admin@gmail.com', 'adminadmin', 'admin'),
	(2, 'kasir', 'kasir@gmail.com', 'kasirkasir', 'kasir');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
