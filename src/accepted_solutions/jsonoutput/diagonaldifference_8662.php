/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/diagonal-difference
this code may need to run in the hackerrank online ide to work correctly
*****************************/
<?php

$handle = fopen ("php://stdin","r");
fscanf($handle,"%d",$n);
$a = array();

$count1=0;
$count2=0;

for($a_i = 0; $a_i < $n; $a_i++) {
    $a_temp = fgets($handle);
    $a[] = explode(" ",$a_temp);
    array_walk($a[$a_i],'intval');

    $count1+=$a[$a_i][$a_i];
    $count2+=$a[$a_i][(($n-1)-$a_i)];
    
}
echo abs($count1-$count2);

?>
