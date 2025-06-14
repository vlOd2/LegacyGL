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

// Bindings generated at 2025-06-12 15:04:13.728718
namespace LegacyGL.Bindings;

[GLFeature(false)]
public static unsafe class GL13
{
    #region Enums
    public const int GL_TEXTURE0 = 0x84C0;
    public const int GL_TEXTURE1 = 0x84C1;
    public const int GL_TEXTURE2 = 0x84C2;
    public const int GL_TEXTURE3 = 0x84C3;
    public const int GL_TEXTURE4 = 0x84C4;
    public const int GL_TEXTURE5 = 0x84C5;
    public const int GL_TEXTURE6 = 0x84C6;
    public const int GL_TEXTURE7 = 0x84C7;
    public const int GL_TEXTURE8 = 0x84C8;
    public const int GL_TEXTURE9 = 0x84C9;
    public const int GL_TEXTURE10 = 0x84CA;
    public const int GL_TEXTURE11 = 0x84CB;
    public const int GL_TEXTURE12 = 0x84CC;
    public const int GL_TEXTURE13 = 0x84CD;
    public const int GL_TEXTURE14 = 0x84CE;
    public const int GL_TEXTURE15 = 0x84CF;
    public const int GL_TEXTURE16 = 0x84D0;
    public const int GL_TEXTURE17 = 0x84D1;
    public const int GL_TEXTURE18 = 0x84D2;
    public const int GL_TEXTURE19 = 0x84D3;
    public const int GL_TEXTURE20 = 0x84D4;
    public const int GL_TEXTURE21 = 0x84D5;
    public const int GL_TEXTURE22 = 0x84D6;
    public const int GL_TEXTURE23 = 0x84D7;
    public const int GL_TEXTURE24 = 0x84D8;
    public const int GL_TEXTURE25 = 0x84D9;
    public const int GL_TEXTURE26 = 0x84DA;
    public const int GL_TEXTURE27 = 0x84DB;
    public const int GL_TEXTURE28 = 0x84DC;
    public const int GL_TEXTURE29 = 0x84DD;
    public const int GL_TEXTURE30 = 0x84DE;
    public const int GL_TEXTURE31 = 0x84DF;
    public const int GL_ACTIVE_TEXTURE = 0x84E0;
    public const int GL_MULTISAMPLE = 0x809D;
    public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
    public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
    public const int GL_SAMPLE_COVERAGE = 0x80A0;
    public const int GL_SAMPLE_BUFFERS = 0x80A8;
    public const int GL_SAMPLES = 0x80A9;
    public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
    public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
    public const int GL_TEXTURE_CUBE_MAP = 0x8513;
    public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
    public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
    public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
    public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
    public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
    public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
    public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
    public const int GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
    public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
    public const int GL_COMPRESSED_RGB = 0x84ED;
    public const int GL_COMPRESSED_RGBA = 0x84EE;
    public const int GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
    public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
    public const int GL_TEXTURE_COMPRESSED = 0x86A1;
    public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
    public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
    public const int GL_CLAMP_TO_BORDER = 0x812D;
    public const int GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
    public const int GL_MAX_TEXTURE_UNITS = 0x84E2;
    public const int GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
    public const int GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
    public const int GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
    public const int GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
    public const int GL_MULTISAMPLE_BIT = 0x20000000;
    public const int GL_NORMAL_MAP = 0x8511;
    public const int GL_REFLECTION_MAP = 0x8512;
    public const int GL_COMPRESSED_ALPHA = 0x84E9;
    public const int GL_COMPRESSED_LUMINANCE = 0x84EA;
    public const int GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
    public const int GL_COMPRESSED_INTENSITY = 0x84EC;
    public const int GL_COMBINE = 0x8570;
    public const int GL_COMBINE_RGB = 0x8571;
    public const int GL_COMBINE_ALPHA = 0x8572;
    public const int GL_SOURCE0_RGB = 0x8580;
    public const int GL_SOURCE1_RGB = 0x8581;
    public const int GL_SOURCE2_RGB = 0x8582;
    public const int GL_SOURCE0_ALPHA = 0x8588;
    public const int GL_SOURCE1_ALPHA = 0x8589;
    public const int GL_SOURCE2_ALPHA = 0x858A;
    public const int GL_OPERAND0_RGB = 0x8590;
    public const int GL_OPERAND1_RGB = 0x8591;
    public const int GL_OPERAND2_RGB = 0x8592;
    public const int GL_OPERAND0_ALPHA = 0x8598;
    public const int GL_OPERAND1_ALPHA = 0x8599;
    public const int GL_OPERAND2_ALPHA = 0x859A;
    public const int GL_RGB_SCALE = 0x8573;
    public const int GL_ADD_SIGNED = 0x8574;
    public const int GL_INTERPOLATE = 0x8575;
    public const int GL_SUBTRACT = 0x84E7;
    public const int GL_CONSTANT = 0x8576;
    public const int GL_PRIMARY_COLOR = 0x8577;
    public const int GL_PREVIOUS = 0x8578;
    public const int GL_DOT3_RGB = 0x86AE;
    public const int GL_DOT3_RGBA = 0x86AF;
    #endregion
    
