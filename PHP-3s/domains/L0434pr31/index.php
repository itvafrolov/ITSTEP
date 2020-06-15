<?php
//mysql - устарела
//mysqli
//PDO
//echo mysqli_connect_error;

// $db = mysqli_connect('127.0.0.1', root, '', 'l04_34pr31');
// echo mysqli_connect_error();

$db = mysqli_connect('127.0.0.1', root, '', 'l04_34pr31') or die('Ошибка соединения с БД!!!');
mysqli_set_charset($db, 'utf8') or die('Не установлена кодировка!');

$sql_ins = "insert into products (manufacturer, name, price) 
values ('Samsung', 'Notebook', 40000)";

// $res = mysqli_query($db, $sql_ins);

$sql_upg = "update products set price = 50000 where id = 6";

//$res = mysqli_query($db, $sql_upg);

$sql_del = "delete from products where id = 6";
// $res = mysqli_query($db, $sql_del);
/*
if($res)
    echo "Good!!!";
else 
{
    echo "Error!";
    echo mysqli_error($db);
}
*/

$sql_select = "select * from products order by price desc";
$res = mysqli_query($db, $sql_select) or die('Error!');
echo mysqli_num_rows($res)."<br>" ;

// $data = mysqli_fetch_all($res);

// $data = mysqli_fetch_all($res, MYSQLI_ASSOC);

// $data = mysqli_fetch_all($res, MYSQLI_NUM);

$data = mysqli_fetch_all($res, MYSQLI_BOTH);

echo "<pre>";
print_r($data);
echo "</pre>";
?>