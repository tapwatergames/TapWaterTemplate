namespace TapWaterTemplate;

using System.Diagnostics;
using Chickensoft.GoDotTest;
using JetBrains.Annotations;
using Shouldly;

public class ExampleTest : TestClass
{
    public ExampleTest(Node testScene) : base(testScene) { }

    [Test]
    public void Test() => 1.ShouldBe<int>(1);
}