<?php
function save_data(){    
    $str = $_POST['name'].'|'.$_POST['text'].'|'.date("Y-m-d H:i:s")."\n***\n";
    file_put_contents(FILE_GB, $str, FILE_APPEND);
}

function get_data(){
    return file_get_contents(FILE_GB);
}
function get_arr_data($str){
    $arr = explode("\n***\n", $str);
    array_pop($arr);    
    $arr = array_reverse($arr);
    return $arr;
}

function get_format_message($m){
    return explode('|', $m);
}


?>