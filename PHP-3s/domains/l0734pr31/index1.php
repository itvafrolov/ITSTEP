<?php
error_reporting(-1);
    require_once 'classes/Car.php';
    echo "<br>Количество экземпляров Car: ".Car::$counter."<br>" ;
    $car1 = new Car("черный","BMW", 250 );

    // $car1->color = "черный";
    // $car1->brand = "BMW";
    //var_dump($car1);
    // echo $car1->getCarInfo();
    echo "<br>Количество экземпляров Car: ".Car::$counter."<br>" ;
    $car2 = new Car("синий", "VW" );
    // $car2->color = "синий";
    // $car2->brand = "VW";
    //var_dump($car1);
    echo "<br>Количество экземпляров Car: ".Car::getCount()."<br>" ;
    echo $car1->getCarInfo();

    //echo $car2->getCarInfo();
    echo "<br> -------- <br>";
    echo Car::TEST;
    echo $car1->t1();
?>