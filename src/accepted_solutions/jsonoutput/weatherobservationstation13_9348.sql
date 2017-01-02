/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/weather-observation-station-13
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT round(sum(lat_n),4) from station where lat_n>38.788 AND lat_n<137.2345