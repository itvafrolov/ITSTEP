<?

isset($_COOKIE['counter'])
?
setcookie('counter', ++$_COOKIE['counter'], time() + 3600, '/')
:
setcookie('counter', 1, time() + 3600, '/');

echo "<p> Вы на нашем сайте: <br>";
echo isset ($_COOKIE['counter']) ? $_COOKIE['counter'] : 1;
echo "<br> раз </p>"

?>