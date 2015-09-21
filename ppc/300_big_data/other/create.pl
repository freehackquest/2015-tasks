#!/usr/bin/env perl
#==============================================================================
#
#         FILE: create.pl
#
#        USAGE: ./create.pl
#
#  DESCRIPTION: 300_big_data creator
#
#      OPTIONS: ---
# REQUIREMENTS: ---
#         BUGS: ---
#        NOTES: ---
#       AUTHOR: Vladislav A. Retivykh (var), firolunis@riseup.net
# ORGANIZATION: keva
#      VERSION: 0.1
#      CREATED: 08/29/2015 11:55:29 PM
#     REVISION: ---
#==============================================================================

use strict;
use warnings FATAL => 'all';
use utf8;

use MIME::Base64;
use List::Util qw(shuffle);
use bignum;

my $flag = 'flagisBIGdataIScool!';

sub main {
    my $b64_flag = encode_base64($flag);
    my @long_flag;
    my @nums;
    my $tmp;
    foreach my $char (split //, $b64_flag) {
        push @long_flag, sprintf "%08b", ord $char;
    }
    for (my $i = 0; $i < scalar(@long_flag); ++$i) {
        $tmp = $long_flag[$i] * 100000000**(scalar(@long_flag)-$i-1);
        push @nums, $tmp;
    }
    for (my $i = 1; $i < 1000000; ++$i) {
        push @nums, $i;
        push @nums, -$i;
    }
    @nums = shuffle @nums;
    foreach my $num (@nums) {
        if ($num > 0) {
            print "+$num ";
        } else {
            print "$num ";
        }
    }
    return 0;
}

main(@ARGV) unless caller;
