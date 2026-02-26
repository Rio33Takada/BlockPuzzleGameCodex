public class BattleStateMachine
{
    public IbattleState currentState {  get; private set; }

    public void ChangeState(IbattleState nextState)
    {
        currentState.Exit();
        currentState = nextState;
        currentState.Enter();
    }
}
