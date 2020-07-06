<?php
class BookProduct extends Product
{
    public $numPages;
    public function __construct($name, $price, $numPages)
    {
        parent::__construct($name, $price);
        $this->numPages = $numPages;
    }

    public function getProductInfo()
    {
        $out = parent::getProductInfo();
        $out .="Количество страниц: {$this->numPages} <br>";
        return $out;
    }


public function Print()
{
    echo "Я печатаю информацию: <br>".$this->getProductInfo();
}
}
?>