// MIT License
// 
// Copyright (c) 2025 vlOd
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using LegacyGL.Internal;

// Bindings generated at 2025-06-12 15:04:13.733696
namespace LegacyGL.Bindings;

[GLFeature(false)]
public static unsafe class GL20
{
    #region Enums
    public const int GL_BLEND_EQUATION_RGB = 0x8009;
    public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
    public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
    public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
    public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
    public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;
    public const int GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642;
    public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
    public const int GL_STENCIL_BACK_FUNC = 0x8800;
    public const int GL_STENCIL_BACK_FAIL = 0x8801;
    public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
    public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
    public const int GL_MAX_DRAW_BUFFERS = 0x8824;
    public const int GL_DRAW_BUFFER0 = 0x8825;
    public const int GL_DRAW_BUFFER1 = 0x8826;
    public const int GL_DRAW_BUFFER2 = 0x8827;
    public const int GL_DRAW_BUFFER3 = 0x8828;
    public const int GL_DRAW_BUFFER4 = 0x8829;
    public const int GL_DRAW_BUFFER5 = 0x882A;
    public const int GL_DRAW_BUFFER6 = 0x882B;
    public const int GL_DRAW_BUFFER7 = 0x882C;
    public const int GL_DRAW_BUFFER8 = 0x882D;
    public const int GL_DRAW_BUFFER9 = 0x882E;
    public const int GL_DRAW_BUFFER10 = 0x882F;
    public const int GL_DRAW_BUFFER11 = 0x8830;
    public const int GL_DRAW_BUFFER12 = 0x8831;
    public const int GL_DRAW_BUFFER13 = 0x8832;
    public const int GL_DRAW_BUFFER14 = 0x8833;
    public const int GL_DRAW_BUFFER15 = 0x8834;
    public const int GL_BLEND_EQUATION_ALPHA = 0x883D;
    public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;
    public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
    public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
    public const int GL_FRAGMENT_SHADER = 0x8B30;
    public const int GL_VERTEX_SHADER = 0x8B31;
    public const int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
    public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
    public const int GL_MAX_VARYING_FLOATS = 0x8B4B;
    public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
    public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
    public const int GL_SHADER_TYPE = 0x8B4F;
    public const int GL_FLOAT_VEC2 = 0x8B50;
    public const int GL_FLOAT_VEC3 = 0x8B51;
    public const int GL_FLOAT_VEC4 = 0x8B52;
    public const int GL_INT_VEC2 = 0x8B53;
    public const int GL_INT_VEC3 = 0x8B54;
    public const int GL_INT_VEC4 = 0x8B55;
    public const int GL_BOOL = 0x8B56;
    public const int GL_BOOL_VEC2 = 0x8B57;
    public const int GL_BOOL_VEC3 = 0x8B58;
    public const int GL_BOOL_VEC4 = 0x8B59;
    public const int GL_FLOAT_MAT2 = 0x8B5A;
    public const int GL_FLOAT_MAT3 = 0x8B5B;
    public const int GL_FLOAT_MAT4 = 0x8B5C;
    public const int GL_SAMPLER_1D = 0x8B5D;
    public const int GL_SAMPLER_2D = 0x8B5E;
    public const int GL_SAMPLER_3D = 0x8B5F;
    public const int GL_SAMPLER_CUBE = 0x8B60;
    public const int GL_SAMPLER_1D_SHADOW = 0x8B61;
    public const int GL_SAMPLER_2D_SHADOW = 0x8B62;
    public const int GL_DELETE_STATUS = 0x8B80;
    public const int GL_COMPILE_STATUS = 0x8B81;
    public const int GL_LINK_STATUS = 0x8B82;
    public const int GL_VALIDATE_STATUS = 0x8B83;
    public const int GL_INFO_LOG_LENGTH = 0x8B84;
    public const int GL_ATTACHED_SHADERS = 0x8B85;
    public const int GL_ACTIVE_UNIFORMS = 0x8B86;
    public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
    public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;
    public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;
    public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
    public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
    public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
    public const int GL_CURRENT_PROGRAM = 0x8B8D;
    public const int GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
    public const int GL_LOWER_LEFT = 0x8CA1;
    public const int GL_UPPER_LEFT = 0x8CA2;
    public const int GL_STENCIL_BACK_REF = 0x8CA3;
    public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
    public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
    public const int GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643;
    public const int GL_POINT_SPRITE = 0x8861;
    public const int GL_COORD_REPLACE = 0x8862;
    public const int GL_MAX_TEXTURE_COORDS = 0x8871;
    #endregion
    
