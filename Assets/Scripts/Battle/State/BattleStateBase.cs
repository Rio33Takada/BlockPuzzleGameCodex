using UnityEngine;

public abstract class BattleStateBase : ScriptableObject, IbattleState
{
    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}
