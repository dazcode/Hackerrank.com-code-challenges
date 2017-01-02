/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/time-conversion
this code may need to run in the hackerrank online ide to work correctly
*****************************/
<?php

$handle = fopen ("php://stdin","r");
fscanf($handle,"%s",$time);

$timeArray = explode(":",$time);
$isAM=(substr($timeArray[2],2)=="AM")?true:false;
$timeHours= $timeArray[0];
$timeMinutes= $timeArray[1];
$timeSeconds=(substr($timeArray[2],0,2));


if($isAM){
    if($timeHours=="12"){
        $timeHours="00";
    }
}
else 
{
        if($timeHours=="12"){
            if($timeMinutes!="00" || $timeSeconds!="00"){
                
            }
            else{
                $timeHours+=12;
            }
        }
        else{
            $timeHours+=12;
        }
    
}
print $timeHours.":".$timeMinutes.":".$timeSeconds;

?>
