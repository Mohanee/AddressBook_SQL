use ABook;

alter table ABookTable
add RelationType varchar(15);


update ABookTable set RelationType ='Self' where FirstName='Mohanee';
update ABookTable set RelationType ='Friends' where FirstName='Prudhvi';
update ABookTable set RelationType ='Brother' where FirstName='Rajat';
update ABookTable set RelationType ='Cousin' where FirstName='Saras';
update ABookTable set RelationType ='Cousin' where FirstName='Ankita';
update ABookTable set RelationType ='Friends' where FirstName='Chinmayi';

select * from ABookTable;