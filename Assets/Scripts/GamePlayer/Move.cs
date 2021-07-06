﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D playerRB;

    [SerializeField]private float moveSpeed;
    [SerializeField]private float jumpForce;
    [SerializeField]private int jumpTimes;
    // Update is called once per frame

    private Player player;
    private float horizontalDir;
    private bool isJump;
    void Start()
    {
        PlayerInit();
    }
    void Update()
    {
        //在update中获取操作指令
        GetButtonPress();
    }

    void FixedUpdate()
    {
        //在FixedUpdate中按指令进行操作
        PlayerMove();
    }
    
    private void PlayerInit()
    {
        player = new Player(moveSpeed, jumpForce, jumpTimes, PlayerPosStateEnum.onGround, PlayerLifeStateEnum.live);
    }
    
    private void PlayerMove()
    {
        playerRB.velocity = new Vector2(horizontalDir * player.moveSpeed, playerRB.velocity.y);

        if (horizontalDir != 0)
        {
            transform.localScale = new Vector3(horizontalDir, 1, 1);
        }

        if (isJump)
        {
            Debug.LogWarning("空格键按下");
            playerRB.velocity = new Vector2(playerRB.velocity.x, player.jumpForce * Time.deltaTime);
        }
    }
    
    private void GetButtonPress()
    {
        horizontalDir = Input.GetAxisRaw("Horizontal");
        isJump = Input.GetButtonDown("Jump");
    }
    
    private void CheckPlayerPosState()
    {
        switch (hideFlags)
        {
            
        }
    }
}
