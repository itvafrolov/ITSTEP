<?php
session_start();
include_once "config.php";
include_once "function.php";

if(isset($_POST['btn_login']))
{
    $msg = login($_POST);
    if ($msg === true)
    {
        //переход на секретную страницу
        header("Location:admin.php");
        exit();
    }
    else
    {
        //Error
        $_SESSION['msg'] = $msg;
    }

}

if (isset($_POST['logout']))
{
  $msg = logout();
  if ($msg === true)
  {
    
    $_SESSION['msg'] = 'Вы вышли из системы';
    header('Location:'.$_SERVER['PHP_SELF']);
    exit();
  }
}
?>

<?php
include_once "inc/header.php";
?>
<div id="content">
    <div id="main">
    <hr>
    <?=$_SESSION['msg'] ?>
    <?php unset($_SESSION['msg']);?>
    </hr>
        <h1>Авторизация</h1>
        <form method='POST'>
        <label>
        login<br>
          <input type='text' name='login'>
        </label><br>
        Password<br>
        <label>
          <input type='password' name='password'>
        </label><br>
        <label>Member
          <input type="checkbox" name='member' value="1">
        </label><br>
        <input style="float:left" type='submit' name='btn_login' value='Вход'>
      </form>
      <p>
        <a href="registration.php">Регистрация</a> | <a href="returnpas.php">Забыли пароль?</a>
      </p>
    </div>
<?php
include_once "inc/sidebar.php";
?>

<?php
include_once "inc/footer.php"

?>