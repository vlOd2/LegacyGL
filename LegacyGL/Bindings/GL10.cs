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

// Bindings generated at 2025-06-12 15:04:13.717985
namespace LegacyGL.Bindings;

[GLFeature(false)]
public static unsafe class GL10
{
    #region Enums
    public const int GL_DEPTH_BUFFER_BIT = 0x100;
    public const int GL_STENCIL_BUFFER_BIT = 0x400;
    public const int GL_COLOR_BUFFER_BIT = 0x4000;
    public const int GL_FALSE = 0x0;
    public const int GL_TRUE = 0x1;
    public const int GL_POINTS = 0x0;
    public const int GL_LINES = 0x1;
    public const int GL_LINE_LOOP = 0x2;
    public const int GL_LINE_STRIP = 0x3;
    public const int GL_TRIANGLES = 0x4;
    public const int GL_TRIANGLE_STRIP = 0x5;
    public const int GL_TRIANGLE_FAN = 0x6;
    public const int GL_QUADS = 0x7;
    public const int GL_NEVER = 0x200;
    public const int GL_LESS = 0x201;
    public const int GL_EQUAL = 0x202;
    public const int GL_LEQUAL = 0x203;
    public const int GL_GREATER = 0x204;
    public const int GL_NOTEQUAL = 0x205;
    public const int GL_GEQUAL = 0x206;
    public const int GL_ALWAYS = 0x207;
    public const int GL_ZERO = 0x0;
    public const int GL_ONE = 0x1;
    public const int GL_SRC_COLOR = 0x300;
    public const int GL_ONE_MINUS_SRC_COLOR = 0x301;
    public const int GL_SRC_ALPHA = 0x302;
    public const int GL_ONE_MINUS_SRC_ALPHA = 0x303;
    public const int GL_DST_ALPHA = 0x304;
    public const int GL_ONE_MINUS_DST_ALPHA = 0x305;
    public const int GL_DST_COLOR = 0x306;
    public const int GL_ONE_MINUS_DST_COLOR = 0x307;
    public const int GL_SRC_ALPHA_SATURATE = 0x308;
    public const int GL_NONE = 0x0;
    public const int GL_FRONT_LEFT = 0x400;
    public const int GL_FRONT_RIGHT = 0x401;
    public const int GL_BACK_LEFT = 0x402;
    public const int GL_BACK_RIGHT = 0x403;
    public const int GL_FRONT = 0x404;
    public const int GL_BACK = 0x405;
    public const int GL_LEFT = 0x406;
    public const int GL_RIGHT = 0x407;
    public const int GL_FRONT_AND_BACK = 0x408;
    public const int GL_NO_ERROR = 0x0;
    public const int GL_INVALID_ENUM = 0x500;
    public const int GL_INVALID_VALUE = 0x501;
    public const int GL_INVALID_OPERATION = 0x502;
    public const int GL_OUT_OF_MEMORY = 0x505;
    public const int GL_CW = 0x900;
    public const int GL_CCW = 0x901;
    public const int GL_POINT_SIZE = 0xB11;
    public const int GL_POINT_SIZE_RANGE = 0xB12;
    public const int GL_POINT_SIZE_GRANULARITY = 0xB13;
    public const int GL_LINE_SMOOTH = 0xB20;
    public const int GL_LINE_WIDTH = 0xB21;
    public const int GL_LINE_WIDTH_RANGE = 0xB22;
    public const int GL_LINE_WIDTH_GRANULARITY = 0xB23;
    public const int GL_POLYGON_MODE = 0xB40;
    public const int GL_POLYGON_SMOOTH = 0xB41;
    public const int GL_CULL_FACE = 0xB44;
    public const int GL_CULL_FACE_MODE = 0xB45;
    public const int GL_FRONT_FACE = 0xB46;
    public const int GL_DEPTH_RANGE = 0xB70;
    public const int GL_DEPTH_TEST = 0xB71;
    public const int GL_DEPTH_WRITEMASK = 0xB72;
    public const int GL_DEPTH_CLEAR_VALUE = 0xB73;
    public const int GL_DEPTH_FUNC = 0xB74;
    public const int GL_STENCIL_TEST = 0xB90;
    public const int GL_STENCIL_CLEAR_VALUE = 0xB91;
    public const int GL_STENCIL_FUNC = 0xB92;
    public const int GL_STENCIL_VALUE_MASK = 0xB93;
    public const int GL_STENCIL_FAIL = 0xB94;
    public const int GL_STENCIL_PASS_DEPTH_FAIL = 0xB95;
    public const int GL_STENCIL_PASS_DEPTH_PASS = 0xB96;
    public const int GL_STENCIL_REF = 0xB97;
    public const int GL_STENCIL_WRITEMASK = 0xB98;
    public const int GL_VIEWPORT = 0xBA2;
    public const int GL_DITHER = 0xBD0;
    public const int GL_BLEND_DST = 0xBE0;
    public const int GL_BLEND_SRC = 0xBE1;
    public const int GL_BLEND = 0xBE2;
    public const int GL_LOGIC_OP_MODE = 0xBF0;
    public const int GL_DRAW_BUFFER = 0xC01;
    public const int GL_READ_BUFFER = 0xC02;
    public const int GL_SCISSOR_BOX = 0xC10;
    public const int GL_SCISSOR_TEST = 0xC11;
    public const int GL_COLOR_CLEAR_VALUE = 0xC22;
    public const int GL_COLOR_WRITEMASK = 0xC23;
    public const int GL_DOUBLEBUFFER = 0xC32;
    public const int GL_STEREO = 0xC33;
    public const int GL_LINE_SMOOTH_HINT = 0xC52;
    public const int GL_POLYGON_SMOOTH_HINT = 0xC53;
    public const int GL_UNPACK_SWAP_BYTES = 0xCF0;
    public const int GL_UNPACK_LSB_FIRST = 0xCF1;
    public const int GL_UNPACK_ROW_LENGTH = 0xCF2;
    public const int GL_UNPACK_SKIP_ROWS = 0xCF3;
    public const int GL_UNPACK_SKIP_PIXELS = 0xCF4;
    public const int GL_UNPACK_ALIGNMENT = 0xCF5;
    public const int GL_PACK_SWAP_BYTES = 0xD00;
    public const int GL_PACK_LSB_FIRST = 0xD01;
    public const int GL_PACK_ROW_LENGTH = 0xD02;
    public const int GL_PACK_SKIP_ROWS = 0xD03;
    public const int GL_PACK_SKIP_PIXELS = 0xD04;
    public const int GL_PACK_ALIGNMENT = 0xD05;
    public const int GL_MAX_TEXTURE_SIZE = 0xD33;
    public const int GL_MAX_VIEWPORT_DIMS = 0xD3A;
    public const int GL_SUBPIXEL_BITS = 0xD50;
    public const int GL_TEXTURE_1D = 0xDE0;
    public const int GL_TEXTURE_2D = 0xDE1;
    public const int GL_TEXTURE_WIDTH = 0x1000;
    public const int GL_TEXTURE_HEIGHT = 0x1001;
    public const int GL_TEXTURE_BORDER_COLOR = 0x1004;
    public const int GL_DONT_CARE = 0x1100;
    public const int GL_FASTEST = 0x1101;
    public const int GL_NICEST = 0x1102;
    public const int GL_BYTE = 0x1400;
    public const int GL_UNSIGNED_BYTE = 0x1401;
    public const int GL_SHORT = 0x1402;
    public const int GL_UNSIGNED_SHORT = 0x1403;
    public const int GL_INT = 0x1404;
    public const int GL_UNSIGNED_INT = 0x1405;
    public const int GL_FLOAT = 0x1406;
    public const int GL_STACK_OVERFLOW = 0x503;
    public const int GL_STACK_UNDERFLOW = 0x504;
    public const int GL_CLEAR = 0x1500;
    public const int GL_AND = 0x1501;
    public const int GL_AND_REVERSE = 0x1502;
    public const int GL_COPY = 0x1503;
    public const int GL_AND_INVERTED = 0x1504;
    public const int GL_NOOP = 0x1505;
    public const int GL_XOR = 0x1506;
    public const int GL_OR = 0x1507;
    public const int GL_NOR = 0x1508;
    public const int GL_EQUIV = 0x1509;
    public const int GL_INVERT = 0x150A;
    public const int GL_OR_REVERSE = 0x150B;
    public const int GL_COPY_INVERTED = 0x150C;
    public const int GL_OR_INVERTED = 0x150D;
    public const int GL_NAND = 0x150E;
    public const int GL_SET = 0x150F;
    public const int GL_TEXTURE = 0x1702;
    public const int GL_COLOR = 0x1800;
    public const int GL_DEPTH = 0x1801;
    public const int GL_STENCIL = 0x1802;
    public const int GL_STENCIL_INDEX = 0x1901;
    public const int GL_DEPTH_COMPONENT = 0x1902;
    public const int GL_RED = 0x1903;
    public const int GL_GREEN = 0x1904;
    public const int GL_BLUE = 0x1905;
    public const int GL_ALPHA = 0x1906;
    public const int GL_RGB = 0x1907;
    public const int GL_RGBA = 0x1908;
    public const int GL_POINT = 0x1B00;
    public const int GL_LINE = 0x1B01;
    public const int GL_FILL = 0x1B02;
    public const int GL_KEEP = 0x1E00;
    public const int GL_REPLACE = 0x1E01;
    public const int GL_INCR = 0x1E02;
    public const int GL_DECR = 0x1E03;
    public const int GL_VENDOR = 0x1F00;
    public const int GL_RENDERER = 0x1F01;
    public const int GL_VERSION = 0x1F02;
    public const int GL_EXTENSIONS = 0x1F03;
    public const int GL_NEAREST = 0x2600;
    public const int GL_LINEAR = 0x2601;
    public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
    public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
    public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
    public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;
    public const int GL_TEXTURE_MAG_FILTER = 0x2800;
    public const int GL_TEXTURE_MIN_FILTER = 0x2801;
    public const int GL_TEXTURE_WRAP_S = 0x2802;
    public const int GL_TEXTURE_WRAP_T = 0x2803;
    public const int GL_REPEAT = 0x2901;
    public const int GL_CURRENT_BIT = 0x1;
    public const int GL_POINT_BIT = 0x2;
    public const int GL_LINE_BIT = 0x4;
    public const int GL_POLYGON_BIT = 0x8;
    public const int GL_POLYGON_STIPPLE_BIT = 0x10;
    public const int GL_PIXEL_MODE_BIT = 0x20;
    public const int GL_LIGHTING_BIT = 0x40;
    public const int GL_FOG_BIT = 0x80;
    public const int GL_ACCUM_BUFFER_BIT = 0x200;
    public const int GL_VIEWPORT_BIT = 0x800;
    public const int GL_TRANSFORM_BIT = 0x1000;
    public const int GL_ENABLE_BIT = 0x2000;
    public const int GL_HINT_BIT = 0x8000;
    public const int GL_EVAL_BIT = 0x10000;
    public const int GL_LIST_BIT = 0x20000;
    public const int GL_TEXTURE_BIT = 0x40000;
    public const int GL_SCISSOR_BIT = 0x80000;
    public const uint GL_ALL_ATTRIB_BITS = 0xFFFFFFFF;
    public const int GL_QUAD_STRIP = 0x8;
    public const int GL_POLYGON = 0x9;
    public const int GL_ACCUM = 0x100;
    public const int GL_LOAD = 0x101;
    public const int GL_RETURN = 0x102;
    public const int GL_MULT = 0x103;
    public const int GL_ADD = 0x104;
    public const int GL_AUX0 = 0x409;
    public const int GL_AUX1 = 0x40A;
    public const int GL_AUX2 = 0x40B;
    public const int GL_AUX3 = 0x40C;
    public const int GL_2D = 0x600;
    public const int GL_3D = 0x601;
    public const int GL_3D_COLOR = 0x602;
    public const int GL_3D_COLOR_TEXTURE = 0x603;
    public const int GL_4D_COLOR_TEXTURE = 0x604;
    public const int GL_PASS_THROUGH_TOKEN = 0x700;
    public const int GL_POINT_TOKEN = 0x701;
    public const int GL_LINE_TOKEN = 0x702;
    public const int GL_POLYGON_TOKEN = 0x703;
    public const int GL_BITMAP_TOKEN = 0x704;
    public const int GL_DRAW_PIXEL_TOKEN = 0x705;
    public const int GL_COPY_PIXEL_TOKEN = 0x706;
    public const int GL_LINE_RESET_TOKEN = 0x707;
    public const int GL_EXP = 0x800;
    public const int GL_EXP2 = 0x801;
    public const int GL_COEFF = 0xA00;
    public const int GL_ORDER = 0xA01;
    public const int GL_DOMAIN = 0xA02;
    public const int GL_PIXEL_MAP_I_TO_I = 0xC70;
    public const int GL_PIXEL_MAP_S_TO_S = 0xC71;
    public const int GL_PIXEL_MAP_I_TO_R = 0xC72;
    public const int GL_PIXEL_MAP_I_TO_G = 0xC73;
    public const int GL_PIXEL_MAP_I_TO_B = 0xC74;
    public const int GL_PIXEL_MAP_I_TO_A = 0xC75;
    public const int GL_PIXEL_MAP_R_TO_R = 0xC76;
    public const int GL_PIXEL_MAP_G_TO_G = 0xC77;
    public const int GL_PIXEL_MAP_B_TO_B = 0xC78;
    public const int GL_PIXEL_MAP_A_TO_A = 0xC79;
    public const int GL_CURRENT_COLOR = 0xB00;
    public const int GL_CURRENT_INDEX = 0xB01;
    public const int GL_CURRENT_NORMAL = 0xB02;
    public const int GL_CURRENT_TEXTURE_COORDS = 0xB03;
    public const int GL_CURRENT_RASTER_COLOR = 0xB04;
    public const int GL_CURRENT_RASTER_INDEX = 0xB05;
    public const int GL_CURRENT_RASTER_TEXTURE_COORDS = 0xB06;
    public const int GL_CURRENT_RASTER_POSITION = 0xB07;
    public const int GL_CURRENT_RASTER_POSITION_VALID = 0xB08;
    public const int GL_CURRENT_RASTER_DISTANCE = 0xB09;
    public const int GL_POINT_SMOOTH = 0xB10;
    public const int GL_LINE_STIPPLE = 0xB24;
    public const int GL_LINE_STIPPLE_PATTERN = 0xB25;
    public const int GL_LINE_STIPPLE_REPEAT = 0xB26;
    public const int GL_LIST_MODE = 0xB30;
    public const int GL_MAX_LIST_NESTING = 0xB31;
    public const int GL_LIST_BASE = 0xB32;
    public const int GL_LIST_INDEX = 0xB33;
    public const int GL_POLYGON_STIPPLE = 0xB42;
    public const int GL_EDGE_FLAG = 0xB43;
    public const int GL_LIGHTING = 0xB50;
    public const int GL_LIGHT_MODEL_LOCAL_VIEWER = 0xB51;
    public const int GL_LIGHT_MODEL_TWO_SIDE = 0xB52;
    public const int GL_LIGHT_MODEL_AMBIENT = 0xB53;
    public const int GL_SHADE_MODEL = 0xB54;
    public const int GL_COLOR_MATERIAL_FACE = 0xB55;
    public const int GL_COLOR_MATERIAL_PARAMETER = 0xB56;
    public const int GL_COLOR_MATERIAL = 0xB57;
    public const int GL_FOG = 0xB60;
    public const int GL_FOG_INDEX = 0xB61;
    public const int GL_FOG_DENSITY = 0xB62;
    public const int GL_FOG_START = 0xB63;
    public const int GL_FOG_END = 0xB64;
    public const int GL_FOG_MODE = 0xB65;
    public const int GL_FOG_COLOR = 0xB66;
    public const int GL_ACCUM_CLEAR_VALUE = 0xB80;
    public const int GL_MATRIX_MODE = 0xBA0;
    public const int GL_NORMALIZE = 0xBA1;
    public const int GL_MODELVIEW_STACK_DEPTH = 0xBA3;
    public const int GL_PROJECTION_STACK_DEPTH = 0xBA4;
    public const int GL_TEXTURE_STACK_DEPTH = 0xBA5;
    public const int GL_MODELVIEW_MATRIX = 0xBA6;
    public const int GL_PROJECTION_MATRIX = 0xBA7;
    public const int GL_TEXTURE_MATRIX = 0xBA8;
    public const int GL_ATTRIB_STACK_DEPTH = 0xBB0;
    public const int GL_ALPHA_TEST = 0xBC0;
    public const int GL_ALPHA_TEST_FUNC = 0xBC1;
    public const int GL_ALPHA_TEST_REF = 0xBC2;
    public const int GL_LOGIC_OP = 0xBF1;
    public const int GL_AUX_BUFFERS = 0xC00;
    public const int GL_INDEX_CLEAR_VALUE = 0xC20;
    public const int GL_INDEX_WRITEMASK = 0xC21;
    public const int GL_INDEX_MODE = 0xC30;
    public const int GL_RGBA_MODE = 0xC31;
    public const int GL_RENDER_MODE = 0xC40;
    public const int GL_PERSPECTIVE_CORRECTION_HINT = 0xC50;
    public const int GL_POINT_SMOOTH_HINT = 0xC51;
    public const int GL_FOG_HINT = 0xC54;
    public const int GL_TEXTURE_GEN_S = 0xC60;
    public const int GL_TEXTURE_GEN_T = 0xC61;
    public const int GL_TEXTURE_GEN_R = 0xC62;
    public const int GL_TEXTURE_GEN_Q = 0xC63;
    public const int GL_PIXEL_MAP_I_TO_I_SIZE = 0xCB0;
    public const int GL_PIXEL_MAP_S_TO_S_SIZE = 0xCB1;
    public const int GL_PIXEL_MAP_I_TO_R_SIZE = 0xCB2;
    public const int GL_PIXEL_MAP_I_TO_G_SIZE = 0xCB3;
    public const int GL_PIXEL_MAP_I_TO_B_SIZE = 0xCB4;
    public const int GL_PIXEL_MAP_I_TO_A_SIZE = 0xCB5;
    public const int GL_PIXEL_MAP_R_TO_R_SIZE = 0xCB6;
    public const int GL_PIXEL_MAP_G_TO_G_SIZE = 0xCB7;
    public const int GL_PIXEL_MAP_B_TO_B_SIZE = 0xCB8;
    public const int GL_PIXEL_MAP_A_TO_A_SIZE = 0xCB9;
    public const int GL_MAP_COLOR = 0xD10;
    public const int GL_MAP_STENCIL = 0xD11;
    public const int GL_INDEX_SHIFT = 0xD12;
    public const int GL_INDEX_OFFSET = 0xD13;
    public const int GL_RED_SCALE = 0xD14;
    public const int GL_RED_BIAS = 0xD15;
    public const int GL_ZOOM_X = 0xD16;
    public const int GL_ZOOM_Y = 0xD17;
    public const int GL_GREEN_SCALE = 0xD18;
    public const int GL_GREEN_BIAS = 0xD19;
    public const int GL_BLUE_SCALE = 0xD1A;
    public const int GL_BLUE_BIAS = 0xD1B;
    public const int GL_ALPHA_SCALE = 0xD1C;
    public const int GL_ALPHA_BIAS = 0xD1D;
    public const int GL_DEPTH_SCALE = 0xD1E;
    public const int GL_DEPTH_BIAS = 0xD1F;
    public const int GL_MAX_EVAL_ORDER = 0xD30;
    public const int GL_MAX_LIGHTS = 0xD31;
    public const int GL_MAX_CLIP_PLANES = 0xD32;
    public const int GL_MAX_PIXEL_MAP_TABLE = 0xD34;
    public const int GL_MAX_ATTRIB_STACK_DEPTH = 0xD35;
    public const int GL_MAX_MODELVIEW_STACK_DEPTH = 0xD36;
    public const int GL_MAX_NAME_STACK_DEPTH = 0xD37;
    public const int GL_MAX_PROJECTION_STACK_DEPTH = 0xD38;
    public const int GL_MAX_TEXTURE_STACK_DEPTH = 0xD39;
    public const int GL_INDEX_BITS = 0xD51;
    public const int GL_RED_BITS = 0xD52;
    public const int GL_GREEN_BITS = 0xD53;
    public const int GL_BLUE_BITS = 0xD54;
    public const int GL_ALPHA_BITS = 0xD55;
    public const int GL_DEPTH_BITS = 0xD56;
    public const int GL_STENCIL_BITS = 0xD57;
    public const int GL_ACCUM_RED_BITS = 0xD58;
    public const int GL_ACCUM_GREEN_BITS = 0xD59;
    public const int GL_ACCUM_BLUE_BITS = 0xD5A;
    public const int GL_ACCUM_ALPHA_BITS = 0xD5B;
    public const int GL_NAME_STACK_DEPTH = 0xD70;
    public const int GL_AUTO_NORMAL = 0xD80;
    public const int GL_MAP1_COLOR_4 = 0xD90;
    public const int GL_MAP1_INDEX = 0xD91;
    public const int GL_MAP1_NORMAL = 0xD92;
    public const int GL_MAP1_TEXTURE_COORD_1 = 0xD93;
    public const int GL_MAP1_TEXTURE_COORD_2 = 0xD94;
    public const int GL_MAP1_TEXTURE_COORD_3 = 0xD95;
    public const int GL_MAP1_TEXTURE_COORD_4 = 0xD96;
    public const int GL_MAP1_VERTEX_3 = 0xD97;
    public const int GL_MAP1_VERTEX_4 = 0xD98;
    public const int GL_MAP2_COLOR_4 = 0xDB0;
    public const int GL_MAP2_INDEX = 0xDB1;
    public const int GL_MAP2_NORMAL = 0xDB2;
    public const int GL_MAP2_TEXTURE_COORD_1 = 0xDB3;
    public const int GL_MAP2_TEXTURE_COORD_2 = 0xDB4;
    public const int GL_MAP2_TEXTURE_COORD_3 = 0xDB5;
    public const int GL_MAP2_TEXTURE_COORD_4 = 0xDB6;
    public const int GL_MAP2_VERTEX_3 = 0xDB7;
    public const int GL_MAP2_VERTEX_4 = 0xDB8;
    public const int GL_MAP1_GRID_DOMAIN = 0xDD0;
    public const int GL_MAP1_GRID_SEGMENTS = 0xDD1;
    public const int GL_MAP2_GRID_DOMAIN = 0xDD2;
    public const int GL_MAP2_GRID_SEGMENTS = 0xDD3;
    public const int GL_TEXTURE_COMPONENTS = 0x1003;
    public const int GL_TEXTURE_BORDER = 0x1005;
    public const int GL_AMBIENT = 0x1200;
    public const int GL_DIFFUSE = 0x1201;
    public const int GL_SPECULAR = 0x1202;
    public const int GL_POSITION = 0x1203;
    public const int GL_SPOT_DIRECTION = 0x1204;
    public const int GL_SPOT_EXPONENT = 0x1205;
    public const int GL_SPOT_CUTOFF = 0x1206;
    public const int GL_CONSTANT_ATTENUATION = 0x1207;
    public const int GL_LINEAR_ATTENUATION = 0x1208;
    public const int GL_QUADRATIC_ATTENUATION = 0x1209;
    public const int GL_COMPILE = 0x1300;
    public const int GL_COMPILE_AND_EXECUTE = 0x1301;
    public const int GL_2_BYTES = 0x1407;
    public const int GL_3_BYTES = 0x1408;
    public const int GL_4_BYTES = 0x1409;
    public const int GL_EMISSION = 0x1600;
    public const int GL_SHININESS = 0x1601;
    public const int GL_AMBIENT_AND_DIFFUSE = 0x1602;
    public const int GL_COLOR_INDEXES = 0x1603;
    public const int GL_MODELVIEW = 0x1700;
    public const int GL_PROJECTION = 0x1701;
    public const int GL_COLOR_INDEX = 0x1900;
    public const int GL_LUMINANCE = 0x1909;
    public const int GL_LUMINANCE_ALPHA = 0x190A;
    public const int GL_BITMAP = 0x1A00;
    public const int GL_RENDER = 0x1C00;
    public const int GL_FEEDBACK = 0x1C01;
    public const int GL_SELECT = 0x1C02;
    public const int GL_FLAT = 0x1D00;
    public const int GL_SMOOTH = 0x1D01;
    public const int GL_S = 0x2000;
    public const int GL_T = 0x2001;
    public const int GL_R = 0x2002;
    public const int GL_Q = 0x2003;
    public const int GL_MODULATE = 0x2100;
    public const int GL_DECAL = 0x2101;
    public const int GL_TEXTURE_ENV_MODE = 0x2200;
    public const int GL_TEXTURE_ENV_COLOR = 0x2201;
    public const int GL_TEXTURE_ENV = 0x2300;
    public const int GL_EYE_LINEAR = 0x2400;
    public const int GL_OBJECT_LINEAR = 0x2401;
    public const int GL_SPHERE_MAP = 0x2402;
    public const int GL_TEXTURE_GEN_MODE = 0x2500;
    public const int GL_OBJECT_PLANE = 0x2501;
    public const int GL_EYE_PLANE = 0x2502;
    public const int GL_CLAMP = 0x2900;
    public const int GL_CLIP_PLANE0 = 0x3000;
    public const int GL_CLIP_PLANE1 = 0x3001;
    public const int GL_CLIP_PLANE2 = 0x3002;
    public const int GL_CLIP_PLANE3 = 0x3003;
    public const int GL_CLIP_PLANE4 = 0x3004;
    public const int GL_CLIP_PLANE5 = 0x3005;
    public const int GL_LIGHT0 = 0x4000;
    public const int GL_LIGHT1 = 0x4001;
    public const int GL_LIGHT2 = 0x4002;
    public const int GL_LIGHT3 = 0x4003;
    public const int GL_LIGHT4 = 0x4004;
    public const int GL_LIGHT5 = 0x4005;
    public const int GL_LIGHT6 = 0x4006;
    public const int GL_LIGHT7 = 0x4007;
    #endregion
    
