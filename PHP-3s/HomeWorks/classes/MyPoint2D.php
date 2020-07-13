<?php
class MyPoint2D
{
    public $name;
    public $X;
    public $Y;

    public function __construct($X, $Y, $n)
    {
        $this->X = $X;
        $this->Y = $Y;
        $this->name = $n;        
    }
?>