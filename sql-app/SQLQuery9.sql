select GETDATE();

select col1=100,col12=200;

select dname from dependent;

select dname,age from dependent order by age;

select dname,age from dependent order by sex;

select dname,age from dependent order by age desc;

select dname,age,sex from dependent order by sex,age desc;

select dname,age,sex from dependent order by sex desc,age desc;

select * from dependent where sex='m';

select dname,age from dependent where age<5 order by age;

select dname,age,sex from dependent where age<=5 and sex='f' ;

select dname,age,sex from dependent where age>20 or sex='f' ;

select dname,age,sex from dependent where age between 3 and 5;

select dname,age,sex from dependent where age not between 3 and 5;

select COUNT(*) from dependent;

select COUNT(age) from dependent;

select dname,age,sex from dependent where age is null;

set rowcount 10 select * from dependent;

set rowcount 0;

SELECT dname AS Dependent_name, age AS Dependent_age, sex AS Dependent_sex
FROM   Dependent
WHERE  age > 5;

SELECT dname AS "Dependent Name", age AS "Dependent Age", sex AS "Dependent Sex"
FROM   Dependent
WHERE  age > 5;

SELECT [Dependent Name] = dname, [Dependent Age] = age, [Dependent Sex] = sex
FROM   Dependent
WHERE  age > 5;

SELECT Name = dname, Age = age, Sex = sex
FROM   Dependent
WHERE  age > 5;

SELECT d.dname
FROM   Dependent d
WHERE  d.age > 5;

SELECT *
FROM   Dependent d
WHERE  d.age > 5;

SELECT *
FROM   Dependent
WHERE  Dependent.age > 5;

SELECT COUNT(class)
FROM Student
WHERE class IS NULL;



create synonym s1 for S5tudent;