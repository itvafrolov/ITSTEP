<?php
function get_statti() {
    global $db;
    $sql = "SELECT * FROM statti";
    $result = mysqli_query($db, $sql);
      
    if(!$result) {
      exit(mysqli_error($db));
    }
    
    for($i = 0; $i<mysqli_num_rows($result);$i++) {
      $row[] = mysqli_fetch_array($result);
    }
    return $row;    
  }

  function clean_data($str) 
  {
    return strip_tags(trim($str));
  }

  function registration($post)
  {
    global $db;
    $login = clean_data($post['reg_login']);
    $password = trim($post['reg_password']);
    $conf_pass= trim($post['reg_password_confirm']);
    $email = clean_data($post['reg_email']);
    $name = clean_data($post['reg_name']);
    
    $msg ="";
    if(empty($login)) {
        $msg .= "Введите логин <br />";
      }
      if(empty($password)) {
        $msg .= "Введите пароль <br />";
      }
      if(empty($email)) {
        $msg .= "Введите адресс почтового ящика <br />";
      }
      if(empty($name)) {
        $msg .= "Введите имя <br />";
      }
      if ($msg)
      {
        $_SESSION['reg']['login'] = $login;
        $_SESSION['reg']['email'] = $email;
        $_SESSION['reg']['name'] = $name;
        return $msg;
      } 
      else 
      {
          if ($conf_pass == $password)
          {
              // регистрация
              $sql = "SELECT user_id FROM users WHERE login ='%s'";
              $sql = sprintf($sql,mysqli_real_escape_string($db, $login));
              $result = mysqli_query($db, $sql);
              if (mysqli_num_rows($result) > 0)
              {
                $_SESSION['reg']['email'] = $email;
                $_SESSION['reg']['name'] = $name;
                return "Пользователь с таким именем уже существует!";
              }

              $password = md5($password);
              $hash = md5(microtime());

              $query = "INSERT INTO users (
                name,
                email,
                password,
                login,
                hash
                ) 
              VALUES (
                '%s',
                '%s',
                '%s',
                '%s',
                '$hash'
              )";
          $query = sprintf
                (
                    $query,
                    mysqli_real_escape_string($db, $name),
                    mysqli_real_escape_string($db, $email),
                    $password,
                    mysqli_real_escape_string($db, $login)
                  );
          $result2 = mysqli_query($db, $query);
          if(!$result2) {
            $_SESSION['reg']['login'] = $login;
            $_SESSION['reg']['email'] = $email;
            $_SESSION['reg']['name'] = $name;
            return "Ошибка при добавлении пользователя в базу данных".mysqli_error($db);
          }
            $headers = '';
            $headers .= "From: Admin <admin@mail.ru> \r\n";
            $headers .= "Content-Type: text/plain; charset=utf8";    
            $tema = "registration";    
            $mail_body = "Спасибо за регистрацию на сайте. Ваша ссылка для подтверждения  учетной записи: 
            http://http://l0534pr31/confirm.php?hash=".$hash;    

            mail($email,$tema,$mail_body,$headers);

            return true;
          }
          else
          {
            $_SESSION['reg']['login'] = $login;
            $_SESSION['reg']['email'] = $email;
            $_SESSION['reg']['name'] = $name;
            return "Ваши пароли не совпадают!";
          }
          
      }
  }

  function confirm()
  {
      global $db;
      $hash = clean_data($_GET['hash']);
  
      $query = "UPDATE users
          SET confirm='1'
          WHERE hash = '%s'
          ";
    $query = sprintf($query,mysqli_real_escape_string($db, $hash));  
    
    $resutl = mysqli_query($db, $query);
    
    if(mysqli_affected_rows($db) == 1) {
      return TRUE;
    }
    else {
      return "Не верный код подтверждения регистрации";
    }
  }

  function login($post)
  {
      global $db;
      if (empty($post['login']) || empty($post['password']))
      {
          return "Заполните поля!!!";
      }

    $login = clean_data(($post['login']));
    $password = md5((trim($post['password'])));

    $sql = "SELECT user_id, confirm 
            FROM users
            WHERE 
            login= '%s' 
            AND
            password = '%s'";

    $sql = sprintf($sql, mysqli_real_escape_string($db, $login), $password);
    $result = mysqli_query($db, $sql);
    if (!$result || mysqli_num_rows($result) < 1){
        return "Неверный пароль или логин";
    }
    $row[] = mysqli_fetch_array($result);

    if ($row[0]['confirm'] == 0){
        return "Вы не окончили регистрацию.";
    }

    $sess= md5(microtime());
    $sql_update = "UPDATE users SET sess='$sess' WHERE login='%s'";
    $sql_update = sprintf($sql_update,mysqli_real_escape_string($db, $login));
  
    if(!mysqli_query($db, $sql_update)) {
      return "Ошибка авторизации пользователя";
      }
    
      $_SESSION['sess'] = $sess;
      
      if($post['member'] == 1) {
        $time = time() + 10*24*3600;
        
        setcookie('login',$login,$time);
        setcookie('password',$password,$time);
        
      }
      return true;
  }

  function logout(){
    global $db;
    $sql_update = "UPDATE users SET sess='' 
                WHERE sess='".$_SESSION['sess']."'";
  
  if(!mysqli_query($db, $sql_update)) {
    return "Ошибка БД!!!";
    }
    
    unset($_SESSION['sess']);

    return true;
}

