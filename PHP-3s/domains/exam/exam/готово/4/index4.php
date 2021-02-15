<?php
    /*
4. Создать форму для ввода электронного адреса в формате vasya.pupkin@ukr.net, пароль и подтверждение пароля. 
При нажатии на кнопку, должна проводиться проверка на валидность введенных данных включая проверку наличия в пароле 
хотя бы 1 цифры и хотя бы 1 большой буквы латинского алфавита. Вывести сообщение об успехе/неуспехе проверки валидности.
*/

// if (!empty($_GET))
// {
//     if (
//         isset($_GET['my_btn']) 
//         && 
//         $_GET['my_btn'] == "btn_send"

//     )
//     {
        
//     echo "<pre>";
//     print_r($_GET);
//     echo "</pre>";
//     }
// }

if (!empty($_POST))
{
    if (
        isset($_POST['my_btn']) 
        && 
        $_POST['my_btn'] == "btn_send")
    {
        $mail = $_POST['emaile'];
        $pswd = $_POST['passw'];     
        $valid_mail = validMail($mail);    
        $valid_pass = validPass($pswd);    
    }    
}

function validPass($pswd)
{
    $countCh = 0;
    $countNum = 0;
    $arrCh=str_split($pswd,1);

    foreach($arrCh as $ch)
    {
        if(ord($ch) > 64 && ord($ch)<91 )
        {
            $countCh++;
        }
        if(ord($ch) > 47 && ord($ch)<58 )
        {
            $countNum++;
        } 
    }
    if($countCh>0 &&  $countNum>0) 
    {
        return true;
    }
    else return false;
}

function validMail($mail)
{
    $arrMail = str_split($mail,1);
    $countA = 0;
    foreach($arrMail as $x)
    {
        if($x == '@')
        {
            $countA++; 
        }
    }
    if($countA==1) 
    {
        return true;
    }
    else return false;
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
    <form action="" method="POST">emaile
        <input 
            type="text" 
            name="emaile" 
            id="em" value=<?=$mail?>> 
        <br>Password
        <input 
            type="text" 
            name="passw" 
            id="" value=<?=$pswd?>>
        <br>        
        <button 
            type="submit"
            name="my_btn"
            value="btn_send"
        >Отправить</button>
    </form>
    <hr>
    <p>
        <h2>Вывод:</h2>
        <?php
        if($valid_mail) 
        {
            echo "email Ok";
        }
        else 
        {
            echo "email Error!";
        }
        echo "<br>";
        if($valid_pass)
        {
            echo "password Ok";
        }
        else 
        {
            echo "password incorrect!";
        }
        ?>
        
    </p>
</body>
</html>