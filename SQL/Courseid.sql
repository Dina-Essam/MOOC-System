 

	



create proc courseid
@course_name varchar(30)
as
select Course_id
from Course
where Name=@course_name
