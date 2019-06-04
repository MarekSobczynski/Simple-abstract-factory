namespace ConsoleApplication2
{
    public class SubtractionFactory : OperationFactory
    {
        public override AbstractMathematicalOperation CreateProceed()
        {
            return new Subtraction();
        }
    }
}