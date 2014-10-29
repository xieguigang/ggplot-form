#!/usr/bin/perl

package My::ConsoleSize;

sub new {
    my $class = shift;
    my $self = {
        $row    => shift, 
        $col    => shift, 
        $xpixel => shift, 
        $ypixel => shift
    };

    bless $self, $class;
    return $self;
}

sub get_nrows {
    my( $self ) = @_;
    return $self->{row};
}

sub get_ncols {
    my( $self ) = @_;
    return $self->{col};
}

sub get_pixel_size {
    my( $self ) = @_;
    return ($self->{xpixel}, $self->{ypixel});
}

sub get_word_size {
    my( $self ) = @_;
    return ($self->{row}, $self->{col});
}

1;