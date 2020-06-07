<?php
//*********   Работа с файлами
/* 1. Создайте файл 'test.txt' и запишите в него фразу 'Привет, мир!'.*/
/*
$str = "Привет, мир!";
file_put_contents('test.txt', $str);
*/
/* 2. Считайте данные из файла 'test.txt' и выведите их на экран. */
/*
$str1 = file_get_contents('test.txt');
echo $str1;
*/
/* 3. Переименуйте файл 'test.txt' в 'mir.txt'.*/
/*
rename('test.txt', 'mir.txt');
*/
/* 4. Сделайте папку 'folder'.*/
/*
mkdir('folder');
*/
/* 5. Создайте копию файла 'mir.txt' и назовите ее 'world.txt'.*/
/*
copy('mir.txt','world.txt');
*/
/* 6. Определите размер файла 'world.txt'. Выведите его на экран. Выведите его в байтах, мегабайтах, гигабайтах.*/
/*
$sizeFile=filesize('world.txt');
echo $sizeFile. " b"."<br>"; 
$sizeFile=$sizeFile/1000;
echo $sizeFile."Kb"."<br>";
$sizeFile=$sizeFile/1000;
echo $sizeFile."Mb"."<br>";
$sizeFile=$sizeFile/1000;
echo $sizeFile."Gb"."<br>";
*/
/* 7. Удалите файл 'world.txt'.*/
/*
unlink('world.txt');
*/
/* 8. Проверьте существование файлов 'world.txt' и 'mir.txt'.*/
/*
if(file_exists('world.txt')){
    echo "Файл world.txt существует!";
    }
else{
        echo "Файл world.txt не существует!<br>";
    }
if(file_exists('mir.txt')){
        echo "Файл mir.txt существует!";
    }
else{
            echo "Файл mir.txt не существует!<br>";
    }
*/

// *********   Работа с папками, mkdir, rmdir
// 9. Создайте папку 'test'.

//mkdir('test');

// 10. Переименуйте папку 'test' на 'www‘.

// rename('test', 'www');

// 11. Удалите папку 'www'.

//rmdir('www');

// 12. Дан массив со строками. Создайте в папке 'test' папки, названиями которых служат элементы этого массива.
/*
$arr = ['css', 'pages','img','resource'];
mkdir('test');
foreach($arr as $item){
    mkdir("test/$item");
}
*/
// *********   На scandir, is_dir, is_file, PHP_EOL
// 13. Выведите на экран название всех файлов и подпапок из папки 'test'.

// $arr = scandir('test');
// foreach($arr as $item){
//     echo $item."<br>";
// }

// 14. Выведите на экран название всех файлов, но не подпапок из папки 'test‘.
/*
$arr = scandir('test');
foreach($arr as $item){
    if(is_file("test/$item")){
    echo $item."<br>";
    }
}
*/
/* 15. В папке 'test' есть файлы и подпапки. Выведите на экран содержимое всех файлов, которые лежат непосредственно
в папке 'test'.*/
/*
$arr = scandir('test');
foreach($arr as $item){
    if(is_file("test/$item")){
    echo "FILE:  ".$item."<br>";
    echo "CONTENT:   ".file_get_contents("test/$item")."<br>";
    }
}
*/

// 16. Выведите на экран название всех файлов с расширением txt из папки 'test'.
/*
$arr = scandir('test');
foreach($arr as $item){
    if(is_file("test/$item"))
        if(fnmatch("*.txt", $item))
            echo $item."<br>";    
}
*/

/* 17. Найдите все файлы из папки 'test' и вставьте в начало каждого файла полный путь к нему (текст файла должен
остаться в нем и начинаться с новой строки после пути).*/
/*
$arr = scandir('test');
foreach($arr as $item){
    if(is_file("test/$item"))
        echo pachinfo("test/$item")."<br>";   
}
*/

// 18. Выведите на экран имена всех папок из папки 'test' и их подпапок (может быть любой уровень вложенности).

// function viewTree( $folder, $space ) {
// $arr = scandir( 'test' );
// foreach( $arr as $file )
//  {
//  // Отбрасываем текущий и родительский каталог
//  if ( ( $file == '.' ) || ( $file == '..' ) ) continue;
//  // Получаем полный путь к файлу
//  $path = $folder.'/'.$file;
//  // Если это директория

//  if ( is_dir( $path ))
//   {
//   // Выводим название директории, делая заданный отступ
//   echo $space.$space.$file."<br />";

//   // С помощью рекурсии выводим содержание полученной директории
//   viewTree( $path, $space.'&nbsp;&nbsp;' );
//   }
//  // Если это файл, то просто выводим название файла
//  else {
//   echo $space.$file."<br />";
//   }
//  }
// }
// viewTree( 'test', '' );


/* 19. Выведите на экран содержимое всех файлов из папки 'test' и ее подпапок (может быть любой уровень
вложенности).*/

$folder = 'test';
function viewTreeFileContent( $folder, $space ) {
    $arr = scandir($folder);
    foreach( $arr as $item )
     {
     // Отбрасываем текущий и родительский каталог
     if ( ( $item == '.' ) || ( $item == '..' ) ) continue;
     // Получаем полный путь к файлу
     $path = $folder.'/'.$item;
     if (!is_dir( $path )){
        //echo $space.$space.$file."<br />";
         echo $space.$item."<br />";
         }
     // Если это директория     
     if ( is_dir( $path ))
      {
      // Выводим название директории, делая заданный отступ
      echo $space.$item."<br />";
      // С помощью рекурсии выводим содержание полученной директории
        viewTreeFileContent( $path, $space.'&nbsp;&nbsp;' );
      }
     // Если это файл, то просто выводим название файла а потом его содержимое
    //  else {
    //  //echo $space.$space.$file."<br />";
    //   echo $space.$file."<br />";
    //   }
     }
    }
    viewTreeFileContent( 'test', '' );


/* 20. Найдите все файлы из папки 'test' и ее подпапок любого уровня вложенности и вставьте в начало каждого файла
полный путь к нему (текст файла должен остаться в нем и начинаться с новой строки после пути).*/
//*********   Задачи
/* 21. Найдите все файлы из папки 'test', в их содержимом найдите тег <h1>текст</h1>. Переименуйте все файлы на их h1.*/
// 22. Удалите из папки 'test' все файлы размером более 1мб.
// 23. Имеется папка с файлами, узнайте размер этой папки.
// 24. Имеется папка с подпапками, узнайте размеры всех подпапок папки и выведите их на экран. 
?>