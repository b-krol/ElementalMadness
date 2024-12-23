using Godot;
using System;

public partial class LevelSelection : CenterContainer
{
    [Export] private PackedScene Level1;
    [Export] private PackedScene Level2;
    [Export] private PackedScene Level3;
    [Export] private PackedScene Level4;
    [Export] private PackedScene Level5;
    [Export] private PackedScene Level6;
    [Export] private PackedScene Level7;
    [Export] private PackedScene Level8;
    [Export] private PackedScene Level9;
    [Export] private PackedScene Level10;

    private void StartLevel(PackedScene level){
        GetTree().ChangeSceneToPacked(level);
    }

    private void StartLevel_1(){
        StartLevel(Level1);
    }

    private void StartLevel_2(){
        StartLevel(Level2);
    }

    private void StartLevel_3(){
        StartLevel(Level3);
    }

    private void StartLevel_4(){
        StartLevel(Level4);
    }

    private void StartLevel_5(){
        StartLevel(Level5);
    }

    private void StartLevel_6(){
        StartLevel(Level6);
    }

    private void StartLevel_7(){
        StartLevel(Level7);
    }

    private void StartLevel_8(){
        StartLevel(Level8);
    }

    private void StartLevel_9(){
        StartLevel(Level9);
    }

    private void StartLevel_10(){
        StartLevel(Level10);
    }
}
