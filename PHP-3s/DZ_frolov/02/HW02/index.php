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
$a = 10;
$b = 7;
$c = 25;
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



/*
- сформировать массив последовательности Фибоначи из 20 элементов   
- сформировать массив случайных чисел от -50 до 50 из 10 элементов 
- вывести массив - перемешать массив (вывести массив) 
- отсортировать массив по убыванию (вывести массив)   
- сформировать ассоциативный массив студентов группы ("Фамилия" => "Имя") 
- вывести всех студентов в табличном виде №№ Фамилия Имя 
- Вывести отсортированные по алфавиту все имена студентов 
- вывести в случайном порядке 3 студентов группы.   
- сформировать ассоц.массив вида ("user1" => "Иванов Иван"). 
В массиве должно быть минимум 3 элемента. Из массива создать переменные и вывести их значения   
- сформировать 3 переменные и присвоить им значения. 
Например, $product1 = "Телефон" Сформировать ассоциативный массив из переменных.    
- сформировать вложенный массив студентов группы "1" => ( name => "ФИО", age => "возраст", 
group => "Группа", like_skills => ("PHP", "C#", "C++", "C++ ООП", "MS Sql") ), 
"2" => ( name => "ФИО", age => "возраст", group => "Группа", 
like_skills => ("PHP", "HTML", "JS") ), 
В массиве должны быть перечислены все студенты группы. 
По каждому студенту указать его скилы. 
Вывести в форматированном виде всех студентов с полной информацией. 
Вывести всех студентов, которые содержат скилы  PHP
*/


?>