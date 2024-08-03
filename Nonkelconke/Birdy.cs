using Godot;
using System;

public partial class Birdy : Sprite2D
{
	int i = 0;
	[Export]
	private float speedModifier;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		int test = 32;
		Position = new Vector2(Position.X + (float)delta*speedModifier, Position.Y);
		++i;
		if (i%10 == 0)
		{
			GD.Print(delta);
		}
	}
}
