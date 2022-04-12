namespace GenshinImpactMovementSystem
{
    public class PlayerAirborneState : PlayerMovementState
    {
        public PlayerAirborneState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            ResetSprintState();
        }

        protected virtual void ResetSprintState()
        {
            stateMachine.ReusableData.ShouldSprint = false;
        }

        protected override void OnContactWithGround()
        {
            stateMachine.ChangeState(stateMachine.IdlingState);
        }
    }
}