<?php include_once('lib2.php');?>
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
</head>
<body>
  <p>Подключение файлов</p>
  <?php require('lib1.php')?>
  <?php require_once('lib1.php')?>

  <?php include('lib1.php')?>
  <?php include_once('lib1.php')?>
  <!-- <?php include_once('lib2.php');?> -->
  <?php print_r($students);?>
  <?php 
  $a = 500;
  $b = 700;
   echo "<br>".my_func($a, $b);
   echo "<br> $a";
   echo "<br> $b";

   echo "<br>".my_func();
  ?>
</body>
</html>