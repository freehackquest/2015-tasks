<?php

session_start();

$username = $_POST['username'];
$password = $_POST['password'];
if  (isset($username, $password)) {
    $_SESSION['signed_in'] = true;
    $_SESSION['username'] = $username;
    $secret = base64_encode("username=$username&password=$password&is_admin=0");
    $host  = $_SERVER['HTTP_HOST'];
    $uri   = rtrim(dirname($_SERVER['PHP_SELF']), '/\\');
    $extra = 'board.php';
    header("Location: http://$host$uri/$extra?token=$secret");
}