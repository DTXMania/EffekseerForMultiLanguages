%module EffekseerCore

%{

#include "../Core/EffekseerBackendCore.h"
#include "../Core/EffekseerEffectCore.h"
#include "../Core/EffekseerManagerCore.h"

%}

%include "stdint.i"

#if SWIGJAVA
%include "swig/Lib/java/char16.i"
%include various.i
%apply char *BYTE { char* data };
#endif

#if SWIGCSHARP
%include "swig/Lib/csharp/char16.i"
%include "arrays_csharp.i"

%apply void* VOID_INT_PTR { void* }
%apply unsigned char INPUT[] { const unsigned char* data };
#endif


#ifdef SWIGPYTHON
%begin %{
#define SWIG_PYTHON_STRICT_BYTE_CHAR
%}
%include "swig/Lib/python/char16.i"
 #endif

%include "cpp/Core/EffekseerBackendCore.h"
%include "cpp/Core/EffekseerEffectCore.h"
%include "cpp/Core/EffekseerManagerCore.h"

enum D3D11_COMPARISON_FUNC {
  D3D11_COMPARISON_NEVER = 1,
  D3D11_COMPARISON_LESS = 2,
  D3D11_COMPARISON_EQUAL = 3,
  D3D11_COMPARISON_LESS_EQUAL = 4,
  D3D11_COMPARISON_GREATER = 5,
  D3D11_COMPARISON_NOT_EQUAL = 6,
  D3D11_COMPARISON_GREATER_EQUAL = 7,
  D3D11_COMPARISON_ALWAYS = 8
};
