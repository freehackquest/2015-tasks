#!/usr/bin/env perl
#==============================================================================
#
#         FILE: solve.pl
#
#        USAGE: ./solve.pl ppc300
#
#  DESCRIPTION: 300_big_data solver
#
#      OPTIONS: ---
# REQUIREMENTS: ---
#         BUGS: ---
#        NOTES: ---
#       AUTHOR: Vladislav A. Retivykh (var), firolunis@riseup.net
# ORGANIZATION: keva
#      VERSION: 0.1
#      CREATED: 08/30/2015 01:27:07 AM
#     REVISION: ---
#==============================================================================

use strict;
use warnings FATAL => 'all';
use utf8;

use MIME::Base64;
use bignum;

sub main {
    my $filename = shift or die 'Error: no file';
    open(my $fh, "<", "$filename") or die "Cannot open < $filename: $!";
    local $/ = ' ';
    my $long_flag=0;
    while (<$fh>) {
        $long_flag += $_;
    }
    close($fh);
    $long_flag = "0$long_flag";
    my @bytes = split(/(\d{8})/, $long_flag);
    my $b64_flag = '';
    for (my $i = 1; $i < scalar(@bytes); $i += 2) {
        $b64_flag .= chr(oct("0b".$bytes[$i]));
    }
    print decode_base64($b64_flag);
    return 0;
}

main(@ARGV) unless caller;
