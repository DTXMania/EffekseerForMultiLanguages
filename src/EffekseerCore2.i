%module EffekseerCore2

%{

#include <Effekseer.h>
typedef Effekseer::Matrix43 Matrix43;
typedef Effekseer::Matrix44 Matrix44;

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

%nodefaultdtor Matrix43;
%nodefaultdtor Matrix44;
typedef struct {} Matrix43;
typedef struct {} Matrix44;
%ignore Matrix43;
%ignore Matrix44;

%include "cpp/Effekseer/Dev/Cpp/Effekseer/Effekseer/Effekseer.Vector3D.h"
