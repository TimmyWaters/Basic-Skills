<!DOCTYPE html>

<?php    
$emailErr = "";
if(isset($_POST['SubmitButton'])){ //check if form was submitted
  $input = $_POST['inputText']; //get input text
  if (!filter_var($input, FILTER_VALIDATE_EMAIL)) {
  	$emailErr = " * Invalid email format";
  }
  else {
  	$message = "Success! You entered: ".$input."<br>";
  }
}    
?>

<html>
	<head>
		<meta charset="utf-8">
		<title>Week 7 Part 1</title>
		<style>
			.error {color: #FF0000;}
		</style>
	</head>
	<body>
		<form action="" method="post">
			<?php echo $message; ?>
			<label for="input">Email: </label>
			<input type="text" id="input" name="inputText"/><span class="error"><?php echo $emailErr;?></span><br>
			<input type="submit" name="SubmitButton"/>
		</form>
	</body>
</html>