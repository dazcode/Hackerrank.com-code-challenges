/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/weather-observation-station-3
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT CITY FROM STATION WHERE ID%2=0 GROUP BY CITY