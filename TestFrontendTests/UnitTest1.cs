using System;
using TestFrontend;
using Xunit;

namespace TestFrontendTests {
	public class UnitTest1 {
		[Fact]
		public void Test1() {
			var c = new FrontendModule();
			Assert.Equal(28, c.MagicValue); // Intentionally wrong.
		}
	}
}
