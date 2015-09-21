<?php

session_start();

$username = $_POST['username'];
$password = $_POST['password'];

if  ($username=="admin" and $password=="SuPeRpAsSwOrD31337") {
    $_SESSION['signed_in'] = true;
    $_SESSION['username'] = $username;
    $host  = $_SERVER['HTTP_HOST'];
    $uri   = rtrim(dirname($_SERVER['PHP_SELF']), '/\\');
    $extra = 'mysecretpage.php';
    header("Location: http://$host$uri/$extra");
} else {
    $_SESSION['flash_error'] = "Invalid username or password";
    $_SESSION['signed_in'] = false;
    $_SESSION['username'] = null;
    readfile('templates/index.html');
    echo "<h3 class='form-signin-heading'>Bad username or password</h3>";
}