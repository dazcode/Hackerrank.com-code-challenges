/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/plus-minus
this code may need to run in the hackerrank online ide to work correctly
*****************************/
<?php

$handle = fopen ("php://stdin","r");
fscanf($handle,"%d",$n);
$arr_temp = fgets($handle);
$arr = explode(" ",$arr_temp);
array_walk($arr,'intval');

$positive="";
$zeroes="";
$negative="";
for($i=0;$i<count($arr);$i++){

    if($arr[$i]>0){
        $positive++;
    }
    else if($arr[$i]==0){
        $zeroes++;
    }
    else{
        $negative++;
    }
}

echo($positive/$n);
echo("\
");
echo($negative/$n);
echo("\
");
echo($zeroes/$n);

?>
