--Conor O'Brien
--T00193238
--Software Engineering Project

DROP TABLE Bookings;
DROP TABLE Tenants;
DROP TABLE Properties;
DROP TABLE Owners;


CREATE TABLE Owners
(Owner_ID numeric(3),
Forename varchar2(15) NOT NULL,
Surname varchar2(15) NOT NULL,
Street varchar2(20) NOT NULL,
Town varchar2(20) NOT NULL,
County varchar2(20) NOT NULL,
Phone varchar2(15),
Email varchar2(50) NOT NULL,
Activity char(1) NOT NULL,
CONSTRAINT pk_Owners PRIMARY KEY (Owner_ID));

CREATE TABLE Properties
(Prop_ID numeric(3),
RentPerMonth decimal NOT NULL,
Bedrooms int NOT NULL,
Bathrooms int NOT NULL,
HouseType varchar2(25) NOT NULL,
Street varchar2(20) NOT NULL,
Town varchar(20) NOT NULL,
County char(15) NOT NULL,
Activity char(1) NOT NULL,
Owner_ID numeric(3),
CONSTRAINT pk_Properties PRIMARY KEY (Prop_ID),
CONSTRAINT fk_Properties_Owners FOREIGN KEY (Owner_ID) REFERENCES Owners);

CREATE TABLE Tenants
(Tenant_ID numeric(3),
Forename varchar2(15) NOT NULL,
Surname varchar2(15) NOT NULL,
Phone varchar2(15) NOT NULL,
Email varchar2(30) NOT NULL,
DOB date,
Activity char(1) NOT NULL,
Prop_ID numeric(3),
CONSTRAINT pk_Tenant PRIMARY KEY (Tenant_ID),
CONSTRAINT fk_Tenant_Properties FOREIGN KEY (Prop_ID) REFERENCES Properties);

CREATE TABLE Bookings
(Booking_ID numeric(3),
DateRegistered date,
StartOfLease date,
EndOfLease date,
Prop_ID numeric(3),
CONSTRAINT pk_Booking PRIMARY KEY (Booking_ID),
CONSTRAINT fk_Booking_Props FOREIGN KEY (Prop_ID) REFERENCES Properties);