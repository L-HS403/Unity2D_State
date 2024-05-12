using UnityEngine;

public class CharacterState : MonoBehaviour
{
    public Character character;

    public CState curState;

    void Start()
    {
        curState = new StateNormal();
    }

    public void Operate()
    {
        curState.Execute(this, character);
    }


    public void SetState(CState newState)
    {
        curState = newState;
    }

    public CState GetCurrentState()
    {
        return curState;
    }
}
