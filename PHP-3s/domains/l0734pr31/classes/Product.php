<?php
abstract class Product
{
    public $name;
    public $price;
    public $numPages;
    
    public function __construct($n, $p)
    {
        $this->name = $n;
        $this->price = $p;
    }
    public function getProductInfo()
    {
        $out = "<hr><b>О товаре: <b> <br>
        Название: {$this->name} <br>
        Цена: {$this->price} <br>    
        ";
        return $out;
    }

    abstract function Print();
}

?>