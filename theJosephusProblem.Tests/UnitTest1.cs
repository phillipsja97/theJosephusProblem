using System;
using Xunit;

namespace theJosephusProblem.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void lets_check_a_group_of_20_with_interval_3()
        {
            // Arrange
            var groupNumber = 10;
            var killInterval = 3;
            var expectedResult = 4;
            var battle = new TheLastBattle();

            // Act
            var actualResult = battle.TheLastManStanding(groupNumber, killInterval);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
