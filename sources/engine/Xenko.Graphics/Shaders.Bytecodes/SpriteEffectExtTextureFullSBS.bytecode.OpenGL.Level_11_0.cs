﻿#if XENKO_GRAPHICS_API_OPENGLCORE
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [SpriteEffectExtTextureFullSBS]
//
//     Command Line: D:\Work\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\sources\assets\Xenko.Core.Assets.CompilerApp\bin\Release\net472\Xenko.Core.Assets.CompilerApp.exe --platform=Windows --property:RuntimeIdentifier=win-opengl --output-path=D:\Work\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=D:\Work\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xenko.Graphics 
{
    public partial class SpriteEffectExtTextureFullSBS
    {
        private static readonly byte[] binaryBytecode = new byte[] {
7, 192, 254, 239, 0, 0, 1, 0, 0, 0, 0, 0, 30, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 83, 97, 109, 112, 108, 101, 114, 21, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 
0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 3, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 26, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 7, 71, 108, 111, 98, 97, 108, 115, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 48, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 
120, 116, 117, 114, 101, 46, 88, 101, 110, 107, 111, 73, 110, 116, 101, 114, 110, 97, 108, 95, 84, 101, 120, 116, 117, 114, 101, 69, 120, 116, 48, 9, 0, 0, 0, 7, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 
1, 0, 30, 88, 101, 110, 107, 111, 73, 110, 116, 101, 114, 110, 97, 108, 95, 84, 101, 120, 116, 117, 114, 101, 69, 120, 116, 48, 95, 105, 100, 50, 48, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 30, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 
84, 101, 120, 116, 117, 114, 101, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 50, 51, 1, 
5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 68, 0, 0, 0, 1, 0, 0, 0, 0, 11, 0, 0, 0, 13, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 
0, 1, 1, 0, 28, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 67, 111, 108, 111, 114, 0, 10, 67, 111, 108, 111, 114, 95, 105, 100, 49, 52, 0, 0, 0, 0, 16, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 
0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 37, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 73, 115, 67, 104, 114, 111, 109, 97, 65, 99, 116, 105, 118, 101, 0, 19, 73, 115, 67, 104, 114, 111, 
109, 97, 65, 99, 116, 105, 118, 101, 95, 105, 100, 49, 53, 16, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 33, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 
120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 83, 105, 109, 105, 108, 97, 114, 105, 116, 121, 0, 15, 83, 105, 109, 105, 108, 97, 114, 105, 116, 121, 95, 105, 100, 49, 54, 20, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 
0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 33, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 83, 109, 111, 111, 116, 104, 110, 101, 115, 115, 0, 15, 83, 109, 111, 111, 116, 104, 110, 101, 115, 115, 95, 105, 100, 49, 55, 24, 0, 0, 
0, 4, 0, 0, 0, 1, 1, 13, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 12, 0, 0, 0, 1, 1, 0, 37, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 67, 104, 114, 111, 109, 97, 
75, 101, 121, 67, 111, 108, 111, 114, 0, 19, 67, 104, 114, 111, 109, 97, 75, 101, 121, 67, 111, 108, 111, 114, 95, 105, 100, 49, 56, 32, 0, 0, 0, 12, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 
1, 0, 28, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 73, 115, 72, 68, 82, 0, 10, 73, 115, 72, 68, 82, 95, 105, 100, 49, 57, 44, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 19, 0, 0, 0, 1, 0, 0, 
0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 40, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 0, 15, 70, 114, 97, 109, 101, 
87, 105, 100, 116, 104, 95, 105, 100, 50, 52, 48, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 19, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 41, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 
101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 0, 16, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 53, 52, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 19, 0, 0, 0, 1, 0, 0, 
0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 43, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 86, 105, 101, 119, 112, 111, 114, 116, 87, 105, 100, 116, 104, 0, 18, 86, 105, 
101, 119, 112, 111, 114, 116, 87, 105, 100, 116, 104, 95, 105, 100, 50, 54, 56, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 19, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 44, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 
99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 86, 105, 101, 119, 112, 111, 114, 116, 72, 101, 105, 103, 104, 116, 0, 19, 86, 105, 101, 119, 112, 111, 114, 116, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 55, 60, 0, 0, 0, 4, 0, 0, 0, 1, 
1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 41, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 76, 101, 116, 116, 101, 
114, 98, 111, 120, 101, 100, 0, 16, 76, 101, 116, 116, 101, 114, 98, 111, 120, 101, 100, 95, 105, 100, 50, 56, 64, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 8, 80, 79, 83, 73, 84, 73, 79, 78, 0, 0, 0, 0, 0, 
8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 0, 0, 5, 0, 0, 0, 29, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 1, 158, 189, 196, 224, 96, 235, 118, 86, 179, 55, 211, 83, 237, 63, 130, 
28, 22, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 1, 59, 193, 168, 80, 196, 97, 110, 19, 209, 47, 11, 217, 151, 8, 170, 137, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 172, 190, 61, 77, 68, 160, 70, 238, 222, 135, 17, 
118, 190, 233, 199, 84, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 163, 165, 191, 129, 133, 242, 163, 216, 153, 114, 41, 63, 128, 100, 48, 211, 12, 67, 111, 108, 111, 114, 85, 116, 105, 108, 105, 116, 121, 1, 193, 201, 137, 96, 204, 243, 212, 99, 251, 53, 219, 
18, 235, 65, 96, 129, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 57, 29, 86, 51, 157, 99, 43, 240, 176, 175, 183, 141, 32, 110, 45, 2, 0, 243, 3, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 49, 48, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 83, 
84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 50, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 59, 13, 10, 32, 32, 
32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 
83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 73, 78, 80, 
85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 50, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 59, 13, 10, 125, 59, 13, 10, 111, 117, 
116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 
10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 
95, 105, 100, 50, 49, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 50, 50, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 
13, 10, 32, 32, 32, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 50, 50, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 
46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 50, 50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 
105, 100, 50, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 50, 50, 59, 13, 
10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 
32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 32, 61, 32, 115, 116, 
114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 
111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 
105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 42, 32, 50, 46, 48, 32, 45, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 119, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 
121, 32, 61, 32, 45, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 59, 13, 10, 125, 13, 10, 0, 5, 0, 0, 0, 1, 50, 131, 72, 109, 148, 70, 218, 147, 104, 251, 24, 150, 253, 197, 72, 215, 0, 94, 16, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 49, 48, 13, 
10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 
114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 
59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 
101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 59, 13, 10, 125, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 13, 10, 32, 32, 32, 32, 118, 
101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 49, 52, 59, 13, 10, 32, 32, 32, 32, 98, 111, 111, 108, 32, 73, 115, 67, 104, 114, 111, 109, 97, 65, 99, 116, 105, 118, 101, 95, 105, 100, 49, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 83, 105, 109, 105, 108, 97, 
114, 105, 116, 121, 95, 105, 100, 49, 54, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 83, 109, 111, 111, 116, 104, 110, 101, 115, 115, 95, 105, 100, 49, 55, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 67, 104, 114, 111, 109, 97, 75, 101, 121, 67, 111, 108, 111, 114, 95, 
105, 100, 49, 56, 59, 13, 10, 32, 32, 32, 32, 98, 111, 111, 108, 32, 73, 115, 72, 68, 82, 95, 105, 100, 49, 57, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 52, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 
32, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 53, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 86, 105, 101, 119, 112, 111, 114, 116, 87, 105, 100, 116, 104, 95, 105, 100, 50, 54, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 86, 105, 101, 119, 112, 
111, 114, 116, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 55, 59, 13, 10, 32, 32, 32, 32, 98, 111, 111, 108, 32, 76, 101, 116, 116, 101, 114, 98, 111, 120, 101, 100, 95, 105, 100, 50, 56, 59, 13, 10, 125, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 
50, 68, 32, 88, 101, 110, 107, 111, 73, 110, 116, 101, 114, 110, 97, 108, 95, 84, 101, 120, 116, 117, 114, 101, 69, 120, 116, 48, 95, 105, 100, 50, 48, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 50, 51, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 108, 111, 99, 97, 116, 105, 111, 110, 
32, 61, 32, 48, 41, 32, 32, 111, 117, 116, 32, 118, 101, 99, 52, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 
79, 79, 82, 68, 48, 59, 13, 10, 118, 101, 99, 51, 32, 84, 111, 83, 68, 82, 95, 105, 100, 52, 40, 118, 101, 99, 51, 32, 104, 100, 114, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 112, 101, 97, 107, 76, 117, 109, 105, 110, 97, 110, 99, 101, 32, 61, 32, 49, 
48, 48, 46, 48, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 107, 110, 101, 101, 32, 61, 32, 48, 46, 55, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 114, 97, 116, 105, 111, 32, 61, 32, 53, 46, 48, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 
32, 109, 97, 120, 67, 76, 76, 32, 61, 32, 49, 48, 48, 48, 48, 46, 48, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 103, 97, 105, 110, 32, 61, 32, 109, 97, 120, 67, 76, 76, 32, 47, 32, 112, 101, 97, 107, 76, 117, 109, 105, 110, 97, 110, 99, 101, 59, 13, 10, 32, 32, 
32, 32, 102, 108, 111, 97, 116, 32, 99, 111, 109, 112, 114, 101, 115, 115, 111, 114, 32, 61, 32, 49, 46, 48, 32, 47, 32, 114, 97, 116, 105, 111, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 109, 49, 105, 110, 118, 32, 61, 32, 102, 108, 111, 97, 116, 40, 49, 54, 51, 56, 52, 
41, 32, 47, 32, 50, 54, 49, 48, 46, 48, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 109, 50, 105, 110, 118, 32, 61, 32, 102, 108, 111, 97, 116, 40, 51, 50, 41, 32, 47, 32, 50, 53, 50, 51, 46, 48, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 99, 49, 
32, 61, 32, 102, 108, 111, 97, 116, 40, 51, 52, 50, 52, 41, 32, 47, 32, 52, 48, 57, 54, 46, 48, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 99, 50, 32, 61, 32, 102, 108, 111, 97, 116, 40, 50, 52, 49, 51, 41, 32, 47, 32, 49, 50, 56, 46, 48, 59, 13, 10, 32, 
32, 32, 32, 102, 108, 111, 97, 116, 32, 99, 51, 32, 61, 32, 102, 108, 111, 97, 116, 40, 50, 51, 57, 50, 41, 32, 47, 32, 49, 50, 56, 46, 48, 59, 13, 10, 32, 32, 32, 32, 109, 97, 116, 51, 32, 98, 116, 50, 48, 50, 48, 95, 116, 111, 95, 98, 116, 55, 48, 57, 32, 61, 32, 109, 
97, 116, 51, 40, 49, 46, 54, 54, 48, 52, 57, 49, 48, 48, 50, 49, 44, 32, 45, 48, 46, 49, 50, 52, 53, 53, 48, 52, 55, 52, 53, 44, 32, 45, 48, 46, 48, 49, 56, 49, 53, 48, 55, 54, 51, 52, 44, 32, 45, 48, 46, 53, 56, 55, 54, 52, 49, 49, 51, 56, 56, 44, 32, 49, 
46, 49, 51, 50, 56, 57, 57, 56, 57, 55, 49, 44, 32, 45, 48, 46, 49, 48, 48, 53, 55, 56, 56, 57, 56, 48, 44, 32, 45, 48, 46, 48, 55, 50, 56, 52, 57, 56, 54, 51, 51, 44, 32, 45, 48, 46, 48, 48, 56, 51, 52, 57, 52, 50, 50, 54, 44, 32, 49, 46, 49, 49, 56, 55, 
50, 57, 54, 54, 49, 52, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 112, 32, 61, 32, 112, 111, 119, 40, 97, 98, 115, 40, 104, 100, 114, 41, 44, 32, 118, 101, 99, 51, 40, 109, 50, 105, 110, 118, 41, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 100, 32, 61, 
32, 109, 97, 120, 40, 112, 32, 45, 32, 99, 49, 44, 32, 118, 101, 99, 51, 40, 48, 41, 41, 32, 47, 32, 40, 99, 50, 32, 45, 32, 99, 51, 32, 42, 32, 112, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 108, 117, 109, 105, 110, 97, 110, 99, 101, 32, 61, 32, 112, 111, 119, 
40, 97, 98, 115, 40, 100, 41, 44, 32, 118, 101, 99, 51, 40, 109, 49, 105, 110, 118, 41, 41, 32, 42, 32, 103, 97, 105, 110, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 112, 105, 120, 101, 108, 32, 61, 32, 40, 98, 116, 50, 48, 50, 48, 95, 116, 111, 95, 98, 116, 55, 48, 57, 
32, 42, 32, 108, 117, 109, 105, 110, 97, 110, 99, 101, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 112, 101, 101, 107, 71, 97, 105, 110, 32, 61, 32, 109, 97, 120, 40, 112, 105, 120, 101, 108, 46, 114, 44, 32, 109, 97, 120, 40, 112, 105, 120, 101, 108, 46, 103, 44, 32, 112, 
105, 120, 101, 108, 46, 98, 41, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 114, 103, 98, 32, 61, 32, 112, 105, 120, 101, 108, 32, 42, 32, 40, 112, 101, 101, 107, 71, 97, 105, 110, 32, 60, 32, 107, 110, 101, 101, 32, 63, 32, 112, 101, 101, 107, 71, 97, 105, 110, 32, 58, 32, 
107, 110, 101, 101, 32, 43, 32, 109, 97, 120, 40, 112, 101, 101, 107, 71, 97, 105, 110, 32, 45, 32, 107, 110, 101, 101, 44, 32, 102, 108, 111, 97, 116, 40, 48, 41, 41, 32, 42, 32, 99, 111, 109, 112, 114, 101, 115, 115, 111, 114, 41, 32, 47, 32, 112, 101, 101, 107, 71, 97, 105, 110, 59, 13, 
10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 83, 49, 32, 61, 32, 115, 113, 114, 116, 40, 114, 103, 98, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 83, 50, 32, 61, 32, 115, 113, 114, 116, 40, 83, 49, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 83, 51, 32, 
61, 32, 115, 113, 114, 116, 40, 83, 50, 41, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 48, 46, 53, 56, 53, 49, 50, 50, 51, 56, 49, 32, 42, 32, 83, 49, 32, 43, 32, 48, 46, 55, 56, 51, 49, 52, 48, 51, 53, 53, 32, 42, 32, 83, 50, 32, 45, 32, 48, 46, 
51, 54, 56, 50, 54, 50, 55, 51, 54, 32, 42, 32, 83, 51, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 
123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 118, 97, 108, 117, 101, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 88, 101, 110, 107, 111, 73, 110, 116, 101, 114, 110, 97, 108, 95, 84, 101, 120, 116, 117, 114, 101, 69, 120, 116, 48, 95, 105, 100, 50, 48, 95, 83, 97, 109, 112, 108, 
101, 114, 95, 105, 100, 50, 51, 44, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 41, 46, 114, 103, 98, 59, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 73, 115, 72, 68, 82, 95, 105, 100, 49, 57, 41, 13, 10, 32, 32, 32, 32, 123, 
13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 118, 97, 108, 117, 101, 32, 61, 32, 84, 111, 83, 68, 82, 95, 105, 100, 52, 40, 118, 97, 108, 117, 101, 41, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 118, 101, 99, 52, 40, 118, 97, 108, 117, 
101, 44, 32, 49, 46, 48, 41, 32, 42, 32, 67, 111, 108, 111, 114, 95, 105, 100, 49, 52, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 51, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 
97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 99, 111, 108, 111, 114, 32, 61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 115, 116, 97, 114, 116, 72, 
101, 105, 103, 104, 116, 32, 61, 32, 117, 105, 110, 116, 40, 76, 101, 116, 116, 101, 114, 98, 111, 120, 101, 100, 95, 105, 100, 50, 56, 32, 63, 32, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 53, 41, 32, 42, 32, 48, 46, 50, 53, 102, 32, 
58, 32, 102, 108, 111, 97, 116, 40, 48, 41, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 101, 110, 100, 72, 101, 105, 103, 104, 116, 32, 61, 32, 117, 105, 110, 116, 40, 76, 101, 116, 116, 101, 114, 98, 111, 120, 101, 100, 95, 105, 100, 50, 56, 32, 63, 32, 102, 108, 111, 97, 116, 
40, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 53, 41, 32, 42, 32, 48, 46, 55, 53, 102, 32, 58, 32, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 53, 41, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 
32, 120, 32, 61, 32, 117, 105, 110, 116, 40, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 46, 120, 32, 42, 32, 102, 108, 111, 97, 116, 40, 86, 105, 101, 119, 112, 111, 114, 116, 87, 105, 100, 116, 104, 95, 105, 100, 50, 54, 41, 41, 59, 13, 
10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 121, 32, 61, 32, 117, 105, 110, 116, 40, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 46, 121, 32, 42, 32, 102, 108, 111, 97, 116, 40, 86, 105, 101, 119, 112, 111, 114, 116, 72, 101, 105, 103, 104, 
116, 95, 105, 100, 50, 55, 41, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 109, 105, 100, 100, 108, 101, 32, 61, 32, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 52, 32, 47, 32, 117, 105, 110, 116, 40, 50, 41, 59, 13, 10, 32, 32, 32, 32, 105, 102, 32, 
40, 121, 32, 60, 32, 115, 116, 97, 114, 116, 72, 101, 105, 103, 104, 116, 32, 43, 32, 117, 105, 110, 116, 40, 52, 41, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 99, 111, 108, 111, 114, 32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 
108, 111, 97, 116, 40, 115, 116, 97, 114, 116, 72, 101, 105, 103, 104, 116, 41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 115, 116, 97, 114, 116, 72, 101, 105, 103, 104, 116, 41, 32, 43, 32, 102, 108, 111, 97, 116, 40, 51, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 121, 
41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 101, 108, 115, 101, 32, 105, 102, 32, 40, 121, 32, 62, 61, 32, 101, 110, 100, 72, 101, 105, 103, 104, 116, 32, 45, 32, 117, 105, 110, 116, 40, 52, 41, 41, 13, 10, 32, 32, 32, 32, 
123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 99, 111, 108, 111, 114, 32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 101, 110, 100, 72, 101, 105, 103, 104, 116, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 49, 41, 41, 
44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 101, 110, 100, 72, 101, 105, 103, 104, 116, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 52, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 121, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 125, 13, 
10, 32, 32, 32, 32, 105, 102, 32, 40, 120, 32, 60, 32, 109, 105, 100, 100, 108, 101, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 105, 102, 32, 40, 120, 32, 60, 32, 117, 105, 110, 116, 40, 52, 41, 41, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 123, 
13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 102, 108, 111, 97, 116, 40, 51, 41, 44, 32, 102, 108, 111, 97, 116, 40, 120, 41, 41, 32, 42, 32, 
99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 109, 105, 100, 100, 108, 101, 41, 
32, 45, 32, 102, 108, 111, 97, 116, 40, 49, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 109, 105, 100, 100, 108, 101, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 52, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 120, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 
59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 101, 108, 115, 101, 32, 105, 102, 32, 40, 120, 32, 62, 61, 32, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 52, 32, 45, 32, 117, 105, 110, 116, 40, 52, 41, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 
32, 32, 32, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 52, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 49, 41, 
41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 52, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 52, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 120, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 
10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 109, 105, 100, 100, 108, 101, 41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 109, 105, 100, 100, 108, 101, 41, 
32, 43, 32, 102, 108, 111, 97, 116, 40, 51, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 120, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 80, 83, 95, 73, 78, 80, 85, 
84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 
105, 110, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 
97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 50, 49, 59, 13, 10, 32, 32, 32, 32, 
118, 101, 99, 52, 32, 99, 111, 108, 111, 114, 32, 61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 51, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 73, 115, 67, 104, 114, 111, 109, 97, 65, 99, 116, 105, 118, 101, 95, 105, 100, 49, 53, 41, 
13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 99, 104, 114, 111, 109, 97, 68, 105, 115, 116, 32, 61, 32, 100, 105, 115, 116, 97, 110, 99, 101, 40, 118, 101, 99, 51, 40, 99, 111, 108, 111, 114, 41, 44, 32, 67, 104, 114, 111, 109, 97, 
75, 101, 121, 67, 111, 108, 111, 114, 95, 105, 100, 49, 56, 41, 32, 47, 32, 115, 113, 114, 116, 40, 102, 108, 111, 97, 116, 40, 51, 41, 41, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 98, 97, 115, 101, 77, 97, 115, 107, 32, 61, 32, 99, 104, 114, 111, 109, 
97, 68, 105, 115, 116, 32, 45, 32, 83, 105, 109, 105, 108, 97, 114, 105, 116, 121, 95, 105, 100, 49, 54, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 102, 117, 108, 108, 77, 97, 115, 107, 32, 61, 32, 112, 111, 119, 40, 99, 108, 97, 109, 112, 40, 98, 97, 115, 
101, 77, 97, 115, 107, 32, 47, 32, 83, 109, 111, 111, 116, 104, 110, 101, 115, 115, 95, 105, 100, 49, 55, 44, 32, 48, 46, 48, 44, 32, 49, 46, 48, 41, 44, 32, 49, 46, 53, 41, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 99, 111, 108, 111, 114, 46, 97, 32, 61, 32, 102, 117, 108, 
108, 77, 97, 115, 107, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 
85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 
114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 32, 32, 32, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 
114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 13, 10, 
        };
    }
}
#endif
