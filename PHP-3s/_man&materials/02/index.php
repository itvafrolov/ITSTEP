<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Получение данных от пользователя</title>
</head>
<body>
    <p>Получение данных от пользователя</p>
    <form action="action.php" method="post"> 
    <p>
        <input type="text" name = "my_name">
    </p>
    <p>
        <textarea name ="my_text"></textarea>
    </p>
    <p>
        <input type="checkbox" name = "remember">
    </p>
    <p>
    <!-- <select name="lang[]" multiple="">
        <option value="eng">English</option>
        <option value="ru">Russian</option>
        <option value="jp">Japan</option>
      </select> -->
        <select name="lang">
        <option value="eng">English</option>
        <option value="ru">Russian</option>
        <option value="jp">Japan</option>
      </select>

    </p>
    <button type="submit" name='btn_send1' value="btn1_test">Oтправить</button>
    </form>
    <hr>    
        <a href="index.php?t=GGGGG&user=admin&age=100">Кликни меня!!!</a>
     <hr>    
     <?php
    if(!empty($_GET)){
        echo "<pre>";
        print_r($_GET);
        echo "<pre>";   
    }
    ?>

<hr>
<form action="action.php" method="post"> 
    <p>
        <input type="text" name = "my_name">
    </p>
    <p>
        <textarea name ="my_text"></textarea>
    </p>
    <p>
        <input type="checkbox" name = "remember">
    </p>
    <p>
    <!-- <select name="lang[]" multiple="">
        <option value="eng">English</option>
        <option value="ru">Russian</option>
        <option value="jp">Japan</option>
      </select> -->
        <select name="lang">
        <option value="eng">English</option>
        <option value="ru">Russian</option>
        <option value="jp">Japan</option>
      </select>

    </p>
    <button type="submit" name='btn_send2' value="btn2_test">Oтправить</button>
    </form>
<hr>

</body>
</html>