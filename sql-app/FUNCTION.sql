CREATE function GetSalaryTop3()
RETURNS @SALARY3 TABLE
(
[EMPID] int,
[EMPNAME] varchar,
[SAL] int,
[COMM] int,
[CTC] int
)
AS
BEGIN
Insert into @SALARY3
	SELECT EMPNO, ENAME, SAL, COMM, (SAL* 12) + (ISNULL(COMM, 0 ) *12) AS CTC 
	FROM EMP
RETURN
END
GO


CREATE FUNCTION GetEmployee(@sal money)
returns table 
as
return 
	SELECT * FROM EMP WHERE sal>=@sal
	
SELECT * FROM GetEmployee(2000)

use AurionPro
	

CREATE FUNCTION dbo.getCurrentDate () RETURNS varchar(8)
BEGIN
DECLARE @currentdatetime varchar(8)
SET @currentdatetime = CONVERT(VARCHAR(8), GETDATE(), 112);--GETDATE()
RETURN @currentdatetime
END
go

SELECT dbo.getCurrentDate() As CurrentDatetime