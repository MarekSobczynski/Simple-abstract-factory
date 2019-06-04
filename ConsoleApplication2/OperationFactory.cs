using System;

namespace ConsoleApplication2
{
    public abstract class OperationFactory
    {
        public static OperationFactory Factory(int type)
        {
            switch (type)
            {
                case 1:
                    return new AdditionFactory();
                case 2:
                    return new SubtractionFactory();
                case 3:
                    return new MultiplicationFactory();
                default:
                    throw new NotImplementedException();
            }
            
        }

        public abstract AbstractMathematicalOperation CreateProceed();
    }
}