/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-data-types
this code may need to run in the hackerrank online ide to work correctly
*****************************/


// Read and save an integer, double, and String to your variables.
$i2 = fscanf($handle,"%i")[0];
$d2 = fscanf($handle,"%f")[0];
$s2 = fgets($handle);


// Print the sum of both integer variables on a new line.
print $i+$i2;
print "\
";
// Print the sum of the double variables on a new line.
printf("%0.1f",($d+$d2));
print "\
";
// Concatenate and print the String variables on a new line
// The 's' variable above should be printed first.
print $s.$s2;