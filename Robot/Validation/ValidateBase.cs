using System.Xml.Schema;

namespace OCPRobot.Validation
{
    public abstract class ValidateBase
    {
        protected IValidateable _validatee;
        protected bool _validationResult;

        protected ValidateBase(IValidateable validatee)
        {
            _validatee = validatee;
        }

        public void ThrowExceptionIfValidationError()
        {
            if (!_validationResult)
                throw new ValidationException();
        }

        protected abstract void Validate();
    }
}