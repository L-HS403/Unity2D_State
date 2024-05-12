using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CState
{
    void Execute(CharacterState characterState, Character character);
}


public class StateNormal : CState
{
    public void Execute(CharacterState characterState, Character character)
    {
        character.NormalState();

        characterState.SetState(new StateAttack());
    }
}


public class StateAttack : CState
{
    public void Execute(CharacterState characterState, Character character)
    {
        character.AttackState();

        characterState.SetState(new StateNormal());
    }
}

