/*
[Table(Name="Customers")]
public class Customer
{
   [Column(IsPrimaryKey=true)]
   public string CustomerID;
   [Column]
   public string City;
}
*/

/*
CREATE TABLE `playlist_song` (
  `userplaylistID` int(11) NOT NULL,
  `idSongInfo` int(11) NOT NULL,
  PRIMARY KEY (`userplaylistID`,`idSongInfo`),
  KEY `idSongInfo_idx` (`idSongInfo`),
  CONSTRAINT `playlistID` FOREIGN KEY (`userplaylistID`) REFERENCES `userplaylist` (`userplaylistID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `idSong` FOREIGN KEY (`idSongInfo`) REFERENCES `songinfo` (`idSongInfo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
*/

[Table(Name="playlist_song")]
public class playlistSong
{
	[Column(Id=true)]
	public int(11) userplaylistID
	[Column(Id=true)]
	public int(11) idSongInfo
	
}

/*
CREATE TABLE `songalbum` (
  `songAlbumID` int(11) NOT NULL AUTO_INCREMENT,
  `songAlbumName` varchar(45) DEFAULT NULL,
  `songAlbumLabel` varchar(45) DEFAULT NULL,
  `songAlbumYear` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`songAlbumID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
*/

[Table(Name="songalbum")]
public class songAlbum
{
	[Column(Id=true)(isPrimarykey=true]
	public int(11) songAlbumID
	[Column]
	public string(45) songAlbumName
	[Column]
	public string(45) songAlbumLabel
	[Column]
	public string(45) songAlbumYear
	
}

/*
CREATE TABLE `songartist` (
  `songArtistID` int(11) NOT NULL AUTO_INCREMENT,
  `ArtistName` varchar(45) DEFAULT NULL,
  `ArtistLabel` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`songArtistID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
*/

[Table(Name="songartist")]
public class songArtist
{
	[Column(Id=true)(isPrimarykey=true)]
	public int(11) songArtistID
	[Column]
	public string(45) ArtistName
	[Column]
	public string(45) ArtistLabel
	
}

/*
CREATE TABLE `songinfo` (
  `idSongInfo` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(45) NOT NULL,
  `Artist` varchar(45) DEFAULT NULL,
  `Genre` varchar(45) DEFAULT NULL,
  `Album` varchar(45) DEFAULT NULL,
  `Location` varchar(45) DEFAULT NULL,
  `AlbumTrack` int(11) DEFAULT NULL,
  `Year` int(11) DEFAULT NULL,
  `Comment` varchar(45) DEFAULT NULL,
  `PlayCount` int(11) DEFAULT NULL,
  `BPM` int(11) DEFAULT NULL,
  PRIMARY KEY (`idSongInfo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
*/

[Table(Name="songinfo")]
public class songInfo
{
	[Column(Id=true)(isPrimarykey=true)]
	public int(11) idSongInfo
	[Column]
	public string(45) Title
	[Column]
	public string(45) Artist
	[Column]
	public string(45) Genre
	[Column]
	public string(45) Album
	[Column]
	public string(45) Location
	[Column]
	public int(11) AlbumTrack
	[Column]
	public int(11) Year
	[Column]
	public string(45) Comment
	[Column]
	public int(11) PlayCount
	[Column]
	public int(11) BPM
}

/*
CREATE TABLE `useraddress` (
  `userAddID` int(11) NOT NULL AUTO_INCREMENT,
  `userStreet` varchar(45) DEFAULT NULL,
  `userCity` varchar(45) DEFAULT NULL,
  `userState` varchar(45) DEFAULT NULL,
  `userZip` varchar(45) DEFAULT NULL,
  `userCountry` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`userAddID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
*/

[Table(Name="useraddress")]
public class userAddress
{
	[Column(Id=true)(isPrimarykey=true)]
	public int(11) userAddID
	[Column]
	public string(45) userStreet
	[Column]
	public string(45) userCity
	[Column]
	public string(45) userState
	[Column]
	public string(45) userZip
	[Column]
	public string(45) userCountry	
}

/*
CREATE TABLE `usercreditcardinfo` (
  `userCreditCardID` int(11) NOT NULL AUTO_INCREMENT,
  `userCardType` varchar(45) DEFAULT NULL,
  `userCreditCardNumber` varchar(100) DEFAULT NULL,
  `userCardExpDate` char(7) DEFAULT NULL,
  `userCardCCV` int(11) DEFAULT NULL,
  `userCardName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`userCreditCardID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8
*/

[Table(Name="usercreditcardinfo")]
public class userCreditCardInfo
{
	[Column(Id=true)(isPrimarykey=true)]
	public int(11) CreditCardID
	[Column]
	public string(45) userCardType
	[Column]
	public string(100) userCreditCardNumber
	[Column]
	public string(7) userCardExpDate
	[Column]
	public string(11) userCardCCV
	[Column]
	public string(100) userCardName
}

/*
CREATE TABLE `userinfo` (
  `iduserInfo` int(11) NOT NULL AUTO_INCREMENT,
  `userFirstName` varchar(45) DEFAULT NULL,
  `userLastName` varchar(45) DEFAULT NULL,
  `userAddID` int(11) DEFAULT NULL,
  `userPurchasesID` int(11) DEFAULT NULL,
  `userEmail` varchar(100) DEFAULT NULL,
  `userCreditCardID` int(11) DEFAULT NULL,
  `userPhoneNumber` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`iduserInfo`),
  KEY `userPurchasesID_idx` (`userPurchasesID`),
  KEY `userCreditCardID_idx` (`userCreditCardID`),
  KEY `uerAddID_idx` (`userAddID`),
  CONSTRAINT `uerAddID` FOREIGN KEY (`userAddID`) REFERENCES `useraddress` (`userAddID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `userCreditCardID` FOREIGN KEY (`userCreditCardID`) REFERENCES `usercreditcardinfo` (`userCreditCardID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `userPurchasesID` FOREIGN KEY (`userPurchasesID`) REFERENCES `userpurchases` (`userPurchasesID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
*/

[Table(Name="userinfo")]
public class userInfo
{
	[Column(Id=true)(isPrimarykey=true)]
	public int(11) iduserInfo
	[Column]
	public string(45) userFirstName
	[Column]
	public string(45) userLastName
	[Column]
	public int(11) userAddID
	[Column]
	public int(11) userPurchaseID
	[Column]
	public string(100) userEmail
	[Column]
	public int(11) userCreditCardID
	[Column]
	public string(10) userPhoneNumber
}

/*
CREATE TABLE `userplaylist` (
  `userplaylistID` int(11) NOT NULL AUTO_INCREMENT,
  `userplaylistNAME` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`userplaylistID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
*/

[Table(Name="userplaylist")]
public class userPlaylist
{
	[Column(Id=true)(isPrimarykey=true)]
	public int(11) userplaylistID
	[Column]
	public string(45) userplaylistNAME
}

/*
CREATE TABLE `userpurchases` (
  `userPurchasesID` int(11) NOT NULL AUTO_INCREMENT,
  `idSongInfo` int(11) DEFAULT NULL,
  PRIMARY KEY (`userPurchasesID`),
  KEY `idSongInfo_idx` (`idSongInfo`),
  CONSTRAINT `idSongInfo` FOREIGN KEY (`idSongInfo`) REFERENCES `songinfo` (`idSongInfo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
*/

[Table(Name="userpurchases")]
public class userPurchases
{
	[Column(Id=true)(isPrimarykey=true)]
	public int(11) userplaylistID
	[Column(Id=true)]
	public string(45) userplaylistNAME

}


