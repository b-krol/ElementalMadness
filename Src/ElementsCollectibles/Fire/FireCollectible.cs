using Godot;
using System;

public partial class FireCollectible : Area2D
{
    private void OnBodyEntered(Node2D body){
        Events.Instance.EmitSignal(Events.SignalName.PlayerCollectedFire);
    }
}
