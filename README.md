## EffekseerForMultiLanguages

Effekseer for C#, Java and Python

### Requirements
- git
- python
- C++ compiler
- cmake (3.15 or later)
- swig
- JDK (If you develop it for JVM)
- ant (If you develop it for JVM)

### Build

```
git clone https://github.com/DTXMania/EffekseerForMultiLanguages.git
cd EffekseerForMultiLanguages
git submodule update --init --recursive
```

#### Windows

```
cd src
generate_swig_wrapper.bat
cd ..
cmake -B build -S .
```

After cmake completes, open build/EffekseerForMultiLanguages.sln in Visual Studio, and build EffekseerNativeForCSharp/Java/Python project.


#### Mac, Linux

```
cd src
sh generate_swig_wrapper.sh
cd ..
cmake -B build -S .
```

## How to use

### C#

Add the following files to your project.
* EffekseerNativeForCSharp.dll
* src/csharp/swig/*.cs

please see examples/CSharpFormDX11 solution.

### libGDX sample

please see examples

#### Windows

call ```python examples/build_libGtxSample.py ```

## How to Develop

### TODO

https://github.com/effekseer/EffekseerForMultiLanguages/issues

### Requeiments

- swig

### Reference

https://github.com/effekseer/EffekseerForWebGL/blob/master/src/cpp/main.cpp
