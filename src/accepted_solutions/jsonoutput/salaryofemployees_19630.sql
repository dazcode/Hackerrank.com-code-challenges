/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/salary-of-employees
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT name from employee WHERE salary >2000 and months<10 order by employee_id asc