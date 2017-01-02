/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/weather-observation-station-9
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT DISTINCT city FROM station WHERE SUBSTRING(city,1,1) NOT IN ('a','e','i','o','u')