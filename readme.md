This is a file format for fonts

It is not meant for practical use on windows

However, it is certainly possible

The editor can go up to 128x, 256x and beyond, however it would be very slow. It could be remastered and work fine, however this is really meant for 16x/32x only.

The file format is in binary. A bit with the value of 1 is a pixel, and a bit with the value of 0 is background/empty.

i.e a 8x format 'A' :

11111111
10000001
11111111
10000001
10000001
10000001
10000001
10000001

(It is so simple, that you can write files in this format by hand, as long as you can convert it to hexadecimal/binary somehow and write to file)

The same format applies for 16x, 32x and 64x. The difference is that on 16x for example, there are 2 bytes per line and there are 16 lines (hence 16x).

This is one character in this format, and there are a suggested 92x characters in a file (A-Z, a-z, 0-9, +general symbols/punctuation). There is an additional byte at the start, which is a header. 
The header is simply an indicator of which size the file is. 00000000 indicates 8x, 00000011 indicates 16x, 00001111 indicates 32x and 00111111 indicates 64x.

Unlimited characters (well, up to 65535) can be supported, and using the provided class library, you can select any index to get the character. It is a very flexible library, relatively lightweight, and EXTREMELY simple.
