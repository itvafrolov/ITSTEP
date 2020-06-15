<?php
//echo "!!!!!";
session_start(); //создается хранилище на сервере ей выделяется уникальный ключ и создается файл с уникальным ключем

$_SESSION['name'] = 'Viacheslav';
$_SESSION['login'] = 'admin';

unset($_SESSION['login']);

session_unset();  // удаляет все данные из сессии


echo $_SESSION['login'];
echo "<br>";
echo session_id();


//удаление файла сессии
session_destroy();
/*
echo "<br>";
print_r ($_SESSION);
*/
?>
<a href="test.php"><br>Тест</a>