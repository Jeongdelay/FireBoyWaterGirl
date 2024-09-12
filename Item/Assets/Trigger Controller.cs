using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) //충돌판정
    {
        if (collision.CompareTag("Player")) //충돌된 오브젝트의 태그가 Player 라면
        {
            ItemGain(); //충돌 받은 오브젝트에서 itemGain 실행
        }
    }

    protected virtual void ItemGain() { } //가상 함수
}
