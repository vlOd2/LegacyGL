// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Numerics;
using static LegacyGL.OpenGL.GL;

namespace LegacyGL.OpenGL
{
    // Not actual GLU
    public unsafe static class GLU
    {
        public static void ExportMatrix(uint name, out Matrix4x4 result)
        {
            float[] matrix = new float[4 * 4];
            fixed (float* ptr = matrix)
                glGetFloatv(name, ptr);
            result = new Matrix4x4(
                matrix[0], matrix[4], matrix[8], matrix[12],
                matrix[1], matrix[5], matrix[9], matrix[13],
                matrix[2], matrix[6], matrix[10], matrix[14],
                matrix[3], matrix[7], matrix[11], matrix[15]
            );
        }

        public static string ErrorString(uint errorCode)
        {
            switch (errorCode)
            {
                case GL_NO_ERROR:
                    return "No error";
                case GL_INVALID_ENUM:
                    return "Invalid enum";
                case GL_INVALID_VALUE:
                    return "Invalid value";
                case GL_INVALID_OPERATION:
                    return "Invalid operation";
                case GL_STACK_OVERFLOW:
                    return "Stack overflow";
                case GL_STACK_UNDERFLOW:
                    return "Stack underflow";
                case GL_OUT_OF_MEMORY:
                    return "Out of memory";
                default:
                    return "";
            }
        }
    }
}