#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Players
#------------------------------------------------------------

CREATE TABLE Player(
        idPlayer    Int  Auto_increment  NOT NULL ,
        plaScore    Int NOT NULL ,
        PlaName     Varchar (20) NOT NULL ,
        PlaPassword Varchar (50) NOT NULL
	,CONSTRAINT Player_PK PRIMARY KEY (idPlayer)
)ENGINE=InnoDB;

