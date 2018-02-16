create proc fefe
@eo_id int 
as 
select First_name
from Tutor inner join Course
on Tutor.T_ID=Course.T_ID
where Eo_ID=@eo_id


