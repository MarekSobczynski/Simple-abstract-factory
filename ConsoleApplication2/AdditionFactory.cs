namespace ConsoleApplication2
{
    public class AdditionFactory : OperationFactory
    {
        public override AbstractMathematicalOperation CreateProceed()
        {
            return new Addition();
        }
    }
}