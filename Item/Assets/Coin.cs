using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : TriggerController //TriggerController ���
{
    public GameObject Movement; //����� �޴��� Ȯ���Ϸ��� �Ѱ� �����ص� ��

    protected override void ItemGain()
    {
        base.ItemGain(); //���� �Լ�
        Destroy(gameObject); //�浹���� ������Ʈ ���� ���⼱ coin ������Ʈ
        Movement.GetComponent<Movement>().PC(); //�̰� ����� �۵� �ϴ��� Ȯ���Ϸ��� ������� ���� ����!
    }
}