-- group by deptno
SELECT DEPTNO,COUNT(*)
FROM EMP
GROUP BY DEPTNO

-- group by job
SELECT JOB,COUNT(*)
FROM EMP
GROUP BY JOB


-- deptwise,jobwise no of employee
SELECT DEPTNO,JOB,COUNT(*)
FROM EMP
GROUP BY DEPTNO,JOB 


--display employee with thier department name
SELECT ENAME,DEPTNO
FROM EMP

--
SELECT DEPT.DNAME,EMP.ENAME
FROM EMP
JOIN DEPT
ON EMP.DEPTNO = DEPT.DEPTNO

--ALL dept with employee if any
SELECT DEPT.DEPTNO,DEPT.DNAME,EMP.ENAME
FROM DEPT
LEFT OUTER JOIN EMP
ON EMP.DEPTNO = DEPT.DEPTNO

--all dept which does not have an employee
SELECT DEPT.DEPTNO,DEPT.DNAME,EMP.ENAME
FROM DEPT
LEFT OUTER JOIN EMP
ON EMP.DEPTNO = DEPT.DEPTNO
WHERE EMP.ENAME is NULL

--ALL employee name and thier boss name
SELECT x.ENAME as EMPLOYEE,y.ENAME as BOSS
FROM EMP as x
LEFT OUTER JOIN EMP as y
ON x.MGR = y.EMPNO

--all employeee name ,department name , manager name;
SELECT DEPT.DNAME,x.ENAME as EMPLOYEE,y.ENAME as BOSS
FROM EMP x
JOIN DEPT
ON x.DEPTNO = DEPT.DEPTNO 
LEFT OUTER JOIN EMP y
ON x.MGR = y.EMPNO

--dept wisse job wise sum of salary of emp sum of salary greater than 2000
--and display in order of sum of salary
SELECT DEPTNO,JOB,COUNT(*) as NoOfEMP,SUM(SAL) as SOS
FROM EMP
GROUP BY DEPTNO,JOB 
having SUM(SAL)>2000 
ORDER BY SUM(SAL) ASC



SELECT * FROM EMP

SELECT * FROM DEPT