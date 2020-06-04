<?php

#1
//copy — Копирует файл
//copy ( string $source , string $dest [, resource $context ] ) : bool
/* copy("text.txt", "f/text2.txt"); */

#2
//file_exists — Проверяет существование указанного файла или каталога
//file_exists ( string $filename ) : bool
/* if (file_exists('f')){
    echo "Файл существует!!!";
}
else{
    echo "Файл NO существует!!!";
} */

#3
//fopen - открыть
//fread - чтение 
//fwrite - записать
//fclose - закрыть
//
//file_get_contents — Читает содержимое файла в строку
/* $str = file_get_contents('text.txt');
echo nl2br($str); */

/* $str = file_get_contents('https://www.google.com/');
echo htmlspecialchars($str); */

#4
//file_put_contents — Пишет данные в файл

/* $str = file_get_contents('https://www.google.com/');
$str2 = file_get_contents('https://php.net');

file_put_contents('html.txt', $str);
file_put_contents('html.txt', $str2, FILE_APPEND); */

#5
//file — Читает содержимое файла и помещает его в массив
/* $arr = file('text.txt', FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES);
//var_dump($arr);
echo '<pre>';
print_r($arr);
echo '</pre>'; */

#6
//is_dir — Определяет, является ли имя файла директорией
/* if (is_dir('text.txt')) echo 'Это каталог';
else echo 'Это не каталог'; */

#7
//is_file — Определяет, является ли файл обычным файлом
//Возвращает TRUE, если файл существует и является обычным файлом, иначе возвращает FALSE.

/* if (is_file('f')) echo 'Это файл';
else echo 'Это не файл'; */

#8
//rename — Переименовывает файл или директорию
//rename('text2.txt', 'ttttttttt.txt');
/* rename('f', 'fffff2'); */

#9
//mkdir — Создаёт директорию
//mkdir('100');
/* mkdir('1/2/3', 0777, true); */

#10
//rmdir — Удаляет директорию
/* rmdir('100'); */

#11
//touch — Устанавливает время доступа и модификации файла
//touch('text.txt', time() + 60*60*24*365*5);

#12
//unlink — Удаляет файл
unlink('html.txt');

echo '<hr/>';
echo "<h1>Скрипт выполнен!</h1>";

?>