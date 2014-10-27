#!/usr/bin/perl

package Console;

sub new {

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
    
    return new ConsoleSize($row, $col, $xpixel, $ypixel);
}

1;

__END__

=head1 this is a module for console operation
=cut
