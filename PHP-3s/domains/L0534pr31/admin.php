<?php
session_start();
include_once "config.php";
include_once "function.php";

if (!check_user())
{
    header('Location:login.php');
    exit();
}
?>

<?php
include_once "inc/header.php";
?>
<div id="content">
    <div id="main">
        <h1>Секретная страница - личный кабинет!!!</h1>
    </div>
    <form  method='POST' action= 'login.php'>
        <input style="margin-top:-16px;" type='submit' name="logout" value='Выход'>
      </form>
<?php
include_once "inc/sidebar.php";
?>


<?php
include_once "inc/footer.php"

?>