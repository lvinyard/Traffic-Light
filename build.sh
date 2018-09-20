#!/bin/bash

echo First remove old binary files
rm *.dll
rm *.exe

echo View the list of source files
ls -l

mcs -target:library -r:System.Drawing -r:System.Windows.Forms -out:ui.dll ui.cs
mcs -r:System -r:System.Windows.Forms -r:System.Drawing  -r:ui.dll -out:Assign1.exe driver.cs

./Assign1.exe

echo Remove old binary files
rm *.dll
rm *.exe