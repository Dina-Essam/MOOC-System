USE [MOOC]
GO
/****** Object:  StoredProcedure [dbo].[dina]    Script Date: 12/22/2016 1:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[dina]
@user_id int 
as
select Name
from Course inner join CourseStudent
on Course.Course_ID=CourseStudent.Course_SID
where Student_ID=@user_id
