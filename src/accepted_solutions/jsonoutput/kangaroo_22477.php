/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/kangaroo
this code may need to run in the hackerrank online ide to work correctly
*****************************/
<?php

$handle = fopen ("php://stdin","r");
fscanf($handle,"%d %d %d %d",$x1,$v1,$x2,$v2);

$val1=$x1;
$val2=$x2;

$currenthighVal1=true;

if($val1==$val2){
    echo "YES";
    exit();
}
else if($val2>$val1){
    $currenthighVal1=false;
}

if($currenthighVal1){
    if($v1>=$v2){
        echo("NO");
        exit();
    }
}
else{
    if($v2>=$v1){
        echo("NO");
        exit();
    }
}

$currentHighNotSwitched=true;


for($i=0;$i<10000;$i++){   
    $val1+=$v1;
    $val2+=$v2;
    
    if($val1==$val2){
        echo"YES";
        exit();
    }
    
    if($val>$val2!=$currenthighVal1){
        echo("NO");
        exit();
    }

}
echo("NO");
exit(); 
    
?>
