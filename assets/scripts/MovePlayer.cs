using Godot;
using System;

public partial class MovePlayer : Area2D
{
    public void OnBodyEntered(Player body)
    {
        Conveyor parent = GetParent() as Conveyor;
        if (parent.Flipped)
            body.Position += new Vector2(1, 0);
        else
            body.Position += new Vector2(-1, 0);
    }
}
