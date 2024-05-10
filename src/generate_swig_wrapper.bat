
setlocal enableextensions
mkdir java\\swig
mkdir csharp\\swig
mkdir python\\swig

mkdir cpp\\java
mkdir cpp\\csharp
mkdir cpp\\python
endlocal

swig -c++ -java -package Effekseer.swig -o cpp/java/dll2.cpp -outdir java/swig/ EffekseerCore2.i
swig -c++ -java -package Effekseer.swig -o cpp/java/dll.cpp -outdir java/swig/ EffekseerCore.i
swig -c++ -csharp -namespace Effekseer.swig -o cpp/csharp/dll2.cpp -outdir csharp/swig/ -dllimport EffekseerNativeForCSharp EffekseerCore2.i
swig -c++ -csharp -namespace Effekseer.swig -o cpp/csharp/dll.cpp -outdir csharp/swig/ -dllimport EffekseerNativeForCSharp EffekseerCore.i
swig -c++ -python -o cpp/python/dll2.cpp -outdir python/swig/ EffekseerCore2.i
swig -c++ -python -o cpp/python/dll.cpp -outdir python/swig/ EffekseerCore.i
