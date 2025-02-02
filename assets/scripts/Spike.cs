using Godot;
using System;

public partial class Spike : Area2D
{
    public void OnBodyEntered(Player body)
    {
        body.Respawn();
    }
}
