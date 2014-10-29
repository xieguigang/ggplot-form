#!/usr/bin/perl

package My::Console;

use My::ConsoleSize;

sub new {
    my $class = shift;
    my $self = {        
    };

    bless $self, $class;
    return $self;
}

# try to get console information for formatted print 
# of the array in perl script
sub getSize {
    require 'sys/ioctl.ph';
    
    die "no TIOCGWINSZ" unless defined &TIOCGWINSZ;

    open(TTY, "+</dev/tty") or die "No tty: $!";
    unless (ioctl(TTY, &TIOCGWINSZ, $winsize='')) {
        die sprintf "$0: ioctl TIOCGWINSZ (%08x: $!)\n", &TIOCGWINSZ;
    }

    ($row, $col, $xpixel, $ypixel) = unpack('S4', $winsize);
    
    return new My::ConsoleSize($row, $col, $xpixel, $ypixel);
}

# 2014-10-27 The 1; at the bottom causes eval to evaluate to TRUE (and thus not fail)
1;

__END__

=head1 this is a module for console operation
=cut
