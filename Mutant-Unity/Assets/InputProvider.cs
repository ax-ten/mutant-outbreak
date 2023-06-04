using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputProvider{
    private static GameInputActions GIA = new();

    public Vector2 MousePos(){
        return GIA.Player.Mouse.ReadValue<Vector2>();
    }

    public Vector2 WalkDirection(){
        return  GIA.Player.Walk.ReadValue<Vector2>();
    }

    public bool doJump(){
        return GIA.Player.Jump.triggered /*&& player.isOnGround*/;
    }

    public void Enable(){
        GIA.Player.Walk.Enable();
        GIA.Player.Mouse.Enable();
        GIA.Player.Jump.Enable();
    }
}
