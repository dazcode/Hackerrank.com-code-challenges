/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/weather-observation-station-7
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT DISTINCT CITY FROM STATION WHERE SUBSTRING(CITY,LENGTH(CITY),1) IN ('a','e','i','o','u')