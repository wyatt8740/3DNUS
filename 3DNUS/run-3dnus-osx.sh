#! /bin/bash
# Tested in OS X 10.8. In OS X, Mono 64-bit does not have working
# Windows Forms. So we need to specify the 32-bit version of the Mono runtime.
mono --arch=32 ./3DNUS.exe
