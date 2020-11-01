use ABook;

select COUNT(City), City, State from ABookTable
group by State, City;