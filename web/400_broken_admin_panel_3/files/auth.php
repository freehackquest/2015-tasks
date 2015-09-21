<?php

session_start();

$username = $_POST['username'];
$password = $_POST['password'];
$admin = $_POST['admin'];

if  (isset($username, $password)) {
    $_SESSION['signed_in'] = true;
    $_SESSION['username'] = $_POST['username'];
    setcookie("admin",$admin);
    setcookie("flag","False");
    $host  = $_SERVER['HTTP_HOST'];
    $uri   = rtrim(dirname($_SERVER['PHP_SELF']), '/\\');
    $extra = 'hiddensuperadminpanel.php';
    header("Location: http://$host$uri/$extra");
} else {
    $_SESSION['flash_error'] = "Invalid username or password";
    $_SESSION['signed_in'] = false;
    $_SESSION['username'] = null;
    readfile('templates/index.html');
}