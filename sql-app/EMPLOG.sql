CREATE TABLE EMPLOG (
 EMPNO               integer NOT NULL,
 ENAME               varchar(10),
 JOB                 varchar(9),
 MGR                 integer ,
 HIREDATE            DATEtime,
 OldSal				 money,
 SAL                 money,
 COMM                money,
 DEPTNO              integer NOT NULL,
 CHANGEDATE			DATETime NOT NULL,
 DESCRIPTIONS       varchar(50)
 );
 
 DROP TABLE EMPLOG
 
 DROP TRIGGER Emp_PutDetailsAtChangeIn_Log
 
 CREATE TRIGGER Emp_PutDetailsAtChangeIn_Log
  ON EMP 
  AFTER UPDATE
  AS
	DECLARE @id integer
	DECLARE @name VARCHAR(10)
	DECLARE @job VARCHAR(9)
	DECLARE @mgr integer
	DECLARE @hiredate DATEtime
	DECLARE @sal money
	DECLARE @comm money
	DECLARE @deptno integer
	DECLARE @salOld money
	BEGIN
		SELECT @salOld = SAL FROM deleted
		SELECT @id = EMPNO,@name = ENAME, @job = JOB,@mgr=MGR,@hiredate = HIREDATE,@sal = SAL,@comm = COMM,@deptno = DEPTNO FROM inserted
		INSERT INTO EMPLOG VALUES (@id,@name,@job,@mgr,@hiredate,@salOld,@sal,@comm,@deptno,GETDATE(),'SALARY Changed From '+CAST(@salOld as varchar(20))+'  to '+CAST(@sal as varchar(20)));	
	END;
	
SELECT * FROM EMPLOG

UPDATE EMP
SET SAL = 2000
WHERE EMPNO = 7369