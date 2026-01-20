-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema gass_livery
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema gass_livery
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `gass_livery` DEFAULT CHARACTER SET utf8 ;
USE `gass_livery` ;

-- -----------------------------------------------------
-- Table `gass_livery`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`users` (
  `id_users` INT(11) NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(64) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `full_name` VARCHAR(100) NULL DEFAULT NULL,
  `gender` TINYINT(4) NOT NULL,
  `profile_pic_path` TEXT NULL DEFAULT NULL,
  `age` TINYINT(4) NULL DEFAULT NULL,
  `phone` INT(11) NOT NULL,
  `birthday` DATETIME NULL DEFAULT NULL,
  `address` TEXT NOT NULL,
  PRIMARY KEY (`id_users`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`driver`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`driver` (
  `id_driver` INT(11) NOT NULL,
  `id_user` INT(11) NOT NULL,
  `pendapatan` BIGINT(20) NOT NULL DEFAULT 0,
  `review` FLOAT NOT NULL DEFAULT 0,
  `description` TEXT NULL DEFAULT NULL,
  `status` ENUM('active', 'offline') NOT NULL DEFAULT 'active',
  PRIMARY KEY (`id_driver`),
  INDEX `fk_id_user` (`id_user` ASC),
  CONSTRAINT `fk_driver_users`
    FOREIGN KEY (`id_user`)
    REFERENCES `gass_livery`.`users` (`id_users`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`tenant`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`tenant` (
  `id_tenant` INT(11) NOT NULL,
  `id_users` INT(11) NOT NULL,
  `nama_tenant` VARCHAR(100) NOT NULL,
  `alamat` TEXT NOT NULL,
  `rating` FLOAT NULL DEFAULT 0,
  `photo` TEXT NULL DEFAULT NULL,
  PRIMARY KEY (`id_tenant`),
  UNIQUE INDEX `nama_tenant_UNIQUE` (`nama_tenant` ASC),
  INDEX `fk_tenant_users1_idx` (`id_users` ASC),
  CONSTRAINT `fk_tenant_users1`
    FOREIGN KEY (`id_users`)
    REFERENCES `gass_livery`.`users` (`id_users`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`menu`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`menu` (
  `id_menu` INT(11) NOT NULL,
  `id_tenant` INT(11) NOT NULL,
  `nama_menu` VARCHAR(100) NOT NULL DEFAULT '',
  `stock` INT(11) NOT NULL DEFAULT 0,
  `harga` INT(11) NOT NULL DEFAULT 0,
  `rating` FLOAT NOT NULL DEFAULT 0,
  `photo` TEXT NULL DEFAULT NULL,
  `description` TEXT NULL DEFAULT NULL,
  PRIMARY KEY (`id_menu`),
  UNIQUE INDEX `nama_menu_UNIQUE` (`nama_menu` ASC),
  INDEX `fk_menu_tenant1_idx` (`id_tenant` ASC),
  CONSTRAINT `fk_menu_tenant1`
    FOREIGN KEY (`id_tenant`)
    REFERENCES `gass_livery`.`tenant` (`id_tenant`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`transaksi`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`transaksi` (
  `id_transaksi` VARCHAR(56) NOT NULL,
  `id_users` INT(11) NOT NULL,
  `id_driver` INT(11) NOT NULL,
  `tanggal` DATETIME NOT NULL DEFAULT now(),
  `rating_driver` FLOAT NULL DEFAULT 0,
  `titik_jemput` TEXT NOT NULL,
  `titik_antar` TEXT NOT NULL,
  `jarak` INT NOT NULL,
  `verifikasi` ENUM('Yes', 'No') NOT NULL DEFAULT 'No',
  PRIMARY KEY (`id_transaksi`, `id_users`, `id_driver`),
  INDEX `fk_transaksi_users1_idx` (`id_users` ASC),
  INDEX `fk_transaksi_driver1_idx` (`id_driver` ASC),
  CONSTRAINT `fk_transaksi_driver1`
    FOREIGN KEY (`id_driver`)
    REFERENCES `gass_livery`.`driver` (`id_driver`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_transaksi_users1`
    FOREIGN KEY (`id_users`)
    REFERENCES `gass_livery`.`users` (`id_users`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`gass_kan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`gass_kan` (
  `id_gasskan` INT NOT NULL,
  `id_menu` INT(11) NOT NULL,
  `id_tenant` INT(11) NOT NULL,
  `id_transaksi` VARCHAR(56) NOT NULL,
  `jumlah` INT NOT NULL,
  `rating_menu` FLOAT NULL DEFAULT 0,
  INDEX `fk_gass_kan_menu1_idx` (`id_menu` ASC),
  INDEX `fk_gass_kan_tenant1_idx` (`id_tenant` ASC),
  PRIMARY KEY (`id_gasskan`),
  INDEX `fk_gass_kan_transaksi1_idx` (`id_transaksi` ASC),
  CONSTRAINT `fk_gass_kan_menu1`
    FOREIGN KEY (`id_menu`)
    REFERENCES `gass_livery`.`menu` (`id_menu`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_gass_kan_tenant1`
    FOREIGN KEY (`id_tenant`)
    REFERENCES `gass_livery`.`tenant` (`id_tenant`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_gass_kan_transaksi1`
    FOREIGN KEY (`id_transaksi`)
    REFERENCES `gass_livery`.`transaksi` (`id_transaksi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`gass_mon`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`gass_mon` (
  `id_gassmon` VARCHAR(45) NOT NULL,
  `id_users` INT(11) NOT NULL,
  `saldo` BIGINT(20) NOT NULL DEFAULT 0,
  `point` INT(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id_gassmon`),
  INDEX `fk_gass_mon_users1_idx` (`id_users` ASC),
  CONSTRAINT `fk_gass_mon_users1`
    FOREIGN KEY (`id_users`)
    REFERENCES `gass_livery`.`users` (`id_users`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`gass_ride`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`gass_ride` (
  `id_gassride` INT NOT NULL,
  `transaksi_id_transaksi` VARCHAR(56) NOT NULL,
  `driver_wanita` TINYINT(1) NOT NULL DEFAULT 0,
  `kendaraan_baru` TINYINT(1) NOT NULL DEFAULT 0,
  `total_bayar` INT(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id_gassride`),
  INDEX `fk_gass_ride_transaksi1_idx` (`transaksi_id_transaksi` ASC),
  CONSTRAINT `fk_gass_ride_transaksi1`
    FOREIGN KEY (`transaksi_id_transaksi`)
    REFERENCES `gass_livery`.`transaksi` (`id_transaksi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`history_penarikan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`history_penarikan` (
  `id_penarikan` INT(11) NOT NULL,
  `id_driver` INT(11) NOT NULL,
  `tanggal` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `jumlah` BIGINT(20) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_penarikan`),
  INDEX `fk_history_penarikan_driver1_idx` (`id_driver` ASC),
  CONSTRAINT `fk_history_penarikan_driver1`
    FOREIGN KEY (`id_driver`)
    REFERENCES `gass_livery`.`driver` (`id_driver`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`kendaraan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`kendaraan` (
  `id_kendaraan` INT(11) NOT NULL,
  `id_driver` INT(11) NOT NULL,
  `no_plat` VARCHAR(10) NULL DEFAULT NULL,
  `tahun_produksi` YEAR(4) NULL DEFAULT NULL,
  `jenis` ENUM('car', 'motorcycle') NOT NULL,
  PRIMARY KEY (`id_kendaraan`),
  INDEX `fk_kendaraan_driver1_idx` (`id_driver` ASC),
  CONSTRAINT `fk_kendaraan_driver1`
    FOREIGN KEY (`id_driver`)
    REFERENCES `gass_livery`.`driver` (`id_driver`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`topup`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`topup` (
  `id_topup` INT(11) NOT NULL,
  `id_gassmon` VARCHAR(45) NOT NULL,
  `jumlah_topup` BIGINT(20) NULL DEFAULT NULL,
  `tanggal` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`id_topup`),
  INDEX `fk_topup_gass_mon1_idx` (`id_gassmon` ASC),
  CONSTRAINT `fk_topup_gass_mon`
    FOREIGN KEY (`id_gassmon`)
    REFERENCES `gass_livery`.`gass_mon` (`id_gassmon`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`transfer`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`transfer` (
  `id_transfer` INT(11) NOT NULL,
  `id_gassmon` VARCHAR(45) NOT NULL,
  `jumlah_transfer` BIGINT(20) NULL DEFAULT NULL,
  `tanggal` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`id_transfer`),
  INDEX `fk_transfer_gass_mon1_idx` (`id_gassmon` ASC),
  CONSTRAINT `fk_transfer_gass_mon1`
    FOREIGN KEY (`id_gassmon`)
    REFERENCES `gass_livery`.`gass_mon` (`id_gassmon`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `gass_livery`.`Admin`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gass_livery`.`Admin` (
  `id_users` INT(11) NOT NULL,
  INDEX `fk_Admin_users1_idx` (`id_users` ASC),
  CONSTRAINT `fk_Admin_users1`
    FOREIGN KEY (`id_users`)
    REFERENCES `gass_livery`.`users` (`id_users`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
