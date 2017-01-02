/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/the-pads
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT CONCAT(name,'(',SUBSTRING(occupation,1,1),')') FROM OCCUPATIONS ORDER BY name ASC;
SELECT CONCAT('There are total ',ANSWER.occupation_count,' ',ANSWER.loweroccupation,'s.')
              FROM 
              (SELECT COUNT(occupation) as occupation_count,
lower(occupation) as loweroccupation FROM OCCUPATIONS
GROUP BY occupation ORDER BY COUNT(OCCUPATION) ASC,
lower(occupation) ASC) AS ANSWER;
