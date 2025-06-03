namespace TapWaterTemplate;

using Chickensoft.Introspection;
using Chickensoft.AutoInject;


[Meta(typeof(IAutoNode))]
public partial class _CLASS_ : Node //TODO: Update Inheretance if needed.
{
    // Needed for OnReady and AutoInject to work.
    public override void _Notification(int what) => this.Notify(what);

    private Log _log = new Log(nameof(_CLASS_));

    public void OnReady()
    {
    }

    // Process, Input, and Physics are not overriden by default, to override them and use OnProcess etc.
    // add SetProcess(true), SetInput(true) etc to OnReady().
    public override void _Process(double delta)
    {
    }
}