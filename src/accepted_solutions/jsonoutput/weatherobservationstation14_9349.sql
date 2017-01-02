/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/weather-observation-station-14
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT round(MAX(lat_n),4) FROM STATION where lat_n<137.2345