    #region Commands
    public static void glActiveTexture(uint texture) => _glActiveTexture(texture);
    [LGLNativeAPI("glActiveTexture")] internal static delegate* unmanaged<uint, void> _glActiveTexture = null;
    
    public static void glSampleCoverage(float value, bool invert) => _glSampleCoverage(value, invert);
    [LGLNativeAPI("glSampleCoverage")] internal static delegate* unmanaged<float, bool, void> _glSampleCoverage = null;
    
    public static void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) => _glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
    [LGLNativeAPI("glCompressedTexImage3D")] internal static delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void> _glCompressedTexImage3D = null;
    
    public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) => _glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
    [LGLNativeAPI("glCompressedTexImage2D")] internal static delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void> _glCompressedTexImage2D = null;
    
    public static void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data) => _glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
    [LGLNativeAPI("glCompressedTexImage1D")] internal static delegate* unmanaged<uint, int, uint, int, int, int, void*, void> _glCompressedTexImage1D = null;
    
    public static void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) => _glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
    [LGLNativeAPI("glCompressedTexSubImage3D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void> _glCompressedTexSubImage3D = null;
    
    public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) => _glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
    [LGLNativeAPI("glCompressedTexSubImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void> _glCompressedTexSubImage2D = null;
    
    public static void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data) => _glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
    [LGLNativeAPI("glCompressedTexSubImage1D")] internal static delegate* unmanaged<uint, int, int, int, uint, int, void*, void> _glCompressedTexSubImage1D = null;
    
    public static void glGetCompressedTexImage(uint target, int level, void* img) => _glGetCompressedTexImage(target, level, img);
    [LGLNativeAPI("glGetCompressedTexImage")] internal static delegate* unmanaged<uint, int, void*, void> _glGetCompressedTexImage = null;
    
    public static void glClientActiveTexture(uint texture) => _glClientActiveTexture(texture);
    [LGLNativeAPI("glClientActiveTexture")] internal static delegate* unmanaged<uint, void> _glClientActiveTexture = null;
    
    public static void glMultiTexCoord1d(uint target, double s) => _glMultiTexCoord1d(target, s);
    [LGLNativeAPI("glMultiTexCoord1d")] internal static delegate* unmanaged<uint, double, void> _glMultiTexCoord1d = null;
    
    public static void glMultiTexCoord1dv(uint target, double* v) => _glMultiTexCoord1dv(target, v);
    [LGLNativeAPI("glMultiTexCoord1dv")] internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord1dv = null;
    
    public static void glMultiTexCoord1f(uint target, float s) => _glMultiTexCoord1f(target, s);
    [LGLNativeAPI("glMultiTexCoord1f")] internal static delegate* unmanaged<uint, float, void> _glMultiTexCoord1f = null;
    
    public static void glMultiTexCoord1fv(uint target, float* v) => _glMultiTexCoord1fv(target, v);
    [LGLNativeAPI("glMultiTexCoord1fv")] internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord1fv = null;
    
    public static void glMultiTexCoord1i(uint target, int s) => _glMultiTexCoord1i(target, s);
    [LGLNativeAPI("glMultiTexCoord1i")] internal static delegate* unmanaged<uint, int, void> _glMultiTexCoord1i = null;
    
    public static void glMultiTexCoord1iv(uint target, int* v) => _glMultiTexCoord1iv(target, v);
    [LGLNativeAPI("glMultiTexCoord1iv")] internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord1iv = null;
    
    public static void glMultiTexCoord1s(uint target, short s) => _glMultiTexCoord1s(target, s);
    [LGLNativeAPI("glMultiTexCoord1s")] internal static delegate* unmanaged<uint, short, void> _glMultiTexCoord1s = null;
    
    public static void glMultiTexCoord1sv(uint target, short* v) => _glMultiTexCoord1sv(target, v);
    [LGLNativeAPI("glMultiTexCoord1sv")] internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord1sv = null;
    
    public static void glMultiTexCoord2d(uint target, double s, double t) => _glMultiTexCoord2d(target, s, t);
    [LGLNativeAPI("glMultiTexCoord2d")] internal static delegate* unmanaged<uint, double, double, void> _glMultiTexCoord2d = null;
    
    public static void glMultiTexCoord2dv(uint target, double* v) => _glMultiTexCoord2dv(target, v);
    [LGLNativeAPI("glMultiTexCoord2dv")] internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord2dv = null;
    
    public static void glMultiTexCoord2f(uint target, float s, float t) => _glMultiTexCoord2f(target, s, t);
    [LGLNativeAPI("glMultiTexCoord2f")] internal static delegate* unmanaged<uint, float, float, void> _glMultiTexCoord2f = null;
    
    public static void glMultiTexCoord2fv(uint target, float* v) => _glMultiTexCoord2fv(target, v);
    [LGLNativeAPI("glMultiTexCoord2fv")] internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord2fv = null;
    
    public static void glMultiTexCoord2i(uint target, int s, int t) => _glMultiTexCoord2i(target, s, t);
    [LGLNativeAPI("glMultiTexCoord2i")] internal static delegate* unmanaged<uint, int, int, void> _glMultiTexCoord2i = null;
    
    public static void glMultiTexCoord2iv(uint target, int* v) => _glMultiTexCoord2iv(target, v);
    [LGLNativeAPI("glMultiTexCoord2iv")] internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord2iv = null;
    
    public static void glMultiTexCoord2s(uint target, short s, short t) => _glMultiTexCoord2s(target, s, t);
    [LGLNativeAPI("glMultiTexCoord2s")] internal static delegate* unmanaged<uint, short, short, void> _glMultiTexCoord2s = null;
    
    public static void glMultiTexCoord2sv(uint target, short* v) => _glMultiTexCoord2sv(target, v);
    [LGLNativeAPI("glMultiTexCoord2sv")] internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord2sv = null;
    
    public static void glMultiTexCoord3d(uint target, double s, double t, double r) => _glMultiTexCoord3d(target, s, t, r);
    [LGLNativeAPI("glMultiTexCoord3d")] internal static delegate* unmanaged<uint, double, double, double, void> _glMultiTexCoord3d = null;
    
    public static void glMultiTexCoord3dv(uint target, double* v) => _glMultiTexCoord3dv(target, v);
    [LGLNativeAPI("glMultiTexCoord3dv")] internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord3dv = null;
    
    public static void glMultiTexCoord3f(uint target, float s, float t, float r) => _glMultiTexCoord3f(target, s, t, r);
    [LGLNativeAPI("glMultiTexCoord3f")] internal static delegate* unmanaged<uint, float, float, float, void> _glMultiTexCoord3f = null;
    
    public static void glMultiTexCoord3fv(uint target, float* v) => _glMultiTexCoord3fv(target, v);
    [LGLNativeAPI("glMultiTexCoord3fv")] internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord3fv = null;
    
    public static void glMultiTexCoord3i(uint target, int s, int t, int r) => _glMultiTexCoord3i(target, s, t, r);
    [LGLNativeAPI("glMultiTexCoord3i")] internal static delegate* unmanaged<uint, int, int, int, void> _glMultiTexCoord3i = null;
    
    public static void glMultiTexCoord3iv(uint target, int* v) => _glMultiTexCoord3iv(target, v);
    [LGLNativeAPI("glMultiTexCoord3iv")] internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord3iv = null;
    
    public static void glMultiTexCoord3s(uint target, short s, short t, short r) => _glMultiTexCoord3s(target, s, t, r);
    [LGLNativeAPI("glMultiTexCoord3s")] internal static delegate* unmanaged<uint, short, short, short, void> _glMultiTexCoord3s = null;
    
    public static void glMultiTexCoord3sv(uint target, short* v) => _glMultiTexCoord3sv(target, v);
    [LGLNativeAPI("glMultiTexCoord3sv")] internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord3sv = null;
    
    public static void glMultiTexCoord4d(uint target, double s, double t, double r, double q) => _glMultiTexCoord4d(target, s, t, r, q);
    [LGLNativeAPI("glMultiTexCoord4d")] internal static delegate* unmanaged<uint, double, double, double, double, void> _glMultiTexCoord4d = null;
    
    public static void glMultiTexCoord4dv(uint target, double* v) => _glMultiTexCoord4dv(target, v);
    [LGLNativeAPI("glMultiTexCoord4dv")] internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord4dv = null;
    
    public static void glMultiTexCoord4f(uint target, float s, float t, float r, float q) => _glMultiTexCoord4f(target, s, t, r, q);
    [LGLNativeAPI("glMultiTexCoord4f")] internal static delegate* unmanaged<uint, float, float, float, float, void> _glMultiTexCoord4f = null;
    
    public static void glMultiTexCoord4fv(uint target, float* v) => _glMultiTexCoord4fv(target, v);
    [LGLNativeAPI("glMultiTexCoord4fv")] internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord4fv = null;
    
    public static void glMultiTexCoord4i(uint target, int s, int t, int r, int q) => _glMultiTexCoord4i(target, s, t, r, q);
    [LGLNativeAPI("glMultiTexCoord4i")] internal static delegate* unmanaged<uint, int, int, int, int, void> _glMultiTexCoord4i = null;
    
    public static void glMultiTexCoord4iv(uint target, int* v) => _glMultiTexCoord4iv(target, v);
    [LGLNativeAPI("glMultiTexCoord4iv")] internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord4iv = null;
    
    public static void glMultiTexCoord4s(uint target, short s, short t, short r, short q) => _glMultiTexCoord4s(target, s, t, r, q);
    [LGLNativeAPI("glMultiTexCoord4s")] internal static delegate* unmanaged<uint, short, short, short, short, void> _glMultiTexCoord4s = null;
    
    public static void glMultiTexCoord4sv(uint target, short* v) => _glMultiTexCoord4sv(target, v);
    [LGLNativeAPI("glMultiTexCoord4sv")] internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord4sv = null;
    
    public static void glLoadTransposeMatrixf(float* m) => _glLoadTransposeMatrixf(m);
    [LGLNativeAPI("glLoadTransposeMatrixf")] internal static delegate* unmanaged<float*, void> _glLoadTransposeMatrixf = null;
    
    public static void glLoadTransposeMatrixd(double* m) => _glLoadTransposeMatrixd(m);
    [LGLNativeAPI("glLoadTransposeMatrixd")] internal static delegate* unmanaged<double*, void> _glLoadTransposeMatrixd = null;
    
    public static void glMultTransposeMatrixf(float* m) => _glMultTransposeMatrixf(m);
    [LGLNativeAPI("glMultTransposeMatrixf")] internal static delegate* unmanaged<float*, void> _glMultTransposeMatrixf = null;
    
    public static void glMultTransposeMatrixd(double* m) => _glMultTransposeMatrixd(m);
    [LGLNativeAPI("glMultTransposeMatrixd")] internal static delegate* unmanaged<double*, void> _glMultTransposeMatrixd = null;
     #endregion
}
