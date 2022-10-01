using FluentAssertions;
using ImperativeVsDeclarative;
using Xunit;

namespace FunctionalToolkit.UnitTests
{
    public class FunctionalToolkitTests
    {
        [Theory]
        [InlineData("imperative", 9)]
        [InlineData("no", 2)]
        public void CalculateScoreReturnsCorrectScore(string word, int expected)
        {
            Exercise.CalculateScore(word).Should().Be(expected);
        }

        [Theory]
        [InlineData("declarative", 9)]
        [InlineData("yes", 3)]
        public void WordScoreReturnsCorrectScore(string word, int expected)
        {
            Exercise.WordScore(word).Should().Be(expected);
        }
    }
}