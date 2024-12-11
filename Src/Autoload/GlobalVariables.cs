using Godot;
using System;

public partial class GlobalVariables : Node
{
    [Export] public Element CurrentElement = Element.none;

    public static GlobalVariables Instance {get;private set;}

    public override void _EnterTree()
    {
        if(Instance is null){
            Instance = this;
        }
        else
        {
            QueueFree();
        }
    }

    public override void _ExitTree()
    {
        if(Instance == this){
            Instance = null;
        }
    }
}

public enum Element{
    none,
    fire,
    water,
    air
}