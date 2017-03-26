3DNUS: 3DS CDN firmware downloader, modified to work via Mono.

This is a modification of 3DNUS Mod ( from https://github.com/zoltx23/3DNUS ).
It is made to run in Linux without Wine, via the Mono framework. It should also
successfully run on Mac OS X via Mono, although there you will need to compile
your own `make_cdn_cia` binaries (probably `make_cdn_cia64` on a modern
install). Linux Intel binaries are included because I have a system to compile
them from, as is a Windows 32-bit x86 binary (which will also work on x86_64).


To make your own `make_cdn_cia` binaries you'll need a development environment
(such as xcode) for the development headers, and GNU Make (I'd recommend just
installing it via macports/fink/brew, though it's been a while since I used
OS X for anything serious). You can get the source code for it here:
https://github.com/Tiger21820/ctr_toolkit

If you make any OS X binaries, make a pull request and let me know, I'd be
happy to include your binaries if I can confirm that they aren't malicious.

To build *this program* in mono on linux, run the `xbuild` command in the
`3DNUS` directory to create debug builds, or `xbuild /p:Configuration=Release`
for a release build. The binaries will go in `3DNUS/bin/Debug/` or
`3DNUS/bin/Release`.
