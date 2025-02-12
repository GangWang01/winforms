// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Drawing.Text.Tests;

[ConditionalClass(typeof(PlatformDetection), nameof(PlatformDetection.IsDrawingSupported))]
public class InstalledFontCollectionTests
{
    [Fact]
    public void Ctor_Default()
    {
        using (InstalledFontCollection fontCollection = new())
        {
            Assert.NotEmpty(fontCollection.Families);
        }
    }

    [Fact]
    public void Families_GetWhenDisposed_ReturnsNonEmpty()
    {
        InstalledFontCollection fontCollection = new();
        fontCollection.Dispose();

        Assert.NotEmpty(fontCollection.Families);
    }

    [Fact]
    public void Dispose_MultipleTimes_Nop()
    {
        InstalledFontCollection fontCollection = new();
        fontCollection.Dispose();
        fontCollection.Dispose();
    }
}
