using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWater : Player
{
    void Update()
    {
        if (playState == PlayState.Dead) { return; } // 죽었다면 움직이지 못하도록 설정

        inputX = Input.GetKey(KeyCode.A) ? -speedX : Input.GetKey(KeyCode.D) ? speedX : 0;

        if (isGround && Input.GetKeyDown(KeyCode.W))
        {
            isJumpReady = true;
        }
    }
}
