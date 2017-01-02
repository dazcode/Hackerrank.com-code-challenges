/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/angry-professor
this code may need to run in the hackerrank online ide to work correctly
*****************************/
<?php

$handle = fopen ("php://stdin","r");
fscanf($handle,"%d",$t);

for($a0 = 0; $a0 < $t; $a0++){
    fscanf($handle,"%d %d",$n,$k);
    $a_temp = fgets($handle);
    $a = explode(" ",$a_temp);
    array_walk($a,'intval');

    $isCanceled = checkIfCanceled($n,$k,$a);
    if($isCanceled){
        print "YES\
";
    }
    else{
        print "NO\
";
    }
}


function checkIfCanceled($numberStudents,$cLimit,$inputData){

    $tardy=0;
    $onTime=0;
    for($i=0;$i<count($inputData);$i++){
        //echo("inputdata: ".$inputData[$i]. "\
");
        if($inputData[$i]<=0){
            $onTime++;
        }
        else{
            $tardy++;
        }
    }

    //echo("tardy: ".$tardy);
    //echo(" climit: ". $cLimit);
    if($onTime>=$cLimit)
    {
        return false;
    }
    else{
        return true;
    }

}


?>