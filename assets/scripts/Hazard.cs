using Godot;
using System;

public partial class Hazard : Area2D
{
    public void OnBodyEntered(Player body)
    {
        body.Respawn();
    }
}
