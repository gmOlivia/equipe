create database aep
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema aep
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema aep
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `aep` DEFAULT CHARACTER SET utf8mb4 ;
-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `aep` ;

-- -----------------------------------------------------
-- Table `aep`.`Cadastro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `aep`.`Cadastro` (
  `pesssoa` VARCHAR(45) NOT NULL,
  `status` VARCHAR(45) NULL,
  `produto` VARCHAR(45) NULL,
  `data` DATE NULL,
  PRIMARY KEY (`pesssoa`))
ENGINE = InnoDB;
