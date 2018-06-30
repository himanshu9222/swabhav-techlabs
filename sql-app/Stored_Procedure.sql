CREATE PROCEDURE SelectAllEmployee
AS
SELECT * FROM EMP
WHERE JOB='SALESMAN'
--GO;

EXEC SelectAllEmployee

use AurionPro

use AurionPro

SELECT * FROM EMP

--WithOut ERROR
CREATE  PROCEDURE usp_giveHike(@id int,@percentage decimal(3,2))
  AS
 BEGIN
 UPDATE    Emp
	SET       SAL = (SAL) * @percentage + SAL
	WHERE EMPNO = @id
 END;	
 
 --With ERROR
 CREATE  PROCEDURE usp_giveHike(@id int,@percentage decimal(3,2))
  AS
  IF EXISTS (SELECT EMPNO FROM EMP WHERE EMPNO = @id)
 BEGIN
 UPDATE    Emp
	SET       SAL = (SAL) * @percentage + SAL
	WHERE EMPNO = @id
 END;
	else
	RAISERROR (15600,-1,-1, 'usp_giveHike');
 
 
 
 EXEC usp_giveHike 7369, 0.30;