/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/more-than-75-marks
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT name FROM STUDENTS WHERE marks>75
ORDER BY
SUBSTRING(name,LENGTH(name)-2,3),ID ASC