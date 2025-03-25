using Godot;
using System;

public partial class Conveyor : Node2D
{
	[Export] public bool Flipped;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		for (int i = 0; i < 4; i++)
		{
			if (Flipped) GetChild<AnimatedSprite2D>(i + 1).FlipH = true;
			GetChild<AnimatedSprite2D>(i + 1).Play();
        }
	}
}
