#!/usr/bin/env perl
#==============================================================================
#
#         FILE: brute.pl
#
#        USAGE: ./brute.pl ciphertext
#
#  DESCRIPTION: 200_caesar brute-force solver
#
#      OPTIONS: ---
# REQUIREMENTS: ---
#         BUGS: ---
#        NOTES: ---
#       AUTHOR: Vladislav A. Retivykh (var), firolunis@riseup.net
# ORGANIZATION: keva
#      VERSION: 0.1
#      CREATED: 08/23/2015 04:16:08 PM
#     REVISION: ---
#==============================================================================

use strict;
use warnings FATAL => 'all';
use utf8;

sub main {
    my $ciphertext = shift or return 1;
    my $a_code = ord('a');
    my $abc_size = ord('z') - $a_code + 1;
    for (my $i = 0; $i < $abc_size; ++$i) {
        print "$i: ";
        foreach my $char (split //, $ciphertext) {
            print chr($a_code + (ord($char) - $a_code + $i) % $abc_size);
        }
        print "\n";
    }
    return 0;
}

exit main(shift) unless caller;

