use Abook;
select * from ABookTable;

alter table ABookTable
drop column RelationType;

create table RelationTable
(
	FirstName varchar(25) not null,
	LastName varchar(25) not null,
	RelationType varchar(20) not null
);

insert into ABookTable values
 ('Shriya','Basak','Newtown','Kolkata','WB','711006','9672379893','shriyab@gmail.com'),
  ('Prateek','Shukla','LajpatNagar','Lucknow','UP','490234','9674567890','miket@gmail.com'),
   ('Kaushal','Kumar','Bisra','Patna','BH','211906','8362478920','kaushalk@gmail.com');

insert into RelationTable(FirstName,RelationType)
 values ('Mohanee','Self'),
 ('Prudhvi','Friend'),
  ('Ankita','Family'),
   ('Chinmayi','Friend'),
    ('Saras','Family'),
 ('Rajat','Family'),
 ('Shriya','Professional'),
 ('Prateek','Professional'),
 ('Kaushal','Professional')
 ;

 select * from RelationTable;

 select * from ABookTable a inner join RelationTable r 
 on (a.FirstName = r.FirstName);
