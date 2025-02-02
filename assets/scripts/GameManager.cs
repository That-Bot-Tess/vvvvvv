using Godot;
using System;

public partial class GameManager : Node2D
{
	CharacterBody2D player;
	Camera2D camera;

	const int roomWidth = 320;
	const int roomHeight = 240;
	const int padding = 16;

	int roomX = 1;
	int roomY = 1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = GetNode<CharacterBody2D>("SceneObjects/Player");
		camera = GetNode<Camera2D>("Camera");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (player.Position.X > (roomWidth + padding) * roomX)
		{
			camera.Position = new(camera.Position.X + roomWidth + padding * 2, camera.Position.Y);
			roomX++;
		}
		if (player.Position.X < (roomWidth + padding) * (roomX - 1)) 
		{
			camera.Position = new(camera.Position.X - roomWidth - padding * 2, camera.Position.Y);
			roomX--;
		}
	}
}
