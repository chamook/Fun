using System.Threading.Tasks;
using AutoFixture.Xunit2;
using Xunit;

namespace Fun.UnitTest
{
    public class TaskTests
    {
        [Theory, AutoData]
        public async Task LiftAsyncPreservesInput(string input)
        {
            var actual = await input.LiftAsync();

            Assert.Equal(input, actual);
        }
    }
}
