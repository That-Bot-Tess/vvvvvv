using Godot;
using System;

public partial class GravityLine : Area2D
{
    public void OnBodyEntered(Player body)
    {
        Modulate = Color.FromHtml("BBBBBB");
        body.Flip();
    }

    public void OnBodyExited(Player body)
    {
        Modulate = Color.FromHtml("FFFFFF");
    }
}
