#!/usr/bin/perl

sub commandline() {
    my $args = $ARGV;

    print $args;
}

BEGIN {

}

END {

}

print "command line input";
print @ARGV;

commandline();