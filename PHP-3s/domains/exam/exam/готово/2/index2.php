<?php
/*
2. Вывести степени чисел от 1 до N, где N - целое число, которое нужно передать
методом GET. Результаты вывести на страницу

*/

if(!empty($_GET)){
    print_r($_GET);
    $a=$_GET[a];    
    $btn = $_GET[btn];
 }


?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<h3>Выводит число "а" в степенях от 1 до "а"<br> НЕ ВВОДИТЕ БОЛЬШОЕ ЧИСЛО! </h3>
<form action="" method="get">
        <div class="all">
            <div class="element">
            <p>a= 
                <input type="text" name = "a" value=<?=$a?>> 
                </p>           
                <p>
                 <button class="button" type="submit" name='btn' value="btn"> РАСЧИТАТЬ! </button>
                </p>
            </div>           
            <div class="result">            
                <p>                     
                    <?php 
                   if ($btn == "btn" && $a>0) 
                   
                    {
                    for($i = 0; $i<=$a; $i++)
                    {
                    echo $a."^".$i.": "; 
                    echo pow($a, $i);
                    echo "<br>";
                    }
                }
                    ?>
                </p>
            </div>
        </div>
    </form>
</body>
</html>