/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/weather-observation-station-2
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT round(sum(lat_n),2),round(sum(long_w),2) from station