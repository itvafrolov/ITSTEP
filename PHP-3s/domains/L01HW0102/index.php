<?php
//error_reporting(-1);
$cols = array(1,2,3,4,5,6,7,8,9,10,11);
$rows = array(1,2,3,4,5,6,7,8,9,10,11);
$tbhead = "<table border='1'>";
$trstart = "<tr>";
$trend = "</tr>";

// echo $cools;
// print_r($cools);
// echo "<br>-------------------<br>";
// echo $rows;
// print_r($rows);
?>

<!DOCTYPE html>
<html lang="ru">
<head>
	<meta charset="UTF-8">
	<title>HW 2</title>
	<link rel="stylesheet" href="js/jquery-ui.min.css" />
	<style>
		body {margin: 15px 40px;}
		/* #wrap {width: 600px; margin: 0 auto;} */
		/* table {border-collapse: collapse; } */
		/* td {padding: 5px; text-align: right;} */
		/* td:first-child {width: 350px;} */
		/* .header { padding: 5px; display: inline;} */
		/* .header a {color: orange; } */
		/* .header a:hover  {color: #d30; text-decoration: none; } */
		 /* td img {width: 15px;  margin-right: 15px; display: none;} */
		/* .price {font-size: 1.1em; font-weight: bold; color: #d00; } */
		/* .frm input {text-align: right;} */
		/* .del {background: url(books/delx.gif) no-repeat; width: 15px; height: 15px; cursor: pointer; text-align: center; } */
		/* #buy {
			width: 135px; cursor: pointer;
			margin: 20px 0;
		} */
	</style>
</head>
<body>
<div>
	<h2>Таблица умножения</h2>
	<!-- <form name="elbooks" id="elbooks"> -->
	
<?php	
	echo $tbhead;
	
	for($i = 0; $i<count($rows); $i++) { //rows
    	  //$tr2 = "<th>пн</th>  <th>вт</th>  <th>ср</th>  <th>чт</th>   <th>пт</th>	<th>сб</th> <th>вс</th>";
		  echo $trstart; 
		  for($j = 0;  $j<count($cols); $j++){  //cols
			  $trdata = $rows[$i] *  $cols[$j];	
			  if ($i == 1){
			  $tr2 = "<th background-color = #d30 >".$trdata."</th>";
			  }
			  $tr2 = "<th>".$trdata."</th>";
		 	  echo $tr2;
		  }
		  echo $trend;
		}
		echo count($rows);
	  //echo $trstart.$tr2.$trend;
	  //$len = 
	?>
	
</div>
</body>
</html>