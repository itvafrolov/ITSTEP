<?php
    if(!empty($_GET)){
        echo "<pre>";
        print_r($_GET);
        echo "<pre>";
        $x = $_GET['my_name'];
        echo $x;
    }
    if(!empty($_POST)){
        echo "<pre>";
        print_r($_POST);
        echo "<pre>";
        $x = $_POST['my_name'];
        echo $x;
        if(isset($_POST['btn_send1'])){
            echo "<br> Пришел запрос из 1 формы";
        }
        if(isset($_POST['btn_send2'])){
            echo "<br> Пришел запрос из 2 формы";
        }

    }

    ?>