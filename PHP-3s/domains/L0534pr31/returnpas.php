<?php
session_start();
include_once "config.php";
include_once "function.php";
if ($_POST['email'])
{
    $msg = get_password($_POST['email']);
  
    if($msg === TRUE) {
      $_SESSION['msg'] = "Новый пароль выслан Вам на почту";
      header("Location:login.php");
    }
    else {
      $_SESSION['msg'] = $msg;
      header("Location:".$_SERVER['PHP_SELF']);
    }
    exit();
}
?>

<?php
include_once "inc/header.php";
?>
<div id="content">
    <div id="main">
    <hr>
            <?=$_SESSION['msg'] ?>
            <?php unset($_SESSION['msg']); ?>
    <hr>
        <h1>Введите свой почтовый адрес</h1>
        <form method='POST'>
        <label>
        EMAIL<br>
          <input type='text' name='email'>
        </label><br>
        <input style="float:left" type='submit' value='Вход'>
      </form>
    </div>
<?php
include_once "inc/sidebar.php";
?>


<?php
include_once "inc/footer.php"

?>