function check_user()
{
  global $db;
  if (isset($_SESSION['sess']))
  {
      $sess = $_SESSION['sess'];
      $sql = "SELECT user_id
      FROM users
      WHERE sess='$sess'";
  $result = mysqli_query($db, $sql);
  
  if(!$result || mysqli_num_rows($result) < 1) {
    return FALSE;
  }
   
  return TRUE;
  } elseif(isset($_COOKIE['login']) && isset($_COOKIE['password']))
  {
      $login = $_COOKIE['login'];
      $password = $_COOKIE['password'];

      $login = clean_data($login);
  $password = md5($password);

  $sql = "SELECT user_id, confirm 
          FROM users
          WHERE 
          login= '%s' 
          AND
          password = '%s'";

  $sql = sprintf($sql, mysqli_real_escape_string($db, $login), $password);
  $result = mysqli_query($db, $sql);
  if (!$result || mysqli_num_rows($result) < 1){
      return "Неверный пароль или логин";
  }
  $row[] = mysqli_fetch_array($result);

  if ($row[0]['confirm'] == 0){
      return "Вы не окончили регистрацию.";
  }

  $sess= md5(microtime());
  $sql_update = "UPDATE users SET sess='$sess' WHERE login='%s'";
$sql_update = sprintf($sql_update,mysqli_real_escape_string($db, $login));

if(!mysqli_query($db, $sql_update)) {
  return "Ошибка авторизации пользователя";
  }
  
  $_SESSION['sess'] = $sess;
      
      return true;
  }
  
  else return false;    
}


function get_password($email) {
  global $db;
  $email = clean_data($email);
  
  $sql = "SELECT user_id
      FROM users
      WHERE email = '%s'";
  $sql = sprintf($sql,mysqli_real_escape_string($db, $email));  
  
  $result = mysqli_query($db, $sql);
  
  if(!$result) {
    return "не возможно сгенерировать новый пароль";
  }
  
  if(mysqli_num_rows($result) == 1) {
    $str = "234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
    
    $pass = '';
    
    for($i = 0; $i < 6; $i++) {
      $x = mt_rand(0,(strlen($str)-1));
      
      if($i != 0) {
        if($pass[strlen($str)-1] == $str[$x]) {
          $i--;
          continue;
        }
      }
      $pass .= $str[$x];
    }
    
    $row[] = mysqli_fetch_array($result);

    $md5pass = md5($pass);
    
    $query = "UPDATE users
    SET password='$md5pass'
    WHERE user_id = '"
              .$row[0]['user_id']."'";
    
    if(!$result2) {
      return "Не возможно сгенерировать новый пароль";
    }
    
    $headers = '';
    $headers .= "From: Admin <admin@mail.ru> \r\n";
    $headers .= "Content-Type: text/plain; charset=utf8";
    
    $subject = 'new password';
    $mail_body = "Ваш новый пароль: ".$pass;
    
    mail($email,$subject,$mail_body,$headers);
    
    return TRUE;  
  }
  else {
    return "Пользователя с таким потчтовым ящиком нет";
  }  
}

function del_statti($id)
  {
    global $db;
    $sql = "DELETE FROM statti WHERE id=$id";
    mysqli_query($db, $sql);
  }  

?>
