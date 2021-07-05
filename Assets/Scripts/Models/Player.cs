using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public float moveSpeed;
    public float jumpForce;

    public int jumpTimes;

    public PlayerPosStateEnum playerPosState;
    public PlayerLifeStateEnum playerLifeState;

    public Player(float moveSpeed, float jumpForce, int jumpTimes, PlayerPosStateEnum playerPosState, PlayerLifeStateEnum playerLifeState)
    {
        this.moveSpeed = moveSpeed;
        this.jumpForce = jumpForce;
        this.jumpTimes = jumpTimes;
        this.playerPosState = playerPosState;
        this.playerLifeState = playerLifeState;
    }
}
