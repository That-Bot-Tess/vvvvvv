using Godot;
using System;
using System.Text;

public partial class Player : CharacterBody2D
{
	public const float Speed = 180.0f;
	AnimatedSprite2D sprites;
	private int flipFactor = 1;
	private Vector2 startPosition;
	private Vector2 velocity;
	private Vector2 maxFallSpeed;

    public override void _Ready()
    {
		sprites = GetChild<AnimatedSprite2D>(1);
        sprites.Play();
		startPosition = Position;
    }

    public override void _PhysicsProcess(double delta)
	{
		velocity = Velocity;

		// Set animations
		if (velocity.X != 0)
			sprites.Animation = "run";
		else
			sprites.Animation = "stand";

		// Add the gravity.
		if (!IsGrounded())
		{
			velocity += GetGravity() * (float)delta * flipFactor;
        }

		// Handle Jump.
		if (Input.IsActionJustPressed("flip") && IsGrounded())
		{
			Flip();
		}

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("left", "right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
        }
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, 15);
		}

		if (Input.IsActionJustPressed("left")) sprites.FlipH = true;
		if (Input.IsActionJustPressed("right")) sprites.FlipH = false;

		Velocity = velocity;
		MoveAndSlide();
	}

	private bool IsGrounded()
	{
		return (IsOnFloor() && flipFactor > 0) || (IsOnCeiling() && flipFactor < 0);
	}

	public void Flip()
	{
        sprites.FlipV = !sprites.FlipV;
        flipFactor *= -1;
        velocity.Y = 0;
    }

	public void Respawn()
	{
		Position = startPosition;
	}
 }