    #region Commands
    public static void glCullFace(uint mode) => _glCullFace(mode);
    [LGLNativeAPI("glCullFace")] internal static delegate* unmanaged<uint, void> _glCullFace = null;
    
    public static void glFrontFace(uint mode) => _glFrontFace(mode);
    [LGLNativeAPI("glFrontFace")] internal static delegate* unmanaged<uint, void> _glFrontFace = null;
    
    public static void glHint(uint target, uint mode) => _glHint(target, mode);
    [LGLNativeAPI("glHint")] internal static delegate* unmanaged<uint, uint, void> _glHint = null;
    
    public static void glLineWidth(float width) => _glLineWidth(width);
    [LGLNativeAPI("glLineWidth")] internal static delegate* unmanaged<float, void> _glLineWidth = null;
    
    public static void glPointSize(float size) => _glPointSize(size);
    [LGLNativeAPI("glPointSize")] internal static delegate* unmanaged<float, void> _glPointSize = null;
    
    public static void glPolygonMode(uint face, uint mode) => _glPolygonMode(face, mode);
    [LGLNativeAPI("glPolygonMode")] internal static delegate* unmanaged<uint, uint, void> _glPolygonMode = null;
    
    public static void glScissor(int x, int y, int width, int height) => _glScissor(x, y, width, height);
    [LGLNativeAPI("glScissor")] internal static delegate* unmanaged<int, int, int, int, void> _glScissor = null;
    
