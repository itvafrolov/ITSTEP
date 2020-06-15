<?
session_start(); // если сессия создана, то повторно она не создается

$_SESSION['name'] = 'Viacheslav';

echo session_id();


?>