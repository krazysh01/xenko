﻿#if XENKO_GRAPHICS_API_VULKAN
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [UIEffect]
//
//     Command Line: D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\sources\assets\Xenko.Core.Assets.CompilerApp\bin\Release\net472\Xenko.Core.Assets.CompilerApp.exe --platform=Windows --property:RuntimeIdentifier=win-vulkan --output-path=D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xenko.Graphics 
{
    internal partial class UIEffect
    {
        private static readonly byte[] binaryBytecodeSRgb = new byte[] {
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
116, 83, 97, 109, 112, 108, 101, 114, 21, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 3, 0, 0, 
0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 13, 84, 101, 120, 116, 117, 114, 101, 
48, 95, 105, 100, 49, 52, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 9, 78, 111, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 9, 78, 111, 83, 97, 109, 112, 108, 101, 114, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 
8, 80, 79, 83, 73, 84, 73, 79, 78, 0, 0, 0, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 0, 0, 5, 67, 79, 76, 79, 82, 0, 0, 0, 0, 0, 13, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 0, 0, 0, 0, 0, 5, 0, 0, 0, 14, 85, 
73, 69, 102, 102, 101, 99, 116, 83, 104, 97, 100, 101, 114, 1, 73, 183, 21, 255, 156, 242, 47, 65, 26, 92, 223, 88, 52, 24, 135, 226, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 172, 190, 61, 77, 68, 160, 70, 238, 222, 135, 17, 118, 190, 233, 199, 84, 16, 83, 104, 97, 100, 101, 
114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 163, 165, 191, 129, 133, 242, 163, 216, 153, 114, 41, 63, 128, 100, 48, 211, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 230, 218, 239, 13, 217, 10, 85, 249, 84, 156, 111, 93, 41, 30, 97, 165, 12, 67, 111, 108, 111, 114, 85, 116, 105, 
108, 105, 116, 121, 1, 193, 201, 137, 96, 204, 243, 212, 99, 251, 53, 219, 18, 235, 65, 96, 129, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 12, 161, 98, 227, 220, 209, 176, 188, 240, 74, 181, 10, 197, 226, 227, 149, 0, 68, 12, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 8, 
80, 79, 83, 73, 84, 73, 79, 78, 1, 0, 0, 0, 0, 9, 84, 69, 88, 67, 79, 79, 82, 68, 48, 2, 0, 0, 0, 0, 5, 67, 79, 76, 79, 82, 3, 0, 0, 0, 0, 13, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 0, 1, 0, 0, 0, 9, 78, 111, 83, 97, 109, 
112, 108, 101, 114, 40, 0, 0, 0, 0, 236, 11, 0, 0, 3, 2, 35, 7, 0, 0, 1, 0, 7, 0, 8, 0, 97, 0, 0, 0, 0, 0, 0, 0, 17, 0, 2, 0, 1, 0, 0, 0, 11, 0, 6, 0, 1, 0, 0, 0, 71, 76, 83, 76, 46, 115, 116, 100, 46, 52, 53, 48, 0, 0, 0, 
0, 14, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 15, 0, 13, 0, 0, 0, 0, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 15, 0, 0, 0, 21, 0, 0, 0, 27, 0, 0, 0, 32, 0, 0, 0, 74, 0, 0, 0, 80, 0, 0, 0, 83, 0, 0, 0, 87, 0, 0, 
0, 3, 0, 3, 0, 2, 0, 0, 0, 194, 1, 0, 0, 5, 0, 4, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 5, 0, 5, 0, 9, 0, 0, 0, 86, 83, 95, 73, 78, 80, 85, 84, 0, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 0, 0, 0, 0, 80, 111, 115, 
105, 116, 105, 111, 110, 95, 105, 100, 55, 51, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 1, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 0, 0, 0, 6, 0, 6, 0, 9, 0, 0, 0, 2, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 
0, 6, 0, 7, 0, 9, 0, 0, 0, 3, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 53, 0, 0, 0, 0, 5, 0, 5, 0, 11, 0, 0, 0, 95, 48, 105, 110, 112, 117, 116, 95, 48, 0, 0, 0, 5, 0, 7, 0, 15, 0, 0, 0, 97, 95, 66, 65, 84, 67, 72, 
95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 5, 0, 5, 0, 21, 0, 0, 0, 97, 95, 67, 79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 5, 0, 27, 0, 0, 0, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 5, 0, 32, 0, 0, 0, 97, 95, 80, 
79, 83, 73, 84, 73, 79, 78, 48, 0, 5, 0, 5, 0, 35, 0, 0, 0, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 0, 0, 6, 0, 7, 0, 35, 0, 0, 0, 0, 0, 0, 0, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 51, 0, 0, 0, 6, 0, 7, 0, 35, 0, 0, 
0, 1, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 0, 0, 0, 6, 0, 6, 0, 35, 0, 0, 0, 2, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 35, 0, 0, 0, 3, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 
95, 105, 100, 55, 53, 0, 0, 0, 0, 6, 0, 8, 0, 35, 0, 0, 0, 4, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 5, 0, 4, 0, 37, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 5, 0, 54, 0, 0, 
0, 86, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 8, 0, 54, 0, 0, 0, 0, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 6, 0, 7, 0, 54, 0, 0, 0, 1, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 
100, 95, 105, 100, 54, 50, 0, 0, 0, 6, 0, 6, 0, 54, 0, 0, 0, 2, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 54, 0, 0, 0, 3, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 53, 0, 0, 0, 0, 5, 0, 5, 
0, 56, 0, 0, 0, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 0, 0, 5, 0, 6, 0, 72, 0, 0, 0, 103, 108, 95, 80, 101, 114, 86, 101, 114, 116, 101, 120, 0, 0, 0, 0, 6, 0, 6, 0, 72, 0, 0, 0, 0, 0, 0, 0, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 
0, 6, 0, 7, 0, 72, 0, 0, 0, 1, 0, 0, 0, 103, 108, 95, 80, 111, 105, 110, 116, 83, 105, 122, 101, 0, 0, 0, 0, 6, 0, 7, 0, 72, 0, 0, 0, 2, 0, 0, 0, 103, 108, 95, 67, 108, 105, 112, 68, 105, 115, 116, 97, 110, 99, 101, 0, 6, 0, 7, 0, 72, 0, 0, 
0, 3, 0, 0, 0, 103, 108, 95, 67, 117, 108, 108, 68, 105, 115, 116, 97, 110, 99, 101, 0, 5, 0, 3, 0, 74, 0, 0, 0, 0, 0, 0, 0, 5, 0, 5, 0, 80, 0, 0, 0, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 5, 0, 83, 0, 0, 0, 118, 95, 67, 
79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 7, 0, 87, 0, 0, 0, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 5, 0, 5, 0, 96, 0, 0, 0, 78, 111, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 71, 0, 4, 0, 15, 0, 0, 
0, 30, 0, 0, 0, 3, 0, 0, 0, 71, 0, 4, 0, 21, 0, 0, 0, 30, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 27, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 32, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 72, 0, 5, 0, 72, 0, 0, 
0, 0, 0, 0, 0, 11, 0, 0, 0, 0, 0, 0, 0, 72, 0, 5, 0, 72, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 1, 0, 0, 0, 72, 0, 5, 0, 72, 0, 0, 0, 2, 0, 0, 0, 11, 0, 0, 0, 3, 0, 0, 0, 72, 0, 5, 0, 72, 0, 0, 0, 3, 0, 0, 
0, 11, 0, 0, 0, 4, 0, 0, 0, 71, 0, 3, 0, 72, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 80, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 83, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 87, 0, 0, 0, 30, 0, 0, 
0, 2, 0, 0, 0, 71, 0, 4, 0, 96, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 96, 0, 0, 0, 33, 0, 0, 0, 40, 0, 0, 0, 19, 0, 2, 0, 2, 0, 0, 0, 33, 0, 3, 0, 3, 0, 0, 0, 2, 0, 0, 0, 22, 0, 3, 0, 6, 0, 0, 
0, 32, 0, 0, 0, 23, 0, 4, 0, 7, 0, 0, 0, 6, 0, 0, 0, 4, 0, 0, 0, 23, 0, 4, 0, 8, 0, 0, 0, 6, 0, 0, 0, 2, 0, 0, 0, 30, 0, 6, 0, 9, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 32, 0, 4, 
0, 10, 0, 0, 0, 7, 0, 0, 0, 9, 0, 0, 0, 21, 0, 4, 0, 12, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 13, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 14, 0, 0, 0, 1, 0, 0, 0, 6, 0, 0, 0, 59, 0, 4, 
0, 14, 0, 0, 0, 15, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 17, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 19, 0, 0, 0, 2, 0, 0, 0, 32, 0, 4, 0, 20, 0, 0, 0, 1, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 
0, 20, 0, 0, 0, 21, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 23, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 25, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 26, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 
0, 26, 0, 0, 0, 27, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 29, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 31, 0, 0, 0, 0, 0, 0, 0, 59, 0, 4, 0, 20, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 30, 0, 7, 
0, 35, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 36, 0, 0, 0, 7, 0, 0, 0, 35, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 50, 0, 0, 0, 4, 0, 0, 0, 30, 0, 6, 0, 54, 0, 0, 
0, 7, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 32, 0, 4, 0, 55, 0, 0, 0, 7, 0, 0, 0, 54, 0, 0, 0, 21, 0, 4, 0, 69, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 43, 0, 4, 0, 69, 0, 0, 0, 70, 0, 0, 0, 1, 0, 0, 
0, 28, 0, 4, 0, 71, 0, 0, 0, 6, 0, 0, 0, 70, 0, 0, 0, 30, 0, 6, 0, 72, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 71, 0, 0, 0, 71, 0, 0, 0, 32, 0, 4, 0, 73, 0, 0, 0, 3, 0, 0, 0, 72, 0, 0, 0, 59, 0, 4, 0, 73, 0, 0, 
0, 74, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 77, 0, 0, 0, 3, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 79, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 79, 0, 0, 0, 80, 0, 0, 0, 3, 0, 0, 0, 59, 0, 4, 0, 77, 0, 0, 
0, 83, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 86, 0, 0, 0, 3, 0, 0, 0, 6, 0, 0, 0, 59, 0, 4, 0, 86, 0, 0, 0, 87, 0, 0, 0, 3, 0, 0, 0, 26, 0, 2, 0, 94, 0, 0, 0, 32, 0, 4, 0, 95, 0, 0, 0, 0, 0, 0, 0, 94, 0, 0, 
0, 59, 0, 4, 0, 95, 0, 0, 0, 96, 0, 0, 0, 0, 0, 0, 0, 54, 0, 5, 0, 2, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 248, 0, 2, 0, 5, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 11, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 
0, 36, 0, 0, 0, 37, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 55, 0, 0, 0, 56, 0, 0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 16, 0, 0, 0, 15, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 18, 0, 0, 0, 11, 0, 0, 0, 13, 0, 0, 
0, 62, 0, 3, 0, 18, 0, 0, 0, 16, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 22, 0, 0, 0, 21, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 24, 0, 0, 0, 11, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 24, 0, 0, 0, 22, 0, 0, 0, 61, 0, 4, 
0, 8, 0, 0, 0, 28, 0, 0, 0, 27, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 30, 0, 0, 0, 11, 0, 0, 0, 25, 0, 0, 0, 62, 0, 3, 0, 30, 0, 0, 0, 28, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 33, 0, 0, 0, 32, 0, 0, 0, 65, 0, 5, 
0, 23, 0, 0, 0, 34, 0, 0, 0, 11, 0, 0, 0, 31, 0, 0, 0, 62, 0, 3, 0, 34, 0, 0, 0, 33, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 38, 0, 0, 0, 11, 0, 0, 0, 31, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 39, 0, 0, 0, 38, 0, 0, 
0, 65, 0, 5, 0, 23, 0, 0, 0, 40, 0, 0, 0, 37, 0, 0, 0, 31, 0, 0, 0, 62, 0, 3, 0, 40, 0, 0, 0, 39, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 41, 0, 0, 0, 11, 0, 0, 0, 25, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 42, 0, 0, 
0, 41, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 43, 0, 0, 0, 37, 0, 0, 0, 25, 0, 0, 0, 62, 0, 3, 0, 43, 0, 0, 0, 42, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 44, 0, 0, 0, 11, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 
0, 45, 0, 0, 0, 44, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 46, 0, 0, 0, 37, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 46, 0, 0, 0, 45, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 47, 0, 0, 0, 11, 0, 0, 0, 13, 0, 0, 0, 61, 0, 4, 
0, 6, 0, 0, 0, 48, 0, 0, 0, 47, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 49, 0, 0, 0, 37, 0, 0, 0, 13, 0, 0, 0, 62, 0, 3, 0, 49, 0, 0, 0, 48, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 51, 0, 0, 0, 37, 0, 0, 0, 31, 0, 0, 
0, 61, 0, 4, 0, 7, 0, 0, 0, 52, 0, 0, 0, 51, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 53, 0, 0, 0, 37, 0, 0, 0, 50, 0, 0, 0, 62, 0, 3, 0, 53, 0, 0, 0, 52, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 57, 0, 0, 0, 37, 0, 0, 
0, 50, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 58, 0, 0, 0, 57, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 59, 0, 0, 0, 56, 0, 0, 0, 31, 0, 0, 0, 62, 0, 3, 0, 59, 0, 0, 0, 58, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 60, 0, 0, 
0, 37, 0, 0, 0, 25, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 61, 0, 0, 0, 60, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 62, 0, 0, 0, 56, 0, 0, 0, 25, 0, 0, 0, 62, 0, 3, 0, 62, 0, 0, 0, 61, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 
0, 63, 0, 0, 0, 37, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 64, 0, 0, 0, 63, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 65, 0, 0, 0, 56, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 65, 0, 0, 0, 64, 0, 0, 0, 65, 0, 5, 
0, 17, 0, 0, 0, 66, 0, 0, 0, 37, 0, 0, 0, 13, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 67, 0, 0, 0, 66, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 68, 0, 0, 0, 56, 0, 0, 0, 13, 0, 0, 0, 62, 0, 3, 0, 68, 0, 0, 0, 67, 0, 0, 
0, 65, 0, 5, 0, 23, 0, 0, 0, 75, 0, 0, 0, 56, 0, 0, 0, 31, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 76, 0, 0, 0, 75, 0, 0, 0, 65, 0, 5, 0, 77, 0, 0, 0, 78, 0, 0, 0, 74, 0, 0, 0, 31, 0, 0, 0, 62, 0, 3, 0, 78, 0, 0, 
0, 76, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 81, 0, 0, 0, 56, 0, 0, 0, 25, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 82, 0, 0, 0, 81, 0, 0, 0, 62, 0, 3, 0, 80, 0, 0, 0, 82, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 84, 0, 0, 
0, 56, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 85, 0, 0, 0, 84, 0, 0, 0, 62, 0, 3, 0, 83, 0, 0, 0, 85, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 88, 0, 0, 0, 56, 0, 0, 0, 13, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 
0, 89, 0, 0, 0, 88, 0, 0, 0, 62, 0, 3, 0, 87, 0, 0, 0, 89, 0, 0, 0, 65, 0, 6, 0, 86, 0, 0, 0, 90, 0, 0, 0, 74, 0, 0, 0, 31, 0, 0, 0, 70, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 91, 0, 0, 0, 90, 0, 0, 0, 127, 0, 4, 
0, 6, 0, 0, 0, 92, 0, 0, 0, 91, 0, 0, 0, 65, 0, 6, 0, 86, 0, 0, 0, 93, 0, 0, 0, 74, 0, 0, 0, 31, 0, 0, 0, 70, 0, 0, 0, 62, 0, 3, 0, 93, 0, 0, 0, 92, 0, 0, 0, 253, 0, 1, 0, 56, 0, 1, 0, 0, 5, 0, 0, 0, 1, 186, 
135, 170, 6, 179, 167, 179, 126, 27, 148, 90, 255, 179, 145, 1, 109, 0, 218, 14, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 2, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 
83, 97, 109, 112, 108, 101, 114, 20, 0, 0, 0, 9, 78, 111, 83, 97, 109, 112, 108, 101, 114, 40, 0, 0, 0, 0, 144, 14, 0, 0, 3, 2, 35, 7, 0, 0, 1, 0, 7, 0, 8, 0, 140, 0, 0, 0, 0, 0, 0, 0, 17, 0, 2, 0, 1, 0, 0, 0, 11, 0, 6, 0, 1, 0, 
0, 0, 71, 76, 83, 76, 46, 115, 116, 100, 46, 52, 53, 48, 0, 0, 0, 0, 14, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 15, 0, 10, 0, 4, 0, 0, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 100, 0, 0, 0, 104, 0, 0, 0, 108, 0, 0, 0, 111, 0, 
0, 0, 136, 0, 0, 0, 16, 0, 3, 0, 4, 0, 0, 0, 7, 0, 0, 0, 3, 0, 3, 0, 2, 0, 0, 0, 194, 1, 0, 0, 5, 0, 4, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 5, 0, 7, 0, 11, 0, 0, 0, 84, 111, 76, 105, 110, 101, 97, 114, 95, 105, 
100, 51, 40, 118, 102, 52, 59, 0, 0, 0, 5, 0, 4, 0, 10, 0, 0, 0, 115, 82, 71, 66, 97, 0, 0, 0, 5, 0, 5, 0, 14, 0, 0, 0, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 0, 0, 6, 0, 7, 0, 14, 0, 0, 0, 0, 0, 0, 0, 84, 101, 120, 67, 111, 111, 
114, 100, 95, 105, 100, 54, 50, 0, 0, 0, 6, 0, 6, 0, 14, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 14, 0, 0, 0, 2, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 53, 0, 0, 0, 0, 6, 0, 
7, 0, 14, 0, 0, 0, 3, 0, 0, 0, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 0, 5, 0, 14, 0, 18, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 115, 116, 114, 117, 99, 116, 45, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 45, 
118, 102, 50, 45, 118, 102, 52, 45, 102, 49, 45, 118, 102, 52, 49, 59, 0, 0, 5, 0, 4, 0, 17, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 4, 0, 22, 0, 0, 0, 115, 82, 71, 66, 0, 0, 0, 0, 5, 0, 6, 0, 49, 0, 0, 0, 115, 97, 109, 112, 108, 101, 
100, 67, 111, 108, 111, 114, 0, 0, 0, 0, 5, 0, 6, 0, 52, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 52, 0, 0, 0, 5, 0, 6, 0, 56, 0, 0, 0, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 50, 0, 0, 0, 0, 5, 0, 4, 0, 66, 0, 
0, 0, 112, 97, 114, 97, 109, 0, 0, 0, 5, 0, 4, 0, 69, 0, 0, 0, 112, 97, 114, 97, 109, 0, 0, 0, 5, 0, 6, 0, 74, 0, 0, 0, 115, 119, 105, 122, 122, 108, 101, 100, 67, 111, 108, 111, 114, 0, 0, 0, 5, 0, 5, 0, 95, 0, 0, 0, 80, 83, 95, 73, 78, 80, 
85, 84, 0, 0, 0, 0, 6, 0, 8, 0, 95, 0, 0, 0, 0, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 6, 0, 7, 0, 95, 0, 0, 0, 1, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 50, 0, 
0, 0, 6, 0, 6, 0, 95, 0, 0, 0, 2, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 95, 0, 0, 0, 3, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 53, 0, 0, 0, 0, 5, 0, 5, 0, 97, 0, 0, 0, 95, 48, 
105, 110, 112, 117, 116, 95, 48, 0, 0, 0, 5, 0, 7, 0, 100, 0, 0, 0, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 5, 0, 5, 0, 104, 0, 0, 0, 118, 95, 67, 79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 5, 0, 108, 0, 
0, 0, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 6, 0, 111, 0, 0, 0, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 0, 0, 0, 0, 5, 0, 4, 0, 114, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 4, 0, 124, 0, 0, 0, 112, 97, 
114, 97, 109, 0, 0, 0, 5, 0, 5, 0, 129, 0, 0, 0, 80, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 7, 0, 129, 0, 0, 0, 0, 0, 0, 0, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 0, 5, 0, 5, 0, 131, 0, 0, 0, 95, 48, 
111, 117, 116, 112, 117, 116, 95, 48, 0, 0, 5, 0, 10, 0, 136, 0, 0, 0, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 0, 5, 0, 5, 0, 139, 0, 0, 0, 78, 111, 83, 97, 109, 112, 
108, 101, 114, 0, 0, 0, 71, 0, 4, 0, 52, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 52, 0, 0, 0, 33, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 56, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 56, 0, 0, 0, 33, 0, 
0, 0, 20, 0, 0, 0, 71, 0, 4, 0, 100, 0, 0, 0, 30, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 104, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 108, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 111, 0, 0, 0, 11, 0, 
0, 0, 15, 0, 0, 0, 71, 0, 4, 0, 136, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 139, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 139, 0, 0, 0, 33, 0, 0, 0, 40, 0, 0, 0, 19, 0, 2, 0, 2, 0, 0, 0, 33, 0, 
3, 0, 3, 0, 0, 0, 2, 0, 0, 0, 22, 0, 3, 0, 6, 0, 0, 0, 32, 0, 0, 0, 23, 0, 4, 0, 7, 0, 0, 0, 6, 0, 0, 0, 4, 0, 0, 0, 32, 0, 4, 0, 8, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 33, 0, 4, 0, 9, 0, 0, 0, 7, 0, 
0, 0, 8, 0, 0, 0, 23, 0, 4, 0, 13, 0, 0, 0, 6, 0, 0, 0, 2, 0, 0, 0, 30, 0, 6, 0, 14, 0, 0, 0, 13, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 15, 0, 0, 0, 7, 0, 0, 0, 14, 0, 0, 0, 33, 0, 
4, 0, 16, 0, 0, 0, 7, 0, 0, 0, 15, 0, 0, 0, 23, 0, 4, 0, 20, 0, 0, 0, 6, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 21, 0, 0, 0, 7, 0, 0, 0, 20, 0, 0, 0, 43, 0, 4, 0, 6, 0, 0, 0, 28, 0, 0, 0, 18, 81, 156, 62, 43, 0, 
4, 0, 6, 0, 0, 0, 30, 0, 0, 0, 196, 162, 46, 63, 43, 0, 4, 0, 6, 0, 0, 0, 34, 0, 0, 0, 194, 44, 77, 60, 21, 0, 4, 0, 38, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 43, 0, 4, 0, 38, 0, 0, 0, 39, 0, 0, 0, 3, 0, 0, 0, 32, 0, 
4, 0, 40, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 25, 0, 9, 0, 50, 0, 0, 0, 6, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 51, 0, 0, 0, 0, 0, 0, 0, 50, 0, 
0, 0, 59, 0, 4, 0, 51, 0, 0, 0, 52, 0, 0, 0, 0, 0, 0, 0, 26, 0, 2, 0, 54, 0, 0, 0, 32, 0, 4, 0, 55, 0, 0, 0, 0, 0, 0, 0, 54, 0, 0, 0, 59, 0, 4, 0, 55, 0, 0, 0, 56, 0, 0, 0, 0, 0, 0, 0, 27, 0, 3, 0, 58, 0, 
0, 0, 50, 0, 0, 0, 21, 0, 4, 0, 60, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 60, 0, 0, 0, 61, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 62, 0, 0, 0, 7, 0, 0, 0, 13, 0, 0, 0, 43, 0, 4, 0, 60, 0, 0, 0, 68, 0, 
0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 60, 0, 0, 0, 75, 0, 0, 0, 2, 0, 0, 0, 43, 0, 4, 0, 6, 0, 0, 0, 78, 0, 0, 0, 0, 0, 0, 0, 20, 0, 2, 0, 79, 0, 0, 0, 30, 0, 6, 0, 95, 0, 0, 0, 7, 0, 0, 0, 13, 0, 0, 0, 7, 0, 
0, 0, 6, 0, 0, 0, 32, 0, 4, 0, 96, 0, 0, 0, 7, 0, 0, 0, 95, 0, 0, 0, 43, 0, 4, 0, 60, 0, 0, 0, 98, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 99, 0, 0, 0, 1, 0, 0, 0, 6, 0, 0, 0, 59, 0, 4, 0, 99, 0, 0, 0, 100, 0, 
0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 103, 0, 0, 0, 1, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 103, 0, 0, 0, 104, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 107, 0, 0, 0, 1, 0, 0, 0, 13, 0, 0, 0, 59, 0, 4, 0, 107, 0, 0, 0, 108, 0, 
0, 0, 1, 0, 0, 0, 59, 0, 4, 0, 103, 0, 0, 0, 111, 0, 0, 0, 1, 0, 0, 0, 30, 0, 3, 0, 129, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 130, 0, 0, 0, 7, 0, 0, 0, 129, 0, 0, 0, 32, 0, 4, 0, 135, 0, 0, 0, 3, 0, 0, 0, 7, 0, 
0, 0, 59, 0, 4, 0, 135, 0, 0, 0, 136, 0, 0, 0, 3, 0, 0, 0, 59, 0, 4, 0, 55, 0, 0, 0, 139, 0, 0, 0, 0, 0, 0, 0, 54, 0, 5, 0, 2, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 248, 0, 2, 0, 5, 0, 0, 0, 59, 0, 
4, 0, 96, 0, 0, 0, 97, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 15, 0, 0, 0, 114, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 15, 0, 0, 0, 124, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 130, 0, 0, 0, 131, 0, 0, 0, 7, 0, 0, 0, 61, 0, 
4, 0, 6, 0, 0, 0, 101, 0, 0, 0, 100, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 102, 0, 0, 0, 97, 0, 0, 0, 98, 0, 0, 0, 62, 0, 3, 0, 102, 0, 0, 0, 101, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 105, 0, 0, 0, 104, 0, 0, 0, 65, 0, 
5, 0, 8, 0, 0, 0, 106, 0, 0, 0, 97, 0, 0, 0, 75, 0, 0, 0, 62, 0, 3, 0, 106, 0, 0, 0, 105, 0, 0, 0, 61, 0, 4, 0, 13, 0, 0, 0, 109, 0, 0, 0, 108, 0, 0, 0, 65, 0, 5, 0, 62, 0, 0, 0, 110, 0, 0, 0, 97, 0, 0, 0, 68, 0, 
0, 0, 62, 0, 3, 0, 110, 0, 0, 0, 109, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 112, 0, 0, 0, 111, 0, 0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 113, 0, 0, 0, 97, 0, 0, 0, 61, 0, 0, 0, 62, 0, 3, 0, 113, 0, 0, 0, 112, 0, 0, 0, 65, 0, 
5, 0, 62, 0, 0, 0, 115, 0, 0, 0, 97, 0, 0, 0, 68, 0, 0, 0, 61, 0, 4, 0, 13, 0, 0, 0, 116, 0, 0, 0, 115, 0, 0, 0, 65, 0, 5, 0, 62, 0, 0, 0, 117, 0, 0, 0, 114, 0, 0, 0, 61, 0, 0, 0, 62, 0, 3, 0, 117, 0, 0, 0, 116, 0, 
0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 118, 0, 0, 0, 97, 0, 0, 0, 75, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 119, 0, 0, 0, 118, 0, 0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 120, 0, 0, 0, 114, 0, 0, 0, 68, 0, 0, 0, 62, 0, 3, 0, 120, 0, 
0, 0, 119, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 121, 0, 0, 0, 97, 0, 0, 0, 98, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 122, 0, 0, 0, 121, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 123, 0, 0, 0, 114, 0, 0, 0, 75, 0, 0, 0, 62, 0, 
3, 0, 123, 0, 0, 0, 122, 0, 0, 0, 61, 0, 4, 0, 14, 0, 0, 0, 125, 0, 0, 0, 114, 0, 0, 0, 62, 0, 3, 0, 124, 0, 0, 0, 125, 0, 0, 0, 57, 0, 5, 0, 7, 0, 0, 0, 126, 0, 0, 0, 18, 0, 0, 0, 124, 0, 0, 0, 61, 0, 4, 0, 14, 0, 
0, 0, 127, 0, 0, 0, 124, 0, 0, 0, 62, 0, 3, 0, 114, 0, 0, 0, 127, 0, 0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 128, 0, 0, 0, 114, 0, 0, 0, 98, 0, 0, 0, 62, 0, 3, 0, 128, 0, 0, 0, 126, 0, 0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 132, 0, 
0, 0, 114, 0, 0, 0, 98, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 133, 0, 0, 0, 132, 0, 0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 134, 0, 0, 0, 131, 0, 0, 0, 61, 0, 0, 0, 62, 0, 3, 0, 134, 0, 0, 0, 133, 0, 0, 0, 65, 0, 5, 0, 8, 0, 
0, 0, 137, 0, 0, 0, 131, 0, 0, 0, 61, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 138, 0, 0, 0, 137, 0, 0, 0, 62, 0, 3, 0, 136, 0, 0, 0, 138, 0, 0, 0, 253, 0, 1, 0, 56, 0, 1, 0, 54, 0, 5, 0, 7, 0, 0, 0, 11, 0, 0, 0, 0, 0, 
0, 0, 9, 0, 0, 0, 55, 0, 3, 0, 8, 0, 0, 0, 10, 0, 0, 0, 248, 0, 2, 0, 12, 0, 0, 0, 59, 0, 4, 0, 21, 0, 0, 0, 22, 0, 0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 23, 0, 0, 0, 10, 0, 0, 0, 79, 0, 8, 0, 20, 0, 
0, 0, 24, 0, 0, 0, 23, 0, 0, 0, 23, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 62, 0, 3, 0, 22, 0, 0, 0, 24, 0, 0, 0, 61, 0, 4, 0, 20, 0, 0, 0, 25, 0, 0, 0, 22, 0, 0, 0, 61, 0, 4, 0, 20, 0, 0, 0, 26, 0, 
0, 0, 22, 0, 0, 0, 61, 0, 4, 0, 20, 0, 0, 0, 27, 0, 0, 0, 22, 0, 0, 0, 142, 0, 5, 0, 20, 0, 0, 0, 29, 0, 0, 0, 27, 0, 0, 0, 28, 0, 0, 0, 80, 0, 6, 0, 20, 0, 0, 0, 31, 0, 0, 0, 30, 0, 0, 0, 30, 0, 0, 0, 30, 0, 
0, 0, 129, 0, 5, 0, 20, 0, 0, 0, 32, 0, 0, 0, 29, 0, 0, 0, 31, 0, 0, 0, 133, 0, 5, 0, 20, 0, 0, 0, 33, 0, 0, 0, 26, 0, 0, 0, 32, 0, 0, 0, 80, 0, 6, 0, 20, 0, 0, 0, 35, 0, 0, 0, 34, 0, 0, 0, 34, 0, 0, 0, 34, 0, 
0, 0, 129, 0, 5, 0, 20, 0, 0, 0, 36, 0, 0, 0, 33, 0, 0, 0, 35, 0, 0, 0, 133, 0, 5, 0, 20, 0, 0, 0, 37, 0, 0, 0, 25, 0, 0, 0, 36, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 41, 0, 0, 0, 10, 0, 0, 0, 39, 0, 0, 0, 61, 0, 
4, 0, 6, 0, 0, 0, 42, 0, 0, 0, 41, 0, 0, 0, 81, 0, 5, 0, 6, 0, 0, 0, 43, 0, 0, 0, 37, 0, 0, 0, 0, 0, 0, 0, 81, 0, 5, 0, 6, 0, 0, 0, 44, 0, 0, 0, 37, 0, 0, 0, 1, 0, 0, 0, 81, 0, 5, 0, 6, 0, 0, 0, 45, 0, 
0, 0, 37, 0, 0, 0, 2, 0, 0, 0, 80, 0, 7, 0, 7, 0, 0, 0, 46, 0, 0, 0, 43, 0, 0, 0, 44, 0, 0, 0, 45, 0, 0, 0, 42, 0, 0, 0, 254, 0, 2, 0, 46, 0, 0, 0, 56, 0, 1, 0, 54, 0, 5, 0, 7, 0, 0, 0, 18, 0, 0, 0, 0, 0, 
0, 0, 16, 0, 0, 0, 55, 0, 3, 0, 15, 0, 0, 0, 17, 0, 0, 0, 248, 0, 2, 0, 19, 0, 0, 0, 59, 0, 4, 0, 8, 0, 0, 0, 49, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 8, 0, 0, 0, 66, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 8, 0, 
0, 0, 69, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 8, 0, 0, 0, 74, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 8, 0, 0, 0, 81, 0, 0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 50, 0, 0, 0, 53, 0, 0, 0, 52, 0, 0, 0, 61, 0, 4, 0, 54, 0, 
0, 0, 57, 0, 0, 0, 56, 0, 0, 0, 86, 0, 5, 0, 58, 0, 0, 0, 59, 0, 0, 0, 53, 0, 0, 0, 57, 0, 0, 0, 65, 0, 5, 0, 62, 0, 0, 0, 63, 0, 0, 0, 17, 0, 0, 0, 61, 0, 0, 0, 61, 0, 4, 0, 13, 0, 0, 0, 64, 0, 0, 0, 63, 0, 
0, 0, 87, 0, 5, 0, 7, 0, 0, 0, 65, 0, 0, 0, 59, 0, 0, 0, 64, 0, 0, 0, 62, 0, 3, 0, 66, 0, 0, 0, 65, 0, 0, 0, 57, 0, 5, 0, 7, 0, 0, 0, 67, 0, 0, 0, 11, 0, 0, 0, 66, 0, 0, 0, 62, 0, 3, 0, 49, 0, 0, 0, 67, 0, 
0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 70, 0, 0, 0, 17, 0, 0, 0, 68, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 71, 0, 0, 0, 70, 0, 0, 0, 62, 0, 3, 0, 69, 0, 0, 0, 71, 0, 0, 0, 57, 0, 5, 0, 7, 0, 0, 0, 72, 0, 0, 0, 11, 0, 
0, 0, 69, 0, 0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 73, 0, 0, 0, 17, 0, 0, 0, 68, 0, 0, 0, 62, 0, 3, 0, 73, 0, 0, 0, 72, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 76, 0, 0, 0, 17, 0, 0, 0, 75, 0, 0, 0, 61, 0, 4, 0, 6, 0, 
0, 0, 77, 0, 0, 0, 76, 0, 0, 0, 180, 0, 5, 0, 79, 0, 0, 0, 80, 0, 0, 0, 77, 0, 0, 0, 78, 0, 0, 0, 247, 0, 3, 0, 83, 0, 0, 0, 0, 0, 0, 0, 250, 0, 4, 0, 80, 0, 0, 0, 82, 0, 0, 0, 85, 0, 0, 0, 248, 0, 2, 0, 82, 0, 
0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 84, 0, 0, 0, 49, 0, 0, 0, 62, 0, 3, 0, 81, 0, 0, 0, 84, 0, 0, 0, 249, 0, 2, 0, 83, 0, 0, 0, 248, 0, 2, 0, 85, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 86, 0, 0, 0, 49, 0, 0, 0, 79, 0, 
9, 0, 7, 0, 0, 0, 87, 0, 0, 0, 86, 0, 0, 0, 86, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 62, 0, 3, 0, 81, 0, 0, 0, 87, 0, 0, 0, 249, 0, 2, 0, 83, 0, 0, 0, 248, 0, 2, 0, 83, 0, 0, 0, 61, 0, 
4, 0, 7, 0, 0, 0, 88, 0, 0, 0, 81, 0, 0, 0, 62, 0, 3, 0, 74, 0, 0, 0, 88, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 89, 0, 0, 0, 74, 0, 0, 0, 65, 0, 5, 0, 8, 0, 0, 0, 90, 0, 0, 0, 17, 0, 0, 0, 68, 0, 0, 0, 61, 0, 
4, 0, 7, 0, 0, 0, 91, 0, 0, 0, 90, 0, 0, 0, 133, 0, 5, 0, 7, 0, 0, 0, 92, 0, 0, 0, 89, 0, 0, 0, 91, 0, 0, 0, 254, 0, 2, 0, 92, 0, 0, 0, 56, 0, 1, 0, 
        };
    }
}
#endif
