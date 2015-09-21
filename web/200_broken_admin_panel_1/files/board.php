<?php
session_start();
$is_admin = 0;
parse_str(base64_decode($_GET['token']));

if (!$is_admin) {
    readfile('templates/notflag.html');
}else{
    readfile('templates/f1aghere.html');
    }