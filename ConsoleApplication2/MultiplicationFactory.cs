namespace ConsoleApplication2
{
    public class MultiplicationFactory : OperationFactory
    {
        public override AbstractMathematicalOperation CreateProceed()
        {
            return new Multiplication();
        }
    }
}