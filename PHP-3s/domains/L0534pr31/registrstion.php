<?php
session_start();

include_once "config.php";
include_once "function.php";
if (isset($_POST['reg']))
{
    $msg = registration($_POST);
    if ($msg === true)
    {
        $_SESSION['$msg'] = "Вы успешно зарегистрировались на сайте!
        Вам отправлено сообщение. Следуйте инструкциям!!!";
    }
    else
    {
        $_SESSION['$msg'] = $msg;
    }
    // редирект  - чтоб не выводилось окно запрос на новое 
    header("Location:".$_SERVER['PHP_SELF']);
    exit();
}
?>

<?php
include_once "inc/header.php";
?>
<div id="content">
    <div id="main">
        <h1>Регистрация.</h1>      
        <?=$_SESSION['$msg']?>  
        <? unset($_SESSION['$msg'])?>  
        <form method='POST'>
    Логин<br>
      <input type='text' name='reg_login' value="<?=$_SESSION['reg']['login'] ?>">
    <br>
    Пароль<br>
      <input type='password' name='reg_password'>
    <br>
    Подтвердите пароль<br>
      <input type='password' name='reg_password_confirm'>
    <br>
    Почта<br>
      <input type='text' name='reg_email' value="<?=$_SESSION['reg']['email'] ?>">
    <br>
    Имя<br>
      <input type='text' name='reg_name' value="<?=$_SESSION['reg']['name'] ?>">
    <br>
    <input style="float:left" type='submit' name='reg' value='Регистрация'>
  </form>
    </div>
    <?php include_once"inc/sidebar.php";?>
    <?php include_once"inc/footer.php";?>

    <?php unset($_SESSION['reg'])?>
    


<?php
include_once "inc/sidebar.php";
?>


<?php
include_once "inc/footer.php"

?>
?>