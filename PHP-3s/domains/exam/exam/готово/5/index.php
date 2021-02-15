<?php

// Соединяемся
$db = mysqli_connect('127.0.0.1', root, '', 'exam_db') or die('Ошибка соединения с БД!!!');
mysqli_set_charset($db, 'utf8') or die('Не установлена кодировка!');

$sql_select = "select `element`, `link` from menu";
$res = mysqli_query($db, $sql_select) or die('Error!');
$data = mysqli_fetch_all($res);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>GISAPR</title>
    <style>
        .header {
    /* background-image: url(../img/header.jpg); */
    background-size: cover;
}
.site-title {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 70px;
}
.site-title > h1 {
    color: #eee;
    font-size: 4rem;
    text-shadow: 0 0 5px #000;
}
.menu {
    display: flex;
    justify-content: flex-start;
    background-color: #00000080;
}
.menu-element {
    color: #fff;
    text-transform: uppercase;
    text-decoration: none;
    font-size: 2rem;
    padding: 1rem 2rem;
    margin-right: 2.5rem;
}
.menu-element:hover {
    background-color: #000000a0;
}
.content-container {
    display: flex;
    justify-content: flex-start;
}
.v-menu{
    font-size: 2rem;    
}
.sidebar {
    width: 20%;
    padding: 5em;
    
}
.sidebar > h2 {
    margin-bottom: 1em;
    color: #646886;
}
.sidebar > ul {
    font-size: 1.5em;
    padding-left: 1rem;    
}
.content-page{        
    color: #eee;
    font-size: 2rem;
    text-shadow: 0 0 5px #000;
    background-color: #eee;
    padding: 5rem 36rem 30rem 10rem;

    display: flex;
    justify-content: center;
    width: 100%; 
}

    </style>
</head>
<body>
<div class="header">
    <div class="site-title">
            <h1>GISAPR company</h1>
    </div>    
    <div class="menu">
            <?php
                foreach($data as $item)
                {    
                    echo "<a class="."menu-element"." href=".$item[1].">".$item[0]."</a></li>";
                }               
            ?> 
    </div>       
</div>
<div class="content-container">
        <div class="sidebar">
            <h2>BЫБЕРИТЕ:</h2>
            <ul>
                <?php
                foreach($data as $item)
                {    
                     echo "<li><a href=".$item[1].">".$item[0]."</a></li>";        
                }
                ?>    
            </ul>
        </div>  
        <div class="content-page">
            <h1>TEST PAGE <br> OF GISAPR company</h1>
         </div>        
</div>
</body>
</html>
