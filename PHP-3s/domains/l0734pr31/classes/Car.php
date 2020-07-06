<?php
class Car
{
    public $brand;
    public $color;
    public $speed = 180;
    public static $counter;
    const TEST = "TEST CAR!";


    public function __construct($b, $c, $s=200)
    {
        $this->brand = $b;
        $this->color = $c;
        $this->speed = $s;
        echo "<br> call__constract <br> ";
        self::$counter++; // так обращаются к переменной статической!!!
    }
public function t1()
{
    return "<br> Константа: ".self::TEST."<br>";
}
    public static function getCount()
    {
        return self::$counter;
    }
    public function Car($b, $c, $s=200)
    {
        $this->brand = $b;
        $this->color = $c;
        $this->speed = $s;
    }
    public function getCarInfo()
    {
        return "
        <h3>Информация об авто</h3> 
        Марка: {$this->brand}
        Цвет: {$this->color}    
        Скорость: {$this->speed}
        <hr>
        ";
    }
    public function __destruct()
    {
        var_dump($this);
    }
}
?>