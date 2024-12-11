using Godot;
using System;

public partial class WoodenCrate : Area2D
{
    private void OnBodyEntered(Node2D body){
        

        if(GlobalVariables.Instance.CurrentElement == Element.fire)
        {
            QueueFree();
        }
    }
}
