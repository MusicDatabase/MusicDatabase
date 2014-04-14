SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`userplaylist`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`userplaylist` (
  `userplaylistID` INT(11) NOT NULL AUTO_INCREMENT,
  `userplaylistNAME` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`userplaylistID`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mydb`.`songalbum`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`songalbum` (
  `songAlbumID` INT(11) NOT NULL AUTO_INCREMENT,
  `songAlbumName` VARCHAR(45) NULL DEFAULT NULL,
  `songAlbumLabel` VARCHAR(45) NULL DEFAULT NULL,
  `songAlbumYear` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`songAlbumID`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mydb`.`songartist`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`songartist` (
  `songArtistID` INT(11) NOT NULL AUTO_INCREMENT,
  `ArtistName` VARCHAR(45) NULL DEFAULT NULL,
  `ArtistLabel` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`songArtistID`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mydb`.`songinfo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`songinfo` (
  `idSongInfo` INT(11) NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(45) NOT NULL,
  `Artist` INT NULL DEFAULT NULL,
  `Genre` VARCHAR(45) NULL DEFAULT NULL,
  `Album` INT NULL DEFAULT NULL,
  `Location` VARCHAR(45) NULL DEFAULT NULL,
  `AlbumTrack` INT(11) NULL DEFAULT NULL,
  `Year` INT(11) NULL DEFAULT NULL,
  `Comment` VARCHAR(45) NULL DEFAULT NULL,
  `PlayCount` INT(11) NULL DEFAULT NULL,
  `BPM` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`idSongInfo`),
  INDEX `songAlbumID_idx` (`Album` ASC),
  INDEX `songArtistID_idx` (`Artist` ASC),
  CONSTRAINT `songAlbumID`
    FOREIGN KEY (`Album`)
    REFERENCES `mydb`.`songalbum` (`songAlbumID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `songArtistID`
    FOREIGN KEY (`Artist`)
    REFERENCES `mydb`.`songartist` (`songArtistID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mydb`.`playlist_song`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`playlist_song` (
  `userplaylistID` INT(11) NOT NULL,
  `idSongInfo` INT(11) NOT NULL,
  PRIMARY KEY (`userplaylistID`, `idSongInfo`),
  INDEX `idSongInfo_idx` (`idSongInfo` ASC),
  CONSTRAINT `playlistID`
    FOREIGN KEY (`userplaylistID`)
    REFERENCES `mydb`.`userplaylist` (`userplaylistID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idSong`
    FOREIGN KEY (`idSongInfo`)
    REFERENCES `mydb`.`songinfo` (`idSongInfo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mydb`.`useraddress`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`useraddress` (
  `userAddID` INT(11) NOT NULL AUTO_INCREMENT,
  `userStreet` VARCHAR(45) NULL DEFAULT NULL,
  `userCity` VARCHAR(45) NULL DEFAULT NULL,
  `userState` VARCHAR(45) NULL DEFAULT NULL,
  `userZip` VARCHAR(45) NULL DEFAULT NULL,
  `userCountry` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`userAddID`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mydb`.`usercreditcardinfo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`usercreditcardinfo` (
  `userCreditCardID` INT(11) NOT NULL AUTO_INCREMENT,
  `userCardType` VARCHAR(45) NULL DEFAULT NULL,
  `userCreditCardNumber` VARCHAR(100) NULL DEFAULT NULL,
  `userCardExpDate` CHAR(7) NULL DEFAULT NULL,
  `userCardCCV` INT(11) NULL DEFAULT NULL,
  `userCardName` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`userCreditCardID`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mydb`.`userinfo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`userinfo` (
  `iduserInfo` INT(11) NOT NULL AUTO_INCREMENT,
  `userFirstName` VARCHAR(45) NULL DEFAULT NULL,
  `userLastName` VARCHAR(45) NULL DEFAULT NULL,
  `userAddID` INT(11) NULL DEFAULT NULL,
  `userPurchasesID` INT(11) NULL DEFAULT NULL,
  `userEmail` VARCHAR(100) NULL DEFAULT NULL,
  `userCreditCardID` INT(11) NULL DEFAULT NULL,
  `userPhoneNumber` VARCHAR(10) NULL DEFAULT NULL,
  PRIMARY KEY (`iduserInfo`),
  INDEX `userPurchasesID_idx` (`userPurchasesID` ASC),
  INDEX `userCreditCardID_idx` (`userCreditCardID` ASC),
  INDEX `uerAddID_idx` (`userAddID` ASC),
  CONSTRAINT `uerAddID`
    FOREIGN KEY (`userAddID`)
    REFERENCES `mydb`.`useraddress` (`userAddID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `userCreditCardID`
    FOREIGN KEY (`userCreditCardID`)
    REFERENCES `mydb`.`usercreditcardinfo` (`userCreditCardID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mydb`.`userpurchases`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`userpurchases` (
  `userPurchasesID` INT(11) NOT NULL AUTO_INCREMENT,
  `idSongInfo` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`userPurchasesID`),
  INDEX `idSongInfo_idx` (`idSongInfo` ASC),
  CONSTRAINT `idSongInfo`
    FOREIGN KEY (`idSongInfo`)
    REFERENCES `mydb`.`songinfo` (`idSongInfo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
