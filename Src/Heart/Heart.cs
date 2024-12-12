using Godot;
using System;

public partial class Heart : Area2D
{
    private void OnBodyEntered(Node2D body){
        QueueFree();

        int hearts = GetTree().GetNodeCountInGroup("Hearts");
        if(hearts == 1)
        {
            GD.Print("Zebrano wszystkie monety");
            Events.Instance.EmitSignal(Events.SignalName.LevelCompleted);
        }
    }
}