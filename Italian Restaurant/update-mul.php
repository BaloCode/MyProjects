<?php
include_once 'dbcon.php';
$id = $_POST['Table_id'];
$fn = $_POST['fn'];
$ln = $_POST['ln'];
$chk = $_POST['chk'];
$chkcount = count($id);
for($i=0; $i<$chkcount; $i++)
{
 $MySQLiconn->query("UPDATE reservation SET tableid='$id[$i]'");
}
header("Location: index.php");
?>