    public static void glTexParameterf(uint target, uint pname, float param) => _glTexParameterf(target, pname, param);
    [LGLNativeAPI("glTexParameterf")] internal static delegate* unmanaged<uint, uint, float, void> _glTexParameterf = null;
    
    public static void glTexParameterfv(uint target, uint pname, float* @params) => _glTexParameterfv(target, pname, @params);
    [LGLNativeAPI("glTexParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glTexParameterfv = null;
    
    public static void glTexParameteri(uint target, uint pname, int param) => _glTexParameteri(target, pname, param);
    [LGLNativeAPI("glTexParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glTexParameteri = null;
    
    public static void glTexParameteriv(uint target, uint pname, int* @params) => _glTexParameteriv(target, pname, @params);
    [LGLNativeAPI("glTexParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glTexParameteriv = null;
    
    public static void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels) => _glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
    [LGLNativeAPI("glTexImage1D")] internal static delegate* unmanaged<uint, int, int, int, int, uint, uint, void*, void> _glTexImage1D = null;
    
    public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels) => _glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
    [LGLNativeAPI("glTexImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void> _glTexImage2D = null;
    
    public static void glDrawBuffer(uint buf) => _glDrawBuffer(buf);
    [LGLNativeAPI("glDrawBuffer")] internal static delegate* unmanaged<uint, void> _glDrawBuffer = null;
    
    public static void glClear(uint mask) => _glClear(mask);
    [LGLNativeAPI("glClear")] internal static delegate* unmanaged<uint, void> _glClear = null;
    
    public static void glClearColor(float red, float green, float blue, float alpha) => _glClearColor(red, green, blue, alpha);
    [LGLNativeAPI("glClearColor")] internal static delegate* unmanaged<float, float, float, float, void> _glClearColor = null;
    
    public static void glClearStencil(int s) => _glClearStencil(s);
    [LGLNativeAPI("glClearStencil")] internal static delegate* unmanaged<int, void> _glClearStencil = null;
    
    public static void glClearDepth(double depth) => _glClearDepth(depth);
    [LGLNativeAPI("glClearDepth")] internal static delegate* unmanaged<double, void> _glClearDepth = null;
    
    public static void glStencilMask(uint mask) => _glStencilMask(mask);
    [LGLNativeAPI("glStencilMask")] internal static delegate* unmanaged<uint, void> _glStencilMask = null;
    
    public static void glColorMask(bool red, bool green, bool blue, bool alpha) => _glColorMask(red, green, blue, alpha);
    [LGLNativeAPI("glColorMask")] internal static delegate* unmanaged<bool, bool, bool, bool, void> _glColorMask = null;
    
    public static void glDepthMask(bool flag) => _glDepthMask(flag);
    [LGLNativeAPI("glDepthMask")] internal static delegate* unmanaged<bool, void> _glDepthMask = null;
    
    public static void glDisable(uint cap) => _glDisable(cap);
    [LGLNativeAPI("glDisable")] internal static delegate* unmanaged<uint, void> _glDisable = null;
    
    public static void glEnable(uint cap) => _glEnable(cap);
    [LGLNativeAPI("glEnable")] internal static delegate* unmanaged<uint, void> _glEnable = null;
    
    public static void glFinish() => _glFinish();
    [LGLNativeAPI("glFinish")] internal static delegate* unmanaged<void> _glFinish = null;
    
    public static void glFlush() => _glFlush();
    [LGLNativeAPI("glFlush")] internal static delegate* unmanaged<void> _glFlush = null;
    
    public static void glBlendFunc(uint sfactor, uint dfactor) => _glBlendFunc(sfactor, dfactor);
    [LGLNativeAPI("glBlendFunc")] internal static delegate* unmanaged<uint, uint, void> _glBlendFunc = null;
    
    public static void glLogicOp(uint opcode) => _glLogicOp(opcode);
    [LGLNativeAPI("glLogicOp")] internal static delegate* unmanaged<uint, void> _glLogicOp = null;
    
    public static void glStencilFunc(uint func, int @ref, uint mask) => _glStencilFunc(func, @ref, mask);
    [LGLNativeAPI("glStencilFunc")] internal static delegate* unmanaged<uint, int, uint, void> _glStencilFunc = null;
    
    public static void glStencilOp(uint fail, uint zfail, uint zpass) => _glStencilOp(fail, zfail, zpass);
    [LGLNativeAPI("glStencilOp")] internal static delegate* unmanaged<uint, uint, uint, void> _glStencilOp = null;
    
    public static void glDepthFunc(uint func) => _glDepthFunc(func);
    [LGLNativeAPI("glDepthFunc")] internal static delegate* unmanaged<uint, void> _glDepthFunc = null;
    
    public static void glPixelStoref(uint pname, float param) => _glPixelStoref(pname, param);
    [LGLNativeAPI("glPixelStoref")] internal static delegate* unmanaged<uint, float, void> _glPixelStoref = null;
    
    public static void glPixelStorei(uint pname, int param) => _glPixelStorei(pname, param);
    [LGLNativeAPI("glPixelStorei")] internal static delegate* unmanaged<uint, int, void> _glPixelStorei = null;
    
    public static void glReadBuffer(uint src) => _glReadBuffer(src);
    [LGLNativeAPI("glReadBuffer")] internal static delegate* unmanaged<uint, void> _glReadBuffer = null;
    
    public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) => _glReadPixels(x, y, width, height, format, type, pixels);
    [LGLNativeAPI("glReadPixels")] internal static delegate* unmanaged<int, int, int, int, uint, uint, void*, void> _glReadPixels = null;
    
    public static void glGetBooleanv(uint pname, bool* data) => _glGetBooleanv(pname, data);
    [LGLNativeAPI("glGetBooleanv")] internal static delegate* unmanaged<uint, bool*, void> _glGetBooleanv = null;
    
    public static void glGetDoublev(uint pname, double* data) => _glGetDoublev(pname, data);
    [LGLNativeAPI("glGetDoublev")] internal static delegate* unmanaged<uint, double*, void> _glGetDoublev = null;
    
    public static uint glGetError() => _glGetError();
    [LGLNativeAPI("glGetError")] internal static delegate* unmanaged<uint> _glGetError = null;
    
    public static void glGetFloatv(uint pname, float* data) => _glGetFloatv(pname, data);
    [LGLNativeAPI("glGetFloatv")] internal static delegate* unmanaged<uint, float*, void> _glGetFloatv = null;
    
    public static void glGetIntegerv(uint pname, int* data) => _glGetIntegerv(pname, data);
    [LGLNativeAPI("glGetIntegerv")] internal static delegate* unmanaged<uint, int*, void> _glGetIntegerv = null;
    
    public static byte* glGetString(uint name) => _glGetString(name);
    [LGLNativeAPI("glGetString")] internal static delegate* unmanaged<uint, byte*> _glGetString = null;
    
    public static void glGetTexImage(uint target, int level, uint format, uint type, void* pixels) => _glGetTexImage(target, level, format, type, pixels);
    [LGLNativeAPI("glGetTexImage")] internal static delegate* unmanaged<uint, int, uint, uint, void*, void> _glGetTexImage = null;
    
    public static void glGetTexParameterfv(uint target, uint pname, float* @params) => _glGetTexParameterfv(target, pname, @params);
    [LGLNativeAPI("glGetTexParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexParameterfv = null;
    
    public static void glGetTexParameteriv(uint target, uint pname, int* @params) => _glGetTexParameteriv(target, pname, @params);
    [LGLNativeAPI("glGetTexParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexParameteriv = null;
    
    public static void glGetTexLevelParameterfv(uint target, int level, uint pname, float* @params) => _glGetTexLevelParameterfv(target, level, pname, @params);
    [LGLNativeAPI("glGetTexLevelParameterfv")] internal static delegate* unmanaged<uint, int, uint, float*, void> _glGetTexLevelParameterfv = null;
    
    public static void glGetTexLevelParameteriv(uint target, int level, uint pname, int* @params) => _glGetTexLevelParameteriv(target, level, pname, @params);
    [LGLNativeAPI("glGetTexLevelParameteriv")] internal static delegate* unmanaged<uint, int, uint, int*, void> _glGetTexLevelParameteriv = null;
    
    public static bool glIsEnabled(uint cap) => _glIsEnabled(cap);
    [LGLNativeAPI("glIsEnabled")] internal static delegate* unmanaged<uint, bool> _glIsEnabled = null;
    
    public static void glDepthRange(double n, double f) => _glDepthRange(n, f);
    [LGLNativeAPI("glDepthRange")] internal static delegate* unmanaged<double, double, void> _glDepthRange = null;
    
    public static void glViewport(int x, int y, int width, int height) => _glViewport(x, y, width, height);
    [LGLNativeAPI("glViewport")] internal static delegate* unmanaged<int, int, int, int, void> _glViewport = null;
    
    public static void glNewList(uint list, uint mode) => _glNewList(list, mode);
    [LGLNativeAPI("glNewList")] internal static delegate* unmanaged<uint, uint, void> _glNewList = null;
    
    public static void glEndList() => _glEndList();
    [LGLNativeAPI("glEndList")] internal static delegate* unmanaged<void> _glEndList = null;
    
    public static void glCallList(uint list) => _glCallList(list);
    [LGLNativeAPI("glCallList")] internal static delegate* unmanaged<uint, void> _glCallList = null;
    
    public static void glCallLists(int n, uint type, void* lists) => _glCallLists(n, type, lists);
    [LGLNativeAPI("glCallLists")] internal static delegate* unmanaged<int, uint, void*, void> _glCallLists = null;
    
    public static void glDeleteLists(uint list, int range) => _glDeleteLists(list, range);
    [LGLNativeAPI("glDeleteLists")] internal static delegate* unmanaged<uint, int, void> _glDeleteLists = null;
    
    public static uint glGenLists(int range) => _glGenLists(range);
    [LGLNativeAPI("glGenLists")] internal static delegate* unmanaged<int, uint> _glGenLists = null;
    
    public static void glListBase(uint @base) => _glListBase(@base);
    [LGLNativeAPI("glListBase")] internal static delegate* unmanaged<uint, void> _glListBase = null;
    
    public static void glBegin(uint mode) => _glBegin(mode);
    [LGLNativeAPI("glBegin")] internal static delegate* unmanaged<uint, void> _glBegin = null;
    
    public static void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap) => _glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
    [LGLNativeAPI("glBitmap")] internal static delegate* unmanaged<int, int, float, float, float, float, byte*, void> _glBitmap = null;
    
    public static void glColor3b(sbyte red, sbyte green, sbyte blue) => _glColor3b(red, green, blue);
    [LGLNativeAPI("glColor3b")] internal static delegate* unmanaged<sbyte, sbyte, sbyte, void> _glColor3b = null;
    
    public static void glColor3bv(sbyte* v) => _glColor3bv(v);
    [LGLNativeAPI("glColor3bv")] internal static delegate* unmanaged<sbyte*, void> _glColor3bv = null;
    
    public static void glColor3d(double red, double green, double blue) => _glColor3d(red, green, blue);
    [LGLNativeAPI("glColor3d")] internal static delegate* unmanaged<double, double, double, void> _glColor3d = null;
    
    public static void glColor3dv(double* v) => _glColor3dv(v);
    [LGLNativeAPI("glColor3dv")] internal static delegate* unmanaged<double*, void> _glColor3dv = null;
    
    public static void glColor3f(float red, float green, float blue) => _glColor3f(red, green, blue);
    [LGLNativeAPI("glColor3f")] internal static delegate* unmanaged<float, float, float, void> _glColor3f = null;
    
    public static void glColor3fv(float* v) => _glColor3fv(v);
    [LGLNativeAPI("glColor3fv")] internal static delegate* unmanaged<float*, void> _glColor3fv = null;
    
    public static void glColor3i(int red, int green, int blue) => _glColor3i(red, green, blue);
    [LGLNativeAPI("glColor3i")] internal static delegate* unmanaged<int, int, int, void> _glColor3i = null;
    
    public static void glColor3iv(int* v) => _glColor3iv(v);
    [LGLNativeAPI("glColor3iv")] internal static delegate* unmanaged<int*, void> _glColor3iv = null;
    
    public static void glColor3s(short red, short green, short blue) => _glColor3s(red, green, blue);
    [LGLNativeAPI("glColor3s")] internal static delegate* unmanaged<short, short, short, void> _glColor3s = null;
    
    public static void glColor3sv(short* v) => _glColor3sv(v);
    [LGLNativeAPI("glColor3sv")] internal static delegate* unmanaged<short*, void> _glColor3sv = null;
    
    public static void glColor3ub(byte red, byte green, byte blue) => _glColor3ub(red, green, blue);
    [LGLNativeAPI("glColor3ub")] internal static delegate* unmanaged<byte, byte, byte, void> _glColor3ub = null;
    
    public static void glColor3ubv(byte* v) => _glColor3ubv(v);
    [LGLNativeAPI("glColor3ubv")] internal static delegate* unmanaged<byte*, void> _glColor3ubv = null;
    
    public static void glColor3ui(uint red, uint green, uint blue) => _glColor3ui(red, green, blue);
    [LGLNativeAPI("glColor3ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glColor3ui = null;
    
    public static void glColor3uiv(uint* v) => _glColor3uiv(v);
    [LGLNativeAPI("glColor3uiv")] internal static delegate* unmanaged<uint*, void> _glColor3uiv = null;
    
    public static void glColor3us(ushort red, ushort green, ushort blue) => _glColor3us(red, green, blue);
    [LGLNativeAPI("glColor3us")] internal static delegate* unmanaged<ushort, ushort, ushort, void> _glColor3us = null;
    
    public static void glColor3usv(ushort* v) => _glColor3usv(v);
    [LGLNativeAPI("glColor3usv")] internal static delegate* unmanaged<ushort*, void> _glColor3usv = null;
    
    public static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) => _glColor4b(red, green, blue, alpha);
    [LGLNativeAPI("glColor4b")] internal static delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void> _glColor4b = null;
    
    public static void glColor4bv(sbyte* v) => _glColor4bv(v);
    [LGLNativeAPI("glColor4bv")] internal static delegate* unmanaged<sbyte*, void> _glColor4bv = null;
    
    public static void glColor4d(double red, double green, double blue, double alpha) => _glColor4d(red, green, blue, alpha);
    [LGLNativeAPI("glColor4d")] internal static delegate* unmanaged<double, double, double, double, void> _glColor4d = null;
    
    public static void glColor4dv(double* v) => _glColor4dv(v);
    [LGLNativeAPI("glColor4dv")] internal static delegate* unmanaged<double*, void> _glColor4dv = null;
    
    public static void glColor4f(float red, float green, float blue, float alpha) => _glColor4f(red, green, blue, alpha);
    [LGLNativeAPI("glColor4f")] internal static delegate* unmanaged<float, float, float, float, void> _glColor4f = null;
    
    public static void glColor4fv(float* v) => _glColor4fv(v);
    [LGLNativeAPI("glColor4fv")] internal static delegate* unmanaged<float*, void> _glColor4fv = null;
    
    public static void glColor4i(int red, int green, int blue, int alpha) => _glColor4i(red, green, blue, alpha);
    [LGLNativeAPI("glColor4i")] internal static delegate* unmanaged<int, int, int, int, void> _glColor4i = null;
    
    public static void glColor4iv(int* v) => _glColor4iv(v);
    [LGLNativeAPI("glColor4iv")] internal static delegate* unmanaged<int*, void> _glColor4iv = null;
    
    public static void glColor4s(short red, short green, short blue, short alpha) => _glColor4s(red, green, blue, alpha);
    [LGLNativeAPI("glColor4s")] internal static delegate* unmanaged<short, short, short, short, void> _glColor4s = null;
    
    public static void glColor4sv(short* v) => _glColor4sv(v);
    [LGLNativeAPI("glColor4sv")] internal static delegate* unmanaged<short*, void> _glColor4sv = null;
    
    public static void glColor4ub(byte red, byte green, byte blue, byte alpha) => _glColor4ub(red, green, blue, alpha);
    [LGLNativeAPI("glColor4ub")] internal static delegate* unmanaged<byte, byte, byte, byte, void> _glColor4ub = null;
    
    public static void glColor4ubv(byte* v) => _glColor4ubv(v);
    [LGLNativeAPI("glColor4ubv")] internal static delegate* unmanaged<byte*, void> _glColor4ubv = null;
    
    public static void glColor4ui(uint red, uint green, uint blue, uint alpha) => _glColor4ui(red, green, blue, alpha);
    [LGLNativeAPI("glColor4ui")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glColor4ui = null;
    
    public static void glColor4uiv(uint* v) => _glColor4uiv(v);
    [LGLNativeAPI("glColor4uiv")] internal static delegate* unmanaged<uint*, void> _glColor4uiv = null;
    
    public static void glColor4us(ushort red, ushort green, ushort blue, ushort alpha) => _glColor4us(red, green, blue, alpha);
    [LGLNativeAPI("glColor4us")] internal static delegate* unmanaged<ushort, ushort, ushort, ushort, void> _glColor4us = null;
    
    public static void glColor4usv(ushort* v) => _glColor4usv(v);
    [LGLNativeAPI("glColor4usv")] internal static delegate* unmanaged<ushort*, void> _glColor4usv = null;
    
    public static void glEdgeFlag(bool flag) => _glEdgeFlag(flag);
    [LGLNativeAPI("glEdgeFlag")] internal static delegate* unmanaged<bool, void> _glEdgeFlag = null;
    
    public static void glEdgeFlagv(bool* flag) => _glEdgeFlagv(flag);
    [LGLNativeAPI("glEdgeFlagv")] internal static delegate* unmanaged<bool*, void> _glEdgeFlagv = null;
    
    public static void glEnd() => _glEnd();
    [LGLNativeAPI("glEnd")] internal static delegate* unmanaged<void> _glEnd = null;
    
    public static void glIndexd(double c) => _glIndexd(c);
    [LGLNativeAPI("glIndexd")] internal static delegate* unmanaged<double, void> _glIndexd = null;
    
    public static void glIndexdv(double* c) => _glIndexdv(c);
    [LGLNativeAPI("glIndexdv")] internal static delegate* unmanaged<double*, void> _glIndexdv = null;
    
    public static void glIndexf(float c) => _glIndexf(c);
    [LGLNativeAPI("glIndexf")] internal static delegate* unmanaged<float, void> _glIndexf = null;
    
    public static void glIndexfv(float* c) => _glIndexfv(c);
    [LGLNativeAPI("glIndexfv")] internal static delegate* unmanaged<float*, void> _glIndexfv = null;
    
    public static void glIndexi(int c) => _glIndexi(c);
    [LGLNativeAPI("glIndexi")] internal static delegate* unmanaged<int, void> _glIndexi = null;
    
    public static void glIndexiv(int* c) => _glIndexiv(c);
    [LGLNativeAPI("glIndexiv")] internal static delegate* unmanaged<int*, void> _glIndexiv = null;
    
    public static void glIndexs(short c) => _glIndexs(c);
    [LGLNativeAPI("glIndexs")] internal static delegate* unmanaged<short, void> _glIndexs = null;
    
    public static void glIndexsv(short* c) => _glIndexsv(c);
    [LGLNativeAPI("glIndexsv")] internal static delegate* unmanaged<short*, void> _glIndexsv = null;
    
    public static void glNormal3b(sbyte nx, sbyte ny, sbyte nz) => _glNormal3b(nx, ny, nz);
    [LGLNativeAPI("glNormal3b")] internal static delegate* unmanaged<sbyte, sbyte, sbyte, void> _glNormal3b = null;
    
    public static void glNormal3bv(sbyte* v) => _glNormal3bv(v);
    [LGLNativeAPI("glNormal3bv")] internal static delegate* unmanaged<sbyte*, void> _glNormal3bv = null;
    
    public static void glNormal3d(double nx, double ny, double nz) => _glNormal3d(nx, ny, nz);
    [LGLNativeAPI("glNormal3d")] internal static delegate* unmanaged<double, double, double, void> _glNormal3d = null;
    
    public static void glNormal3dv(double* v) => _glNormal3dv(v);
    [LGLNativeAPI("glNormal3dv")] internal static delegate* unmanaged<double*, void> _glNormal3dv = null;
    
    public static void glNormal3f(float nx, float ny, float nz) => _glNormal3f(nx, ny, nz);
    [LGLNativeAPI("glNormal3f")] internal static delegate* unmanaged<float, float, float, void> _glNormal3f = null;
    
    public static void glNormal3fv(float* v) => _glNormal3fv(v);
    [LGLNativeAPI("glNormal3fv")] internal static delegate* unmanaged<float*, void> _glNormal3fv = null;
    
    public static void glNormal3i(int nx, int ny, int nz) => _glNormal3i(nx, ny, nz);
    [LGLNativeAPI("glNormal3i")] internal static delegate* unmanaged<int, int, int, void> _glNormal3i = null;
    
    public static void glNormal3iv(int* v) => _glNormal3iv(v);
    [LGLNativeAPI("glNormal3iv")] internal static delegate* unmanaged<int*, void> _glNormal3iv = null;
    
    public static void glNormal3s(short nx, short ny, short nz) => _glNormal3s(nx, ny, nz);
    [LGLNativeAPI("glNormal3s")] internal static delegate* unmanaged<short, short, short, void> _glNormal3s = null;
    
    public static void glNormal3sv(short* v) => _glNormal3sv(v);
    [LGLNativeAPI("glNormal3sv")] internal static delegate* unmanaged<short*, void> _glNormal3sv = null;
    
    public static void glRasterPos2d(double x, double y) => _glRasterPos2d(x, y);
    [LGLNativeAPI("glRasterPos2d")] internal static delegate* unmanaged<double, double, void> _glRasterPos2d = null;
    
    public static void glRasterPos2dv(double* v) => _glRasterPos2dv(v);
    [LGLNativeAPI("glRasterPos2dv")] internal static delegate* unmanaged<double*, void> _glRasterPos2dv = null;
    
    public static void glRasterPos2f(float x, float y) => _glRasterPos2f(x, y);
    [LGLNativeAPI("glRasterPos2f")] internal static delegate* unmanaged<float, float, void> _glRasterPos2f = null;
    
    public static void glRasterPos2fv(float* v) => _glRasterPos2fv(v);
    [LGLNativeAPI("glRasterPos2fv")] internal static delegate* unmanaged<float*, void> _glRasterPos2fv = null;
    
    public static void glRasterPos2i(int x, int y) => _glRasterPos2i(x, y);
    [LGLNativeAPI("glRasterPos2i")] internal static delegate* unmanaged<int, int, void> _glRasterPos2i = null;
    
    public static void glRasterPos2iv(int* v) => _glRasterPos2iv(v);
    [LGLNativeAPI("glRasterPos2iv")] internal static delegate* unmanaged<int*, void> _glRasterPos2iv = null;
    
    public static void glRasterPos2s(short x, short y) => _glRasterPos2s(x, y);
    [LGLNativeAPI("glRasterPos2s")] internal static delegate* unmanaged<short, short, void> _glRasterPos2s = null;
    
    public static void glRasterPos2sv(short* v) => _glRasterPos2sv(v);
    [LGLNativeAPI("glRasterPos2sv")] internal static delegate* unmanaged<short*, void> _glRasterPos2sv = null;
    
    public static void glRasterPos3d(double x, double y, double z) => _glRasterPos3d(x, y, z);
    [LGLNativeAPI("glRasterPos3d")] internal static delegate* unmanaged<double, double, double, void> _glRasterPos3d = null;
    
    public static void glRasterPos3dv(double* v) => _glRasterPos3dv(v);
    [LGLNativeAPI("glRasterPos3dv")] internal static delegate* unmanaged<double*, void> _glRasterPos3dv = null;
    
    public static void glRasterPos3f(float x, float y, float z) => _glRasterPos3f(x, y, z);
    [LGLNativeAPI("glRasterPos3f")] internal static delegate* unmanaged<float, float, float, void> _glRasterPos3f = null;
    
    public static void glRasterPos3fv(float* v) => _glRasterPos3fv(v);
    [LGLNativeAPI("glRasterPos3fv")] internal static delegate* unmanaged<float*, void> _glRasterPos3fv = null;
    
    public static void glRasterPos3i(int x, int y, int z) => _glRasterPos3i(x, y, z);
    [LGLNativeAPI("glRasterPos3i")] internal static delegate* unmanaged<int, int, int, void> _glRasterPos3i = null;
    
    public static void glRasterPos3iv(int* v) => _glRasterPos3iv(v);
    [LGLNativeAPI("glRasterPos3iv")] internal static delegate* unmanaged<int*, void> _glRasterPos3iv = null;
    
    public static void glRasterPos3s(short x, short y, short z) => _glRasterPos3s(x, y, z);
    [LGLNativeAPI("glRasterPos3s")] internal static delegate* unmanaged<short, short, short, void> _glRasterPos3s = null;
    
    public static void glRasterPos3sv(short* v) => _glRasterPos3sv(v);
    [LGLNativeAPI("glRasterPos3sv")] internal static delegate* unmanaged<short*, void> _glRasterPos3sv = null;
    
    public static void glRasterPos4d(double x, double y, double z, double w) => _glRasterPos4d(x, y, z, w);
    [LGLNativeAPI("glRasterPos4d")] internal static delegate* unmanaged<double, double, double, double, void> _glRasterPos4d = null;
    
    public static void glRasterPos4dv(double* v) => _glRasterPos4dv(v);
    [LGLNativeAPI("glRasterPos4dv")] internal static delegate* unmanaged<double*, void> _glRasterPos4dv = null;
    
    public static void glRasterPos4f(float x, float y, float z, float w) => _glRasterPos4f(x, y, z, w);
    [LGLNativeAPI("glRasterPos4f")] internal static delegate* unmanaged<float, float, float, float, void> _glRasterPos4f = null;
    
    public static void glRasterPos4fv(float* v) => _glRasterPos4fv(v);
    [LGLNativeAPI("glRasterPos4fv")] internal static delegate* unmanaged<float*, void> _glRasterPos4fv = null;
    
    public static void glRasterPos4i(int x, int y, int z, int w) => _glRasterPos4i(x, y, z, w);
    [LGLNativeAPI("glRasterPos4i")] internal static delegate* unmanaged<int, int, int, int, void> _glRasterPos4i = null;
    
    public static void glRasterPos4iv(int* v) => _glRasterPos4iv(v);
    [LGLNativeAPI("glRasterPos4iv")] internal static delegate* unmanaged<int*, void> _glRasterPos4iv = null;
    
    public static void glRasterPos4s(short x, short y, short z, short w) => _glRasterPos4s(x, y, z, w);
    [LGLNativeAPI("glRasterPos4s")] internal static delegate* unmanaged<short, short, short, short, void> _glRasterPos4s = null;
    
    public static void glRasterPos4sv(short* v) => _glRasterPos4sv(v);
    [LGLNativeAPI("glRasterPos4sv")] internal static delegate* unmanaged<short*, void> _glRasterPos4sv = null;
    
    public static void glRectd(double x1, double y1, double x2, double y2) => _glRectd(x1, y1, x2, y2);
    [LGLNativeAPI("glRectd")] internal static delegate* unmanaged<double, double, double, double, void> _glRectd = null;
    
    public static void glRectdv(double* v1, double* v2) => _glRectdv(v1, v2);
    [LGLNativeAPI("glRectdv")] internal static delegate* unmanaged<double*, double*, void> _glRectdv = null;
    
    public static void glRectf(float x1, float y1, float x2, float y2) => _glRectf(x1, y1, x2, y2);
    [LGLNativeAPI("glRectf")] internal static delegate* unmanaged<float, float, float, float, void> _glRectf = null;
    
    public static void glRectfv(float* v1, float* v2) => _glRectfv(v1, v2);
    [LGLNativeAPI("glRectfv")] internal static delegate* unmanaged<float*, float*, void> _glRectfv = null;
    
    public static void glRecti(int x1, int y1, int x2, int y2) => _glRecti(x1, y1, x2, y2);
    [LGLNativeAPI("glRecti")] internal static delegate* unmanaged<int, int, int, int, void> _glRecti = null;
    
    public static void glRectiv(int* v1, int* v2) => _glRectiv(v1, v2);
    [LGLNativeAPI("glRectiv")] internal static delegate* unmanaged<int*, int*, void> _glRectiv = null;
    
    public static void glRects(short x1, short y1, short x2, short y2) => _glRects(x1, y1, x2, y2);
    [LGLNativeAPI("glRects")] internal static delegate* unmanaged<short, short, short, short, void> _glRects = null;
    
    public static void glRectsv(short* v1, short* v2) => _glRectsv(v1, v2);
    [LGLNativeAPI("glRectsv")] internal static delegate* unmanaged<short*, short*, void> _glRectsv = null;
    
    public static void glTexCoord1d(double s) => _glTexCoord1d(s);
    [LGLNativeAPI("glTexCoord1d")] internal static delegate* unmanaged<double, void> _glTexCoord1d = null;
    
    public static void glTexCoord1dv(double* v) => _glTexCoord1dv(v);
    [LGLNativeAPI("glTexCoord1dv")] internal static delegate* unmanaged<double*, void> _glTexCoord1dv = null;
    
    public static void glTexCoord1f(float s) => _glTexCoord1f(s);
    [LGLNativeAPI("glTexCoord1f")] internal static delegate* unmanaged<float, void> _glTexCoord1f = null;
    
    public static void glTexCoord1fv(float* v) => _glTexCoord1fv(v);
    [LGLNativeAPI("glTexCoord1fv")] internal static delegate* unmanaged<float*, void> _glTexCoord1fv = null;
    
    public static void glTexCoord1i(int s) => _glTexCoord1i(s);
    [LGLNativeAPI("glTexCoord1i")] internal static delegate* unmanaged<int, void> _glTexCoord1i = null;
    
    public static void glTexCoord1iv(int* v) => _glTexCoord1iv(v);
    [LGLNativeAPI("glTexCoord1iv")] internal static delegate* unmanaged<int*, void> _glTexCoord1iv = null;
    
    public static void glTexCoord1s(short s) => _glTexCoord1s(s);
    [LGLNativeAPI("glTexCoord1s")] internal static delegate* unmanaged<short, void> _glTexCoord1s = null;
    
    public static void glTexCoord1sv(short* v) => _glTexCoord1sv(v);
    [LGLNativeAPI("glTexCoord1sv")] internal static delegate* unmanaged<short*, void> _glTexCoord1sv = null;
    
    public static void glTexCoord2d(double s, double t) => _glTexCoord2d(s, t);
    [LGLNativeAPI("glTexCoord2d")] internal static delegate* unmanaged<double, double, void> _glTexCoord2d = null;
    
    public static void glTexCoord2dv(double* v) => _glTexCoord2dv(v);
    [LGLNativeAPI("glTexCoord2dv")] internal static delegate* unmanaged<double*, void> _glTexCoord2dv = null;
    
    public static void glTexCoord2f(float s, float t) => _glTexCoord2f(s, t);
    [LGLNativeAPI("glTexCoord2f")] internal static delegate* unmanaged<float, float, void> _glTexCoord2f = null;
    
    public static void glTexCoord2fv(float* v) => _glTexCoord2fv(v);
    [LGLNativeAPI("glTexCoord2fv")] internal static delegate* unmanaged<float*, void> _glTexCoord2fv = null;
    
    public static void glTexCoord2i(int s, int t) => _glTexCoord2i(s, t);
    [LGLNativeAPI("glTexCoord2i")] internal static delegate* unmanaged<int, int, void> _glTexCoord2i = null;
    
    public static void glTexCoord2iv(int* v) => _glTexCoord2iv(v);
    [LGLNativeAPI("glTexCoord2iv")] internal static delegate* unmanaged<int*, void> _glTexCoord2iv = null;
    
    public static void glTexCoord2s(short s, short t) => _glTexCoord2s(s, t);
    [LGLNativeAPI("glTexCoord2s")] internal static delegate* unmanaged<short, short, void> _glTexCoord2s = null;
    
    public static void glTexCoord2sv(short* v) => _glTexCoord2sv(v);
    [LGLNativeAPI("glTexCoord2sv")] internal static delegate* unmanaged<short*, void> _glTexCoord2sv = null;
    
    public static void glTexCoord3d(double s, double t, double r) => _glTexCoord3d(s, t, r);
    [LGLNativeAPI("glTexCoord3d")] internal static delegate* unmanaged<double, double, double, void> _glTexCoord3d = null;
    
    public static void glTexCoord3dv(double* v) => _glTexCoord3dv(v);
    [LGLNativeAPI("glTexCoord3dv")] internal static delegate* unmanaged<double*, void> _glTexCoord3dv = null;
    
    public static void glTexCoord3f(float s, float t, float r) => _glTexCoord3f(s, t, r);
    [LGLNativeAPI("glTexCoord3f")] internal static delegate* unmanaged<float, float, float, void> _glTexCoord3f = null;
    
    public static void glTexCoord3fv(float* v) => _glTexCoord3fv(v);
    [LGLNativeAPI("glTexCoord3fv")] internal static delegate* unmanaged<float*, void> _glTexCoord3fv = null;
    
    public static void glTexCoord3i(int s, int t, int r) => _glTexCoord3i(s, t, r);
    [LGLNativeAPI("glTexCoord3i")] internal static delegate* unmanaged<int, int, int, void> _glTexCoord3i = null;
    
    public static void glTexCoord3iv(int* v) => _glTexCoord3iv(v);
    [LGLNativeAPI("glTexCoord3iv")] internal static delegate* unmanaged<int*, void> _glTexCoord3iv = null;
    
    public static void glTexCoord3s(short s, short t, short r) => _glTexCoord3s(s, t, r);
    [LGLNativeAPI("glTexCoord3s")] internal static delegate* unmanaged<short, short, short, void> _glTexCoord3s = null;
    
    public static void glTexCoord3sv(short* v) => _glTexCoord3sv(v);
    [LGLNativeAPI("glTexCoord3sv")] internal static delegate* unmanaged<short*, void> _glTexCoord3sv = null;
    
    public static void glTexCoord4d(double s, double t, double r, double q) => _glTexCoord4d(s, t, r, q);
    [LGLNativeAPI("glTexCoord4d")] internal static delegate* unmanaged<double, double, double, double, void> _glTexCoord4d = null;
    
    public static void glTexCoord4dv(double* v) => _glTexCoord4dv(v);
    [LGLNativeAPI("glTexCoord4dv")] internal static delegate* unmanaged<double*, void> _glTexCoord4dv = null;
    
    public static void glTexCoord4f(float s, float t, float r, float q) => _glTexCoord4f(s, t, r, q);
    [LGLNativeAPI("glTexCoord4f")] internal static delegate* unmanaged<float, float, float, float, void> _glTexCoord4f = null;
    
    public static void glTexCoord4fv(float* v) => _glTexCoord4fv(v);
    [LGLNativeAPI("glTexCoord4fv")] internal static delegate* unmanaged<float*, void> _glTexCoord4fv = null;
    
    public static void glTexCoord4i(int s, int t, int r, int q) => _glTexCoord4i(s, t, r, q);
    [LGLNativeAPI("glTexCoord4i")] internal static delegate* unmanaged<int, int, int, int, void> _glTexCoord4i = null;
    
    public static void glTexCoord4iv(int* v) => _glTexCoord4iv(v);
    [LGLNativeAPI("glTexCoord4iv")] internal static delegate* unmanaged<int*, void> _glTexCoord4iv = null;
    
    public static void glTexCoord4s(short s, short t, short r, short q) => _glTexCoord4s(s, t, r, q);
    [LGLNativeAPI("glTexCoord4s")] internal static delegate* unmanaged<short, short, short, short, void> _glTexCoord4s = null;
    
    public static void glTexCoord4sv(short* v) => _glTexCoord4sv(v);
    [LGLNativeAPI("glTexCoord4sv")] internal static delegate* unmanaged<short*, void> _glTexCoord4sv = null;
    
    public static void glVertex2d(double x, double y) => _glVertex2d(x, y);
    [LGLNativeAPI("glVertex2d")] internal static delegate* unmanaged<double, double, void> _glVertex2d = null;
    
    public static void glVertex2dv(double* v) => _glVertex2dv(v);
    [LGLNativeAPI("glVertex2dv")] internal static delegate* unmanaged<double*, void> _glVertex2dv = null;
    
    public static void glVertex2f(float x, float y) => _glVertex2f(x, y);
    [LGLNativeAPI("glVertex2f")] internal static delegate* unmanaged<float, float, void> _glVertex2f = null;
    
    public static void glVertex2fv(float* v) => _glVertex2fv(v);
    [LGLNativeAPI("glVertex2fv")] internal static delegate* unmanaged<float*, void> _glVertex2fv = null;
    
    public static void glVertex2i(int x, int y) => _glVertex2i(x, y);
    [LGLNativeAPI("glVertex2i")] internal static delegate* unmanaged<int, int, void> _glVertex2i = null;
    
    public static void glVertex2iv(int* v) => _glVertex2iv(v);
    [LGLNativeAPI("glVertex2iv")] internal static delegate* unmanaged<int*, void> _glVertex2iv = null;
    
    public static void glVertex2s(short x, short y) => _glVertex2s(x, y);
    [LGLNativeAPI("glVertex2s")] internal static delegate* unmanaged<short, short, void> _glVertex2s = null;
    
    public static void glVertex2sv(short* v) => _glVertex2sv(v);
    [LGLNativeAPI("glVertex2sv")] internal static delegate* unmanaged<short*, void> _glVertex2sv = null;
    
    public static void glVertex3d(double x, double y, double z) => _glVertex3d(x, y, z);
    [LGLNativeAPI("glVertex3d")] internal static delegate* unmanaged<double, double, double, void> _glVertex3d = null;
    
    public static void glVertex3dv(double* v) => _glVertex3dv(v);
    [LGLNativeAPI("glVertex3dv")] internal static delegate* unmanaged<double*, void> _glVertex3dv = null;
    
    public static void glVertex3f(float x, float y, float z) => _glVertex3f(x, y, z);
    [LGLNativeAPI("glVertex3f")] internal static delegate* unmanaged<float, float, float, void> _glVertex3f = null;
    
    public static void glVertex3fv(float* v) => _glVertex3fv(v);
    [LGLNativeAPI("glVertex3fv")] internal static delegate* unmanaged<float*, void> _glVertex3fv = null;
    
    public static void glVertex3i(int x, int y, int z) => _glVertex3i(x, y, z);
    [LGLNativeAPI("glVertex3i")] internal static delegate* unmanaged<int, int, int, void> _glVertex3i = null;
    
    public static void glVertex3iv(int* v) => _glVertex3iv(v);
    [LGLNativeAPI("glVertex3iv")] internal static delegate* unmanaged<int*, void> _glVertex3iv = null;
    
    public static void glVertex3s(short x, short y, short z) => _glVertex3s(x, y, z);
    [LGLNativeAPI("glVertex3s")] internal static delegate* unmanaged<short, short, short, void> _glVertex3s = null;
    
    public static void glVertex3sv(short* v) => _glVertex3sv(v);
    [LGLNativeAPI("glVertex3sv")] internal static delegate* unmanaged<short*, void> _glVertex3sv = null;
    
    public static void glVertex4d(double x, double y, double z, double w) => _glVertex4d(x, y, z, w);
    [LGLNativeAPI("glVertex4d")] internal static delegate* unmanaged<double, double, double, double, void> _glVertex4d = null;
    
    public static void glVertex4dv(double* v) => _glVertex4dv(v);
    [LGLNativeAPI("glVertex4dv")] internal static delegate* unmanaged<double*, void> _glVertex4dv = null;
    
    public static void glVertex4f(float x, float y, float z, float w) => _glVertex4f(x, y, z, w);
    [LGLNativeAPI("glVertex4f")] internal static delegate* unmanaged<float, float, float, float, void> _glVertex4f = null;
    
    public static void glVertex4fv(float* v) => _glVertex4fv(v);
    [LGLNativeAPI("glVertex4fv")] internal static delegate* unmanaged<float*, void> _glVertex4fv = null;
    
    public static void glVertex4i(int x, int y, int z, int w) => _glVertex4i(x, y, z, w);
    [LGLNativeAPI("glVertex4i")] internal static delegate* unmanaged<int, int, int, int, void> _glVertex4i = null;
    
    public static void glVertex4iv(int* v) => _glVertex4iv(v);
    [LGLNativeAPI("glVertex4iv")] internal static delegate* unmanaged<int*, void> _glVertex4iv = null;
    
    public static void glVertex4s(short x, short y, short z, short w) => _glVertex4s(x, y, z, w);
    [LGLNativeAPI("glVertex4s")] internal static delegate* unmanaged<short, short, short, short, void> _glVertex4s = null;
    
    public static void glVertex4sv(short* v) => _glVertex4sv(v);
    [LGLNativeAPI("glVertex4sv")] internal static delegate* unmanaged<short*, void> _glVertex4sv = null;
    
    public static void glClipPlane(uint plane, double* equation) => _glClipPlane(plane, equation);
    [LGLNativeAPI("glClipPlane")] internal static delegate* unmanaged<uint, double*, void> _glClipPlane = null;
    
    public static void glColorMaterial(uint face, uint mode) => _glColorMaterial(face, mode);
    [LGLNativeAPI("glColorMaterial")] internal static delegate* unmanaged<uint, uint, void> _glColorMaterial = null;
    
    public static void glFogf(uint pname, float param) => _glFogf(pname, param);
    [LGLNativeAPI("glFogf")] internal static delegate* unmanaged<uint, float, void> _glFogf = null;
    
    public static void glFogfv(uint pname, float* @params) => _glFogfv(pname, @params);
    [LGLNativeAPI("glFogfv")] internal static delegate* unmanaged<uint, float*, void> _glFogfv = null;
    
    public static void glFogi(uint pname, int param) => _glFogi(pname, param);
    [LGLNativeAPI("glFogi")] internal static delegate* unmanaged<uint, int, void> _glFogi = null;
    
    public static void glFogiv(uint pname, int* @params) => _glFogiv(pname, @params);
    [LGLNativeAPI("glFogiv")] internal static delegate* unmanaged<uint, int*, void> _glFogiv = null;
    
    public static void glLightf(uint light, uint pname, float param) => _glLightf(light, pname, param);
    [LGLNativeAPI("glLightf")] internal static delegate* unmanaged<uint, uint, float, void> _glLightf = null;
    
    public static void glLightfv(uint light, uint pname, float* @params) => _glLightfv(light, pname, @params);
    [LGLNativeAPI("glLightfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glLightfv = null;
    
    public static void glLighti(uint light, uint pname, int param) => _glLighti(light, pname, param);
    [LGLNativeAPI("glLighti")] internal static delegate* unmanaged<uint, uint, int, void> _glLighti = null;
    
    public static void glLightiv(uint light, uint pname, int* @params) => _glLightiv(light, pname, @params);
    [LGLNativeAPI("glLightiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glLightiv = null;
    
    public static void glLightModelf(uint pname, float param) => _glLightModelf(pname, param);
    [LGLNativeAPI("glLightModelf")] internal static delegate* unmanaged<uint, float, void> _glLightModelf = null;
    
    public static void glLightModelfv(uint pname, float* @params) => _glLightModelfv(pname, @params);
    [LGLNativeAPI("glLightModelfv")] internal static delegate* unmanaged<uint, float*, void> _glLightModelfv = null;
    
    public static void glLightModeli(uint pname, int param) => _glLightModeli(pname, param);
    [LGLNativeAPI("glLightModeli")] internal static delegate* unmanaged<uint, int, void> _glLightModeli = null;
    
    public static void glLightModeliv(uint pname, int* @params) => _glLightModeliv(pname, @params);
    [LGLNativeAPI("glLightModeliv")] internal static delegate* unmanaged<uint, int*, void> _glLightModeliv = null;
    
    public static void glLineStipple(int factor, ushort pattern) => _glLineStipple(factor, pattern);
    [LGLNativeAPI("glLineStipple")] internal static delegate* unmanaged<int, ushort, void> _glLineStipple = null;
    
    public static void glMaterialf(uint face, uint pname, float param) => _glMaterialf(face, pname, param);
    [LGLNativeAPI("glMaterialf")] internal static delegate* unmanaged<uint, uint, float, void> _glMaterialf = null;
    
    public static void glMaterialfv(uint face, uint pname, float* @params) => _glMaterialfv(face, pname, @params);
    [LGLNativeAPI("glMaterialfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glMaterialfv = null;
    
    public static void glMateriali(uint face, uint pname, int param) => _glMateriali(face, pname, param);
    [LGLNativeAPI("glMateriali")] internal static delegate* unmanaged<uint, uint, int, void> _glMateriali = null;
    
    public static void glMaterialiv(uint face, uint pname, int* @params) => _glMaterialiv(face, pname, @params);
    [LGLNativeAPI("glMaterialiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glMaterialiv = null;
    
    public static void glPolygonStipple(byte* mask) => _glPolygonStipple(mask);
    [LGLNativeAPI("glPolygonStipple")] internal static delegate* unmanaged<byte*, void> _glPolygonStipple = null;
    
    public static void glShadeModel(uint mode) => _glShadeModel(mode);
    [LGLNativeAPI("glShadeModel")] internal static delegate* unmanaged<uint, void> _glShadeModel = null;
    
    public static void glTexEnvf(uint target, uint pname, float param) => _glTexEnvf(target, pname, param);
    [LGLNativeAPI("glTexEnvf")] internal static delegate* unmanaged<uint, uint, float, void> _glTexEnvf = null;
    
    public static void glTexEnvfv(uint target, uint pname, float* @params) => _glTexEnvfv(target, pname, @params);
    [LGLNativeAPI("glTexEnvfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glTexEnvfv = null;
    
    public static void glTexEnvi(uint target, uint pname, int param) => _glTexEnvi(target, pname, param);
    [LGLNativeAPI("glTexEnvi")] internal static delegate* unmanaged<uint, uint, int, void> _glTexEnvi = null;
    
    public static void glTexEnviv(uint target, uint pname, int* @params) => _glTexEnviv(target, pname, @params);
    [LGLNativeAPI("glTexEnviv")] internal static delegate* unmanaged<uint, uint, int*, void> _glTexEnviv = null;
    
    public static void glTexGend(uint coord, uint pname, double param) => _glTexGend(coord, pname, param);
    [LGLNativeAPI("glTexGend")] internal static delegate* unmanaged<uint, uint, double, void> _glTexGend = null;
    
    public static void glTexGendv(uint coord, uint pname, double* @params) => _glTexGendv(coord, pname, @params);
    [LGLNativeAPI("glTexGendv")] internal static delegate* unmanaged<uint, uint, double*, void> _glTexGendv = null;
    
    public static void glTexGenf(uint coord, uint pname, float param) => _glTexGenf(coord, pname, param);
    [LGLNativeAPI("glTexGenf")] internal static delegate* unmanaged<uint, uint, float, void> _glTexGenf = null;
    
    public static void glTexGenfv(uint coord, uint pname, float* @params) => _glTexGenfv(coord, pname, @params);
    [LGLNativeAPI("glTexGenfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glTexGenfv = null;
    
    public static void glTexGeni(uint coord, uint pname, int param) => _glTexGeni(coord, pname, param);
    [LGLNativeAPI("glTexGeni")] internal static delegate* unmanaged<uint, uint, int, void> _glTexGeni = null;
    
    public static void glTexGeniv(uint coord, uint pname, int* @params) => _glTexGeniv(coord, pname, @params);
    [LGLNativeAPI("glTexGeniv")] internal static delegate* unmanaged<uint, uint, int*, void> _glTexGeniv = null;
    
    public static void glFeedbackBuffer(int size, uint type, float* buffer) => _glFeedbackBuffer(size, type, buffer);
    [LGLNativeAPI("glFeedbackBuffer")] internal static delegate* unmanaged<int, uint, float*, void> _glFeedbackBuffer = null;
    
    public static void glSelectBuffer(int size, uint* buffer) => _glSelectBuffer(size, buffer);
    [LGLNativeAPI("glSelectBuffer")] internal static delegate* unmanaged<int, uint*, void> _glSelectBuffer = null;
    
    public static int glRenderMode(uint mode) => _glRenderMode(mode);
    [LGLNativeAPI("glRenderMode")] internal static delegate* unmanaged<uint, int> _glRenderMode = null;
    
    public static void glInitNames() => _glInitNames();
    [LGLNativeAPI("glInitNames")] internal static delegate* unmanaged<void> _glInitNames = null;
    
    public static void glLoadName(uint name) => _glLoadName(name);
    [LGLNativeAPI("glLoadName")] internal static delegate* unmanaged<uint, void> _glLoadName = null;
    
    public static void glPassThrough(float token) => _glPassThrough(token);
    [LGLNativeAPI("glPassThrough")] internal static delegate* unmanaged<float, void> _glPassThrough = null;
    
    public static void glPopName() => _glPopName();
    [LGLNativeAPI("glPopName")] internal static delegate* unmanaged<void> _glPopName = null;
    
    public static void glPushName(uint name) => _glPushName(name);
    [LGLNativeAPI("glPushName")] internal static delegate* unmanaged<uint, void> _glPushName = null;
    
    public static void glClearAccum(float red, float green, float blue, float alpha) => _glClearAccum(red, green, blue, alpha);
    [LGLNativeAPI("glClearAccum")] internal static delegate* unmanaged<float, float, float, float, void> _glClearAccum = null;
    
    public static void glClearIndex(float c) => _glClearIndex(c);
    [LGLNativeAPI("glClearIndex")] internal static delegate* unmanaged<float, void> _glClearIndex = null;
    
    public static void glIndexMask(uint mask) => _glIndexMask(mask);
    [LGLNativeAPI("glIndexMask")] internal static delegate* unmanaged<uint, void> _glIndexMask = null;
    
    public static void glAccum(uint op, float value) => _glAccum(op, value);
    [LGLNativeAPI("glAccum")] internal static delegate* unmanaged<uint, float, void> _glAccum = null;
    
    public static void glPopAttrib() => _glPopAttrib();
    [LGLNativeAPI("glPopAttrib")] internal static delegate* unmanaged<void> _glPopAttrib = null;
    
    public static void glPushAttrib(uint mask) => _glPushAttrib(mask);
    [LGLNativeAPI("glPushAttrib")] internal static delegate* unmanaged<uint, void> _glPushAttrib = null;
    
    public static void glMap1d(uint target, double u1, double u2, int stride, int order, double* points) => _glMap1d(target, u1, u2, stride, order, points);
    [LGLNativeAPI("glMap1d")] internal static delegate* unmanaged<uint, double, double, int, int, double*, void> _glMap1d = null;
    
    public static void glMap1f(uint target, float u1, float u2, int stride, int order, float* points) => _glMap1f(target, u1, u2, stride, order, points);
    [LGLNativeAPI("glMap1f")] internal static delegate* unmanaged<uint, float, float, int, int, float*, void> _glMap1f = null;
    
    public static void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points) => _glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
    [LGLNativeAPI("glMap2d")] internal static delegate* unmanaged<uint, double, double, int, int, double, double, int, int, double*, void> _glMap2d = null;
    
    public static void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points) => _glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
    [LGLNativeAPI("glMap2f")] internal static delegate* unmanaged<uint, float, float, int, int, float, float, int, int, float*, void> _glMap2f = null;
    
    public static void glMapGrid1d(int un, double u1, double u2) => _glMapGrid1d(un, u1, u2);
    [LGLNativeAPI("glMapGrid1d")] internal static delegate* unmanaged<int, double, double, void> _glMapGrid1d = null;
    
    public static void glMapGrid1f(int un, float u1, float u2) => _glMapGrid1f(un, u1, u2);
    [LGLNativeAPI("glMapGrid1f")] internal static delegate* unmanaged<int, float, float, void> _glMapGrid1f = null;
    
    public static void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) => _glMapGrid2d(un, u1, u2, vn, v1, v2);
    [LGLNativeAPI("glMapGrid2d")] internal static delegate* unmanaged<int, double, double, int, double, double, void> _glMapGrid2d = null;
    
    public static void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) => _glMapGrid2f(un, u1, u2, vn, v1, v2);
    [LGLNativeAPI("glMapGrid2f")] internal static delegate* unmanaged<int, float, float, int, float, float, void> _glMapGrid2f = null;
    
    public static void glEvalCoord1d(double u) => _glEvalCoord1d(u);
    [LGLNativeAPI("glEvalCoord1d")] internal static delegate* unmanaged<double, void> _glEvalCoord1d = null;
    
    public static void glEvalCoord1dv(double* u) => _glEvalCoord1dv(u);
    [LGLNativeAPI("glEvalCoord1dv")] internal static delegate* unmanaged<double*, void> _glEvalCoord1dv = null;
    
    public static void glEvalCoord1f(float u) => _glEvalCoord1f(u);
    [LGLNativeAPI("glEvalCoord1f")] internal static delegate* unmanaged<float, void> _glEvalCoord1f = null;
    
    public static void glEvalCoord1fv(float* u) => _glEvalCoord1fv(u);
    [LGLNativeAPI("glEvalCoord1fv")] internal static delegate* unmanaged<float*, void> _glEvalCoord1fv = null;
    
    public static void glEvalCoord2d(double u, double v) => _glEvalCoord2d(u, v);
    [LGLNativeAPI("glEvalCoord2d")] internal static delegate* unmanaged<double, double, void> _glEvalCoord2d = null;
    
    public static void glEvalCoord2dv(double* u) => _glEvalCoord2dv(u);
    [LGLNativeAPI("glEvalCoord2dv")] internal static delegate* unmanaged<double*, void> _glEvalCoord2dv = null;
    
    public static void glEvalCoord2f(float u, float v) => _glEvalCoord2f(u, v);
    [LGLNativeAPI("glEvalCoord2f")] internal static delegate* unmanaged<float, float, void> _glEvalCoord2f = null;
    
    public static void glEvalCoord2fv(float* u) => _glEvalCoord2fv(u);
    [LGLNativeAPI("glEvalCoord2fv")] internal static delegate* unmanaged<float*, void> _glEvalCoord2fv = null;
    
    public static void glEvalMesh1(uint mode, int i1, int i2) => _glEvalMesh1(mode, i1, i2);
    [LGLNativeAPI("glEvalMesh1")] internal static delegate* unmanaged<uint, int, int, void> _glEvalMesh1 = null;
    
    public static void glEvalPoint1(int i) => _glEvalPoint1(i);
    [LGLNativeAPI("glEvalPoint1")] internal static delegate* unmanaged<int, void> _glEvalPoint1 = null;
    
    public static void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2) => _glEvalMesh2(mode, i1, i2, j1, j2);
    [LGLNativeAPI("glEvalMesh2")] internal static delegate* unmanaged<uint, int, int, int, int, void> _glEvalMesh2 = null;
    
    public static void glEvalPoint2(int i, int j) => _glEvalPoint2(i, j);
    [LGLNativeAPI("glEvalPoint2")] internal static delegate* unmanaged<int, int, void> _glEvalPoint2 = null;
    
    public static void glAlphaFunc(uint func, float @ref) => _glAlphaFunc(func, @ref);
    [LGLNativeAPI("glAlphaFunc")] internal static delegate* unmanaged<uint, float, void> _glAlphaFunc = null;
    
    public static void glPixelZoom(float xfactor, float yfactor) => _glPixelZoom(xfactor, yfactor);
    [LGLNativeAPI("glPixelZoom")] internal static delegate* unmanaged<float, float, void> _glPixelZoom = null;
    
    public static void glPixelTransferf(uint pname, float param) => _glPixelTransferf(pname, param);
    [LGLNativeAPI("glPixelTransferf")] internal static delegate* unmanaged<uint, float, void> _glPixelTransferf = null;
    
    public static void glPixelTransferi(uint pname, int param) => _glPixelTransferi(pname, param);
    [LGLNativeAPI("glPixelTransferi")] internal static delegate* unmanaged<uint, int, void> _glPixelTransferi = null;
    
    public static void glPixelMapfv(uint map, int mapsize, float* values) => _glPixelMapfv(map, mapsize, values);
    [LGLNativeAPI("glPixelMapfv")] internal static delegate* unmanaged<uint, int, float*, void> _glPixelMapfv = null;
    
    public static void glPixelMapuiv(uint map, int mapsize, uint* values) => _glPixelMapuiv(map, mapsize, values);
    [LGLNativeAPI("glPixelMapuiv")] internal static delegate* unmanaged<uint, int, uint*, void> _glPixelMapuiv = null;
    
    public static void glPixelMapusv(uint map, int mapsize, ushort* values) => _glPixelMapusv(map, mapsize, values);
    [LGLNativeAPI("glPixelMapusv")] internal static delegate* unmanaged<uint, int, ushort*, void> _glPixelMapusv = null;
    
    public static void glCopyPixels(int x, int y, int width, int height, uint type) => _glCopyPixels(x, y, width, height, type);
    [LGLNativeAPI("glCopyPixels")] internal static delegate* unmanaged<int, int, int, int, uint, void> _glCopyPixels = null;
    
    public static void glDrawPixels(int width, int height, uint format, uint type, void* pixels) => _glDrawPixels(width, height, format, type, pixels);
    [LGLNativeAPI("glDrawPixels")] internal static delegate* unmanaged<int, int, uint, uint, void*, void> _glDrawPixels = null;
    
    public static void glGetClipPlane(uint plane, double* equation) => _glGetClipPlane(plane, equation);
    [LGLNativeAPI("glGetClipPlane")] internal static delegate* unmanaged<uint, double*, void> _glGetClipPlane = null;
    
    public static void glGetLightfv(uint light, uint pname, float* @params) => _glGetLightfv(light, pname, @params);
    [LGLNativeAPI("glGetLightfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetLightfv = null;
    
    public static void glGetLightiv(uint light, uint pname, int* @params) => _glGetLightiv(light, pname, @params);
    [LGLNativeAPI("glGetLightiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetLightiv = null;
    
    public static void glGetMapdv(uint target, uint query, double* v) => _glGetMapdv(target, query, v);
    [LGLNativeAPI("glGetMapdv")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetMapdv = null;
    
    public static void glGetMapfv(uint target, uint query, float* v) => _glGetMapfv(target, query, v);
    [LGLNativeAPI("glGetMapfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetMapfv = null;
    
    public static void glGetMapiv(uint target, uint query, int* v) => _glGetMapiv(target, query, v);
    [LGLNativeAPI("glGetMapiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetMapiv = null;
    
    public static void glGetMaterialfv(uint face, uint pname, float* @params) => _glGetMaterialfv(face, pname, @params);
    [LGLNativeAPI("glGetMaterialfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetMaterialfv = null;
    
    public static void glGetMaterialiv(uint face, uint pname, int* @params) => _glGetMaterialiv(face, pname, @params);
    [LGLNativeAPI("glGetMaterialiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetMaterialiv = null;
    
    public static void glGetPixelMapfv(uint map, float* values) => _glGetPixelMapfv(map, values);
    [LGLNativeAPI("glGetPixelMapfv")] internal static delegate* unmanaged<uint, float*, void> _glGetPixelMapfv = null;
    
    public static void glGetPixelMapuiv(uint map, uint* values) => _glGetPixelMapuiv(map, values);
    [LGLNativeAPI("glGetPixelMapuiv")] internal static delegate* unmanaged<uint, uint*, void> _glGetPixelMapuiv = null;
    
    public static void glGetPixelMapusv(uint map, ushort* values) => _glGetPixelMapusv(map, values);
    [LGLNativeAPI("glGetPixelMapusv")] internal static delegate* unmanaged<uint, ushort*, void> _glGetPixelMapusv = null;
    
    public static void glGetPolygonStipple(byte* mask) => _glGetPolygonStipple(mask);
    [LGLNativeAPI("glGetPolygonStipple")] internal static delegate* unmanaged<byte*, void> _glGetPolygonStipple = null;
    
    public static void glGetTexEnvfv(uint target, uint pname, float* @params) => _glGetTexEnvfv(target, pname, @params);
    [LGLNativeAPI("glGetTexEnvfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexEnvfv = null;
    
    public static void glGetTexEnviv(uint target, uint pname, int* @params) => _glGetTexEnviv(target, pname, @params);
    [LGLNativeAPI("glGetTexEnviv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexEnviv = null;
    
    public static void glGetTexGendv(uint coord, uint pname, double* @params) => _glGetTexGendv(coord, pname, @params);
    [LGLNativeAPI("glGetTexGendv")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetTexGendv = null;
    
    public static void glGetTexGenfv(uint coord, uint pname, float* @params) => _glGetTexGenfv(coord, pname, @params);
    [LGLNativeAPI("glGetTexGenfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexGenfv = null;
    
    public static void glGetTexGeniv(uint coord, uint pname, int* @params) => _glGetTexGeniv(coord, pname, @params);
    [LGLNativeAPI("glGetTexGeniv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexGeniv = null;
    
    public static bool glIsList(uint list) => _glIsList(list);
    [LGLNativeAPI("glIsList")] internal static delegate* unmanaged<uint, bool> _glIsList = null;
    
    public static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar) => _glFrustum(left, right, bottom, top, zNear, zFar);
    [LGLNativeAPI("glFrustum")] internal static delegate* unmanaged<double, double, double, double, double, double, void> _glFrustum = null;
    
    public static void glLoadIdentity() => _glLoadIdentity();
    [LGLNativeAPI("glLoadIdentity")] internal static delegate* unmanaged<void> _glLoadIdentity = null;
    
    public static void glLoadMatrixf(float* m) => _glLoadMatrixf(m);
    [LGLNativeAPI("glLoadMatrixf")] internal static delegate* unmanaged<float*, void> _glLoadMatrixf = null;
    
    public static void glLoadMatrixd(double* m) => _glLoadMatrixd(m);
    [LGLNativeAPI("glLoadMatrixd")] internal static delegate* unmanaged<double*, void> _glLoadMatrixd = null;
    
    public static void glMatrixMode(uint mode) => _glMatrixMode(mode);
    [LGLNativeAPI("glMatrixMode")] internal static delegate* unmanaged<uint, void> _glMatrixMode = null;
    
    public static void glMultMatrixf(float* m) => _glMultMatrixf(m);
    [LGLNativeAPI("glMultMatrixf")] internal static delegate* unmanaged<float*, void> _glMultMatrixf = null;
    
    public static void glMultMatrixd(double* m) => _glMultMatrixd(m);
    [LGLNativeAPI("glMultMatrixd")] internal static delegate* unmanaged<double*, void> _glMultMatrixd = null;
    
    public static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar) => _glOrtho(left, right, bottom, top, zNear, zFar);
    [LGLNativeAPI("glOrtho")] internal static delegate* unmanaged<double, double, double, double, double, double, void> _glOrtho = null;
    
    public static void glPopMatrix() => _glPopMatrix();
    [LGLNativeAPI("glPopMatrix")] internal static delegate* unmanaged<void> _glPopMatrix = null;
    
    public static void glPushMatrix() => _glPushMatrix();
    [LGLNativeAPI("glPushMatrix")] internal static delegate* unmanaged<void> _glPushMatrix = null;
    
    public static void glRotated(double angle, double x, double y, double z) => _glRotated(angle, x, y, z);
    [LGLNativeAPI("glRotated")] internal static delegate* unmanaged<double, double, double, double, void> _glRotated = null;
    
    public static void glRotatef(float angle, float x, float y, float z) => _glRotatef(angle, x, y, z);
    [LGLNativeAPI("glRotatef")] internal static delegate* unmanaged<float, float, float, float, void> _glRotatef = null;
    
    public static void glScaled(double x, double y, double z) => _glScaled(x, y, z);
    [LGLNativeAPI("glScaled")] internal static delegate* unmanaged<double, double, double, void> _glScaled = null;
    
    public static void glScalef(float x, float y, float z) => _glScalef(x, y, z);
    [LGLNativeAPI("glScalef")] internal static delegate* unmanaged<float, float, float, void> _glScalef = null;
    
    public static void glTranslated(double x, double y, double z) => _glTranslated(x, y, z);
    [LGLNativeAPI("glTranslated")] internal static delegate* unmanaged<double, double, double, void> _glTranslated = null;
    
    public static void glTranslatef(float x, float y, float z) => _glTranslatef(x, y, z);
    [LGLNativeAPI("glTranslatef")] internal static delegate* unmanaged<float, float, float, void> _glTranslatef = null;
     #endregion
}
