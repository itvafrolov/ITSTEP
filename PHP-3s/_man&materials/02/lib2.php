<?php
    $students = ['Ivanov', 'Sidorov', 'Petrov', 'Stepanov'];

    function my_func(&$x=100, &$y=200)
    {
        
        $x++;
        $y++;
        $res = $x + $y;
        return $res;
    }
?>