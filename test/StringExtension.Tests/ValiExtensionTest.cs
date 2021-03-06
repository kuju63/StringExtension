/**
 * ValidExtensionTest.cs
 *
 * Copyright (c) 2019 Kurihara.Jun
 * All rights reserved.
 *
 * MIT License
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

using Xunit;

namespace StringExtension.Tests
{
    public class ValidExtensionTest
    {
        [Theory]
        [InlineData("a")]
        [InlineData("z")]
        [InlineData("A")]
        [InlineData("Z")]
        [InlineData("aa")]
        [InlineData("zz")]
        [InlineData("AA")]
        [InlineData("ZZ")]
        public void IsAlphabetOnlySuccess(string source)
        {
            Assert.True(source.IsAlphabetOnly(), $"source is {source}");
        }

        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("@")]
        [InlineData("!")]
        [InlineData(" ")]
        [InlineData("a1")]
        [InlineData("A1")]
        [InlineData("a ")]
        [InlineData(" a")]
        public void IsAlphabetOnlyFailed(string source)
        {
            Assert.False(source.IsAlphabetOnly(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("-10")]
        [InlineData("-10.0")]
        [InlineData("-10.01")]
        [InlineData("-1")]
        [InlineData("-1.0")]
        [InlineData("-1.01")]
        [InlineData("0")]
        [InlineData("0.0")]
        [InlineData("0.00")]
        [InlineData("1")]
        [InlineData("1.0")]
        [InlineData("1.01")]
        [InlineData("9")]
        [InlineData("10")]
        [InlineData("10.0")]
        [InlineData("10.01")]
        [InlineData("+1")]
        [InlineData("+1.0")]
        [InlineData("+1.01")]
        [InlineData("+10")]
        [InlineData("+10.0")]
        [InlineData("+10.01")]
        public void IsFloatWithSignSuccess(string source)
        {
            Assert.True(source.IsFloatWithSign(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("a")]
        [InlineData("1.a")]
        [InlineData("-1.a")]
        [InlineData("1..0")]
        [InlineData(".1")]
        [InlineData("..1")]
        [InlineData("1..")]
        [InlineData("1-")]
        [InlineData("1+")]
        public void IsFloatWithSignFailed(string source)
        {
            Assert.False(source.IsFloatWithSign(), $"source is \"{source}\"");
        }
        [Theory]
        [InlineData("0")]
        [InlineData("0.0")]
        [InlineData("0.00")]
        [InlineData("1")]
        [InlineData("1.0")]
        [InlineData("1.01")]
        [InlineData("9")]
        [InlineData("10")]
        [InlineData("10.0")]
        [InlineData("10.01")]
        public void IsFloatWithoutSignSuccess(string source)
        {
            Assert.True(source.IsFloatWithoutSign(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("-10")]
        [InlineData("-10.0")]
        [InlineData("-10.01")]
        [InlineData("-1")]
        [InlineData("-1.0")]
        [InlineData("-1.01")]
        [InlineData("+1")]
        [InlineData("+1.0")]
        [InlineData("+1.01")]
        [InlineData("+10")]
        [InlineData("+10.0")]
        [InlineData("+10.01")]
        [InlineData("a")]
        [InlineData("1.a")]
        [InlineData("-1.a")]
        [InlineData("1..0")]
        [InlineData(".1")]
        [InlineData("..1")]
        [InlineData("1..")]
        [InlineData("1-")]
        [InlineData("1+")]
        public void IsFloatWithoutSignFailed(string source)
        {
            Assert.False(source.IsFloatWithoutSign(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("-10")]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("9")]
        [InlineData("10")]
        [InlineData("+1")]
        [InlineData("+10")]
        public void IsIntegerWithSignSuccess(string source)
        {
            Assert.True(source.IsIntegerWithSign(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("-10.0")]
        [InlineData("-10.01")]
        [InlineData("-1.0")]
        [InlineData("-1.01")]
        [InlineData("+1.0")]
        [InlineData("+1.01")]
        [InlineData("+10.0")]
        [InlineData("+10.01")]
        [InlineData("a")]
        [InlineData("1.a")]
        [InlineData("-1.a")]
        [InlineData("1..0")]
        [InlineData(".1")]
        [InlineData("..1")]
        [InlineData("1..")]
        [InlineData("1-")]
        [InlineData("1+")]
        [InlineData("0.0")]
        [InlineData("0.00")]
        [InlineData("1.0")]
        [InlineData("1.01")]
        [InlineData("10.0")]
        [InlineData("10.01")]
        public void IsIntegerWithSignSignFailed(string source)
        {
            Assert.False(source.IsIntegerWithSign(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("9")]
        [InlineData("10")]
        public void IsIntegerWithoutSignSuccess(string source)
        {
            Assert.True(source.IsIntegerWithoutSign(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("-10")]
        [InlineData("-1")]
        [InlineData("-10.0")]
        [InlineData("-10.01")]
        [InlineData("-1.0")]
        [InlineData("-1.01")]
        [InlineData("+1.0")]
        [InlineData("+1.01")]
        [InlineData("+10.0")]
        [InlineData("+10.01")]
        [InlineData("+1")]
        [InlineData("+10")]
        [InlineData("a")]
        [InlineData("1.a")]
        [InlineData("-1.a")]
        [InlineData("1..0")]
        [InlineData(".1")]
        [InlineData("..1")]
        [InlineData("1..")]
        [InlineData("1-")]
        [InlineData("1+")]
        [InlineData("0.0")]
        [InlineData("0.00")]
        [InlineData("1.0")]
        [InlineData("1.01")]
        [InlineData("10.0")]
        [InlineData("10.01")]
        public void IsIntegerWithSignoutSignFailed(string source)
        {
            Assert.False(source.IsIntegerWithoutSign(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("\x7F")]
        [InlineData("あ")]
        [InlineData("１")]
        [InlineData("Ａ")]
        [InlineData("ｱ")]
        [InlineData("!あ~")]
        public void IsAsciiFailed(string source)
        {
            Assert.False(source.IsASCII(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("\x00")]
        [InlineData("\x7E")]
        [InlineData("\x00\x20\x30\x7E")]
        public void IsAsciiSuccess(string source)
        {
            Assert.True(source.IsASCII(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("A")]
        [InlineData("Z")]
        [InlineData("ABCXYZ")]
        public void ReturnTrueIsOnlyUpperCaseAlphabet(string source)
        {
            Assert.True(source.IsOnlyUpperCaseAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("9")]
        [InlineData("a")]
        [InlineData("z")]
        [InlineData("あ")]
        [InlineData("ア")]
        [InlineData("A1")]
        [InlineData("Aa")]
        [InlineData("Aあ")]
        [InlineData("Aア")]
        public void ReturnFalseIsOnlyUpperCaseAlphabet(string source)
        {
            Assert.False(source.IsOnlyUpperCaseAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("9")]
        [InlineData("A")]
        [InlineData("Z")]
        [InlineData("あ")]
        [InlineData("ア")]
        [InlineData("A1")]
        [InlineData("Aa")]
        [InlineData("Aあ")]
        [InlineData("Aア")]
        public void ReturnFalseIsOnlyLowerCaseAlphabet(string source)
        {
            Assert.False(source.IsOnlyLowerCaseAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("a")]
        [InlineData("z")]
        [InlineData("abcxyz")]
        public void ReturnTrueIsOnlyLowerCaseAlphabet(string source)
        {
            Assert.True(source.IsOnlyLowerCaseAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("a")]
        [InlineData("z")]
        [InlineData(" a")]
        [InlineData("a ")]
        [InlineData("1a")]
        [InlineData("a1")]
        [InlineData("Aa")]
        [InlineData("aA")]
        [InlineData("あa")]
        [InlineData("aあ")]
        [InlineData("@a")]
        [InlineData("a@")]
        [InlineData("\na")]
        [InlineData("a\n")]
        public void ReturnTrueHasLowerCaseAlphabet(string source)
        {
            Assert.True(source.HasLowerCaseAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("A")]
        [InlineData("Z")]
        [InlineData("1")]
        [InlineData("あ")]
        [InlineData("@")]
        [InlineData("\n")]
        public void ReturnFalseHasLowerCaseAlphabet(string source)
        {
            Assert.False(source.HasLowerCaseAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("A")]
        [InlineData("Z")]
        [InlineData("Aa")]
        [InlineData("aA")]
        [InlineData(" A")]
        [InlineData("A ")]
        [InlineData("1A")]
        [InlineData("A1")]
        [InlineData("あA")]
        [InlineData("Aあ")]
        [InlineData("@A")]
        [InlineData("A@")]
        public void ReturnTrueHasUpperCaseAlphabet(string source)
        {
            Assert.True(source.HasUpperCaseAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("z")]
        [InlineData("1")]
        [InlineData("あ")]
        [InlineData("@")]
        [InlineData("\n")]
        public void ReturnFalseHasUpperCaseAlphabet(string source)
        {
            Assert.False(source.HasUpperCaseAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("a")]
        [InlineData("z")]
        [InlineData("A")]
        [InlineData("Z")]
        [InlineData(" a")]
        [InlineData("a ")]
        [InlineData(" A")]
        [InlineData("A ")]
        [InlineData("1a")]
        [InlineData("a1")]
        [InlineData("1A")]
        [InlineData("A1")]
        [InlineData("@a")]
        [InlineData("a@")]
        [InlineData("@A")]
        [InlineData("A@")]
        [InlineData("あa")]
        [InlineData("aあ")]
        [InlineData("あA")]
        [InlineData("Aあ")]
        [InlineData("\na")]
        [InlineData("a\n")]
        [InlineData("\nA")]
        [InlineData("A\n")]
        public void ReturnTrueHasAlphabet(string source)
        {
            Assert.True(source.HasAlphabet(), $"source is \"{source}\"");
        }

        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("あ")]
        [InlineData("@")]
        [InlineData("\n")]
        public void ReturnFalseHasAlphabet(string source)
        {
            Assert.False(source.HasAlphabet(), $"source is \"{source}\"");
        }
    }
}
