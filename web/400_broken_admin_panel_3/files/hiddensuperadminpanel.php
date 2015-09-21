<?php

$admin = $_COOKIE['admin'];
$flag = $_COOKIE['flag'];

if ($admin == 'on'){
    readfile('templates/hiddensuperadminpanel.html');
    if ($flag == 'True'){
        header('flag: fhq{ReGistRatIon_is_OPen_Really?}');
    }
}
else{
    readfile('templates/notadmin.html');
}