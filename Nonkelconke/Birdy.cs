using Godot;
using System;

public partial class Birdy : RigidBody2D
{
	[Export]
	private float speedModifier;

	[Export]
	private float downModifier;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		// Position = new Vector2(Position.X + (float)delta*speedModifier, Position.Y);
		AddConstantCentralForce(new Vector2((float)delta*speedModifier, downModifier));
	}
}
