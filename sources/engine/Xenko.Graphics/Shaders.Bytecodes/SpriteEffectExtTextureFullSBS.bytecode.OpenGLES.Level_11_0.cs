﻿#if XENKO_GRAPHICS_API_OPENGLES
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [SpriteEffectExtTextureFullSBS]
//
//     Command Line: D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\sources\assets\Xenko.Core.Assets.CompilerApp\bin\Debug\net472\Xenko.Core.Assets.CompilerApp.exe --platform=Windows --property:RuntimeIdentifier=win-opengles --output-path=D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=D:\Xenko\sources\engine\Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xenko.Graphics 
{
    public partial class SpriteEffectExtTextureFullSBS
    {
        private static readonly byte[] binaryBytecode = new byte[] {
7, 192, 254, 239, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 26, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 7, 71, 108, 111, 98, 97, 
108, 115, 0, 7, 71, 108, 111, 98, 97, 108, 115, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 48, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 88, 101, 110, 107, 111, 73, 110, 116, 101, 114, 110, 97, 108, 95, 84, 
101, 120, 116, 117, 114, 101, 69, 120, 116, 48, 9, 0, 0, 0, 7, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 30, 88, 101, 110, 107, 111, 73, 110, 116, 101, 114, 110, 97, 108, 95, 84, 101, 120, 116, 
117, 114, 101, 69, 120, 116, 48, 95, 105, 100, 49, 54, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 30, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 49, 55, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 7, 
71, 108, 111, 98, 97, 108, 115, 40, 0, 0, 0, 1, 0, 0, 0, 0, 7, 0, 0, 0, 13, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 1, 0, 28, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 
101, 120, 116, 117, 114, 101, 46, 67, 111, 108, 111, 114, 0, 10, 67, 111, 108, 111, 114, 95, 105, 100, 49, 52, 0, 0, 0, 0, 16, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 30, 83, 112, 
114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 46, 72, 97, 115, 83, 82, 103, 98, 0, 12, 72, 97, 115, 83, 82, 103, 98, 95, 105, 100, 49, 53, 16, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 19, 0, 0, 0, 1, 0, 0, 0, 
1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 40, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 0, 15, 70, 114, 97, 109, 101, 87, 
105, 100, 116, 104, 95, 105, 100, 50, 48, 20, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 19, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 41, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 
120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 0, 16, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 49, 24, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 19, 0, 0, 0, 1, 0, 0, 0, 
1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 43, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 86, 105, 101, 119, 112, 111, 114, 116, 87, 105, 100, 116, 104, 0, 18, 86, 105, 101, 
119, 112, 111, 114, 116, 87, 105, 100, 116, 104, 95, 105, 100, 50, 50, 28, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 19, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 44, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 
116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 86, 105, 101, 119, 112, 111, 114, 116, 72, 101, 105, 103, 104, 116, 0, 19, 86, 105, 101, 119, 112, 111, 114, 116, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 51, 32, 0, 0, 0, 4, 0, 0, 0, 1, 1, 
0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 41, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 46, 76, 101, 116, 116, 101, 114, 
98, 111, 120, 101, 100, 0, 16, 76, 101, 116, 116, 101, 114, 98, 111, 120, 101, 100, 95, 105, 100, 50, 52, 36, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 8, 80, 79, 83, 73, 84, 73, 79, 78, 0, 0, 0, 0, 0, 8, 
84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 0, 0, 5, 0, 0, 0, 29, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 70, 117, 108, 108, 83, 66, 83, 1, 158, 189, 196, 224, 96, 235, 118, 86, 179, 55, 211, 83, 237, 63, 130, 28, 
22, 83, 112, 114, 105, 116, 101, 69, 102, 102, 101, 99, 116, 69, 120, 116, 84, 101, 120, 116, 117, 114, 101, 1, 170, 179, 52, 63, 13, 10, 197, 186, 92, 68, 41, 151, 77, 179, 151, 201, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 172, 190, 61, 77, 68, 160, 70, 238, 222, 135, 17, 118, 
190, 233, 199, 84, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 163, 165, 191, 129, 133, 242, 163, 216, 153, 114, 41, 63, 128, 100, 48, 211, 12, 67, 111, 108, 111, 114, 85, 116, 105, 108, 105, 116, 121, 1, 124, 200, 88, 161, 33, 56, 76, 239, 97, 45, 238, 84, 
91, 130, 62, 69, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 6, 70, 66, 146, 159, 255, 247, 100, 56, 111, 150, 90, 237, 22, 217, 12, 0, 0, 8, 0, 0, 0, 222, 11, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 13, 10, 13, 10, 112, 114, 101, 99, 105, 115, 
105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 105, 110, 116, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 51, 68, 
59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 83, 104, 
97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 
114, 114, 97, 121, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 
51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 
121, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 
105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 13, 10, 35, 100, 101, 
102, 105, 110, 101, 32, 116, 101, 120, 101, 108, 70, 101, 116, 99, 104, 66, 117, 102, 102, 101, 114, 80, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 
52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 57, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 
105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 
59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 
115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 57, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 59, 13, 10, 125, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 
13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 
32, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 
59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 57, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 
114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 57, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 57, 59, 13, 10, 32, 32, 
32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 
83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 57, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 
116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 
105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 
59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 95, 84, 69, 88, 67, 
79, 79, 82, 68, 48, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 
111, 110, 46, 122, 32, 42, 32, 50, 46, 48, 32, 45, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 119, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 59, 
13, 10, 125, 13, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 1, 160, 105, 101, 243, 254, 238, 147, 54, 114, 247, 240, 18, 75, 232, 221, 19, 0, 0, 16, 0, 0, 0, 
177, 26, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 35, 101, 120, 116, 101, 110, 115, 105, 111, 110, 32, 71, 76, 95, 79, 69, 83, 95, 69, 71, 76, 95, 105, 109, 97, 103, 101, 95, 101, 120, 116, 101, 114, 110, 97, 108, 95, 101, 115, 115, 108, 51, 32, 58, 32, 114, 
101, 113, 117, 105, 114, 101, 13, 10, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 105, 110, 116, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 
110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 
108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 
32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 83, 104, 97, 100, 111, 119, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 
111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 
112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 
115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 13, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 
114, 50, 68, 65, 114, 114, 97, 121, 59, 13, 10, 13, 10, 35, 100, 101, 102, 105, 110, 101, 32, 116, 101, 120, 101, 108, 70, 101, 116, 99, 104, 66, 117, 102, 102, 101, 114, 80, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 
65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 59, 13, 
10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 
73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 
59, 13, 10, 125, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 49, 52, 59, 13, 10, 
32, 32, 32, 32, 98, 111, 111, 108, 32, 72, 97, 115, 83, 82, 103, 98, 95, 105, 100, 49, 53, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 48, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 70, 114, 97, 109, 
101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 49, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 86, 105, 101, 119, 112, 111, 114, 116, 87, 105, 100, 116, 104, 95, 105, 100, 50, 50, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 86, 105, 101, 119, 112, 111, 114, 116, 72, 101, 
105, 103, 104, 116, 95, 105, 100, 50, 51, 59, 13, 10, 32, 32, 32, 32, 98, 111, 111, 108, 32, 76, 101, 116, 116, 101, 114, 98, 111, 120, 101, 100, 95, 105, 100, 50, 52, 59, 13, 10, 125, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 69, 120, 116, 101, 114, 
110, 97, 108, 79, 69, 83, 32, 88, 101, 110, 107, 111, 73, 110, 116, 101, 114, 110, 97, 108, 95, 84, 101, 120, 116, 117, 114, 101, 69, 120, 116, 48, 95, 105, 100, 49, 54, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 49, 55, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 108, 111, 99, 97, 
116, 105, 111, 110, 32, 61, 32, 48, 41, 32, 32, 111, 117, 116, 32, 118, 101, 99, 52, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 
84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 118, 101, 99, 52, 32, 84, 111, 76, 105, 110, 101, 97, 114, 95, 105, 100, 52, 40, 118, 101, 99, 52, 32, 115, 82, 71, 66, 97, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 115, 82, 71, 66, 32, 61, 32, 115, 82, 
71, 66, 97, 46, 114, 103, 98, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 118, 101, 99, 52, 40, 115, 82, 71, 66, 32, 42, 32, 40, 115, 82, 71, 66, 32, 42, 32, 40, 115, 82, 71, 66, 32, 42, 32, 48, 46, 51, 48, 53, 51, 48, 54, 48, 49, 49, 32, 43, 32, 48, 
46, 54, 56, 50, 49, 55, 49, 49, 49, 49, 41, 32, 43, 32, 48, 46, 48, 49, 50, 53, 50, 50, 56, 55, 56, 41, 44, 32, 115, 82, 71, 66, 97, 46, 97, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 105, 110, 111, 117, 116, 
32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 116, 101, 120, 116, 117, 114, 101, 67, 111, 108, 111, 114, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 88, 101, 110, 107, 111, 73, 110, 
116, 101, 114, 110, 97, 108, 95, 84, 101, 120, 116, 117, 114, 101, 69, 120, 116, 48, 95, 105, 100, 49, 54, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 49, 55, 44, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 41, 59, 13, 10, 32, 
32, 32, 32, 105, 102, 32, 40, 72, 97, 115, 83, 82, 103, 98, 95, 105, 100, 49, 53, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 116, 101, 120, 116, 117, 114, 101, 67, 111, 108, 111, 114, 32, 61, 32, 84, 111, 76, 105, 110, 101, 97, 114, 95, 105, 100, 52, 
40, 116, 101, 120, 116, 117, 114, 101, 67, 111, 108, 111, 114, 41, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 116, 101, 120, 116, 117, 114, 101, 67, 111, 108, 111, 114, 32, 42, 32, 67, 111, 108, 111, 114, 95, 105, 100, 49, 52, 59, 13, 10, 125, 
13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 51, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 99, 111, 108, 111, 114, 32, 
61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 115, 116, 97, 114, 116, 72, 101, 105, 103, 104, 116, 32, 61, 32, 117, 105, 110, 116, 40, 76, 101, 116, 116, 101, 114, 98, 111, 120, 101, 100, 
95, 105, 100, 50, 52, 32, 63, 32, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 49, 41, 32, 42, 32, 48, 46, 50, 53, 32, 58, 32, 102, 108, 111, 97, 116, 40, 48, 41, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 101, 110, 
100, 72, 101, 105, 103, 104, 116, 32, 61, 32, 117, 105, 110, 116, 40, 76, 101, 116, 116, 101, 114, 98, 111, 120, 101, 100, 95, 105, 100, 50, 52, 32, 63, 32, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 49, 41, 32, 42, 32, 48, 46, 55, 53, 
32, 58, 32, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 49, 41, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 120, 32, 61, 32, 117, 105, 110, 116, 40, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 
95, 105, 100, 49, 56, 46, 120, 32, 42, 32, 102, 108, 111, 97, 116, 40, 86, 105, 101, 119, 112, 111, 114, 116, 87, 105, 100, 116, 104, 95, 105, 100, 50, 50, 41, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 121, 32, 61, 32, 117, 105, 110, 116, 40, 115, 116, 114, 101, 97, 109, 115, 
46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 46, 121, 32, 42, 32, 102, 108, 111, 97, 116, 40, 86, 105, 101, 119, 112, 111, 114, 116, 72, 101, 105, 103, 104, 116, 95, 105, 100, 50, 51, 41, 41, 59, 13, 10, 32, 32, 32, 32, 117, 105, 110, 116, 32, 109, 105, 100, 100, 108, 101, 
32, 61, 32, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 48, 32, 47, 32, 117, 105, 110, 116, 40, 50, 41, 59, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 121, 32, 60, 32, 115, 116, 97, 114, 116, 72, 101, 105, 103, 104, 116, 32, 43, 32, 117, 105, 110, 116, 40, 52, 41, 
41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 99, 111, 108, 111, 114, 32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 115, 116, 97, 114, 116, 72, 101, 105, 103, 104, 116, 41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 
108, 111, 97, 116, 40, 115, 116, 97, 114, 116, 72, 101, 105, 103, 104, 116, 41, 32, 43, 32, 102, 108, 111, 97, 116, 40, 51, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 121, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 101, 108, 
115, 101, 32, 105, 102, 32, 40, 121, 32, 62, 61, 32, 101, 110, 100, 72, 101, 105, 103, 104, 116, 32, 45, 32, 117, 105, 110, 116, 40, 52, 41, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 99, 111, 108, 111, 114, 32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 
116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 101, 110, 100, 72, 101, 105, 103, 104, 116, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 49, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 101, 110, 100, 72, 101, 105, 103, 104, 116, 41, 32, 45, 
32, 102, 108, 111, 97, 116, 40, 52, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 121, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 120, 32, 60, 32, 109, 105, 100, 100, 108, 101, 41, 13, 10, 32, 32, 32, 32, 
123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 105, 102, 32, 40, 120, 32, 60, 32, 117, 105, 110, 116, 40, 52, 41, 41, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 109, 111, 111, 116, 
104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 102, 108, 111, 97, 116, 40, 51, 41, 44, 32, 102, 108, 111, 97, 116, 40, 120, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 32, 32, 32, 
32, 114, 101, 116, 117, 114, 110, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 109, 105, 100, 100, 108, 101, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 49, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 
109, 105, 100, 100, 108, 101, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 52, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 120, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 101, 108, 115, 101, 32, 105, 102, 32, 40, 120, 32, 62, 
61, 32, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 48, 32, 45, 32, 117, 105, 110, 116, 40, 52, 41, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 
108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 105, 100, 50, 48, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 49, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 70, 114, 97, 109, 101, 87, 105, 100, 116, 104, 95, 
105, 100, 50, 48, 41, 32, 45, 32, 102, 108, 111, 97, 116, 40, 52, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 120, 41, 41, 32, 42, 32, 99, 111, 108, 111, 114, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 109, 111, 111, 116, 104, 115, 
116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 109, 105, 100, 100, 108, 101, 41, 44, 32, 102, 108, 111, 97, 116, 40, 102, 108, 111, 97, 116, 40, 109, 105, 100, 100, 108, 101, 41, 32, 43, 32, 102, 108, 111, 97, 116, 40, 51, 41, 41, 44, 32, 102, 108, 111, 97, 116, 40, 120, 41, 41, 32, 42, 32, 
99, 111, 108, 111, 114, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 80, 83, 95, 73, 78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 
48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 
48, 32, 61, 32, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 
95, 105, 100, 49, 56, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 56, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 
83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 51, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 
46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 32, 32, 32, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 
95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 50, 59, 13, 10, 125, 13, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
        };
    }
}
#endif
