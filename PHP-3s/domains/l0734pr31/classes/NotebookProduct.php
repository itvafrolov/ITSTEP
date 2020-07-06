<?php
class NotebookProduct extends Product implements IGadget
{
    use TColor;
    public $CPU;
    public function __construct($name, $price, $CPU)
    {
        parent::__construct($name, $price);
        $this->CPU = $CPU;
    }

    public function getProductInfo()
    {
        $out = parent::getProductInfo();
        $out .="Частота: {$this->CPU} <br>";
        return $out;
    }


public function Print()
{
    echo "<hr><br>Я рисую информацию: <br>".$this->getProductInfo();
}

public function PrintGadget()
{
    echo "<hr><br>Сопутствующие товары: <br>";
    $arr_gadget = ["часы", "мышь"];
    foreach($arr_gadget as $item)
    {
        echo "<br> $item <br>";
    }
}

}

?>