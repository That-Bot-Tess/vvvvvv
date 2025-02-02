using Godot;
using System;

public partial class Warp : Area2D
{
    [Export]
    Warp compliment;
    [Export]
    bool isVertical;
    [Export]
    public bool isActive = false;
    
    bool isReady;
    
    private double pauseDelta = 0;

    public void OnBodyEntered(PhysicsBody2D collider)
    {
        if (isReady && isActive)
        {
            compliment.isReady = false;
            if (isVertical) collider.Position = new(collider.Position.X, compliment.Position.Y);
            else collider.Position = new(compliment.Position.X, collider.Position.Y);
        } 
    }

    public override void _Process(double delta)
    {
        if (!isReady) { 
            pauseDelta += delta;
            Console.WriteLine(delta);
            if (pauseDelta > 0.1)
            {
                isReady = true;
                pauseDelta = 0;
            }
        }
    }
}
