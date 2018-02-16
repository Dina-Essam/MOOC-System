create proc enrolled
@course_id int ,@usre_id int 
as
select Review
from Course inner join CourseStudent
on Course.Course_ID=CourseStudent.Course_SID
where Course_ID=@course_id
and
Student_ID=@usre_id

 
 execute courseid
 @course_name='c++'