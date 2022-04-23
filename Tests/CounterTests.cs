using Bunit;
using NUnit.Framework;
using Site.Pages;

namespace Tests
{
    public class CounterTests
    {
        [Test]
        public void TestCounter()
        {
            using var bunit = new Bunit.TestContext();

            for (var i = 0; i < 100; i++)
            {
                var cut1 = bunit.RenderComponent<Counter>();
                cut1.WaitForAssertion(() => cut1.Find("[data-id=1]"));
                cut1.Find("[data-id=1]").Click();
                cut1.WaitForAssertion(() => cut1.Find("[data-id=2]"));
            }
        }
    }
}
