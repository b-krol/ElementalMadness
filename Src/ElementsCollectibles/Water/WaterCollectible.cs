using Godot;
using System;

public partial class WaterCollectible : Area2D
{
    private void OnBodyEntered(Node2D body){
        Events.Instance.EmitSignal(Events.SignalName.PlayerCollectedWater);
    }
}
