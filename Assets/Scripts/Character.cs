using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public void NormalState()
    {
        Debug.Log("대기 상태...");
    }

    public void AttackState()
    {
        Debug.Log("공격 중!");
    }
}
