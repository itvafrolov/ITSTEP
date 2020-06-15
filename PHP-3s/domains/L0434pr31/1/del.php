<?php
//чтобы удалить куку нужно вернуть ее назад по времени
setcookie('c1','',time() -600, '/');
setcookie('counter','',time() -600, '/');
?>
<a href="test.php">Тест</a>