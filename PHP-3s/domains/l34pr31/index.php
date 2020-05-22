<?php
error_reporting(-1); // выводит информацию обо всех ошибках и не фатальных в том числе
$arr = array('Ivanov','Petrov','Sidorov','Frolov');
echo $arr;
echo "<br>";
var_dump($arr);
echo "<br>-------------------<br>";
echo "<pre>";
print_r($arr);
echo "</pre>";
echo "<br>-------------------<br>";
echo $arr[3];
echo "<br>-------------------<br>";
echo $arr{3};
echo "<br>-------------------<br>";
$arr2 = [1,2,3,4,5,6,7, 'Frolov', 898.78, ['banana', 'apple', 'orange']];
echo "<pre>";
print_r($arr2);
echo "</pre>";
echo "<br>-------------------<br>";
echo $arr2[9];

echo "<br>---------------<br>";
$arr3 = [
    2 =>'Ivanov',
    4 => 'Petrov',
    10 =>'Sidorov',
    'Pupkin'
];
$arr3[]='Pupkin2';
$arr3[100]='Pupkin333';
echo "<pre>";
print_r($arr3);
echo "</pre>";
//ассоциативный массив
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
  
  echo "<pre>";
  print_r($goods);
  echo "</pre>";
  echo "<br>---------------<br>";

echo $goods[1]['title'];
echo "<br>---------------<br>";
$arr4 = array(0 =>'Ivanov',1=>'Petrov',2=>'Sidorov','man'=>'Frolov2');
echo "<br>-------------   ------  --<br>";
echo "<br>---------------<br>";
echo $arr4[0];

//цыкл
echo "<br>---------------<br>";
foreach($arr4 as $item)
{
    echo $item."<br>";
}
echo "<br>---------------<br>";
foreach($arr4 as $key => $value)
{
    echo "$key : $value<br>";
    
}

echo "<br>---------------<br>";
echo "<br>---------------<br>";
echo "<br>---------------<br>";
foreach($goods as $item)
{
foreach($item as $key => $value)
{
    echo "$key : $value<br>";    
}
echo "<br>---------------<br>";
}


?>