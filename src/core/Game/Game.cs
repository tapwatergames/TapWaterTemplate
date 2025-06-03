namespace TapWaterTemplate;

using Chickensoft.Introspection;
using Chickensoft.AutoInject;


[Meta(typeof(IAutoNode))]
public partial class Game : Node3D
{
    public override void _Notification(int what) => this.Notify(what);
}
