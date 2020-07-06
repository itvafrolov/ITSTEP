<?php
require_once "classes/IGadget.php";
require_once "classes/TColor.php";
require_once "classes/Product.php";
require_once "classes/BookProduct.php";
require_once "classes/NotebookProduct.php";

// $p1 = new Product("огурец", 40);
// $p2 = new Product("помидор", 50);
$p3 = new BookProduct("Пушкин", 150, 300);
$p4 = new NotebookProduct("Asus", 15000, 3000);
$p41 = new NotebookProduct("LG", 11000, 3200);
// echo $p1->getProductInfo();
// echo $p2->getProductInfo();
// echo $b1->getProductInfo();
// echo $n1->getProductInfo();






$arr = [$p3, $p4, $p41];
foreach($arr as $item)
{
    if($item instanceof NotebookProduct)
    {
    echo $item->getProductInfo();
    echo "Цвет: ".$item->getColor()."<br>";
    $item->PrintGadget();
    }
    else
    {
       echo $item->getProductInfo();
    }
}

/* echo $b1->Print();
echo $n1->Print();
 */
?>