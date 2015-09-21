<?php
session_start();
if (!$_SESSION['signed_in']) {
    $_SESSION['flash_error'] = "Please sign in";
    readfile('templates/403.html');
    exit;
}else{
    readfile('templates/f1agnothere.html');
    }
