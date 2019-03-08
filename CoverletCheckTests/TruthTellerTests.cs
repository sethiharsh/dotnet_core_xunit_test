using CoverletCheck;
using Xunit;

namespace CoverletCheckTests
{
    public class TruthTellerTests
    {
        [Fact]
        public void TellTruth_MethodCall_ReturnsTrue()
        {
            var truthTeller = new TruthTeller();
            var result = truthTeller.TellTruth();
            Assert.True(true);
        }
    }
}
