<?php
require_once 'func_lib.php';
const FILE_GB = 'gb.txt';

if (!empty($_POST))
{
    save_data();
    header("Location: {$_SERVER['PHP_SELF']}");
    exit;
}

$messages = get_data();

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Гостевая книга</title>
    <style>
    .messages{
        border: 1px solid #ccc;
        padding: 10px;
        margin-bottom: 20px;
    }
    </style>
</head>
<body>
    <h1>Гостевая книга</h1>
    <form action="<?=$_SERVER['PHP_SELF']?>" method="post">
        <p>
            <label for="name">Имя:</label>
            <input type="text" name="name" id="name">
        </p>
        <p>
            <label for="text">Текст:</label>
            <textarea name="text" id="text"></textarea>
        </p>
        <button type="submit">Написать</button>
    </form>
    <hr>
    <?php 
        //echo $messages;
        $messages = get_arr_data($messages);
        /* echo "<pre>";
        print_r($messages);
        echo "</pre>"; */
    ?>
    <?php if (!empty($messages)): ?>
        <?php foreach($messages as $item): ?>
        <div class="messages">
                <?php
                    $m = get_format_message($item);
                 ?>
                 <p>Автор: <?=$m[0]?> |  Дата: <?=$m[2]?> </p>
                 <div>
                    <?=nl2br(htmlspecialchars($m[1])) ?>
                 </div>
        </div>
        <?php endforeach ?>
    <?php endif ?>
</body>
</html>