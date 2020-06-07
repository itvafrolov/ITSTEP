<?php
    //копирование файла, директория уже должна быть создана или будет ошбика
    // copy("text.txt", "text2.txt");
    // copy("text.txt", "f/text2.txt");
    //проверка есть ли такой файл в файловой системе
   /* if(file_exists('text3.txt')){
        echo "Файл существует!";
    }
    else{
            echo "Файл не существует!";
        }

        $str = file_get_contents('text.txt');
        echo $str;
        //с переводом на новую строку функция  nl2br
        echo nl2br($str);
        */
        /*
        //ссылки
        $str = file_get_contents('https://www.google.com/');
        //echo $str;
        echo htmlspecialchars($str);
        */
        /*
        //функция для записи в текстовый файл
        $str = file_get_contents('https://www.google.com/');
        file_put_contents('html.txt', $str);
        $str2 = file_get_contents('https://php.net/');
        //file_put_contents('html.txt', $str2);
        //дозаписать файл
        file_put_contents('html.txt', $str2, FILE_APPEND);
        */
        /*
        //каждая строчка в массив
        $arr = file('text.txt', FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES); // константа в конце, чтобы игнорировать перевод каретки и пробелы
        //var_dump($arr);
        echo '<pre>';
        print_r($arr);
        echo '</pre>';
*/      
        //проверка является ли это каталогом
        //функция is_file - проверка является ли это файлом
        // if (is_dir('folder')) echo 'Это каталог';
        // else echo 'Это не каталог';

        //переименование фала или каталога
       /* rename('text2.txt', 'tttttt.txt');
        rename('f', 'ff');*/
        
        //создание каталога
        //mkdir('100');
        //mkdir('1/2/3', 0777, true); //потому что создается сначала каталог 3, а при этом каталога 2 еще нет. 
        //потому создаются директории рекурсивно
        
        //удаление директории
        //rmdir('100');
        
        //изменение атрибута "время изменения"
        //touch('tttttt.txt', time() + 60*60*24*365*2);

        //удаление файла
        //unlink('html.txt');

//---------------------------------------------------
    echo '<hr/>';
    echo "<h1>Скрипт выполнен!</h1>";
?>