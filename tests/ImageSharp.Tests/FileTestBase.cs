﻿// <copyright file="FileTestBase.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Tests
{
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The test base class for reading and writing to files.
    /// </summary>
    public abstract class FileTestBase
    {
        /// <summary>
        /// The collection of image files to test against.
        /// </summary>
        protected static readonly List<TestFile> Files = new List<TestFile>
        {
            // TestFile.Create(TestImages.Png.P1), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Pd), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Floorplan), // Perf: Enable for local testing only
            TestFile.Create(TestImages.Jpeg.Calliphora),
            // TestFile.Create(TestImages.Jpeg.Ycck), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Cmyk), // Perf: Enable for local testing only
            TestFile.Create(TestImages.Jpeg.Turtle),
            // TestFile.Create(TestImages.Jpeg.Fb), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Progress), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.GammaDalaiLamaGray), // Perf: Enable for local testing only
            TestFile.Create(TestImages.Bmp.Car),
            // TestFile.Create(TestImages.Bmp.Neg_height), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Blur), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Indexed), // Perf: Enable for local testing only
            TestFile.Create(TestImages.Png.Splash),
            // TestFile.Create(TestImages.Png.SplashInterlaced), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Interlaced), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter0), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter1), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter2), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter3), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter4), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.FilterVar), // Perf: Enable for local testing only
            TestFile.Create(TestImages.Gif.Rings), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Gif.Cheers),
            // TestFile.Create(TestImages.Gif.Giphy) // Perf: Enable for local testing only
        };

        protected string CreateOutputDirectory(string path, params string[] pathParts)
        {
            var postFix = "";
            if (pathParts != null && pathParts.Length > 0)
            {
                postFix  = "/" + string.Join("/", pathParts);
            }

            path = "TestOutput/" + path + postFix;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }
    }
}