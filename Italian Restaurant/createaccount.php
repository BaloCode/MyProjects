<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Create Account</title>
<link href="css/bootstrap.css" rel="stylesheet" type="text/css">
</head>

<body class="inputform">
<form method = "POST" action = "createaccount.php">
  Username:<br>
  <input type="text" name="username" ><br>
  Password:<br>
  <input type="text" name="password" ><br><br>
  Email:<br>
  <input type ="text" name="email"><br><br>
  <input type="submit" value="Submit">
	</form> 
</body>
</html>

<?php
    function test_input($data){
        $data = trim($data);
        $data = stripslashes($data);
        $data = htmlspecialchars($data);
        return $data;
    }
    
    if ($_SERVER['REQUEST_METHOD'] == 'POST'){
        
        $uname = test_input($_POST['username']);
        $pass = test_input($_POST['password']);
        $email = test_input($_POST['email']);
        
require 'dbcon.php';

$sql = "INSERT INTO accounts (username, password, email)
VALUES ('$uname', '$pass', '$email')";
if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
} else {    echo "Error: " . $sql . "<br>" . $conn->error; } $conn->close(); 



    }
   
    
?> 




