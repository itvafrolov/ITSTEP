<?php
//$_GET
//$_POST
//$_SERVER

// echo '<pre>';
// print_r($_FILES);
// echo '</pre>';

if (!empty($_FILES)){
    move_uploaded_file(
        $_FILES['my_file']['tmp_name'], 
        'uploads/'.
        $_FILES['my_file']
        ['tmp_name']
    );
}


// if(!empty($_FILES)){
//     move_uploaded_file($_FILES['my_file']['tmp_name'],'uploads/'.$_FILES['my_file']['name']);
//     move_uploaded_file($_FILES['my_file']['tmp_name'],'uploads/'.$_FILES['my_file']['name']);
// }

echo '<pre>';
print_r($_FILES['my_file']['tmp_name']);
echo '</pre>';

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Загрузка файлов на сервер</title>
</head>
<body>
    <h1>Загрузка файлов на сервер</h1>    
    <form action="" method="POST" enctype="multipart/form-data">     
    <p>
        <label for="my_file">Файл:</label>
        <input type="file" name="my_file" id="my_file">
    </p>
    <button type="submit">Отправить</button>    
    </form>
</body>
</html>