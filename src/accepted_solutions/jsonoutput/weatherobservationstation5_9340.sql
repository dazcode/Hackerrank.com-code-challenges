/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/weather-observation-station-5
this code may need to run in the hackerrank online ide to work correctly
*****************************/
SELECT city,length(city) FROM station ORDER BY length(city) asc limit 1;
SELECT city,length(city) FROM station ORDER BY length(city) desc limit 1