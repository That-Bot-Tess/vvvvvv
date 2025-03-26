using Godot;
using System;

public partial class MovingPlatform : CharacterBody2D
{
	[Export] string direction;
	[Export] int travelDistance;

	int maxTravelDistance;
    Vector2 linearVelocity;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ResetTravelDistance();
		switch (direction)
		{
			case "up":
                linearVelocity = new(0, -100);
				break;
			case "down":
                linearVelocity = new(0, 100);
				break;
			case "left":
                linearVelocity = new(-100, 0);
				break;
			case "right":
                linearVelocity = new(100, 0);
				break;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        switch (direction)
        {
            case "up":
                if (Position.Y <= maxTravelDistance) {
                    linearVelocity *= -1;
                    direction = "down";
                    ResetTravelDistance();
                }
                break;
            case "down":
                if (Position.Y >= maxTravelDistance) {
                    linearVelocity *= -1;
                    direction = "up";
                    ResetTravelDistance();
                }
                break;
            case "right":
                if (Position.X >= maxTravelDistance) {
                    linearVelocity *= -1;
                    direction = "left";
                    ResetTravelDistance();
                }
                break;
            case "left":
                if (Position.X <= maxTravelDistance) {
                    linearVelocity *= -1;
                    direction = "right";
                    ResetTravelDistance();
                }
                break;
        }

        Velocity = linearVelocity;
        MoveAndSlide();
    }
    private void ResetTravelDistance()
    {
        if (travelDistance < 0) return;
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
