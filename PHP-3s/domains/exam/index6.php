<?php
$db = mysqli_connect('127.0.0.1', 'root', '', 'exam') or die('Ошибка соединения с БД!');

mysqli_set_charset($db, "utf8") or die('Не установлена кодировка!');

$res = mysqli_query($db, "SELECT * FROM birthday");

$data = mysqli_fetch_all($res, MYSQLI_ASSOC);
/* echo "<pre>";
print_r($data);
echo "</pre>";
*/

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <title>Document</title>
</head>
<body>
<table class="table">
  <thead>
    <tr>
      <th scope="col">Id</th>
      <th scope="col">Фамилия</th>
      <th scope="col">День рожденья</th>      
    </tr>
  </thead>
  <tbody>
  <?php foreach($data as $item): ?>
    <tr>      
      <td><?= $item['id'] ?></td>
      <td><?= $item['Family'] ?></td>
      <td><?= $item['Birthday'] ?></td>
    </tr>
  <?php endforeach; ?>
  </tbody>
</table>
</body>
</html>