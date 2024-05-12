using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacterState : MonoBehaviour
{
    public CharacterState characterState;

    public void ChangeState()
    {
        characterState.Operate();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeState();
        }
    }
}

