/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/staircase
this code may need to run in the hackerrank online ide to work correctly
*****************************/
<?php

$handle = fopen ("php://stdin","r");
fscanf($handle,"%d",$n);


function printCharTimes($theChar,$times){
    for($i=0;$i<$times;$i++){
        print $theChar;
    }
}
for($x=1;$x<=$n;$x++){
    printCharTimes(" ",($n-$x));
    printCharTimes("#",$x);
    print "\
";
}
?>
