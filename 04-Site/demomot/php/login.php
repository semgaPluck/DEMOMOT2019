<!DOCTYPE html>
<html lang="fr">
  <head>
    <meta charset="utf-8">
    <title>Connexion</title>
  </head>
  <body>

    <header>
      <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

      <ul class="nav nav-pills">
        <li class="nav-item">
          <a class="nav-link" href="home.php">Accueil</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="Contact.php">Contact</a>
        </li>
        <li class="nav-item">
          <a class="nav-link active" href="login.php">Connexion</a>
        </li>
      </ul>
    </header>

    <form action="controllerLogin.php" method="post">
      <div class="form-group">
        <label for="exampleInputEmail1">Pseudo</label>
        <input type="text" name="pseudo" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Pseudo">
      </div>
      <div class="form-group">
        <label for="exampleInputPassword1">Mot de passe</label>
        <input type="password" name="password" class="form-control" id="exampleInputPassword1" placeholder="Mot de passe">
      </div>
      <button type="submit" class="btn btn-primary">Se connecter</button>
    </form>


  </body>
</html>
