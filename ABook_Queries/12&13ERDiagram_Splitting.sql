use ABook;

--Splitting the table into other tables
--Name, ContactInfo,Address,RelationType

alter table ABookTable
drop column PhoneNumber, Address, City, State, Email;
alter table ABookTable drop column ZipCode;

alter table ABookTable 
add unique (FirstName);

--alter table ABookTable
--add PersonID int identity(1,1) not null primary key;

--alter table ABookTable drop column PersonID;

--alter table ABookTable
--add unique (FirstName);

alter table ABookTable
add primary key (FirstName);

select * from ABookTable;


--Cmd to check for Primary Keys in a table
SELECT *
FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA + '.' + QUOTENAME(CONSTRAINT_NAME)), 'IsPrimaryKey') = 1
AND TABLE_NAME = 'ABookTable';


---Contact Info Table
create table ContactInfo  
(
	FirstName varchar(20) not null foreign key references ABookTable(FirstName),
	PhoneNumber varchar(13) not null,
	Email varchar(25) not null
);

alter table ContactInfo add foreign key (FirstName) references ABookTable(FirstName);

INSERT INTO ContactInfo(FirstName,PhoneNumber,Email)
     VALUES
           ('Mohanee','9674879893','monee99@gmail.com'),
		   ('Prudhvi','8555466603','pru17@gmail.com'),
		   ('Rajat','7487009893','rajat002@gmail.com'),
		   ('Ankita','7487009893','ank675@gmail.com'),
		   ('Chinmayi','924579893','chin56@gmail.com'),
		   ('Saras','9609787863','sarasroy@gmail.com'),
		    ('Shriya','9672379893','shriyab@gmail.com'),
			('Prateek','9674567890','miket@gmail.com'),
			('Kaushal','8362478920','kaushalk@gmail.com');
GO

select * from ContactInfo;


--AddressInfo Table
create table AddressInfo
(
	FirstName varchar(20) not null foreign key references ABookTable(FirstName),
	Address varchar(15) not null,
	City varchar(15) not null,
	State varchar(20) not null,
	Zipcode varchar(6) not null,
);

INSERT INTO AddressInfo(FirstName,Address,City,State,Zipcode)
     VALUES
           ('Mohanee','28/A','Bhilai','C.G.','490006'),
		   ('Prudhvi','28/A','Hyd','T.L.','490566'),
		   ('Rajat','28/A','Vizag','A.P.','499876'),
		   ('Ankita','LtWillaims','Raigarh','C.G.','579893'),
		   ('Chinmayi','Ban/A','Bhellary','K.A.','780006'),
		   ('Saras','Russian Comp','Bhilai','C.G.','490006'),
		    ('Shriya','Newtown','Kolkata','WB','711006'),
			('Prateek','LajpatNagar','Lucknow','UP','490234'),
			('Kaushal','Bisra','Patna','BH','211906');
GO

select * from AddressInfo;

select a.FirstName,i.City from ABookTable a join AddressInfo i 
on (a.FirstName= i.FirstName) where i.City='Bhilai'
order by a.FirstName;

select n.FirstName, n.LastName, af.Address, af.City, af.State, af.Zipcode, cf.PhoneNumber,cf.Email, rt.RelationType
from AddressInfo af join ABookTable n on  af.FirstName= n.FirstName
join ContactInfo cf on cf.FirstName=af.FirstName
join RelationTable rt on af.FirstName=rt.FirstName;


 

