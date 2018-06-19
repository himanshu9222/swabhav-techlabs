CREATE TABLE Employee(name VARCHAR(20),
					address VARCHAR(20),
					employee_no INT,
					salary SMALLMONEY)
					
CREATE TABLE Names
   (fullname VARCHAR(20));

INSERT INTO Names
VALUES ('Himanshu Lal');
					
SELECT * from Names;

INSERT INTO Employee VALUES ('Himanshu Lal', 'Nallasopara', 1, 2500);

SELECT * from Employee;

INSERT INTO Employee (name, address)
VALUES ('Anshu', 'Nallasopara');

INSERT INTO Employee (salary, name, employee_no, address)
VALUES (40000, 'Parth', 10, 'Vasai');

SELECT * from Employee;

INSERT INTO Employee
VALUES ('Joe Smith', null, 101, null);

INSERT INTO Names(fullname)
  SELECT  name
  FROM    Employee;

SELECT * from Names;

INSERT INTO Names(fullname)
  SELECT name
  FROM   Employee
  WHERE  salary > 2600;
  
  CREATE TABLE Emp1(
					address VARCHAR(20),
					employee_no INT,
					salary SMALLMONEY)
					
INSERT into Emp1(address,employee_no,salary)
SELECT address,employee_no,salary from Employee;

SELECT * from Emp1;

  CREATE TABLE Emp2(
					address VARCHAR(20),
					employee_no INT,
					salary SMALLMONEY);
					
INSERT into Emp2(address,employee_no,salary)
SELECT * from Emp1;

SELECT * from Emp2;

UPDATE Emp2
SET salary = 0;

UPDATE Employee
SET    salary = 0
WHERE  employee_no=1;

SELECT * FROM Employee;

ALTER TABLE Employee
ADD bonus SMALLMONEY;

ALTER TABLE Employee
ALTER COLUMN bonus FLOAT;

ALTER TABLE 
 Employee
ALTER COLUMN name VARCHAR(19);

ALTER TABLE Employee
DROP column bonus;

DELETE FROM Employee
WHERE salary < 1500;

SELECT * FROM Employee;

DROP TABLE Names;


