====ABOUT====
This is a modification of 3DNUS Mod ( from https://github.com/zoltx23/3DNUS ).
It is made to run in Linux without Wine, via the Mono framework.

Note that on a fresh install of Debian, I had to install
`libmono-system-windows-forms4.0-cil` for the app to run properly.
Installing the `mono-complete` package would probably also accomplish this.

====BUILDING====
To build this program in mono on linux, run the `xbuild` command in the
`3DNUS` directory to create debug builds, or `xbuild /p:Configuration=Release`
for a release build.

The binaries will go in `3DNUS/bin/Debug/` or `3DNUS/bin/Release`.

====NOTE TO OS X USERS:====
It should also successfully run on Mac OS X via Mono, although you will
need to compile your own `make_cdn_cia` binaries (probably `make_cdn_cia64` on
a modern install). Linux Intel binaries are included because I have a system to
compile them from, as is a Windows 32-bit x86 binary (which will also work on
x86_64).

As of 31 July 2017, I have compiled a Mac OS X binary that *SHOULD* work on
32-bit or 64-bit Intel-based systems running at least OS X 10.5 (Leopard).
I have only been able to test it in 10.8 (Mountain Lion), however, so if you
encounter trouble you may need to compile your own anyway.

To make the provided binary work correctly, you also need to rename
`make_cdn_cia_osx` to `make_cdn_cia64`, replacing the existing file, and also
potentially make a copy called `make_cdn_cia32`, depending on if you have a
64-bit mac or not. This is required because I HAVE NOT PROPERLY TESTED ANYTHING
IN OS X, and as such have not written any code to make 3DNUS differentiate
between OS X & Linux systems - which is actually kind of tricky to do in C#
from the looks of it (both identify as POSIX-type operating systems).
This effectively replaces the linux binaries with OS X ones, which the system
will happily execute.

====TO COMPILE make_cdn_cia IN OS X====
To make your own `make_cdn_cia` binaries you'll need a development environment
(such as xcode) for the development headers, and GNU Make (I'd recommend just
installing it via macports/fink/brew, though it's been a while since I used
OS X for anything serious). You can get the source code for it here:
https://github.com/Tiger21820/ctr_toolkit

You also need to edit types.h, comment out all the endianness definitions, and
replace every `BIG_ENDIAN`, `LITTLE_ENDIAN`, `BE`, and `LE` in all the source
files, so that they become:

original       new
BIG_ENDIAN     0
LITTLE_ENDIAN  1
BE             0
LE             1

Apparently this is because something or another is already defined in OS X,
but there's probably a simpler fix than this. I just couldn't be bothered to
figure it out when this solved the issue, too.

I also changed the Makefile so that it included the flags:
-arch i386 -arch x86_64 -mmacosx-version-min=10.5

This makes GCC/clang compile a "fat" binary that has 32-bit and 64-bit versions
of the program in a single file for simplicity. It also theoretically should
make the program run on any version OS X at or above Leopard (on Intel CPUs),
but this is entirely untested at present. My binary works for sure in
10.8 (Mountain Lion).
