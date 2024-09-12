using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : TriggerController //TriggerController 상속
{
    public GameObject Movement; //제대로 받는지 확인하려고 한거 무시해도 됌

    protected override void ItemGain()
    {
        base.ItemGain(); //가상 함수
        Destroy(gameObject); //충돌받은 오브젝트 삭제 여기선 coin 오브젝트
        Movement.GetComponent<Movement>().PC(); //이건 제대로 작동 하는지 확인하려고 만들었어 무시 가능!
    }
}
