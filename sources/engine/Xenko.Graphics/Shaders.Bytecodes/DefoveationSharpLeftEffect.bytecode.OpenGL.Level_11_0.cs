﻿#if XENKO_GRAPHICS_API_OPENGLCORE
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [DefoveationSharpLeftEffect]
//
//     Command Line: D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\sources\assets\Xenko.Core.Assets.CompilerApp\bin\Release\net472\Xenko.Core.Assets.CompilerApp.exe --platform=Windows --property:RuntimeIdentifier=win-opengl --output-path=D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xenko.Graphics 
{
    public partial class DefoveationSharpLeftEffect
    {
        private static readonly byte[] binaryBytecode = new byte[] {
7, 192, 254, 239, 0, 0, 9, 0, 0, 0, 0, 0, 22, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 80, 111, 105, 110, 116, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 23, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 76, 105, 110, 101, 97, 114, 83, 97, 109, 112, 108, 101, 114, 21, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 
0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 29, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 76, 105, 110, 101, 97, 114, 66, 111, 114, 100, 101, 114, 83, 97, 109, 
112, 108, 101, 114, 21, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 44, 84, 101, 120, 116, 117, 
114, 105, 110, 103, 46, 76, 105, 110, 101, 97, 114, 67, 108, 97, 109, 112, 67, 111, 109, 112, 97, 114, 101, 76, 101, 115, 115, 69, 113, 117, 97, 108, 83, 97, 109, 112, 108, 101, 114, 148, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 4, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 28, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 65, 110, 105, 115, 111, 116, 114, 111, 112, 105, 99, 83, 97, 109, 112, 108, 101, 114, 85, 0, 0, 0, 3, 0, 
0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 34, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 65, 110, 105, 115, 111, 
116, 114, 111, 112, 105, 99, 82, 101, 112, 101, 97, 116, 83, 97, 109, 112, 108, 101, 114, 85, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 
255, 127, 255, 255, 255, 127, 127, 0, 0, 28, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 80, 111, 105, 110, 116, 82, 101, 112, 101, 97, 116, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 29, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 76, 105, 110, 101, 97, 114, 82, 101, 112, 101, 97, 116, 83, 97, 109, 112, 108, 101, 114, 21, 0, 0, 0, 1, 0, 
0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 0, 23, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 82, 101, 112, 101, 97, 
116, 83, 97, 109, 112, 108, 101, 114, 21, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 4, 0, 0, 
0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 10, 0, 0, 0, 26, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 7, 80, 101, 114, 68, 114, 97, 119, 0, 7, 80, 101, 114, 68, 114, 97, 119, 1, 0, 
0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 26, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 
7, 71, 108, 111, 98, 97, 108, 115, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 0, 
7, 80, 101, 114, 68, 114, 97, 119, 64, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 26, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 46, 77, 97, 116, 114, 
105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 0, 20, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 51, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 108, 0, 0, 0, 1, 0, 0, 0, 0, 13, 0, 
0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 
114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 53, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 
46, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 55, 8, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 
2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 
100, 49, 57, 16, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 
83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 49, 24, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 
0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 51, 32, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 
0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 53, 
84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 53, 40, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 
120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 55, 48, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 
0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 57, 
56, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 
101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 49, 64, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 
101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 51, 72, 0, 0, 0, 8, 0, 0, 0, 1, 1, 13, 0, 0, 0, 
3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 1, 0, 18, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 46, 67, 111, 108, 111, 114, 0, 10, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 80, 0, 0, 0, 16, 0, 0, 0, 1, 1, 
1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 37, 68, 101, 102, 111, 118, 101, 97, 116, 105, 111, 110, 83, 104, 97, 114, 112, 69, 102, 102, 101, 99, 116, 46, 79, 110, 101, 79, 118, 101, 114, 84, 101, 120, 83, 105, 122, 
101, 0, 19, 79, 110, 101, 79, 118, 101, 114, 84, 101, 120, 83, 105, 122, 101, 95, 105, 100, 55, 53, 96, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 33, 68, 101, 102, 111, 
118, 101, 97, 116, 105, 111, 110, 83, 104, 97, 114, 112, 69, 102, 102, 101, 99, 116, 46, 83, 104, 97, 114, 112, 101, 110, 105, 110, 103, 0, 15, 83, 104, 97, 114, 112, 101, 110, 105, 110, 103, 95, 105, 100, 55, 54, 104, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 
0, 0, 0, 2, 0, 0, 0, 0, 8, 80, 79, 83, 73, 84, 73, 79, 78, 0, 0, 0, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 0, 0, 7, 0, 0, 0, 26, 68, 101, 102, 111, 118, 101, 97, 116, 105, 111, 110, 83, 104, 97, 114, 112, 76, 101, 102, 116, 69, 102, 102, 
101, 99, 116, 1, 223, 127, 118, 4, 31, 9, 165, 62, 90, 205, 252, 18, 222, 236, 85, 240, 22, 68, 101, 102, 111, 118, 101, 97, 116, 105, 111, 110, 83, 104, 97, 114, 112, 69, 102, 102, 101, 99, 116, 1, 251, 134, 180, 204, 74, 51, 178, 107, 81, 161, 20, 220, 198, 193, 188, 48, 12, 83, 112, 114, 
105, 116, 101, 69, 102, 102, 101, 99, 116, 1, 197, 28, 71, 53, 50, 246, 70, 142, 27, 184, 231, 50, 114, 52, 51, 181, 10, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 1, 227, 25, 196, 119, 122, 150, 76, 62, 187, 143, 130, 89, 14, 78, 39, 241, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 
101, 1, 172, 190, 61, 77, 68, 160, 70, 238, 222, 135, 17, 118, 190, 233, 199, 84, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 163, 165, 191, 129, 133, 242, 163, 216, 153, 114, 41, 63, 128, 100, 48, 211, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 230, 
218, 239, 13, 217, 10, 85, 249, 84, 156, 111, 93, 41, 30, 97, 165, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 238, 33, 184, 26, 69, 173, 24, 123, 29, 184, 99, 129, 102, 191, 133, 82, 0, 83, 4, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 49, 48, 13, 10, 13, 10, 115, 
116, 114, 117, 99, 116, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 
95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 
10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 
117, 99, 116, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 
50, 59, 13, 10, 125, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 32, 117, 110, 105, 102, 111, 114, 109, 32, 80, 101, 114, 68, 114, 97, 119, 32, 123, 13, 10, 32, 32, 32, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 
111, 114, 109, 95, 105, 100, 55, 51, 59, 13, 10, 125, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 110, 32, 118, 
101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 
48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 
55, 50, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 
95, 105, 100, 55, 50, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 95, 48, 
105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 40, 115, 116, 114, 101, 97, 
109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 32, 42, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 51, 41, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 
116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 
111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 
32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 
68, 48, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 
122, 32, 42, 32, 50, 46, 48, 32, 45, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 119, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 59, 13, 10, 125, 
13, 10, 0, 5, 0, 0, 0, 1, 135, 109, 193, 128, 50, 131, 165, 96, 66, 106, 97, 217, 35, 100, 23, 230, 0, 25, 11, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 49, 48, 13, 10, 13, 10, 99, 111, 110, 115, 116, 32, 102, 108, 111, 97, 116, 32, 66, 111, 114, 100, 101, 114, 83, 
105, 122, 101, 95, 105, 100, 55, 55, 32, 61, 32, 48, 46, 50, 53, 102, 59, 13, 10, 99, 111, 110, 115, 116, 32, 102, 108, 111, 97, 116, 32, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 66, 111, 114, 100, 101, 114, 83, 105, 122, 101, 95, 105, 100, 55, 56, 32, 61, 32, 48, 46, 49, 50, 53, 
102, 59, 13, 10, 99, 111, 110, 115, 116, 32, 102, 108, 111, 97, 116, 32, 68, 101, 102, 111, 118, 101, 97, 116, 105, 111, 110, 82, 97, 116, 105, 111, 95, 105, 100, 55, 57, 32, 61, 32, 50, 46, 48, 102, 59, 13, 10, 99, 111, 110, 115, 116, 32, 102, 108, 111, 97, 116, 32, 68, 101, 99, 111, 109, 
112, 114, 101, 115, 115, 105, 111, 110, 82, 97, 116, 105, 111, 95, 105, 100, 56, 48, 32, 61, 32, 49, 46, 53, 102, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 
111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 
10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 
97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 125, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 
32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 53, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 
101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 55, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 57, 59, 13, 10, 32, 32, 32, 32, 118, 101, 
99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 51, 59, 13, 10, 32, 32, 
32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 53, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 55, 59, 
13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 57, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 
100, 51, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 51, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 59, 13, 10, 32, 32, 
32, 32, 118, 101, 99, 50, 32, 79, 110, 101, 79, 118, 101, 114, 84, 101, 120, 83, 105, 122, 101, 95, 105, 100, 55, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 83, 104, 97, 114, 112, 101, 110, 105, 110, 103, 95, 105, 100, 55, 54, 59, 13, 10, 125, 59, 13, 10, 117, 110, 105, 
102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 108, 111, 99, 97, 116, 105, 111, 110, 32, 61, 32, 48, 41, 
32, 32, 111, 117, 116, 32, 118, 101, 99, 52, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 
59, 13, 10, 118, 101, 99, 51, 32, 67, 65, 83, 95, 105, 100, 53, 40, 105, 110, 32, 118, 101, 99, 50, 32, 117, 118, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 97, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 
49, 52, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 44, 32, 117, 118, 41, 46, 114, 103, 98, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 98, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 95, 83, 97, 
109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 44, 32, 117, 118, 32, 43, 32, 118, 101, 99, 50, 40, 45, 79, 110, 101, 79, 118, 101, 114, 84, 101, 120, 83, 105, 122, 101, 95, 105, 100, 55, 53, 46, 120, 44, 32, 48, 46, 48, 41, 41, 46, 114, 103, 98, 59, 13, 10, 32, 32, 32, 32, 118, 101, 
99, 51, 32, 99, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 44, 32, 117, 118, 32, 43, 32, 118, 101, 99, 50, 40, 48, 46, 48, 44, 32, 45, 79, 110, 101, 79, 118, 
101, 114, 84, 101, 120, 83, 105, 122, 101, 95, 105, 100, 55, 53, 46, 121, 41, 41, 46, 114, 103, 98, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 100, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 95, 83, 97, 109, 112, 
108, 101, 114, 95, 105, 100, 52, 50, 44, 32, 117, 118, 32, 43, 32, 118, 101, 99, 50, 40, 79, 110, 101, 79, 118, 101, 114, 84, 101, 120, 83, 105, 122, 101, 95, 105, 100, 55, 53, 46, 120, 44, 32, 48, 46, 48, 41, 41, 46, 114, 103, 98, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 
101, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 44, 32, 117, 118, 32, 43, 32, 118, 101, 99, 50, 40, 48, 46, 48, 44, 32, 79, 110, 101, 79, 118, 101, 114, 84, 101, 
120, 83, 105, 122, 101, 95, 105, 100, 55, 53, 46, 121, 41, 41, 46, 114, 103, 98, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 109, 105, 110, 77, 97, 120, 71, 32, 61, 32, 118, 101, 99, 50, 40, 109, 105, 110, 40, 97, 46, 103, 44, 32, 109, 105, 110, 40, 98, 46, 103, 44, 32, 109, 
105, 110, 40, 99, 46, 103, 44, 32, 109, 105, 110, 40, 100, 46, 103, 44, 32, 101, 46, 103, 41, 41, 41, 41, 44, 32, 109, 97, 120, 40, 97, 46, 103, 44, 32, 109, 97, 120, 40, 98, 46, 103, 44, 32, 109, 97, 120, 40, 99, 46, 103, 44, 32, 109, 97, 120, 40, 100, 46, 103, 44, 32, 101, 46, 
103, 41, 41, 41, 41, 41, 59, 13, 10, 32, 32, 32, 32, 109, 105, 110, 77, 97, 120, 71, 46, 121, 32, 43, 61, 32, 48, 46, 48, 48, 48, 53, 102, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 65, 65, 32, 61, 32, 115, 113, 114, 116, 40, 109, 105, 110, 40, 49, 46, 48, 32, 
45, 32, 109, 105, 110, 77, 97, 120, 71, 46, 121, 44, 32, 109, 105, 110, 77, 97, 120, 71, 46, 120, 41, 32, 47, 32, 109, 105, 110, 77, 97, 120, 71, 46, 121, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 119, 32, 61, 32, 83, 104, 97, 114, 112, 101, 110, 105, 110, 103, 95, 
105, 100, 55, 54, 32, 42, 32, 65, 65, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 40, 119, 32, 42, 32, 40, 98, 32, 43, 32, 99, 32, 43, 32, 100, 32, 43, 32, 101, 41, 32, 43, 32, 97, 41, 32, 47, 32, 40, 119, 32, 42, 32, 52, 46, 48, 32, 43, 32, 49, 46, 
48, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 50, 32, 68, 101, 102, 111, 118, 101, 97, 116, 101, 95, 105, 100, 52, 40, 105, 110, 32, 118, 101, 99, 50, 32, 116, 101, 120, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 110, 101, 97, 114, 66, 111, 114, 100, 101, 114, 32, 
61, 32, 49, 46, 48, 32, 45, 32, 115, 116, 101, 112, 40, 118, 101, 99, 50, 40, 66, 111, 114, 100, 101, 114, 83, 105, 122, 101, 95, 105, 100, 55, 55, 41, 44, 32, 116, 101, 120, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 102, 97, 114, 66, 111, 114, 100, 101, 114, 32, 61, 32, 
115, 116, 101, 112, 40, 118, 101, 99, 50, 40, 40, 49, 46, 48, 32, 45, 32, 66, 111, 114, 100, 101, 114, 83, 105, 122, 101, 95, 105, 100, 55, 55, 41, 41, 44, 32, 116, 101, 120, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 99, 101, 110, 116, 101, 114, 32, 61, 32, 49, 46, 48, 
32, 45, 32, 110, 101, 97, 114, 66, 111, 114, 100, 101, 114, 32, 45, 32, 102, 97, 114, 66, 111, 114, 100, 101, 114, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 105, 110, 118, 101, 114, 115, 101, 84, 101, 120, 32, 61, 32, 49, 46, 48, 32, 45, 32, 116, 101, 120, 59, 13, 10, 32, 32, 
32, 32, 114, 101, 116, 117, 114, 110, 32, 40, 110, 101, 97, 114, 66, 111, 114, 100, 101, 114, 32, 42, 32, 116, 101, 120, 32, 42, 32, 116, 101, 120, 32, 42, 32, 68, 101, 102, 111, 118, 101, 97, 116, 105, 111, 110, 82, 97, 116, 105, 111, 95, 105, 100, 55, 57, 41, 32, 43, 32, 40, 102, 97, 114, 
66, 111, 114, 100, 101, 114, 32, 42, 32, 40, 49, 46, 48, 32, 45, 32, 40, 105, 110, 118, 101, 114, 115, 101, 84, 101, 120, 32, 42, 32, 105, 110, 118, 101, 114, 115, 101, 84, 101, 120, 32, 42, 32, 68, 101, 102, 111, 118, 101, 97, 116, 105, 111, 110, 82, 97, 116, 105, 111, 95, 105, 100, 55, 57, 
41, 41, 41, 32, 43, 32, 40, 99, 101, 110, 116, 101, 114, 32, 42, 32, 40, 40, 116, 101, 120, 32, 45, 32, 66, 111, 114, 100, 101, 114, 83, 105, 122, 101, 95, 105, 100, 55, 55, 41, 32, 42, 32, 68, 101, 99, 111, 109, 112, 114, 101, 115, 115, 105, 111, 110, 82, 97, 116, 105, 111, 95, 105, 100, 
56, 48, 32, 43, 32, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 66, 111, 114, 100, 101, 114, 83, 105, 122, 101, 95, 105, 100, 55, 56, 41, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 55, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 
83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 117, 118, 32, 61, 32, 68, 101, 102, 111, 118, 101, 97, 116, 101, 95, 105, 100, 52, 40, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 
100, 95, 105, 100, 54, 50, 41, 59, 13, 10, 32, 32, 32, 32, 117, 118, 46, 120, 32, 61, 32, 117, 118, 46, 120, 32, 47, 32, 102, 108, 111, 97, 116, 40, 50, 41, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 118, 101, 99, 52, 40, 67, 65, 83, 95, 105, 100, 53, 40, 117, 
118, 41, 44, 32, 49, 46, 48, 41, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 80, 83, 95, 73, 78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 
117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 
95, 105, 100, 48, 32, 61, 32, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 
111, 114, 100, 95, 105, 100, 54, 50, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 
32, 61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 55, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 
116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 32, 32, 32, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 
97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 13, 10, 
        };
    }
}
#endif
