<?php

session_start();

$username = $_POST['username'];
$password = $_POST['password'];

if  ($username=="admin" and $password=="SuPeRpAsSwOrD31337") {
    $_SESSION['signed_in'] = true;
    $_SESSION['username'] = $username;
    header("Location: /fhq/phps_backdoor/mysecretpage.php");
} else {
    $_SESSION['flash_error'] = "Invalid username or password";
    $_SESSION['signed_in'] = false;
    $_SESSION['username'] = null;
    readfile('templates/index.html');
    echo "<h3 class='form-signin-heading'>Bad username or password</h3>";
}