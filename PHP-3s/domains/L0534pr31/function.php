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

?>