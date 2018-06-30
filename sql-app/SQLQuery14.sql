SELECT * from DEPT

SELECT * from EMP

-- Display all employee in ascending order of name
SELECT *
From EMP
Order By EMP.ENAME

-- Display all employee in dept 10
SELECT * 
From EMP 
Where DEPTNO =10

-- Display all employee whose commision is null
SELECT *
FROM EMP
Where COMM is null

-- Display all employee name starting with s
SELECT * 
From EMP
Where ENAME like 's%'


-- Display all employee where managers
SELECT * 
FROM EMP
Where JOB = 'MANAGER'

-- Display top 2 salary employee
SELECT TOP 2 *
FROM EMP
order by EMP.SAL desc 

-- Display all employee in small case
SELECT LOWER(ENAME)
From EMP

-- Display all employee details with cost to company ctc column
SELECT ENAME, SAL, COMM, (SAL* 12) + (ISNULL(COMM, 0 ) *12) AS CTC 
FROM EMP

-- Display all employee in dept 10 and 20
SELECT * 
FROM EMP
WHERE EMP.DEPTNO = 10 and EMP.DEPTNO = 20

--sum of salary of all employee
SELECT SUM(SAL)
FROM EMP

-- avg salary of all employee
SELECT AVG(SAL)
FROM EMP

--all empolyee employee in same department of 'smith'
SELECT *  
FROM EMP 
WHERE DEPTNO = (SELECT DEPTNO 
				FROM EMP 
				WHERE ENAME ='SMITH');


--employee having same salary of blake
SELECT *  
FROM EMP 
WHERE SAL = (SELECT SAL 
				FROM EMP 
				WHERE ENAME ='BLAKE');



