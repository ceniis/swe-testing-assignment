namespace Quick_Calc
{
    public class Calculator
    {
        public int Result { get; set; } = 0;

        public int Calculate(int first, int second, string operation)
        {
            return operation switch
            {
                "+" => first + second,
                "-" => first - second,
                "×" => first * second,
                "÷" => second != 0 ? first / second : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Unknown operation"),
            };
        }

        public void Clear()
        {
            Result = 0;
        }
    }
}