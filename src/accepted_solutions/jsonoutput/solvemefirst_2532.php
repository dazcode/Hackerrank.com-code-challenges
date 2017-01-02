/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/solve-me-first
this code may need to run in the hackerrank online ide to work correctly
*****************************/
<?php
function solveMeFirst($a,$b){
  return $a+$b;
}
$handle = fopen ("php://stdin","r");
$_a = fgets($handle);
$_b = fgets($handle);
$sum = solveMeFirst((int)$_a,(int)$_b);
print ($sum);
fclose($handle);
?>
