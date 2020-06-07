<!-- Веб приложение "Калькулятор" -->
<?php
     if(!empty($_GET)){
        $a=$_GET[a];
        $b=$_GET[b];
        $res=0;
     }
        function calc($a, $b){
        if($_GET[answer]=="a1"){
            // echo "RESULT:   "; 
            $res=$a+$b;
        }
        if($_GET[answer]=="a2"){
            // echo "RESULT:   "; 
             $res=$a-$b;
        }
        if($_GET[answer]=="a3"){
            // echo "RESULT:   "; 
            $res=$a*$b;
        }
        if($_GET[answer]=="a4"&&$b!=0){
            // echo "RESULT:   "; 
            $res=$a/$b;
        }
        return $res;   
        };
    ?>
   
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=100px, initial-scale=1.0">
    <style>
        .all{
            width: 800px;            
            }
        .all{display: flex;
            flex-direction: row;
            align-items: center;
            justify-content: space-between;
            background-color: #70808080;
            padding: 35px ;
        }
        .button {            
            width: 300%;
            
        }      
    </style>
    <title>Calculator</title>
</head>
<body>    
    <form action="" method="get">
        <div class="all">
            <div class="element">
            <p>a= <br>
                <input type="text" name = "a" value=<?=$a?>> 
                </p>
            </div>
            <div class="rbut" default="a1">
            <p><input type="radio" name="answer" value="a1"> + <Br>
                <input type="radio" name="answer" value="a2"> - <Br>
                <input type="radio" name="answer" value="a3"> * <Br>
                <input type="radio" name="answer" value="a4"> / 
            </p>
            </div>
            <div>
                <p>b= <br>
                <input type="text" name = "b" value=<?=$b?>> 
                </p>
            </div>
            <div>
                <p><br>  
                 <button class="button" type="submit" name='btn' value="btn"> = </button>
                </p>
            </div>
            <div class="result">
                <p>result: <br>
                <input type="text" name = "res" value=<?=calc($a, $b)?>>
                </p>
            </div>
        </div>
    </form>
</body>
</html>