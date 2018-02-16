CREATE PROCEDURE searchpr
@speciality varchar(10)
AS
SELECT DoctorID,DoctorName
FROM Doctor
WHERE Speciality=@speciality

Execute searchpr @speciality=Eyes
