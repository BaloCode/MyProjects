link rel="stylesheet" href="bootstrap/css/style.css" type="text/css" />
<form method="post" action="add-data.php">

<table width="50%" align="center" border="0">

<tr>
<td>Just A reminder there are 3 record tha you should to enter (1 for 2 seat table,2 for 4 seat table and 3 for 6)</td>
</tr>

<tr>
<td>
<input type="text" name="no_of_rec" placeholder="Enter Between 1 - 3 " maxlength="2" pattern="[0-9]+" required />
</td>
</tr>

<tr>
<td><button type="submit" name="btn-gen-form">Generate</button> 
&nbsp;
<a href="index.php">back</a>
</td>
</tr>

</table>

</form>
