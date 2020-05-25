<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <p>Пример альтернативного массива</p>
    <?php
    $goods = [
  [
    'title' => 'Nokia',
    'price' => 100,
    'description' => 'Description'
  ],
  [
    'title' => 'iPad',
    'price' => 200,
    'description' => 'Description'
  ]
];
?>
<?php
echo "<table border='1'>";
foreach($goods as $item)
{
    echo "<tr>";
    foreach($item as $k=>$v)
    {
        echo "<td>";
        echo "$v";
        echo "</td>";
    }
    echo "</tr>";
}
echo "</table>";
?>

<hr>
<table border="1">
<?php foreach($goods as $item): ?>
    <tr>
    <?php foreach($item as $k=>$v): ?>
        <td>
        <?=$v?>
        </td>
    <?php endforeach ?>
    </tr>
    <?php endforeach ?>
</table>
<hr>
<table border="1">
<?php for($i=1; $i<10; $i++ ):?>
        <tr>
            <?php for($j =1; $j<10; $j++):?>
                <td>
                    <?=$i*$j?> 
                </td>
            <? endfor?>
        </tr>
    <? endfor?>
</table>
<hr>
<?php
    $bool = 1;
    $str1 = '1111';
    $str2 = '2222';
    $str3 = '3333';
?>
<?php if($bool):?>
<table class="table" border="1" >

        <tr>          
            <td><?=$str1?></td>
            <td><?=$str2?></td>
            <!-- можно другой стиль записи -->
            <td><?php echo $str3?></td> 
        </tr>    
</table>
<?php endif ?>


</body>
</html>