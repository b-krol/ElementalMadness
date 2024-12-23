using Godot;
using System;

public partial class Level : Node2D
{
    [Export] private PackedScene NextLevel;

    public override void _Ready()
    {
        Events.Instance.LevelCompleted += OnLevelCompleted;
    }

    private void OnLevelCompleted(){
        GoToNextLevel();
    }

    private void GoToNextLevel(){
        var x = (PackedScene)ResourceLoader.Load("res://Src/Levels/LevelSelection.tscn");
        GetTree().ChangeSceneToPacked(x);
    }
}
