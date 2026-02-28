namespace Quick_Calc
{
    public class Calculator
    {
        public int Result { get; set; } = 0;
        public int MaxValue { get; set; } = 100000;

        public int Calculate(int first, int second, string operation)
        {
            int tempResult = operation switch
            {
                "+" => first + second,
                "-" => first - second,
                "×" => first * second,
                "÷" => second != 0 ? first / second : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Unknown operation"),
            };

            if (tempResult > MaxValue)
                throw new ArgumentOutOfRangeException($"Result cannot exceed {MaxValue}.");

            return tempResult;
        }

        public void Clear()
        {
            Result = 0;
        }
    }
}