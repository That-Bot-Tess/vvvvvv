using Godot;
using System;

public partial class Enemy : Hazard
{
	[Export] string direction;
	[Export] int travelDistance;

	int maxTravelDistance;
	int movementSpeed = 2;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        ResetTravelDistance();
		GetChild<AnimatedSprite2D>(1).Play();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 position = Position;
        switch (direction)
        {
            case "up":
                position.Y -= movementSpeed;
                if (position.Y <= maxTravelDistance) {
                    direction = "down";
                    ResetTravelDistance();
                }
                break;
            case "down":
                position.Y += movementSpeed;
                if (position.Y >= maxTravelDistance) {
                    direction = "up";
                    ResetTravelDistance();
                }
                    
                break;
            case "right":
                position.X += movementSpeed;
                if (position.X >= maxTravelDistance) {
                    direction = "left";
                    ResetTravelDistance();
                }
                    
                break;
            case "left":
                position.X -= movementSpeed;
                if (position.X <= maxTravelDistance) { 
                    direction = "right";
                    ResetTravelDistance();
                }
                   
                break;
        }

		Position = position;
    }

	private void ResetTravelDistance()
	{
        switch (direction)
        {
            case "up":
                maxTravelDistance = (int)Position.Y - travelDistance;
                break;
            case "down":
                maxTravelDistance = (int)Position.Y + travelDistance;
                break;
            case "right":
                maxTravelDistance = (int)Position.X + travelDistance;
                break;
            case "left":
                maxTravelDistance = (int)Position.X - travelDistance;
                break;
        }
    }
}
