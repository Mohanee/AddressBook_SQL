use ABook;

select Count(FirstName) as No_of_Contacts,RelationType from ABookTable group by RelationType;