<?php
// ******  Самостоятельная работа   
//- найти все нечетные числа от 0 до 20 
for($i = 0 ; $i < 20; $i++){
    if ($i %2 != 0){
        echo $i.",  ";
    }
}
echo "<hr>";

/*- найти все числа, которые делятся на 3*/   
for($i = 0 ; $i < 43; $i++){
    if ($i %3 == 0){
        echo $i.",  ";
    }
}
echo "<hr>";
/*- получить сумму: 1^1 + 2^2 + ... 10^10*/
$sum1 = 0;
for($i = 1 ; $i < 11; $i++){
    $sum1 += $i * $i;
    }
echo $sum1;
echo "<hr>";

/*- решить квадратные уровнения:  2x^2 – 5x + 3 = 0 10x^2 + 7x + 25 = 0
Если корни есть - вывести в табличном виде корни. 
Если корней нет - вывести сообщение корней нет без таблицы.   */
$a = 2;
$b = -5;
$c = 3;
$D=($b * $b) - (4 * $a * $c);
if ($D>0){
    $x1=($b* -1 + (sqrt($D)))/(2*$a);
    $x2=($b* -1 - (sqrt($D)))/(2*$a);  
    //echo $D."<br>";    
echo "<table border='1'><tr><td>x1</td><td>".$x1."</td></tr>";
echo "<tr><td>x2</td><td>".$x2."</td></tr></table>";
}
if ($D==0){
    $x3=($b* -1 + (sqrt($D)))/(2*$a);    
    //echo $D."<br>";    
echo "<table border='1'><tr><td>x1</td><td>".$x3."</td></tr></table>";
}
if ($D<0){
    $x3=($b* -1 + (sqrt($D)))/(2*$a);    
    //echo $D."<br>";    
echo "<p>Уравнение не имеет решения</p>";
}
///////// *** не нужный кусок кода
// if ($D==0){
//     $x1=($b* -1 + (sqrt($b * $b - 4 * $a * $c)))/(2*$a*$b);
//     $x2=($b* -1 - (sqrt($b * $b - 4 * $a * $c)))/(2*$a*$b);  
// echo "<table border='1'><tr><td>x1</td><td>".$x1."</td></tr></table>";
// echo "<table border='1'><tr><td>x2</td><td>".$x2."</td></tr></table>";
// }

// $a = 10;
// $b = 7;
// $c = 25;
// $D=$b * $b - 4 * $a * $c;
// if ($D>=0){
//     $x3=($b* -1 + (sqrt($b * $b - 4 * $a * $c)))/2*$a*$b;
//     $x4=($b* -1 - (sqrt($b * $b - 4 * $a * $c)))/2*$a*$b;   
//     echo  $x1."<br>";
//     echo  $x2."<br>";
// }
///////// *** КОНЕЦ  не нужный кусок кода


/*
- сформировать массив последовательности Фибоначи из 20 элементов  */
$arrFibo  = array(1,2);
for($i = 2 ; $i < 20; $i++){    
    array_push($arrFibo, ($arrFibo[$i-2] + $arrFibo[$i-1]));       
}
foreach($arrFibo as $item){
    echo $item.", ";
    }
echo "<hr>";

/*
- сформировать массив случайных чисел от -50 до 50 из 10 элементов 
- вывести массив */
$arrRand = array();
for($i = 0 ; $i < 10; $i++){    
    array_push($arrRand, rand(-50,50));
    echo $arrRand[$i].", ";
}
echo "<hr>";
/*- перемешать массив (вывести массив) */
shuffle($arrRand);
foreach($arrRand as $item){
    echo $item.", ";
    }
echo "<hr>";

/*- отсортировать массив по убыванию (вывести массив)   */
rsort($arrRand);
foreach($arrRand as $item){
    echo $item.", ";
    }
echo "<hr>";
/*- сформировать ассоциативный массив студентов группы ("Фамилия" => "Имя") 
- вывести всех студентов в табличном виде №№ Фамилия Имя  */
$students = array('Фролов' => 'Вячеслав', 'Иванов' => 'Евгений', 'Ленский' => 'Евгений', 'Смирнов' => 'Андрей', 'Трофимов' => 'Виктор', 'Маркус' => 'Виктор', 'Будыкина' => 'Оксана');

echo "<table border='1'>";
$i=1;
foreach($students as $k=>$v)
{    
    echo "<tr>";        
        echo "<td>";
        echo "$i";
        echo "</td>";
        echo "<td>";
        echo "$k";
        echo "</td>";
        echo "<td>";
        echo "$v";
        echo "</td>";    
    echo "</tr>";
    $i+=1;
}
echo "</table>";
/* - Вывести отсортированные по алфавиту все имена студентов */
sort($students);
foreach($students as $item){
        echo $item.", ";
    }
echo "<hr>";

?>