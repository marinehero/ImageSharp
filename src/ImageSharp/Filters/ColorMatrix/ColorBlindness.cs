﻿// <copyright file="ColorBlindness.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp
{
    using System;

    using Processors;

    /// <summary>
    /// Extension methods for the <see cref="Image{TColor}"/> type.
    /// </summary>
    public static partial class ImageExtensions
    {
        /// <summary>
        /// Applies the given colorblindness simulator to the image.
        /// </summary>
        /// <typeparam name="TColor">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="colorBlindness">The type of color blindness simulator to apply.</param>
        /// <returns>The <see cref="Image{TColor}"/>.</returns>
        public static Image<TColor> ColorBlindness<TColor>(this Image<TColor> source, ColorBlindness colorBlindness)
            where TColor : struct, IPackedPixel, IEquatable<TColor>
        {
            return ColorBlindness(source, colorBlindness, source.Bounds);
        }

        /// <summary>
        /// Applies the given colorblindness simulator to the image.
        /// </summary>
        /// <typeparam name="TColor">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="colorBlindness">The type of color blindness simulator to apply.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="Image{TColor}"/>.</returns>
        public static Image<TColor> ColorBlindness<TColor>(this Image<TColor> source, ColorBlindness colorBlindness, Rectangle rectangle)
            where TColor : struct, IPackedPixel, IEquatable<TColor>
        {
            IImageFilteringProcessor<TColor> processor;

            switch (colorBlindness)
            {
                case ImageSharp.ColorBlindness.Achromatomaly:
                    processor = new AchromatomalyProcessor<TColor>();
                    break;

                case ImageSharp.ColorBlindness.Achromatopsia:
                    processor = new AchromatopsiaProcessor<TColor>();
                    break;

                case ImageSharp.ColorBlindness.Deuteranomaly:
                    processor = new DeuteranomalyProcessor<TColor>();
                    break;

                case ImageSharp.ColorBlindness.Deuteranopia:
                    processor = new DeuteranopiaProcessor<TColor>();
                    break;

                case ImageSharp.ColorBlindness.Protanomaly:
                    processor = new ProtanomalyProcessor<TColor>();
                    break;

                case ImageSharp.ColorBlindness.Protanopia:
                    processor = new ProtanopiaProcessor<TColor>();
                    break;

                case ImageSharp.ColorBlindness.Tritanomaly:
                    processor = new TritanomalyProcessor<TColor>();
                    break;

                default:
                    processor = new TritanopiaProcessor<TColor>();
                    break;
            }

            return source.Process(rectangle, processor);
        }
    }
}
