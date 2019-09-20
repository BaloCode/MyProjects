<!doctype html>
<?php
session_start();
?>
<html>
<head>
<meta charset="utf-8">
<title>login</title>
<link href="css/bootstrap.css" rel="stylesheet" type="text/css">
</head>

<body class="loginform">
 <form method = "post" action = "login.php">
  Username:<br>
  <input type="text" name="username" ><br>
  Password:<br>
  <input type="text" name="password" ><br><br>
  <input type="submit" value="Submit">

	</form> 
<br/><br/>CLick here: <a href="logout.php">LOGOUT</a> to destroy Session!
</body>
</html>
<?php
if ($_SERVER['REQUEST_METHOD'] == 'POST'){
    require 'dbcon.php';
    $name = $_POST["username"];
    $pass = $_POST["password"];

    
    $sql = "select Usr_id, username,email,password,Score  from accounts where username='$name' and password='$pass'";
    
$result = $conn->query($sql);
if ($result->num_rows > 0) {
        while($row = $result->fetch_assoc()) {
                $_SESSION['Usr_id'] = $row['Usr_id'];
                $_SESSION['username']=$row['username'];
        echo "<br/><br/>Welcome " . $_SESSION['username'];
    
} 
} else {     echo "You are not a registered user. Please <a href='login.php'>retry</a> or <a href='register.php'>register</a>"; } $conn->close(); 
}
?>


