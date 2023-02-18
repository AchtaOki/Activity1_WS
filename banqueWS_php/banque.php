<?php
$mt=0;
if(isset($_POST['action'])){
$action=$_POST['action'];
if($action=="OK"){
if(isset($_POST['montant'])){
    $mt=$_POST['montant'];
    $clientSOAP = new SoapClient("http://localhost:9191/BanqueWS?wsdl");
    $param=new stdClass();
    $param->montant=$mt;
    $res=$clientSOAP->__soapCall("Convert",array($param));
}
}elseif($action=="ListeComptes"){
    $clientSOAP = new SoapClient("http://localhost:9191/BanqueWS?wsdl");
    $cptes=$clientSOAP->__soapCall("listComptes",array());
}
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css"
     rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65"
      crossorigin="anonymous">
    <title>Client Soap PHP</title>
</head>
<body>
    <form action="banque.php" method="post">
        Montant : <input type="text" name="montant" value="<?php echo($mt)?>">
        <input type="submit" name="action" class="btn btn-success" value="OK">
        <input type="submit" name="action" class="btn btn-primary" value="ListeComptes">
    </form>
    <?php if(isset($res)) {?>
        <?php echo($mt) ?> en Euro = <?php echo($res->return) ?> en DH
    <?php }?>

    
    <?php if(isset($cptes)) {?>
        <table class="table">
  <thead>
    <tr>
      <th scope="col">Code</th>
      <th scope="col">Solde</th>
    </tr>
    
  </thead>
  <?php foreach($cptes->return as $cp)  {?>
    <tr>
<td><?php echo($cp->code) ?></td>
<td><?php echo($cp->solde) ?></td>

    </tr>
  <?php } ?>
</table>  
    <?php }?>
</body>
</html>