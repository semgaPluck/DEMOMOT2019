<?php

  include 'Controller.php';

  $username = $_POST["pseudo"];
  $password = $_POST["password"];

  $controller = new demomotController();



  $data = $controller->getLoginData();

  var_dump($data);

  if($username == $data[0]['plaName'] && $password == $data[0]['plaPassword'])
  {
    header("location: loginSucces.php");
  }
  else
  {
    header("location: loginFail.php");
  }


 ?>
