using Godot;
using System;

[GlobalClass]
public partial class PlayerMovementData : Resource
{
    [ExportGroup("Ground")]
    [Export] public float Speed {get; private set;} = 80;
    [Export] public float Gravity {get; private set;} = 160;
    [Export] public float Acceleration {get; private set;} = 5;
    [Export] public float Friction {get; private set;} = 10;
    [Export] public float Jump {get; private set;} = 40;

    [ExportGroup("Air")]
    [Export] public float AirSpeed {get; private set;} = 80;
    [Export] public float AirAcceleration {get; private set;} = 3;
    [Export] public float AirFriction {get; private set;} = 3;
}
