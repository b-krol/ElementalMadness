using Godot;
using System;

public partial class StartMenu : CenterContainer
{
    [Export] private PackedScene startLevel;

    public override void _Ready()
    {
        RenderingServer.SetDefaultClearColor(Colors.Blue);
    }

    private void OnStartButtonPressed(){
        GetTree().ChangeSceneToPacked(startLevel);
    }

    private void OnQuitButtonPressed(){
        GetTree().Quit();
    }
}
