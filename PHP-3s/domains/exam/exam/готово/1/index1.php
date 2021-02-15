
<?php

//error_reporting(-1);
/*
1. Сформировать таблицу размером 10*10 ячеек. Содержимое каждой ячейки –
это число, которое равняется i*j, где i – номер строки, j – номер столбца ячейки. 
*/

$cols = array(1,2,3,4,5,6,7,8,9,10);
$rows = array(1,2,3,4,5,6,7,8,9,10);
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
		.hhh {background-color: #f01;
		font: 14pt sans-serif;
		font-weight: bold;
		}
		.ddd {background-color: #199;
		font: 12pt/10pt sans-serif;}
		body {margin: 10px 60px;}
	</style>
</head>
<body>
<div>
	<h2>Таблица умножения</h2>
	<!-- <form name="elbooks" id="elbooks"> -->
	<!-- <p class=ddd > 123 -->
	</p>
	
<?php	
	echo $tbhead;
	
	//$i=0;
	//$j = 0;
	for($i = 0; $i<count($rows); $i++) {
		  echo $trstart; 
		  for($j = 0;  $j<count($cols); $j++){  //cols
			  $trdata = $rows[$i] * $cols[$j];	
			  if ($i == 0 || $j == 0){
			  $tr2 = "<th class=hhh>".$trdata."</th>";
			  }
			  else {$tr2 = "<th class=ddd>".$trdata."</th>";}
		 	  echo $tr2;
		  }
		  echo $trend;
		}
		//echo count($rows);	 
	?>
	
</div>
</body>
</html>