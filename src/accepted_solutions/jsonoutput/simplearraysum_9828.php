/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/simple-array-sum
this code may need to run in the hackerrank online ide to work correctly
*****************************/
<?php

$handle = fopen ("php://stdin","r");
fscanf($handle,"%d",$n);
$arr_temp = fgets($handle);
$arr = explode(" ",$arr_temp);
array_walk($arr,'intval');

$sum = 0;
foreach($arr as $key => $value){
    $sum+=$value;
}
echo($sum);

?>
