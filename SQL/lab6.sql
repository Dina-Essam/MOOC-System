create table VideoCategory (CatID int Primary Key , CatName nvarchar(50));
insert into Videos values ('spoungpop' ,'3-4-2005',80,6 );

select * 
From Videos inner join VideoCategory on
Vid_Cat_ID=CatID
where VideoCategory.CatName='Animation';

select * from Videos
order by FilmDuration Desc;


