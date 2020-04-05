#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------

#------------------------------------------------------------
# CREATE DataBase
#------------------------------------------------------------

CREATE DATABASE IF NOT EXISTS `m2lgestiondesadherents` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `m2lgestiondesadherents`;

#------------------------------------------------------------
# Table: Club
#------------------------------------------------------------

CREATE TABLE Club(
        Id_Club   Int  Auto_increment  NOT NULL ,
        Name_Club Varchar (25) NOT NULL
	,CONSTRAINT Club_PK PRIMARY KEY (Id_Club)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: AccesRight
#------------------------------------------------------------

CREATE TABLE AccesRight(
        Id_AccesRight   Int  Auto_increment  NOT NULL ,
        Name_AccesRight Varchar (50) NOT NULL
	,CONSTRAINT AccesRight_PK PRIMARY KEY (Id_AccesRight)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Member
#------------------------------------------------------------

CREATE TABLE Member(
        Id_Member       Int  Auto_increment  NOT NULL ,
        Name_Member     Varchar (25) NOT NULL ,
        LastName_Member Varchar (25) NOT NULL ,
        Password_Member Varchar (50) ,
        Login_Member    Varchar (50) ,
        Id_Club         Int ,
        Id_AccesRight   Int NOT NULL
	,CONSTRAINT Member_PK PRIMARY KEY (Id_Member)

	,CONSTRAINT Member_Club_FK FOREIGN KEY (Id_Club) REFERENCES Club(Id_Club)
	,CONSTRAINT Member_AccesRight0_FK FOREIGN KEY (Id_AccesRight) REFERENCES AccesRight(Id_AccesRight)
)ENGINE=InnoDB;

