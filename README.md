# 3DNUS

## ABOUT

This is a modification of [3DNUS Mod](https://github.com/zoltx23/3DNUS).
It has been modified to run on **all** platforms with
[CIL](https://www.mono-project.com/) implementations that include WinForms,
rather than just on Windows with the MS .NET framework. (This essentially means
[Mono](https://www.mono-project.com/) is supported). It is still compatible
with the original Microsoft .NET framework as well.

As such, it should work in Linux, most BSD's, Mac OS, and Windows. It is also
much, much smaller than the version it is derived from, on account of having
many aesthetic niceties ripped out and not playing music in the background.

Note that on a fresh install of Debian, I had to install
`libmono-system-windows-forms4.0-cil` for the app to run properly.
Installing the `mono-complete` package would probably also accomplish this.

## USAGE

* Find your desired firmware version name from [here](https://yls8.mtheall.com/ninupdates/reports.php).

  * Example: if you want 10.7, find it in the list. It's listed as `10.7.0-32`.
  
* Add your region code to the name (example for USA: `10.7.0-32U`.

* Enter it into the text input field, choose your system, and click the
download button.

Note that there's some weird firmware versions that break the parser
in the original 3DNUS. To get around that, I'm doing something silly, as was
the author of the fork I forked this from.

* If you want `08-18-16_TWN_BeginScanning`, ask for `11.0.0-33T`. I don't know
if that's its actual name, but I had to call it something to not break the
parser, unless I wanted to rewrite it. Since this program is just a
hack of a hack, I didn't bother.

* If you want `N/A` (another actual firmware name), ask for `11.3.0-36T`.
Again, no idea if that's its real name, but I'm guessing based on the
release date and just trying to make the thing build.

* Looks like the guy I forked this code from also was using similar techniques.
`02-11-15_GPIO` -> `9.5.0-22`, and `10-02-14 JPN` is `9.1.0-20J`.

## BUILDING

To build this program in mono on linux, run the `xbuild` (or `msbuild`, if you
have it) command in the `3DNUS` directory to create debug builds, or
`xbuild /p:Configuration=Release` for a release build. In Debian, `xbuild` is
currently installed in the package `mono-xbuild`.

The binaries will go in `3DNUS/bin/Debug` or `3DNUS/bin/Release`.

To build it initially, I had to install the following packages in Debian:

`mono-devel mono-xbuild libmono-microsoft-csharp4.0-cil
libmono-system-deployment4.0-cil libmono-system-data-datasetextensions4.0-cil`

Just installing `mono-complete` and `mono-devel` should also work, although
it means installing possibly more libraries than you need.

##### Note:

You also will need `make-cdn-cia` for your system in order to successfully
use this program. I have included a few binaries that I compiled myself inside
the `3DNUS/` directory for common platforms.
The original program is included in
[CTR_Toolkit](https://github.com/Tiger21820/ctr_toolkit).

#### NOTES FOR OS X USERS:
You may have to invoke the program with:
```
mono --arch=32 3DNUS.exe
```
Forcing 32-bit is necessary *in older mono releases* because Mono's winforms
implementation was tied to a few 32-bit only API's. Apparently, that is no
longer true as of 2019.

As of 31 July 2017, I have compiled a Mac OS X binary that *SHOULD* work on
32-bit or 64-bit Intel-based systems running at least OS X 10.5 (Leopard).
I have only been able to test it in 10.8 (Mountain Lion), however, so if you
encounter trouble you may need to compile your own anyway.

***To make the provided binary work correctly***, you also need to rename
`make_cdn_cia_osx` to `make_cdn_cia64`, replacing the existing file, and also
potentially make a copy called `make_cdn_cia32`, depending on if you have a
64-bit mac or not. This is required because I have not written any code to
identify Mac OS as distinct from Linux or other Unix systems - which is
actually kind of tricky to do in C#, apparently (All identify as POSIX-type
operating systems).
This effectively replaces the linux binaries with OS X ones, which the system
will happily execute.

If your system will not run my binary, you will have to compile make_cdn_cia
yourself. Read on in that case.

#### TO COMPILE `make_cdn_cia` IN OS X
Note that my git repo includes pre-built binaries, so hopefully this won't be
necessary for you.

To make your own `make_cdn_cia` binaries you'll need a development environment
(such as xcode) for the development headers, and GNU Make (I'd recommend just
installing it via macports/fink/brew, though it's been a while since I used
OS X for anything serious). You can get the source code for it
[here](https://github.com/Tiger21820/ctr_toolkit).

You also need to edit `types.h`, comment out all the endianness definitions,
and replace every `BIG_ENDIAN`, `LITTLE_ENDIAN`, `BE`, and `LE` in all the
source files, so that they become:
```
original       new
BIG_ENDIAN     0
LITTLE_ENDIAN  1
BE             0
LE             1
```
Apparently, this is because something or another is already defined in OS X,
but there's probably a simpler fix than this. I just couldn't be bothered to
figure it out when this solved the issue, too.

I also changed the `Makefile` so that it included the flags:
```
-arch i386 -arch x86_64 -mmacosx-version-min=10.5
```
This makes GCC/clang compile a "fat" binary that has 32-bit and 64-bit versions
of the program in a single file for simplicity and portability. It also
theoretically should make the program run on any version OS X at or above
Leopard (on Intel CPUs), but this is entirely untested at present. My binary
works for sure in 10.8 (Mountain Lion).
