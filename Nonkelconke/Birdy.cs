using Godot;
using System;

public partial class Birdy : RigidBody2D
{
	[Export]
	private float speedModifier;

	[Export]
	private float downModifier;

	[Export]
	private float airFriction = 5;

	[Export]
	private float jumpPower = 5000;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		// Position = new Vector2(Position.X + (float)delta*speedModifier, Position.Y);
		ApplyForce(new Vector2((float)delta*speedModifier, downModifier*(float)delta));
		float airResistance = LinearVelocity.Length() * LinearVelocity.Length() * -airFriction;
		GD.Print(airResistance);
		ApplyForce(LinearVelocity.Normalized() * airResistance * (float)delta);

		if (Input.IsActionPressed("Jump"))
		{
			ApplyForce(new Vector2(0.0f, (float)delta*jumpPower));
		}
	}
}
