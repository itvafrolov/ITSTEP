<?php
include_once "config.php";
include_once "functions.php";

if ($_GET['hash'])
{
    $msg = confirm();

    if ($msg === true)
    {
        $msg = "Ваша учетная запись активирована. Можно авторизироваться!";
    }
} else {
    $msg = "Неверна ссылка!!!!";
}
?>

<?php
include_once "inc/header.php";
?>

<div id="content">
		<div id="main">
			<?=$msg ?>
		</div>

<?php
include_once "inc/sidebar.php";
?>

<?php
include_once "inc/footer.php";
?>