using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] public PlayerMovementData MovementData;
    [Export] public AnimatedSprite2D AnimatedSprite;
    private Vector2 velocity;
    private Vector2 startingPosition;

    public override void _Ready()
    {
        startingPosition = GlobalPosition;
    }

    public override void _Process(double delta)
    {
        
    }

    public override void _PhysicsProcess(double delta)
    {
        var inputAxis = Input.GetAxis("MoveLeft", "MoveRight");

        if(!IsOnFloor()){
            ApplyGravity(delta);

            if(inputAxis != 0){
                Acceleration(delta, inputAxis, MovementData.AirSpeed, MovementData.AirAcceleration);
            }
            else{
                ApplyFriction(delta, MovementData.AirFriction);
            }

        }
        else{
            if(inputAxis != 0){
                Acceleration(delta, inputAxis, MovementData.Speed, MovementData.Acceleration);
            }
            else{
                ApplyFriction(delta, MovementData.Friction);
            }

            if(Input.IsActionJustPressed("Jump")){
                Jump();
            }
        }

        Velocity = velocity;
        MoveAndSlide();
        this.velocity = Velocity;

        UpdateAnimation(inputAxis);
    }

    private void ApplyGravity(double delta){
        this.velocity -= UpDirection * MovementData.Gravity * (float)delta;
    }

    private void Acceleration(double delta, float axis, float speed, float acceleration){
        velocity.X = Mathf.Lerp(velocity.X, speed * axis, (float)delta * acceleration);
    }

    private void Jump(){
        velocity.Y = -Mathf.Sqrt(2 * MovementData.Gravity * MovementData.Jump);
    }

    private void ApplyFriction(double delta, float friction){
        velocity.X = Mathf.Lerp(velocity.X, 0, friction * (float)delta);
    }

    private void OnHazadrDetected(Area2D area){
        GlobalPosition = startingPosition;
        velocity = Vector2.Zero;
    }

    private void UpdateAnimation(float input){
        if(input != 0){
            AnimatedSprite.FlipH = input < 0;
            AnimatedSprite.Play("Run");
        }
        else{
            AnimatedSprite.Play("Idle");
        }

        if(!IsOnFloor()){
            AnimatedSprite.Play("Jump");
        }
    }
}
