<?php
// Соединяемся
$db = mysqli_connect('127.0.0.1', root, '', 'hw04_db') or die('Ошибка соединения с БД!!!');
mysqli_set_charset($db, 'utf8') or die('Не установлена кодировка!');

/* PRODUCTS */

$sql_select = "select * from products";
$res = mysqli_query($db, $sql_select) or die('Error!');

$data = mysqli_fetch_all($res);
echo "Table products:";
echo "<table>";
echo "<table border='1'>";
echo "<td>id</td><td>id_brand</td><td>id_type_product</td><td>model</td><td>price</td><td>old_price</td><td>status</td><td>keywords</td><td>description</td><td>id_category</td><td>about</td><td>img</td><td>hit</td><td>created_at</td><td>updated_at </td><td>deleted_at</td>";

foreach($data as $arr)
{    
    echo "<tr>";        
      foreach($arr as $item)
        {
        echo "<td>";
        echo "$item";
        echo "</td>";    
        }
    echo "</tr>";
}
echo "</table>";

/* BRANDS */
echo "Table brand:";
$sql_select = "select * from brand";
$res = mysqli_query($db, $sql_select) or die('Error!');
$data = mysqli_fetch_all($res);
echo "<table>";
echo "<table border='1'>";
echo "<td>id</td><td>title</td><td>img</td><td>description</td>";
foreach($data as $arr)
{    
    echo "<tr>";        
      foreach($arr as $item)
        {
        echo "<td>";
        echo "$item";
        echo "</td>";    
        }
    echo "</tr>";
}
echo "</table>";

/* categories */
echo "Table categories:";
$sql_select = "select * from categories";
$res = mysqli_query($db, $sql_select) or die('Error!');
$data = mysqli_fetch_all($res);
echo "<table>";
echo "<table border='1'>";
echo "<td>id</td><td>title</td><td>keywords</td><td>description</td><td>created_at</td><td>updated_at</td><td>deleted_at</td>";
foreach($data as $arr)
{    
    echo "<tr>";        
      foreach($arr as $item)
        {
        echo "<td>";
        echo "$item";
        echo "</td>";    
        }
    echo "</tr>";
}
echo "</table>";

/* BRANDS */
echo "Table type_products:";
$sql_select = "select * from type_products";
$res = mysqli_query($db, $sql_select) or die('Error!');
$data = mysqli_fetch_all($res);
echo "<table>";
echo "<table border='1'>";
echo "<td>id</td><td>title</td><td>img</td><td>description</td>";
foreach($data as $arr)
{    
    echo "<tr>";        
      foreach($arr as $item)
        {
        echo "<td>";
        echo "$item";
        echo "</td>";    
        }
    echo "</tr>";
}
echo "</table>";

?>