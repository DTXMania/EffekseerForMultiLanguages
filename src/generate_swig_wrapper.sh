#!/bin/sh
mkdir -p java/swig
mkdir -p csharp/swig
mkdir -p python/swig

mkdir -p cpp/java
mkdir -p cpp/csharp
mkdir -p cpp/python

swig -c++ -java -package Effekseer.swig -o cpp/java/dll2.cpp -outdir java/swig/ EffekseerCore2.i
swig -c++ -java -package Effekseer.swig -o cpp/java/dll.cpp -outdir java/swig/ EffekseerCore.i
swig -c++ -csharp -namespace Effekseer.swig -o cpp/csharp/dll2.cpp -outdir csharp/swig/ -dllimport EffekseerNativeForCSharp EffekseerCore2.i
swig -c++ -csharp -namespace Effekseer.swig -o cpp/csharp/dll.cpp -outdir csharp/swig/ -dllimport EffekseerNativeForCSharp EffekseerCore.i
swig -c++ -python -o cpp/python/dll2.cpp -outdir python/swig/ EffekseerCore2.i
swig -c++ -python -o cpp/python/dll.cpp -outdir python/swig/ EffekseerCore.i
