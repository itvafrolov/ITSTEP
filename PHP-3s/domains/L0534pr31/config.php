<?php
define("HOST", "localhost");
define("USER", "root");
define("PASSWORD", "");
define("DB", "l05_34pr31");


$db = mysqli_connect(HOST,USER,PASSWORD);
if (!$db) {
  exit('WRONG CONNECTION');
}
if(!mysqli_select_db($db, DB)) {
  exit(DB);
}
//mysqli_query('SET NAMES utf8');
mysqli_set_charset($db, "utf8") or die('Не установлена кодировка!');
?>