create proc mepo
@course_name nvarchar(20)
as

select Course.Name
from   Field_Course inner join Course 
    on Field_Course.F_ID=Course.F_ID

inner join Tutor on Course.T_ID=Tutor.T_ID inner join Educational_organization on Course.Eo_ID=Educational_organization.Eo_ID
where Field_Course.Name=@course_name
or
Educational_organization.Name=@course_name
or
Tutor.First_name=@course_name


