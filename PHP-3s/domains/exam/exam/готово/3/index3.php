<!-- 
3. Сформировать таблицу телефонов в три столбца по данными из текстового
файла. Содержимое файла:
Василий # Пупкин # 0677454541
Иннокентий # Мышь # 0681234541
Анна # Семенова # 0993213212
Ирина # Жэк # 0487745551
Ольга # Посольство # 0504125452
... и т.д.
(1 балл) 
 -->  
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
		.hhh {background-color: #199;
		font: 13pt sans-serif;
		font-weight: bold;
		}
		.ddd {
		font: 13pt/15pt sans-serif;}
		body {margin: 10px 30px;}
	</style>
</head>
<body>
	<h2>Телефонный lkdjfgldkfjg справочник</h2>
    <table>
  <thead>
    <tr>      
      <th class=hhh>Имя</th>
      <th class=hhh>Организация</th>
      <th class=hhh>Телефон</th>
    </tr>
  </thead>
  <tbody>
  <?php $f = file('3.txt');?>
  <?php foreach($f as $item): ?>    
  <?php $ff = explode('#', $item) ?>
    <tr >     
      <td class=ddd><?= $ff[0] ?></td>
      <td class=ddd><?= $ff[1] ?></td>
      <td class=ddd><?= $ff[2] ?></td>      
    </tr>
  <?php endforeach; ?>
  </tbody>
</table>
</body>
</html>