#!/usr/bin/perl

use lib 'lib';

use My::Console;

# nice print module for perl

my $console = new My::Console();

my $n = $console->getSize()->get_nrows();

print "test: $n\n";