<?php

$var1 = "Hello world!!!";
echo $var1;
echo "<br>"; // перевод каретки ... однако

$var2 = "Строка 2!!!";
echo $var2;
echo "<br>";

$fruit = 'apple';

$winnie_pooh = "Hello winnie!!! 2 {$fruit}s  ";
echo $winnie_pooh;
echo "<br>";

$str = "I\'m Winnie. I have 2 apples ."." I have 2 ". $fruit."s";
echo $str;
echo "<br>";
echo "<br>---------------------<br>";
var_dump($str);
echo "<br>---------------------<br>";
$str = 100;
var_dump($str);

echo "<br>---------------------<br>";
$str = 100.87;
var_dump($str);

echo "<br>---------------------<br>";
$str = true;
var_dump($str);

echo "<br>---------------------<br>";
print_r($str);

echo "<br>---------------------<br>";
$v1 = "111";
$v2 = '222';
$v3 = 333;
$r = $v1 + $v2 + $v3;
var_dump($r);

echo "<br>---------------------<br>";
$v1 = "d111";  // результат даст ошибку
$v2 = '222';
$v3 = 333;
$r = $v1 + $v2 + $v3;
var_dump($r);

echo "<br>---------------------<br>";
$r = $v1.$v2.$v3;  //конкатенация
var_dump($r);

echo "<br>---------------------<br>";
$v1 = null;
var_dump($v1);

echo "<br>---------------------<br>";
$v11100;
var_dump($v1);

echo "<br>---------------------<br>";
define('PAGE', "new page");  //константа
echo PAGE;
echo "<br>---------------------<br>";
const  PAGE2 = "new constant page2";  //еще раз константа
echo PAGE2;
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?php echo PAGE ?></title>    
</head>
<body>
    <h1><?php echo $winnie_pooh ?></h1>
    <p><?php echo $var2 ?></p>
    <p><?php echo $v3 ?></p>    
</body>
</html>

