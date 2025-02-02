using Godot;
using System;

public partial class TriggerZone : Area2D
{
    public void OnBodyEntered(PhysicsBody2D collider)
    {
        GetParent().GetChild<Warp>(1).isActive = true;
        GetParent().GetChild<Warp>(2).isActive = true;
    }
}
