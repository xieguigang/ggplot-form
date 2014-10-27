#!/usr/bin/perl

require "./lib/console.pm";

# nice print module for perl

my $console = new Console();

print $console->getSize()->get_nrows();