    #region Commands
    public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha) => _glBlendEquationSeparate(modeRGB, modeAlpha);
    [LGLNativeAPI("glBlendEquationSeparate")] internal static delegate* unmanaged<uint, uint, void> _glBlendEquationSeparate = null;
    
    public static void glDrawBuffers(int n, uint* bufs) => _glDrawBuffers(n, bufs);
    [LGLNativeAPI("glDrawBuffers")] internal static delegate* unmanaged<int, uint*, void> _glDrawBuffers = null;
    
    public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) => _glStencilOpSeparate(face, sfail, dpfail, dppass);
    [LGLNativeAPI("glStencilOpSeparate")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glStencilOpSeparate = null;
    
    public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask) => _glStencilFuncSeparate(face, func, @ref, mask);
    [LGLNativeAPI("glStencilFuncSeparate")] internal static delegate* unmanaged<uint, uint, int, uint, void> _glStencilFuncSeparate = null;
    
    public static void glStencilMaskSeparate(uint face, uint mask) => _glStencilMaskSeparate(face, mask);
    [LGLNativeAPI("glStencilMaskSeparate")] internal static delegate* unmanaged<uint, uint, void> _glStencilMaskSeparate = null;
    
    public static void glAttachShader(uint program, uint shader) => _glAttachShader(program, shader);
    [LGLNativeAPI("glAttachShader")] internal static delegate* unmanaged<uint, uint, void> _glAttachShader = null;
    
    public static void glBindAttribLocation(uint program, uint index, byte* name) => _glBindAttribLocation(program, index, name);
    [LGLNativeAPI("glBindAttribLocation")] internal static delegate* unmanaged<uint, uint, byte*, void> _glBindAttribLocation = null;
    
    public static void glCompileShader(uint shader) => _glCompileShader(shader);
    [LGLNativeAPI("glCompileShader")] internal static delegate* unmanaged<uint, void> _glCompileShader = null;
    
    public static uint glCreateProgram() => _glCreateProgram();
    [LGLNativeAPI("glCreateProgram")] internal static delegate* unmanaged<uint> _glCreateProgram = null;
    
    public static uint glCreateShader(uint type) => _glCreateShader(type);
    [LGLNativeAPI("glCreateShader")] internal static delegate* unmanaged<uint, uint> _glCreateShader = null;
    
    public static void glDeleteProgram(uint program) => _glDeleteProgram(program);
    [LGLNativeAPI("glDeleteProgram")] internal static delegate* unmanaged<uint, void> _glDeleteProgram = null;
    
    public static void glDeleteShader(uint shader) => _glDeleteShader(shader);
    [LGLNativeAPI("glDeleteShader")] internal static delegate* unmanaged<uint, void> _glDeleteShader = null;
    
    public static void glDetachShader(uint program, uint shader) => _glDetachShader(program, shader);
    [LGLNativeAPI("glDetachShader")] internal static delegate* unmanaged<uint, uint, void> _glDetachShader = null;
    
    public static void glDisableVertexAttribArray(uint index) => _glDisableVertexAttribArray(index);
    [LGLNativeAPI("glDisableVertexAttribArray")] internal static delegate* unmanaged<uint, void> _glDisableVertexAttribArray = null;
    
    public static void glEnableVertexAttribArray(uint index) => _glEnableVertexAttribArray(index);
    [LGLNativeAPI("glEnableVertexAttribArray")] internal static delegate* unmanaged<uint, void> _glEnableVertexAttribArray = null;
    
    public static void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name) => _glGetActiveAttrib(program, index, bufSize, length, size, type, name);
    [LGLNativeAPI("glGetActiveAttrib")] internal static delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveAttrib = null;
    
    public static void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name) => _glGetActiveUniform(program, index, bufSize, length, size, type, name);
    [LGLNativeAPI("glGetActiveUniform")] internal static delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveUniform = null;
    
    public static void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) => _glGetAttachedShaders(program, maxCount, count, shaders);
    [LGLNativeAPI("glGetAttachedShaders")] internal static delegate* unmanaged<uint, int, int*, uint*, void> _glGetAttachedShaders = null;
    
    public static int glGetAttribLocation(uint program, byte* name) => _glGetAttribLocation(program, name);
    [LGLNativeAPI("glGetAttribLocation")] internal static delegate* unmanaged<uint, byte*, int> _glGetAttribLocation = null;
    
    public static void glGetProgramiv(uint program, uint pname, int* @params) => _glGetProgramiv(program, pname, @params);
    [LGLNativeAPI("glGetProgramiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetProgramiv = null;
    
    public static void glGetProgramInfoLog(uint program, int bufSize, int* length, byte* infoLog) => _glGetProgramInfoLog(program, bufSize, length, infoLog);
    [LGLNativeAPI("glGetProgramInfoLog")] internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetProgramInfoLog = null;
    
    public static void glGetShaderiv(uint shader, uint pname, int* @params) => _glGetShaderiv(shader, pname, @params);
    [LGLNativeAPI("glGetShaderiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetShaderiv = null;
    
    public static void glGetShaderInfoLog(uint shader, int bufSize, int* length, byte* infoLog) => _glGetShaderInfoLog(shader, bufSize, length, infoLog);
    [LGLNativeAPI("glGetShaderInfoLog")] internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetShaderInfoLog = null;
    
    public static void glGetShaderSource(uint shader, int bufSize, int* length, byte* source) => _glGetShaderSource(shader, bufSize, length, source);
    [LGLNativeAPI("glGetShaderSource")] internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetShaderSource = null;
    
    public static int glGetUniformLocation(uint program, byte* name) => _glGetUniformLocation(program, name);
    [LGLNativeAPI("glGetUniformLocation")] internal static delegate* unmanaged<uint, byte*, int> _glGetUniformLocation = null;
    
    public static void glGetUniformfv(uint program, int location, float* @params) => _glGetUniformfv(program, location, @params);
    [LGLNativeAPI("glGetUniformfv")] internal static delegate* unmanaged<uint, int, float*, void> _glGetUniformfv = null;
    
    public static void glGetUniformiv(uint program, int location, int* @params) => _glGetUniformiv(program, location, @params);
    [LGLNativeAPI("glGetUniformiv")] internal static delegate* unmanaged<uint, int, int*, void> _glGetUniformiv = null;
    
    public static void glGetVertexAttribdv(uint index, uint pname, double* @params) => _glGetVertexAttribdv(index, pname, @params);
    [LGLNativeAPI("glGetVertexAttribdv")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetVertexAttribdv = null;
    
    public static void glGetVertexAttribfv(uint index, uint pname, float* @params) => _glGetVertexAttribfv(index, pname, @params);
    [LGLNativeAPI("glGetVertexAttribfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetVertexAttribfv = null;
    
    public static void glGetVertexAttribiv(uint index, uint pname, int* @params) => _glGetVertexAttribiv(index, pname, @params);
    [LGLNativeAPI("glGetVertexAttribiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribiv = null;
    
    public static void glGetVertexAttribPointerv(uint index, uint pname, void** pointer) => _glGetVertexAttribPointerv(index, pname, pointer);
    [LGLNativeAPI("glGetVertexAttribPointerv")] internal static delegate* unmanaged<uint, uint, void**, void> _glGetVertexAttribPointerv = null;
    
    public static bool glIsProgram(uint program) => _glIsProgram(program);
    [LGLNativeAPI("glIsProgram")] internal static delegate* unmanaged<uint, bool> _glIsProgram = null;
    
    public static bool glIsShader(uint shader) => _glIsShader(shader);
    [LGLNativeAPI("glIsShader")] internal static delegate* unmanaged<uint, bool> _glIsShader = null;
    
    public static void glLinkProgram(uint program) => _glLinkProgram(program);
    [LGLNativeAPI("glLinkProgram")] internal static delegate* unmanaged<uint, void> _glLinkProgram = null;
    
    public static void glShaderSource(uint shader, int count, byte** @string, int* length) => _glShaderSource(shader, count, @string, length);
    [LGLNativeAPI("glShaderSource")] internal static delegate* unmanaged<uint, int, byte**, int*, void> _glShaderSource = null;
    
    public static void glUseProgram(uint program) => _glUseProgram(program);
    [LGLNativeAPI("glUseProgram")] internal static delegate* unmanaged<uint, void> _glUseProgram = null;
    
    public static void glUniform1f(int location, float v0) => _glUniform1f(location, v0);
    [LGLNativeAPI("glUniform1f")] internal static delegate* unmanaged<int, float, void> _glUniform1f = null;
    
    public static void glUniform2f(int location, float v0, float v1) => _glUniform2f(location, v0, v1);
    [LGLNativeAPI("glUniform2f")] internal static delegate* unmanaged<int, float, float, void> _glUniform2f = null;
    
    public static void glUniform3f(int location, float v0, float v1, float v2) => _glUniform3f(location, v0, v1, v2);
    [LGLNativeAPI("glUniform3f")] internal static delegate* unmanaged<int, float, float, float, void> _glUniform3f = null;
    
    public static void glUniform4f(int location, float v0, float v1, float v2, float v3) => _glUniform4f(location, v0, v1, v2, v3);
    [LGLNativeAPI("glUniform4f")] internal static delegate* unmanaged<int, float, float, float, float, void> _glUniform4f = null;
    
    public static void glUniform1i(int location, int v0) => _glUniform1i(location, v0);
    [LGLNativeAPI("glUniform1i")] internal static delegate* unmanaged<int, int, void> _glUniform1i = null;
    
    public static void glUniform2i(int location, int v0, int v1) => _glUniform2i(location, v0, v1);
    [LGLNativeAPI("glUniform2i")] internal static delegate* unmanaged<int, int, int, void> _glUniform2i = null;
    
    public static void glUniform3i(int location, int v0, int v1, int v2) => _glUniform3i(location, v0, v1, v2);
    [LGLNativeAPI("glUniform3i")] internal static delegate* unmanaged<int, int, int, int, void> _glUniform3i = null;
    
    public static void glUniform4i(int location, int v0, int v1, int v2, int v3) => _glUniform4i(location, v0, v1, v2, v3);
    [LGLNativeAPI("glUniform4i")] internal static delegate* unmanaged<int, int, int, int, int, void> _glUniform4i = null;
    
    public static void glUniform1fv(int location, int count, float* value) => _glUniform1fv(location, count, value);
    [LGLNativeAPI("glUniform1fv")] internal static delegate* unmanaged<int, int, float*, void> _glUniform1fv = null;
    
    public static void glUniform2fv(int location, int count, float* value) => _glUniform2fv(location, count, value);
    [LGLNativeAPI("glUniform2fv")] internal static delegate* unmanaged<int, int, float*, void> _glUniform2fv = null;
    
    public static void glUniform3fv(int location, int count, float* value) => _glUniform3fv(location, count, value);
    [LGLNativeAPI("glUniform3fv")] internal static delegate* unmanaged<int, int, float*, void> _glUniform3fv = null;
    
    public static void glUniform4fv(int location, int count, float* value) => _glUniform4fv(location, count, value);
    [LGLNativeAPI("glUniform4fv")] internal static delegate* unmanaged<int, int, float*, void> _glUniform4fv = null;
    
    public static void glUniform1iv(int location, int count, int* value) => _glUniform1iv(location, count, value);
    [LGLNativeAPI("glUniform1iv")] internal static delegate* unmanaged<int, int, int*, void> _glUniform1iv = null;
    
    public static void glUniform2iv(int location, int count, int* value) => _glUniform2iv(location, count, value);
    [LGLNativeAPI("glUniform2iv")] internal static delegate* unmanaged<int, int, int*, void> _glUniform2iv = null;
    
    public static void glUniform3iv(int location, int count, int* value) => _glUniform3iv(location, count, value);
    [LGLNativeAPI("glUniform3iv")] internal static delegate* unmanaged<int, int, int*, void> _glUniform3iv = null;
    
    public static void glUniform4iv(int location, int count, int* value) => _glUniform4iv(location, count, value);
    [LGLNativeAPI("glUniform4iv")] internal static delegate* unmanaged<int, int, int*, void> _glUniform4iv = null;
    
    public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value) => _glUniformMatrix2fv(location, count, transpose, value);
    [LGLNativeAPI("glUniformMatrix2fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix2fv = null;
    
    public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value) => _glUniformMatrix3fv(location, count, transpose, value);
    [LGLNativeAPI("glUniformMatrix3fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix3fv = null;
    
    public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value) => _glUniformMatrix4fv(location, count, transpose, value);
    [LGLNativeAPI("glUniformMatrix4fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix4fv = null;
    
    public static void glValidateProgram(uint program) => _glValidateProgram(program);
    [LGLNativeAPI("glValidateProgram")] internal static delegate* unmanaged<uint, void> _glValidateProgram = null;
    
    public static void glVertexAttrib1d(uint index, double x) => _glVertexAttrib1d(index, x);
    [LGLNativeAPI("glVertexAttrib1d")] internal static delegate* unmanaged<uint, double, void> _glVertexAttrib1d = null;
    
    public static void glVertexAttrib1dv(uint index, double* v) => _glVertexAttrib1dv(index, v);
    [LGLNativeAPI("glVertexAttrib1dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib1dv = null;
    
    public static void glVertexAttrib1f(uint index, float x) => _glVertexAttrib1f(index, x);
    [LGLNativeAPI("glVertexAttrib1f")] internal static delegate* unmanaged<uint, float, void> _glVertexAttrib1f = null;
    
    public static void glVertexAttrib1fv(uint index, float* v) => _glVertexAttrib1fv(index, v);
    [LGLNativeAPI("glVertexAttrib1fv")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib1fv = null;
    
    public static void glVertexAttrib1s(uint index, short x) => _glVertexAttrib1s(index, x);
    [LGLNativeAPI("glVertexAttrib1s")] internal static delegate* unmanaged<uint, short, void> _glVertexAttrib1s = null;
    
    public static void glVertexAttrib1sv(uint index, short* v) => _glVertexAttrib1sv(index, v);
    [LGLNativeAPI("glVertexAttrib1sv")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib1sv = null;
    
    public static void glVertexAttrib2d(uint index, double x, double y) => _glVertexAttrib2d(index, x, y);
    [LGLNativeAPI("glVertexAttrib2d")] internal static delegate* unmanaged<uint, double, double, void> _glVertexAttrib2d = null;
    
    public static void glVertexAttrib2dv(uint index, double* v) => _glVertexAttrib2dv(index, v);
    [LGLNativeAPI("glVertexAttrib2dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib2dv = null;
    
    public static void glVertexAttrib2f(uint index, float x, float y) => _glVertexAttrib2f(index, x, y);
    [LGLNativeAPI("glVertexAttrib2f")] internal static delegate* unmanaged<uint, float, float, void> _glVertexAttrib2f = null;
    
    public static void glVertexAttrib2fv(uint index, float* v) => _glVertexAttrib2fv(index, v);
    [LGLNativeAPI("glVertexAttrib2fv")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib2fv = null;
    
    public static void glVertexAttrib2s(uint index, short x, short y) => _glVertexAttrib2s(index, x, y);
    [LGLNativeAPI("glVertexAttrib2s")] internal static delegate* unmanaged<uint, short, short, void> _glVertexAttrib2s = null;
    
    public static void glVertexAttrib2sv(uint index, short* v) => _glVertexAttrib2sv(index, v);
    [LGLNativeAPI("glVertexAttrib2sv")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib2sv = null;
    
    public static void glVertexAttrib3d(uint index, double x, double y, double z) => _glVertexAttrib3d(index, x, y, z);
    [LGLNativeAPI("glVertexAttrib3d")] internal static delegate* unmanaged<uint, double, double, double, void> _glVertexAttrib3d = null;
    
    public static void glVertexAttrib3dv(uint index, double* v) => _glVertexAttrib3dv(index, v);
    [LGLNativeAPI("glVertexAttrib3dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib3dv = null;
    
    public static void glVertexAttrib3f(uint index, float x, float y, float z) => _glVertexAttrib3f(index, x, y, z);
    [LGLNativeAPI("glVertexAttrib3f")] internal static delegate* unmanaged<uint, float, float, float, void> _glVertexAttrib3f = null;
    
    public static void glVertexAttrib3fv(uint index, float* v) => _glVertexAttrib3fv(index, v);
    [LGLNativeAPI("glVertexAttrib3fv")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib3fv = null;
    
    public static void glVertexAttrib3s(uint index, short x, short y, short z) => _glVertexAttrib3s(index, x, y, z);
    [LGLNativeAPI("glVertexAttrib3s")] internal static delegate* unmanaged<uint, short, short, short, void> _glVertexAttrib3s = null;
    
    public static void glVertexAttrib3sv(uint index, short* v) => _glVertexAttrib3sv(index, v);
    [LGLNativeAPI("glVertexAttrib3sv")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib3sv = null;
    
    public static void glVertexAttrib4Nbv(uint index, sbyte* v) => _glVertexAttrib4Nbv(index, v);
    [LGLNativeAPI("glVertexAttrib4Nbv")] internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4Nbv = null;
    
    public static void glVertexAttrib4Niv(uint index, int* v) => _glVertexAttrib4Niv(index, v);
    [LGLNativeAPI("glVertexAttrib4Niv")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4Niv = null;
    
    public static void glVertexAttrib4Nsv(uint index, short* v) => _glVertexAttrib4Nsv(index, v);
    [LGLNativeAPI("glVertexAttrib4Nsv")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4Nsv = null;
    
    public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) => _glVertexAttrib4Nub(index, x, y, z, w);
    [LGLNativeAPI("glVertexAttrib4Nub")] internal static delegate* unmanaged<uint, byte, byte, byte, byte, void> _glVertexAttrib4Nub = null;
    
    public static void glVertexAttrib4Nubv(uint index, byte* v) => _glVertexAttrib4Nubv(index, v);
    [LGLNativeAPI("glVertexAttrib4Nubv")] internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4Nubv = null;
    
    public static void glVertexAttrib4Nuiv(uint index, uint* v) => _glVertexAttrib4Nuiv(index, v);
    [LGLNativeAPI("glVertexAttrib4Nuiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4Nuiv = null;
    
    public static void glVertexAttrib4Nusv(uint index, ushort* v) => _glVertexAttrib4Nusv(index, v);
    [LGLNativeAPI("glVertexAttrib4Nusv")] internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4Nusv = null;
    
    public static void glVertexAttrib4bv(uint index, sbyte* v) => _glVertexAttrib4bv(index, v);
    [LGLNativeAPI("glVertexAttrib4bv")] internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4bv = null;
    
    public static void glVertexAttrib4d(uint index, double x, double y, double z, double w) => _glVertexAttrib4d(index, x, y, z, w);
    [LGLNativeAPI("glVertexAttrib4d")] internal static delegate* unmanaged<uint, double, double, double, double, void> _glVertexAttrib4d = null;
    
    public static void glVertexAttrib4dv(uint index, double* v) => _glVertexAttrib4dv(index, v);
    [LGLNativeAPI("glVertexAttrib4dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib4dv = null;
    
    public static void glVertexAttrib4f(uint index, float x, float y, float z, float w) => _glVertexAttrib4f(index, x, y, z, w);
    [LGLNativeAPI("glVertexAttrib4f")] internal static delegate* unmanaged<uint, float, float, float, float, void> _glVertexAttrib4f = null;
    
    public static void glVertexAttrib4fv(uint index, float* v) => _glVertexAttrib4fv(index, v);
    [LGLNativeAPI("glVertexAttrib4fv")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib4fv = null;
    
    public static void glVertexAttrib4iv(uint index, int* v) => _glVertexAttrib4iv(index, v);
    [LGLNativeAPI("glVertexAttrib4iv")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4iv = null;
    
    public static void glVertexAttrib4s(uint index, short x, short y, short z, short w) => _glVertexAttrib4s(index, x, y, z, w);
    [LGLNativeAPI("glVertexAttrib4s")] internal static delegate* unmanaged<uint, short, short, short, short, void> _glVertexAttrib4s = null;
    
    public static void glVertexAttrib4sv(uint index, short* v) => _glVertexAttrib4sv(index, v);
    [LGLNativeAPI("glVertexAttrib4sv")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4sv = null;
    
    public static void glVertexAttrib4ubv(uint index, byte* v) => _glVertexAttrib4ubv(index, v);
    [LGLNativeAPI("glVertexAttrib4ubv")] internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4ubv = null;
    
    public static void glVertexAttrib4uiv(uint index, uint* v) => _glVertexAttrib4uiv(index, v);
    [LGLNativeAPI("glVertexAttrib4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4uiv = null;
    
    public static void glVertexAttrib4usv(uint index, ushort* v) => _glVertexAttrib4usv(index, v);
    [LGLNativeAPI("glVertexAttrib4usv")] internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4usv = null;
    
    public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer) => _glVertexAttribPointer(index, size, type, normalized, stride, pointer);
    [LGLNativeAPI("glVertexAttribPointer")] internal static delegate* unmanaged<uint, int, uint, bool, int, void*, void> _glVertexAttribPointer = null;
     #endregion
}
