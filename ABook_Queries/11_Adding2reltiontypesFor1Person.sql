use ABook;

insert into AbookTable values 
('Shriya','Basak','Newtown','Kolkata','WB','711006','9672379893','shriyab@gmail.com');

insert into RelationTable(FirstName,RelationType) values
('Prudhvi','Family');


 select * from ABookTable a inner join RelationTable r 
 on (a.FirstName = r.FirstName) order by a.FirstName;