<?php
/*
  Author: Diogo Navega Pinto
  Date: 20/06/19
  Company: ETML
  Topic: Mini-Project
*/

//
class demomotModel
{
  private $connector = null;

  // Connexion to the database
  public function dbConnect()
  {
    try
    {
      $this->connector = new PDO('mysql:host=localhost;dbname=demomot','root','root');
    }
    catch(PDOExeption $e)
    {
      echo "Echec de la connexion à la base de donné";
      die();
    }
  }

  // Connexion to the database
  private function executeGetRequestSQL($queryParam)
  {
    $req = $this->connector->prepare($queryParam);
    if($req->execute())
    {
      echo "";
      $result = $req->fetchAll(PDO::FETCH_ASSOC);
      $req->closeCursor();

      return $result;
    }
    else {
      echo "Erreur";
    }
  }

  private function executeSetRequestSQL($queryParam)
  {
    $req = $this->connector->prepare($queryParam);
    if($req->execute())
    {
      echo "";
    }
    else {
      echo "";
    }

    $req->closeCursor();
  }

  public function getLoginData()
  {
    return $this->executeGetRequestSQL("SELECT `plaName`, `plaPassword` FROM `t_player`");

  }

  // Unset connexion to the database
  public function dbUnConnect()
  {
    unset($this->connector);
  }

} // .

?>
