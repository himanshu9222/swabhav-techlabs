SELECT Student.sname, Student.stno
    FROM   Student
    WHERE  "link to Grade_report"
       IN  ("link to Student" - subquery involving Grade_report)
       
SELECT Student.sname, Student.stno
    FROM   Student
    WHERE  Student.stno
      IN (SELECT   gr.student_number
          FROM     Grade_report gr
          WHERE    gr.grade = 'B' OR  gr.grade = 'A')
    ORDER BY Student.stno
    
SELECT  Student.sname, Student.stno
    FROM    Student, Grade_report gr
    WHERE   Student.stno = gr.student_number
    AND        (gr.grade = 'B' OR gr.grade = 'A')
    
SELECT DISTINCT Student.sname, Student.stno
    FROM    Student, Grade_report AS gr
    WHERE   Student.stno = gr.student_number
    AND       (gr.grade = 'B' OR gr.grade = 'A')
    
SELECT Student.sname, Student.stno
    FROM   Student
    WHERE  Student.stno
      IN (SELECT   gr.student_number
          FROM     Grade_report gr
          WHERE    gr.grade = 'B' OR  gr.grade = 'A')
    ORDER BY Student.stno
    
SELECT DISTINCT Student.sname, gr.grade
    FROM   Student, Grade_report gr
    WHERE  Student.stno = gr.student_number
    AND       (gr.grade = 'B' OR gr.grade = 'A')
    
