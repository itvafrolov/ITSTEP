<?php
//echo "Hello";
setcookie('my_name', 'Viacheslav', time() + 60*60*24*7, '/');
setcookie('c1', 'Info1', time() + 60*60*24*7, '/');

echo "<br>Занятие 04 <br>";
echo "Меня зовут: ".$_COOKIE['my_name'];

echo "<br>";
echo "<pre>";
print_r($_COOKIE);
echo "</pre>";

?>
<a href="test.php">Тест</a>
<a href="del.php">Удаление куки</a> 
<a href="testcounter.php">Тест</a>