namespace TapWaterTemplate;

#if DEBUG
using System.Reflection;
using Chickensoft.GoDotTest;
#endif

/// <summary>
/// The entry point of the game. This determines if tests will be run or the game will play.
/// </summary>
public partial class EntryPoint : Node3D
{
#if DEBUG
    public TestEnvironment Environment = default!;
#endif

    public override void _Ready()
    {
#if DEBUG
        // If this is a debug build, use GoDotTest to examine the
        // command line arguments and determine if we should run tests.
        Environment = TestEnvironment.From(OS.GetCmdlineArgs());
        if (Environment.ShouldRunTests)
        {
            CallDeferred("RunTests");
            return;
        }
#endif
        // If we don't need to run tests, we can just switch to the game scene.
        GetTree().ChangeSceneToFile("res://src/core/Game/Game.tscn");
    }

#if DEBUG
    private void RunTests()
      => _ = GoTest.RunTests(Assembly.GetExecutingAssembly(), this, Environment);
#endif
}
