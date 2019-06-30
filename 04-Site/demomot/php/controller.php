<?php
/*
  Author: Diogo Navega Pinto
  Date: 20/06/19
  Company: ETML
  Topic: Mini-Project
*/

require('dao.php');


//
class demomotController
{
  private $demomotModel;

  //
  function __construct()
  {
    $this->demomotModel = new demomotModel();
  }

  //
  private function openDemomotDb()
  {
    $this->demomotModel->dbConnect();
  }

  //
  private function closeDemomotDb()
  {
    $this->demomotModel->dbUnConnect();
  }

  //
  public function getLoginData()
  {
    $this->openDemomotDb();
    $data = $this->demomotModel->getLoginData();
    $this->closeDemomotDb();

    return $data;
  }
} // .
?>
