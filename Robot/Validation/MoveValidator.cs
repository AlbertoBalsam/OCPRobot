using OCPRobot.Commands;

namespace OCPRobot.Validation
{
    public class MoveValidator : ValidateBase
    {
        private IRobot _robotValidatee;

        public MoveValidator(IValidateable validatee) : base(validatee)
        {
            _robotValidatee = _validatee as IRobot;
        }

        protected override void Validate()
        {
            _validationResult = _robotValidatee.CanWalk;
        }
    }
}