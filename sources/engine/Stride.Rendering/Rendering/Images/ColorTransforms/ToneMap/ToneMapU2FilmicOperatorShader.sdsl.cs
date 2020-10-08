﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Stride.Rendering.Images
{
    internal static partial class ToneMapU2FilmicOperatorShaderKeys
    {
        public static readonly ValueParameterKey<float> ShoulderStrength = ParameterKeys.NewValue<float>(0.22f);
        public static readonly ValueParameterKey<float> LinearStrength = ParameterKeys.NewValue<float>(0.25f);
        public static readonly ValueParameterKey<float> LinearAngle = ParameterKeys.NewValue<float>(0.1f);
        public static readonly ValueParameterKey<float> ToeStrength = ParameterKeys.NewValue<float>(0.2f);
        public static readonly ValueParameterKey<float> ToeNumerator = ParameterKeys.NewValue<float>(0.01f);
        public static readonly ValueParameterKey<float> ToeDenominator = ParameterKeys.NewValue<float>(0.3f);
        public static readonly ValueParameterKey<float> LinearWhite = ParameterKeys.NewValue<float>(11.2f);
    }
}
